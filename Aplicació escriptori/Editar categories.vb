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
        'Control d'error de que no hi hagui cap camp null
        If String.IsNullOrEmpty(nom.Text) = True Then
            MessageBox.Show("No hi poden haver-hi camps buits")
        Else
            Dim id As String
            id = identificador.Text
            Dim name As String
            name = nom.Text
            'Controll d'errors dels apostrofs
            If name.Contains("'") Then
                name = nom.Text.Replace("'", "’")
                'Update de les dades
                query = $"Update Categoria SET nom=('{name}') where id = ('{id}');"
            Else
                'Update de les dades
                query = $"Update Categoria SET nom=('{name}') where id = ('{id}');"
            End If
            Dim comanda = New MySqlCommand(query, Connexions.connexio)
            comanda.ExecuteNonQuery()
            MessageBox.Show("Categoria actualitzada")
        End If
        Connexions.desconnectar()

    End Sub
End Class