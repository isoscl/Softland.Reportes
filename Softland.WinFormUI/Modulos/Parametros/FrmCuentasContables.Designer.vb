<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCuentasContables
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
        Me.MenuLateral1 = New Softland.WinFormUI.MenuLateral()
        Me.IGridCuentas = New TenTec.Windows.iGridLib.iGrid()
        Me.IGrid1DefaultCellStyle = New TenTec.Windows.iGridLib.iGCellStyle(True)
        Me.IGrid1DefaultColHdrStyle = New TenTec.Windows.iGridLib.iGColHdrStyle(True)
        Me.IGrid1RowTextColCellStyle = New TenTec.Windows.iGridLib.iGCellStyle(True)
        CType(Me.IGridCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuLateral1
        '
        Me.MenuLateral1.Location = New System.Drawing.Point(759, 12)
        Me.MenuLateral1.Name = "MenuLateral1"
        Me.MenuLateral1.Size = New System.Drawing.Size(107, 428)
        Me.MenuLateral1.TabIndex = 0
        '
        'IGridCuentas
        '
        Me.IGridCuentas.DefaultCol.CellStyle = Me.IGrid1DefaultCellStyle
        Me.IGridCuentas.DefaultCol.ColHdrStyle = Me.IGrid1DefaultColHdrStyle
        Me.IGridCuentas.Location = New System.Drawing.Point(12, 12)
        Me.IGridCuentas.Name = "IGridCuentas"
        Me.IGridCuentas.Size = New System.Drawing.Size(741, 428)
        Me.IGridCuentas.TabIndex = 1
        '
        'FrmCuentasContables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 466)
        Me.Controls.Add(Me.IGridCuentas)
        Me.Controls.Add(Me.MenuLateral1)
        Me.Name = "FrmCuentasContables"
        Me.Text = "CuentasContables"
        CType(Me.IGridCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuLateral1 As Softland.WinFormUI.MenuLateral
    Friend WithEvents IGridCuentas As TenTec.Windows.iGridLib.iGrid
    Friend WithEvents IGrid1DefaultCellStyle As TenTec.Windows.iGridLib.iGCellStyle
    Friend WithEvents IGrid1DefaultColHdrStyle As TenTec.Windows.iGridLib.iGColHdrStyle
    Friend WithEvents IGrid1RowTextColCellStyle As TenTec.Windows.iGridLib.iGCellStyle
End Class
