#include "pch.h"
#include "framework.h"
#include "TelegramNotifier.h"
#include "TelegramNotifierDlg.h"
#include "afxdialogex.h"
#include "TelegramThread.h"

#include <ext/thread/invoker.h>

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

// CTelegramNotifierDlg dialog
CTelegramNotifierDlg::CTelegramNotifierDlg(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_TELEGRAMNOTIFIER_DIALOG, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CTelegramNotifierDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_EDIT_TELEGRAM_TOKEN, m_editToken);
	DDX_Control(pDX, IDC_EDIT_TELEGRAM_PASSWORD, m_editPassword);
	DDX_Control(pDX, IDC_EDIT_MESSAGE, m_message);
	DDX_Control(pDX, IDC_BUTTON_RUN, m_buttonRun);
}

BEGIN_MESSAGE_MAP(CTelegramNotifierDlg, CDialogEx)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_WM_CLOSE()
	ON_WM_COPYDATA()
	ON_BN_CLICKED(IDC_BUTTON_RUN, &CTelegramNotifierDlg::OnBnClickedButtonRun)
	ON_BN_CLICKED(IDC_BUTTON_SEND_MESSAGE, &CTelegramNotifierDlg::OnBnClickedButtonSendMessage)
END_MESSAGE_MAP()

BOOL CTelegramNotifierDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	m_editToken.SetWindowTextW(m_settings.token.c_str());
	m_editPassword.SetWindowTextW(m_settings.password.c_str());

	m_errorDialog = std::make_shared<ErrorDialog>(this);

	ParseCommandLine(GetCommandLineW());

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CTelegramNotifierDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting
		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

HCURSOR CTelegramNotifierDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

void CTelegramNotifierDlg::OnClose()
{
	CDialogEx::OnClose();

	StoreParameters();
	StopThread();
}

void CTelegramNotifierDlg::StoreParameters()
{
	CString str;
	m_editToken.GetWindowTextW(str);
	m_settings.token = str;
	m_editPassword.GetWindowTextW(str);
	m_settings.password = str;
	m_settings.Store();
}

void CTelegramNotifierDlg::StopThread()
{
	if (!m_telegramThread)
		return;

	m_telegramThread->StopTelegramThread();
	m_telegramThread = nullptr;
}

void CTelegramNotifierDlg::ParseCommandLine(LPCWSTR commandLine)
{
	try
	{
		int nArgs;
		LPWSTR* szArglist = CommandLineToArgvW(commandLine, &nArgs);

		if (nArgs == 1)
			return; // only exe name
		if (NULL == szArglist)
			throw std::exception("Failed to get command line arguments");

		CString message;
		for (int i = 1; i < nArgs; ++i)
		{
			std::wstring arg = szArglist[i];
			std::string_trim_all(arg);

			if (auto delimer = arg.find_first_of('='); delimer != std::wstring::npos)
			{
				message.Append(((arg.front() == '/' ? arg.substr(1, delimer - 1) : arg.substr(0, delimer)) + L": ").c_str());
				message.Append(arg.substr(delimer + 1, arg.length() - delimer - 1).c_str());
			}
			else
				message.Append(arg.c_str());

			message += '\n';
		}
		SendMessageToUsers(message);
	}
	catch (...)
	{
		const auto commandLine = GetCommandLine(); commandLine; // for debugging
		EXT_DUMP_IF(true);

		ext::ManageException(L"Failed to parse command line");
	}
}

BOOL CTelegramNotifierDlg::OnCopyData(CWnd* pWnd, COPYDATASTRUCT* pCopyDataStruct)
{
	std::wstring commandLine;
	commandLine.resize(pCopyDataStruct->cbData);
	std::memcpy(commandLine.data(), pCopyDataStruct->lpData,
				pCopyDataStruct->cbData * sizeof(wchar_t));
	ParseCommandLine(commandLine.c_str());

	return CDialogEx::OnCopyData(pWnd, pCopyDataStruct);
}

void CTelegramNotifierDlg::SendMessageToUsers(const CString& text)
{
	if (m_settings.registeredUsers.empty())
	{
		m_errorDialog->ShowWindow((L"No registered users for hanlde: " + text).GetString());
		return;
	}

	const ITelegramThreadPtr thread = CreateTelegramThread(std::narrow(m_settings.token).c_str(),
		[errorDialog = m_errorDialog](const std::wstring& error)
		{
			errorDialog->ShowWindow(error);
		});

	for (const auto& user : m_settings.registeredUsers)
	{
		thread->SendMessageW(user.id, text.GetString());
	}
}

void CTelegramNotifierDlg::OnBnClickedButtonRun()
{
	const auto onExecute = [&](bool start)
	{
		ext::InvokeMethodAsync([&, start]()
			{
				m_editPassword.EnableWindow(!start);
				m_editToken.EnableWindow(!start);
				m_buttonRun.SetWindowTextW(start ?
					L"Stop waiting for users" :
					L"Run bot and wait for users");
			});
	};

	const bool threadWorking = !!m_telegramThread;

	if (threadWorking)
	{
		StopThread();
		onExecute(false);
		return;
	}

	onExecute(true);

	m_telegramThread = CreateTelegramThread(std::narrow(m_settings.token).c_str(),
		[errorDialog = m_errorDialog](const std::wstring& error)
		{
			ext::InvokeMethodAsync([error, errorDialog]()
				{
					errorDialog->ShowWindow(error);
				});
		});

	StoreParameters();

	const auto onMessage = [pass = m_settings.password, telegramThread = m_telegramThread]
		(const MessagePtr& commandMessage)
		{
			const std::wstring messageText = getUNICODEString(commandMessage->text);
			if (messageText != pass)
			{
				telegramThread->SendMessage(commandMessage->chat->id, L"Unknown message");
				return;
			}

			ext::InvokeMethodAsync([telegramThread, pUser = commandMessage->from]()
				{
					auto& settings = ext::get_service<Settings>();

					auto& users = settings.registeredUsers;
					const bool exist = std::any_of(users.begin(), users.end(),
						[&](const Settings::User& user)
						{
							return user.id == pUser->id;
						});
					if (exist)
						telegramThread->SendMessage(pUser->id, L"User already registered");
					else
					{
						users.emplace_back(pUser);
						settings.Store();

						telegramThread->SendMessage(pUser->id, L"User registered");
					}
				});
		};
	const auto onUnknownCommand = [onMessage](const MessagePtr& commandMessage)
	{
		onMessage(commandMessage);
	};

	m_telegramThread->StartTelegramThread({}, onUnknownCommand, onMessage);
}

void CTelegramNotifierDlg::OnBnClickedButtonSendMessage()
{
	if (m_settings.registeredUsers.empty())
	{
		MessageBox(L"No registered users", L"Can't send message", MB_ICONERROR);
		return;
	}

	CString text;
	m_message.GetWindowTextW(text);
	SendMessageToUsers(text);

	MessageBox(std::string_swprintf(L"Message sent to %u users", m_settings.registeredUsers.size()).c_str(),
		L"Can't send message", MB_ICONERROR);
}

BOOL CTelegramNotifierDlg::PreTranslateMessage(MSG* pMsg)
{
	if (pMsg->message == WM_KEYDOWN)
	{
		switch (pMsg->wParam)
		{
		case VK_RETURN:
			OnBnClickedButtonSendMessage();
			return TRUE;
		case VK_ESCAPE:
			m_message.SetWindowTextW(L"");
			return TRUE;
		default:
			break;
		}
	}
	return CDialogEx::PreTranslateMessage(pMsg);
}
