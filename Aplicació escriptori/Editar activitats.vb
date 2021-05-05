Imports MySql.Data.MySqlClient
Public Class editar_activitats
    Dim query As String
    Public pantalla As String

    Private Sub actualitzar_Click(sender As Object, e As EventArgs) Handles actualitzar.Click

    End Sub

    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_activitats.Show()
    End Sub

    Private Sub gestionar_ponents_activitat_Click(sender As Object, e As EventArgs) Handles gestionar_ponents_activitat.Click
        Me.Hide()
        gestio_ponents_activitat.Show()
        pantalla = "Editar"
    End Sub

    Private Sub egstionar_categories_activitat_Click(sender As Object, e As EventArgs) Handles egstionar_categories_activitat.Click
        Me.Hide()
        gestio_categories_activitat.Show()
    End Sub

    Private Sub editar_activitats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Function emplenarCamps()
        Connexions.connectar()
        Dim query As String
        query = $"Select * from activitat where id='{identificador.Text}'"
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        titol.Text = conjunt_dades.Rows(0).Item(1)
        data.Text = conjunt_dades.Rows(0).Item(2)
        descripcio.Text = conjunt_dades.Rows(0).Item(3)
        preu.Text = conjunt_dades.Rows(0).Item(4)
        places_totals.Text = conjunt_dades.Rows(0).Item(5)
        Connexions.desconnectar()

    End Function
End Class