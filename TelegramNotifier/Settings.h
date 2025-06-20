#pragma once

#include <ext/core/singleton.h>
#include <ext/std/filesystem.h>
#include <ext/serialization/iserializable.h>

#include "TelegramThread.h"

class Settings
{
    friend ext::Singleton<Settings>;
    Settings()
    {
        try
        {
            std::wifstream file(get_settings_path());
            EXT_CHECK(file.is_open()) << "Failed to open settings file";
            EXT_DEFER(file.close());

            std::wstringstream buffer;
            buffer << file.rdbuf();

            std::wstring json = buffer.str();
            ext::serializer::DeserializeFromJson(*this, json);
        }
        catch (...)
        {
        }
    }
    ~Settings()
    {
        Store();
    }

private:
    [[nodiscard]] static std::filesystem::path get_settings_path()
    {
        const static auto result = []()
        {
            std::wstring exeName = std::filesystem::get_binary_name().c_str();
            exeName = exeName.substr(0, exeName.rfind('.')) + L".json";
            return std::filesystem::get_exe_directory() / exeName;
        }();
        return result;
    }

public:
    void Store()
    {
        try
        {
            std::wstring json;
            ext::serializer::SerializeToJson(*this, json);

            std::ofstream file(get_settings_path());
            EXT_CHECK(file.is_open()) << "Failed to open settings file";
            EXT_DEFER(file.close());

            // Some user name or first name may contain unicode characters, so we need to convert it to narrow string
            file << std::narrow(json);
        }
        catch (...)
        {
        }
    }

    struct User
    {
        User() noexcept = default;
        User(const TgBot::User::Ptr& user) noexcept
        {
            id = user->id;
            firstName = getUNICODEString(user->firstName);
            userName = getUNICODEString(user->username);
        }

        REGISTER_SERIALIZABLE_OBJECT();

        DECLARE_SERIALIZABLE_FIELD(std::int64_t, id);
        DECLARE_SERIALIZABLE_FIELD(std::wstring, firstName);
        DECLARE_SERIALIZABLE_FIELD(std::wstring, userName);
    };

    REGISTER_SERIALIZABLE_OBJECT();

    DECLARE_SERIALIZABLE_FIELD(std::wstring, token);
    DECLARE_SERIALIZABLE_FIELD(std::wstring, password);
    DECLARE_SERIALIZABLE_FIELD(std::list<User>, registeredUsers);
};