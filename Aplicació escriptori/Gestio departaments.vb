Imports MySql.Data.MySqlClient
Public Class gestio_departament
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub Afegir_Click(sender As Object, e As EventArgs) Handles Afegir.Click
        Me.Hide()
        crear_departaments.Show()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Me.Hide()
        editar_departaments.Show()
        Dim Fila As Integer
        Dim id As String
        Fila = taula_departament.CurrentRow.Index
        id = taula_departament.Rows(Fila).Cells(0).Value.ToString
        editar_departaments.nom.Text = taula_departament.Rows(Fila).Cells(0).Value
        editar_departaments.identificador.Text = Fila + 1
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        administrar_activitats.Show()
    End Sub

    Private Sub Cerca_Click(sender As Object, e As EventArgs) Handles Cerca.Click
        If String.IsNullOrEmpty(Nom.Text) = True Then
            query = $"SELECT nom FROM departament"
        Else
            query = $"SELECT nom FROM departament where nom LIKE '%{Nom.Text}%'"
        End If
        Connexions.connectar()
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_departament.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_departament.DataSource = conjunt_dades
        Connexions.desconnectar()
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim nom As String
        Dim Fila As Integer
        Fila = taula_departament.CurrentRow.Index
        nom = taula_departament.Rows(Fila).Cells(0).Value

        query = $"DELETE FROM departament where nom = '{nom}'"

        Connexions.connectar()
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_departament.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_departament.DataSource = conjunt_dades
        Connexions.desconnectar()
    End Sub
End Class