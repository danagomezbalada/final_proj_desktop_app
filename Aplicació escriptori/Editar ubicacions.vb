Imports MySql.Data.MySqlClient

Public Class editar_ubicacions
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_ubicacions.Show()
        gestio_ubicacions.actualitzarTaula()
    End Sub

    Private Sub actualitzar_Click(sender As Object, e As EventArgs) Handles actualitzar.Click
        Connexions.connectar()
        Dim id As String
        id = identificador.Text
        Dim name As String
        name = Nom.Text
        If name.Contains("'") Then
            name = Nom.Text.Replace("'", "’")
            query = $"Update ubicacio SET nom=('{name}') where id = ('{id}')"
        Else
            query = $"Update ubicacio SET nom=('{name}') where id = ('{id}')"
        End If

        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        comanda.ExecuteNonQuery()
        Connexions.desconnectar()
    End Sub

    Private Sub editar_ubicacions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class