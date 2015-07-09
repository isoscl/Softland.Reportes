Imports Softalnd.Business
Imports TenTec.Windows.iGridLib


Public Class FrmCuentasContables
    Inherits FormularioBase

    Private tabla As DataTable
    Private ds As DataSet
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()


        With Me.IGridCuentas
            .GroupBox.Visible = True
            .Cols.Add("PCCODI", "Código de la cuenta")
            .Cols.Add("PCDESC", "Descripción de la cuenta")
            .Cols.Add("CODIGOIFRSFK", "Cuenta según IFRS")
            .Cols.Add("CODIGO1501FK", "Cuenta según Circular 1501")
        End With

        'Personalizar botones del control user menu lateral.
        Me.MenuLateral1.btnUno.Text = "Actualizar"
        Me.MenuLateral1.btnCuatro.Text = "Salir"

    End Sub
    Private Sub FrmCuentasContables_Load(sender As Object, e As EventArgs) Handles Me.Load




        Me.IGridCuentas.BeginUpdate()
        Try
            CargarDatosCombos()
            CargarDatosPrincipal()
            Me.IGridCuentas.Cols.AutoWidth()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.IGridCuentas.EndUpdate()
        End Try
    End Sub

   


    Private Sub CargarDatosCombos()
        Dim cboCuentasIFRS = New iGDropDownList
        tabla = CuentasContables.ListarCuentasIFRS
        cboCuentasIFRS.FillWithData(tabla, "CODIGOIFRS", "CUENTAIFRS")
        Me.IGridCuentas.Cols(2).CellStyle.DropDownControl = cboCuentasIFRS

        Dim cboCuentas1501 = New iGDropDownList
        tabla = CuentasContables.ListarCuentas1501
        cboCuentas1501.FillWithData(tabla, "CODIGO1501", "CUENTA1501")
        Me.IGridCuentas.Cols(3).CellStyle.DropDownControl = cboCuentas1501
    End Sub
    Private Sub CargarDatosPrincipal()
        ds = CuentasContables.ListarCuentasSoftland
        Me.IGridCuentas.FillWithData(ds.Tables(0), True)
    End Sub
    Private Sub ActualizarCuentas()
        For Each fila As iGRow In Me.IGridCuentas.Rows
            CuentasContables.ActualizarDatos(CStr(fila.Cells(0).Value), CStr(fila.Cells(2).Value), CStr(fila.Cells(3).Value))
        Next
    End Sub

    Private Sub MenuLateral1_btnCuatroClick() Handles MenuLateral1.btnCuatroClick
        Me.Close()
    End Sub

    Private Sub MenuLateral1_btnUnoClick() Handles MenuLateral1.btnUnoClick
        'actualizar datos
        If MessageBox.Show("Are you sure you want to update the data store?", "CodeTrigger Sample - Update notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If
        Me.IGridCuentas.BeginUpdate()
        Try
            ActualizarCuentas()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.IGridCuentas.EndUpdate()
            MessageBox.Show("Datos Actualizados correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class