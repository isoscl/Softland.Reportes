<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits Softland.WinFormUI.FormularioBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.tsslabelNombreUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslabelNombre = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslabelApellido_p = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslabelApellido_m = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslabelFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslabelReloj = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ParámetrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasContablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BalanceClasificadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslabelNombreUsuario, Me.tsslabelNombre, Me.tsslabelApellido_p, Me.tsslabelApellido_m, Me.tsslabelFecha, Me.tsslabelReloj, Me.ToolStripStatusLabel1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 541)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(897, 24)
        Me.StatusStrip.TabIndex = 2
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'tsslabelNombreUsuario
        '
        Me.tsslabelNombreUsuario.AutoSize = False
        Me.tsslabelNombreUsuario.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslabelNombreUsuario.Name = "tsslabelNombreUsuario"
        Me.tsslabelNombreUsuario.Size = New System.Drawing.Size(180, 19)
        Me.tsslabelNombreUsuario.Text = "[Nombre Usuario]"
        '
        'tsslabelNombre
        '
        Me.tsslabelNombre.AutoSize = False
        Me.tsslabelNombre.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.tsslabelNombre.Name = "tsslabelNombre"
        Me.tsslabelNombre.Size = New System.Drawing.Size(80, 19)
        '
        'tsslabelApellido_p
        '
        Me.tsslabelApellido_p.AutoSize = False
        Me.tsslabelApellido_p.Name = "tsslabelApellido_p"
        Me.tsslabelApellido_p.Size = New System.Drawing.Size(80, 19)
        '
        'tsslabelApellido_m
        '
        Me.tsslabelApellido_m.AutoSize = False
        Me.tsslabelApellido_m.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.tsslabelApellido_m.Name = "tsslabelApellido_m"
        Me.tsslabelApellido_m.Size = New System.Drawing.Size(80, 19)
        '
        'tsslabelFecha
        '
        Me.tsslabelFecha.AutoSize = False
        Me.tsslabelFecha.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslabelFecha.Name = "tsslabelFecha"
        Me.tsslabelFecha.Size = New System.Drawing.Size(400, 19)
        Me.tsslabelFecha.Text = "[Fecha]"
        '
        'tsslabelReloj
        '
        Me.tsslabelReloj.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslabelReloj.Name = "tsslabelReloj"
        Me.tsslabelReloj.Size = New System.Drawing.Size(42, 19)
        Me.tsslabelReloj.Text = "[reloj]"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(4, 19)
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem, Me.ParámetrosToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(897, 24)
        Me.MenuStrip.TabIndex = 3
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ParámetrosToolStripMenuItem
        '
        Me.ParámetrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuentasContablesToolStripMenuItem})
        Me.ParámetrosToolStripMenuItem.Name = "ParámetrosToolStripMenuItem"
        Me.ParámetrosToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.ParámetrosToolStripMenuItem.Text = "&Parámetros"
        '
        'CuentasContablesToolStripMenuItem
        '
        Me.CuentasContablesToolStripMenuItem.Name = "CuentasContablesToolStripMenuItem"
        Me.CuentasContablesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CuentasContablesToolStripMenuItem.Text = "&Cuentas contables"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BalanceClasificadoToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "&Reportes"
        '
        'BalanceClasificadoToolStripMenuItem
        '
        Me.BalanceClasificadoToolStripMenuItem.Name = "BalanceClasificadoToolStripMenuItem"
        Me.BalanceClasificadoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.BalanceClasificadoToolStripMenuItem.Text = "&Balance Clasificado"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 565)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FrmPrincipal"
        Me.Text = "FormPrincipal"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslabelNombreUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslabelNombre As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslabelApellido_p As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslabelApellido_m As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslabelFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslabelReloj As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ParámetrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasContablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BalanceClasificadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
