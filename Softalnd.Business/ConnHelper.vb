Imports DALC4NET

Public Class ConnHelper
    Private Shared dbHelper As New DBHelper("sqlCon")
    Private Shared conn As IDbConnection = dbHelper.GetConnObject

    Public Sub New()

    End Sub


    'Ejecuta la consulta y devuelve la primera columna de la primera fila del conjunto de resultados devuelto por la consulta. Las demás columnas o filas no se tienen en cuenta.
    'Valor devuelto Tipo: System.Object. 
    'La primera columna de la primera fila es el conjunto resultante, o una referencia null (Nothing en Visual Basic) si el conjunto resultante está vacío. Devuelve un máximo de 2033 caracteres.
    Public Overloads Shared Function ExecuteScalar(ByVal query As String) As Object
        Dim obj As Object = Nothing

        obj = dbHelper.ExecuteScalar(query)
        If Not IsNothing(obj) Then
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            Return obj
        Else
            Return Nothing
        End If
    End Function

    Public Overloads Shared Function ExecuteScalar(ByVal query As String, ByVal ParamArray args() As DBParameter) As Object
        Dim obj As Object = Nothing
        Dim coleccion As New DBParameterCollection

        If args.Length <= 0 Then
            Return Nothing
            Exit Function
        Else
            For i As Integer = 0 To UBound(args, 1)
                coleccion.Add(args(i))
            Next i

            obj = dbHelper.ExecuteScalar(query, coleccion)
            If Not IsNothing(obj) Then
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                Return obj
                Exit Function
            End If
            Return Nothing
        End If
    End Function

    Public Overloads Shared Function ExecuteScalarSP(ByVal sp As String) As Object
        Dim obj As Object = Nothing

        obj = dbHelper.ExecuteScalar(sp, CommandType.StoredProcedure)
        If Not IsNothing(obj) Then
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            Return obj
        Else
            Return Nothing
        End If
    End Function

    Public Overloads Shared Function ExecuteScalarSP(ByVal sp As String, ByVal ParamArray args() As DBParameter) As Object
        Dim obj As Object = Nothing
        Dim coleccion As New DBParameterCollection

        If args.Length <= 0 Then
            Return Nothing
            Exit Function
        Else
            For i As Integer = 0 To UBound(args, 1)
                coleccion.Add(args(i))
            Next i

            obj = dbHelper.ExecuteScalar(sp, coleccion, CommandType.StoredProcedure)
            If Not IsNothing(obj) Then
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                Return obj
                Exit Function
            End If
            Return Nothing
        End If
    End Function


    'Ejecuta una instrucción de Transact-SQL en la conexión y devuelve el número de filas afectadas.
    'Cambiar la información de una base de datos sin utilizar un DataSet mediante la ejecución de instrucciones UPDATE, INSERT o DELETE.
    'Para las instrucciones UPDATE, INSERT y DELETE, el valor devuelto corresponde al número de filas afectadas por el comando.'Para los demás tipos de instrucciones, el valor devuelto es -1
    Public Overloads Shared Function ExecuteNonQuery(ByVal query As String) As Integer
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        ExecuteNonQuery = dbHelper.ExecuteNonQuery(query)
    End Function
    Public Overloads Shared Function ExecuteNonQuery(ByVal query As String, ByVal ParamArray args() As DBParameter) As Integer
        Dim coleccion As New DBParameterCollection

        If args.Length <= 0 Then
            Return Nothing
            Exit Function
        Else
            For i As Integer = 0 To UBound(args, 1)
                coleccion.Add(args(i))
            Next i
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            ExecuteNonQuery = dbHelper.ExecuteNonQuery(query, coleccion)
        End If
    End Function

    Public Shared Function ExecuteNonQuerySP(ByVal sp As String, ByVal ParamArray args() As DBParameter) As Integer
        Dim coleccion As New DBParameterCollection

        If args.Length <= 0 Then
            Return Nothing
            Exit Function
        Else
            For i As Integer = 0 To UBound(args, 1)
                coleccion.Add(args(i))
            Next i
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            ExecuteNonQuerySP = dbHelper.ExecuteNonQuery(sp, coleccion, CommandType.StoredProcedure)
        End If
    End Function


    'El DATAREADER sirve principalmente para recuperar datos y procesar ellos de forma rapida.Es decir el DataReader opera en una forma CONECTADA. Mientras que otros objectos como el DATASET y el DATATABLE si funcionan de una forma desconectada, con el DATAREADER no se puede hacer nada si no hay conection a una base. *El DataReader no es un objeto para pasar entre capas.

    Public Shared Function ExecuteDataReader(ByVal query As String) As IDataReader
        'Dim conn As IDbConnection = dbHelper.GetConnObject
        Dim reader As IDataReader = Nothing
        Dim comm As IDbCommand = dbHelper.GetCommand(query)
        'comm.CommandText = query
        comm.Connection = conn
        'comm.CommandType = CommandType.Text
        'El CommandBehavior.CloseConnection lo que hace es ue cierra la conexion asociada con el Reader cuando se cierra este.
        reader = comm.ExecuteReader(CommandBehavior.CloseConnection)
        Return reader
    End Function

    'DATAREADER
    Public Shared Function ExecuteDataTable(ByVal query As String) As DataTable
        Dim tabla As DataTable = dbHelper.ExecuteDataTable(query)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Return tabla
    End Function

    'DATASET
    Public Shared Function ExecuteDataSet(ByVal query As String) As DataSet
        Dim ds As DataSet = dbHelper.ExecuteDataSet(query)
        'If conn.State = ConnectionState.Open Then
        '    conn.Close()
        'End If
        Return ds


        


    End Function
End Class
