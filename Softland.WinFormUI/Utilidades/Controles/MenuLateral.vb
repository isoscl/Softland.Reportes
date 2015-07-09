Imports System.ComponentModel

Public Class MenuLateral

    '<Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
   


    Public Event btnUnoClick()
    Public Event btnDosClick()
    Public Event btnTresClick()
    Public Event btnCuatroClick()
    
    Private Sub btnUno_Click(sender As Object, e As EventArgs) Handles btnUno.Click
        RaiseEvent btnUnoClick()
    End Sub

    Private Sub btnDos_Click(sender As Object, e As EventArgs) Handles btnDos.Click
        RaiseEvent btnDosClick()
    End Sub

    Private Sub btnTres_Click(sender As Object, e As EventArgs) Handles btnTres.Click
        RaiseEvent btnTresClick()
    End Sub

    Private Sub btnCuatro_Click(sender As Object, e As EventArgs) Handles btnCuatro.Click
        RaiseEvent btnCuatroClick()
    End Sub
End Class
