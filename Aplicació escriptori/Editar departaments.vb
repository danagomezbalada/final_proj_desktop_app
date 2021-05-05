Imports MySql.Data.MySqlClient

Public Class editar_departaments
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_departament.Show()
        gestio_departament.actualitzarTaula()
    End Sub

    Private Sub actualitzar_Click(sender As Object, e As EventArgs) Handles actualitzar.Click
        Connexions.connectar()
        Dim id As String
        id = identificador.Text
        Dim name As String
        name = nom.Text
        If name.Contains("'") Then
            name = nom.Text.Replace("'", "’")
            query = $"Update departament SET nom=('{name}') where id = ('{id}')"
        Else
            query = $"Update departament SET nom=('{name}') where id = ('{id}')"
        End If

        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        comanda.ExecuteNonQuery()
        Connexions.desconnectar()
    End Sub

    Private Sub editar_departaments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class