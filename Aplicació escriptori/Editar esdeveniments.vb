Imports MySql.Data.MySqlClient
Public Class editar_esdeveniments
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_esdeveniment.Show()
    End Sub

    Private Sub actualitzar_Click(sender As Object, e As EventArgs) Handles actualitzar.Click
        Connexions.connectar()
        Dim id As String
        id = identificador.Text
        Dim active As Int32
        If actiu.Checked = True Then
            active = 1
        Else
            active = 0
        End If

        query = $"Update esdeveniment SET any = ('{any.Text}'),nom=('{nom.Text}'),  descripcio = ('{descripcio.Text}'),actiu = ('{active}') 
        where id = ('{id}')"
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        comanda.ExecuteNonQuery()
        Connexions.desconnectar()
    End Sub
End Class