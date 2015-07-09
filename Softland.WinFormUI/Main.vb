Public Class Main
    <STAThread()> _
    Shared Sub Main()
        'Environment.CurrentDirectory = Application.StartupPath
        Application.SetCompatibleTextRenderingDefault(False)
        Application.EnableVisualStyles()
        Application.Run(New FrmPrincipal)

        'Dim login As frmLogin = New frmLogin
        'login.ShowDialog()

        'If (login.DialogResult = DialogResult.OK) Then

        '    Application.Run(New frmPrincipal)

        'End If
    End Sub
End Class
