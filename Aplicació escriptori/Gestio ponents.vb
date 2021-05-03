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
        Dim Fila As Integer
        Dim id As String
        Fila = taula_ponent.CurrentRow.Index
        id = taula_ponent.Rows(Fila).Cells(0).Value.ToString
        editar_ponents.nom.Text = taula_ponent.Rows(Fila).Cells(0).Value
        editar_ponents.cognom.Text = taula_ponent.Rows(Fila).Cells(1).Value
        editar_ponents.telefon.Text = taula_ponent.Rows(Fila).Cells(2).Value
        editar_ponents.email.Text = taula_ponent.Rows(Fila).Cells(3).Value
        editar_ponents.identificador.Text = Fila + 1
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
            query = $"SELECT nom, cognoms, telefon, email FROM ponent where nom LIKE '%{Nom.Text}%' AND cognoms LIKE '%{Cognom.Text}%'"
        End If
        Connexions.connectar()
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_ponent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_ponent.DataSource = conjunt_dades
        Connexions.desconnectar()
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim nom As String
        Dim cognom As String
        Dim email As String
        Dim telefon As Int32
        Dim Fila As Integer

        Fila = taula_ponent.CurrentRow.Index
        nom = taula_ponent.Rows(Fila).Cells(0).Value
        cognom = taula_ponent.Rows(Fila).Cells(1).Value
        telefon = taula_ponent.Rows(Fila).Cells(2).Value
        email = taula_ponent.Rows(Fila).Cells(3).Value

        query = $"DELETE FROM ponent where nom = '{nom}' AND cognoms = '{cognom}'"

        Connexions.connectar()
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_ponent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_ponent.DataSource = conjunt_dades
        Connexions.desconnectar()

    End Sub
End Class