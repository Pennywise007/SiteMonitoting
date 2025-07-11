
// TelegramNotifierDlg.h : header file
//

#pragma once

#include <queue>

#include "Settings.h"

#include "TelegramThread.h"
#include "ErrorDialog.h"
// CTelegramNotifierDlg dialog
class CTelegramNotifierDlg : public CDialogEx
{
// Construction
public:
	CTelegramNotifierDlg(CWnd* pParent = nullptr);	// standard constructor

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_TELEGRAMNOTIFIER_DIALOG };
#endif

protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support

// Implementation
protected:
	HICON m_hIcon;

	DECLARE_MESSAGE_MAP()
		
	// Generated message map functions
	virtual BOOL PreTranslateMessage(MSG* pMsg);
	virtual BOOL OnInitDialog();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnPaint();
	afx_msg void OnClose();
	afx_msg void OnBnClickedButtonRun();
	afx_msg void OnBnClickedButtonSendMessage();
	afx_msg BOOL OnCopyData(CWnd* pWnd, COPYDATASTRUCT* pCopyDataStruct);

private:
	void StoreParameters();
	void StopThread();
	void ParseCommandLine(LPCWSTR commandLine);
	void SendMessageToUsers(const CString& text);

private:
	Settings& m_settings = ext::get_singleton<Settings>();
	ITelegramThreadPtr m_telegramThread;

public:
	CEdit m_editToken;
	CEdit m_editPassword;
	CEdit m_message;
	CButton m_buttonRun;
	
	std::shared_ptr<ErrorDialog> m_errorDialog;
};
