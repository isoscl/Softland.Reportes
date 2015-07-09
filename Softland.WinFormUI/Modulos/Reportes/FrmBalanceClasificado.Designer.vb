<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBalanceClasificado
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
        Me.IGrid1 = New TenTec.Windows.iGridLib.iGrid()
        Me.IGrid1DefaultCellStyle = New TenTec.Windows.iGridLib.iGCellStyle(True)
        Me.IGrid1DefaultColHdrStyle = New TenTec.Windows.iGridLib.iGColHdrStyle(True)
        Me.IGrid1RowTextColCellStyle = New TenTec.Windows.iGridLib.iGCellStyle(True)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuLateral1 = New Softland.WinFormUI.MenuLateral()
        CType(Me.IGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IGrid1
        '
        Me.IGrid1.DefaultCol.CellStyle = Me.IGrid1DefaultCellStyle
        Me.IGrid1.DefaultCol.ColHdrStyle = Me.IGrid1DefaultColHdrStyle
        Me.IGrid1.Location = New System.Drawing.Point(13, 123)
        Me.IGrid1.Name = "IGrid1"
        Me.IGrid1.Size = New System.Drawing.Size(730, 401)
        Me.IGrid1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 105)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'MenuLateral1
        '
        Me.MenuLateral1.Location = New System.Drawing.Point(749, 123)
        Me.MenuLateral1.Name = "MenuLateral1"
        Me.MenuLateral1.Size = New System.Drawing.Size(105, 401)
        Me.MenuLateral1.TabIndex = 3
        '
        'FrmBalanceClasificado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 529)
        Me.Controls.Add(Me.MenuLateral1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.IGrid1)
        Me.Name = "FrmBalanceClasificado"
        Me.Text = "BalanceClasificado"
        CType(Me.IGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IGrid1 As TenTec.Windows.iGridLib.iGrid
    Friend WithEvents IGrid1DefaultCellStyle As TenTec.Windows.iGridLib.iGCellStyle
    Friend WithEvents IGrid1DefaultColHdrStyle As TenTec.Windows.iGridLib.iGColHdrStyle
    Friend WithEvents IGrid1RowTextColCellStyle As TenTec.Windows.iGridLib.iGCellStyle
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuLateral1 As Softland.WinFormUI.MenuLateral
End Class
