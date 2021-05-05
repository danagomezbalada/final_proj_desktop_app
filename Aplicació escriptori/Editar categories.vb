Imports MySql.Data.MySqlClient
Public Class editar_categories
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_categoria.Show()
        gestio_categoria.actualitzarTaula()

    End Sub

    Private Sub actualitzar_Click(sender As Object, e As EventArgs) Handles actualitzar.Click
        Connexions.connectar()
        Dim id As String
        id = identificador.Text
        Dim name As String
        name = nom.Text
        If name.Contains("'") Then
            name = nom.Text.Replace("'", "’")
            query = $"Update Categoria SET nom=('{name}') where id = ('{id}');"
        Else
            query = $"Update Categoria SET nom=('{name}') where id = ('{id}');"
        End If

        Dim comanda = New MySqlCommand(query, Connexions.connexio)
        comanda.ExecuteNonQuery()
        Connexions.desconnectar()
    End Sub

    Private Sub editar_categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class