Imports MySql.Data.MySqlClient
Public Class gestio_ponent
    Dim query As String
    Private Sub Nom_TextChanged(sender As Object, e As EventArgs) Handles Nom.TextChanged

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub Afegir_Click(sender As Object, e As EventArgs) Handles Afegir.Click
        Me.Hide()
        crear_ponents.Show()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Me.Hide()
        editar_ponents.Show()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        administrar_activitats.Show()
    End Sub

    Private Sub Cerca_Click(sender As Object, e As EventArgs) Handles Cerca.Click
        If String.IsNullOrEmpty(Nom.Text) = True And String.IsNullOrEmpty(Cognom.Text) = True Then
            query = $"SELECT nom, cognoms, telefon, email FROM ponent"
        ElseIf String.IsNullOrEmpty(Cognom.Text) = True Then
            query = $"SELECT nom, cognoms, telefon, email FROM ponent where nom LIKE '%{Nom.Text}%'"
        ElseIf String.IsNullOrEmpty(Nom.Text) = True Then
            query = $"SELECT nom, cognoms, telefon, email FROM ponent where cognoms LIKE '%{Cognom.Text}%'"
        Else
            query = $"SELECT nom, cognoms, telefon, email FROM ponent where nom LIKE '%{Nom.Text}%' AND cognoms = '%{Cognom.Text}%'"
        End If
        Connexions.connectar()
        'PASSAR DADES DE LA BD A UNA TAULA DE DADES DE VB'
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_ponent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_ponent.DataSource = conjunt_dades
        Connexions.desconnectar()
    End Sub
End Class