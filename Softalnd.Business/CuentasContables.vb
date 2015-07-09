Imports Softalnd.Business.ConnHelper
Imports DALC4NET

Public Class CuentasContables
    Public Shared Function ListarCuentasSoftland() As DataSet
        ListarCuentasSoftland = ExecuteDataSet(sqlSelectCuentasSoftland)
    End Function

    Public Shared Function ListarCuentasIFRS() As DataTable
        ListarCuentasIFRS = ExecuteDataTable(sqlSelectCuentasIFRS)
    End Function

    Public Shared Function ListarCuentas1501() As DataTable
        ListarCuentas1501 = ExecuteDataTable(sqlSelectCuentas1501)
    End Function

    Public Shared Function ActualizarDatos(ByVal x As String, ByVal y As String, ByVal z As String) As Integer
        Dim p1 = New DBParameter("@PCCODI", x)
        Dim p2 = New DBParameter("@CODIGOIFRSFK", y)
        Dim p3 = New DBParameter("@CODIGO1501FK", z)

        ActualizarDatos = ExecuteNonQuery(sqlUpdateCuentas, p2, p3, p1)
    End Function
End Class






Partial Public Class CuentasContables
    Private Shared ReadOnly sqlSelectCuentasSoftland As String = "SELECT PCCODI, PCDESC, CODIGOIFRSFK, CODIGO1501FK FROM cwpctas WHERE PCLNIVEL > 3"

    Private Shared ReadOnly sqlSelectCuentasIFRS As String = "SELECT * FROM cwpctasifrs"

    Private Shared ReadOnly sqlSelectCuentas1501 As String = "SELECT * FROM cwpctas1501"

    Private Shared ReadOnly sqlUpdateCuentas As String = "UPDATE cwpctas SET CODIGOIFRSFK=@CODIGOIFRSFK, CODIGO1501FK=@CODIGO1501FK WHERE PCCODI=@PCCODI "
End Class
