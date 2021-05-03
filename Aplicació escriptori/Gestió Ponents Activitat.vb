Imports MySql.Data.MySqlClient
Public Class gestio_ponents_activitat
    Dim query As String
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        crear_activitat.Show()

    End Sub

    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub



    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click



    End Sub

    Private Sub veure_ponents_Click(sender As Object, e As EventArgs) Handles veure_ponents.Click
        Connexions.connectar()
        query = $"SELECT nom, cognoms, telefon, email FROM ponent"
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_ponents_actuals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_ponents_actuals.DataSource = conjunt_dades
        taula_ponents_disponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_ponents_disponibles.DataSource = conjunt_dades
        Connexions.desconnectar()
    End Sub
End Class