Public Class FrmPrincipal
    Inherits FormularioBase
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.IsMdiContainer = True
        Me.Height = 800
        Me.Width = 1200
        Me.StartPosition = FormStartPosition.Manual
        Me.DesktopLocation = New Point(50, 10)
    End Sub

    'Private Sub Timer_Tick(sender As Object, e As System.EventArgs) Handles Timer.Tick
    '    Me.tsslabelReloj.Text = Date.Now.ToLongTimeString
    'End Sub

    Private Sub CuentasContablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasContablesToolStripMenuItem.Click
        FrmCuentasContables.MdiParent = Me
        FrmCuentasContables.StartPosition = FormStartPosition.CenterScreen
        FrmCuentasContables.Show()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tsslabelFecha.Text = FormatDateTime(CDate(Now.Date.ToString), DateFormat.LongDate)
    End Sub

    Private Sub BalanceClasificadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalanceClasificadoToolStripMenuItem.Click
        FrmBalanceClasificado.MdiParent = Me
        FrmBalanceClasificado.StartPosition = FormStartPosition.CenterScreen
        FrmBalanceClasificado.Show()
    End Sub
End Class