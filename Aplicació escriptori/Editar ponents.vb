Imports MySql.Data.MySqlClient

Public Class editar_ponents
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_ponent.Show()
        gestio_ponent.actualitzarTaula()
    End Sub
    Private Sub actualitzar_Click(sender As Object, e As EventArgs) Handles actualitzar.Click
        Connexions.connectar()
        Dim name As String
        Dim lastname As String
        Dim phone As Int32
        Dim mail As String

        name = nom.Text
        lastname = cognom.Text
        phone = telefon.Text
        mail = email.Text
        Dim id As String
        id = identificador.Text
        If name.Contains("'") Then
            name = nom.Text.Replace("'", "’")
            query = $"Update ponent SET nom=('{name}'), cognoms = ('{cognom.Text}'), telefon = ('{telefon.Text}'), 
        email =('{email.Text}') where id = ('{id}')"
        Else
            query = $"Update ponent SET nom=('{nom.Text}'), cognoms = ('{cognom.Text}'), telefon = ('{telefon.Text}'), 
        email =('{email.Text}') where id = ('{id}')"
        End If
        If lastname.Contains("'") Then
            lastname = cognom.Text.Replace("'", "’")
            query = $"Update ponent SET nom=('{nom.Text}'), cognoms = ('{cognom.Text}'), telefon = ('{telefon.Text}'), 
        email =('{email.Text}') where id = ('{id}')"
        Else
            query = $"Update ponent SET nom=('{nom.Text}'), cognoms = ('{cognom.Text}'), telefon = ('{telefon.Text}'), 
        email =('{email.Text}') where id = ('{id}')"
        End If
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        comanda.ExecuteNonQuery()
        Connexions.desconnectar()

    End Sub

    Private Sub editar_ponents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class