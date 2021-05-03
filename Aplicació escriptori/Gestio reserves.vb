Imports MySql.Data.MySqlClient

Public Class gestio_reserves
    Dim query As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Me.Hide()
        editar_reserves.Show()
    End Sub

    Private Sub Cercar_Click(sender As Object, e As EventArgs) Handles Cercar.Click

    End Sub
End Class
