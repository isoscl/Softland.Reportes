<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuLateral
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCuatro = New System.Windows.Forms.Button()
        Me.btnTres = New System.Windows.Forms.Button()
        Me.btnDos = New System.Windows.Forms.Button()
        Me.btnUno = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCuatro)
        Me.GroupBox1.Controls.Add(Me.btnTres)
        Me.GroupBox1.Controls.Add(Me.btnDos)
        Me.GroupBox1.Controls.Add(Me.btnUno)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 401)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones:"
        '
        'btnCuatro
        '
        Me.btnCuatro.Location = New System.Drawing.Point(15, 312)
        Me.btnCuatro.Name = "btnCuatro"
        Me.btnCuatro.Size = New System.Drawing.Size(75, 53)
        Me.btnCuatro.TabIndex = 3
        Me.btnCuatro.Text = "Button4"
        Me.btnCuatro.UseVisualStyleBackColor = True
        '
        'btnTres
        '
        Me.btnTres.Location = New System.Drawing.Point(15, 220)
        Me.btnTres.Name = "btnTres"
        Me.btnTres.Size = New System.Drawing.Size(75, 53)
        Me.btnTres.TabIndex = 2
        Me.btnTres.Text = "Button3"
        Me.btnTres.UseVisualStyleBackColor = True
        '
        'btnDos
        '
        Me.btnDos.Location = New System.Drawing.Point(15, 128)
        Me.btnDos.Name = "btnDos"
        Me.btnDos.Size = New System.Drawing.Size(75, 53)
        Me.btnDos.TabIndex = 1
        Me.btnDos.Text = "Button2"
        Me.btnDos.UseVisualStyleBackColor = True
        '
        'btnUno
        '
        Me.btnUno.Location = New System.Drawing.Point(15, 36)
        Me.btnUno.Name = "btnUno"
        Me.btnUno.Size = New System.Drawing.Size(75, 53)
        Me.btnUno.TabIndex = 0
        Me.btnUno.Text = "Button1"
        Me.btnUno.UseVisualStyleBackColor = True
        '
        'MenuLateral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MenuLateral"
        Me.Size = New System.Drawing.Size(105, 401)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCuatro As System.Windows.Forms.Button
    Friend WithEvents btnTres As System.Windows.Forms.Button
    Friend WithEvents btnDos As System.Windows.Forms.Button
    Friend WithEvents btnUno As System.Windows.Forms.Button

End Class
