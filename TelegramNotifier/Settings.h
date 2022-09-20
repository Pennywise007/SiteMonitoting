#pragma once

#include <ext/core/singleton.h>
#include <ext/serialization/iserializable.h>

#include "TelegramThread.h"

class Settings : private ext::serializable::SerializableObject<Settings>
{
    friend ext::Singleton<Settings>;
    Settings()
    {
        using namespace ext::serializable::serializer;
        try
        {
            Executor::DeserializeObject(Fabric::XMLDeserializer(get_settings_path()), this);
        }
        catch (...)
        {
        }
    }
    ~Settings()
    {
        using namespace ext::serializable::serializer;
        try
        {
            Executor::SerializeObject(Fabric::XMLSerializer(get_settings_path()), this);
        }
        catch (...)
        {
        }
    }

private:
    EXT_NODISCARD static std::filesystem::path get_settings_path()
    {
        const static auto result = []()
        {
            std::wstring exeName = std::filesystem::get_exe_name().c_str();
            exeName = exeName.substr(0, exeName.rfind('.')) + L".xml";
            return std::filesystem::get_exe_directory() / exeName;
        }();
        return result;
    }

public:
    struct User : private ext::serializable::SerializableObject<User>
    {
        User() EXT_NOEXCEPT = default;
        User(const TgBot::User::Ptr& user) EXT_NOEXCEPT
        {
            id = user->id;
            firstName = getUNICODEString(user->firstName);
            userName = getUNICODEString(user->username);
        }
        DECLARE_SERIALIZABLE((std::int64_t) id);
        DECLARE_SERIALIZABLE((std::wstring) firstName);
        DECLARE_SERIALIZABLE((std::wstring) userName);
    };

    DECLARE_SERIALIZABLE((std::wstring) token);
    DECLARE_SERIALIZABLE((std::wstring) password);
    DECLARE_SERIALIZABLE((std::list<User>) registeredUsers);
};