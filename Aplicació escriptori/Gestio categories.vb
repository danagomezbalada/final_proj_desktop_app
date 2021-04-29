Imports MySql.Data.MySqlClient
Public Class gestio_categoria
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub Afegir_Click(sender As Object, e As EventArgs) Handles Afegir.Click
        Me.Hide()
        crear_categories.Show()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Me.Hide()
        editar_categories.Show()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        administrar_activitats.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles taula_categoria.CellContentClick

    End Sub

    Private Sub Cercar_Click(sender As Object, e As EventArgs) Handles Cercar.Click
        If String.IsNullOrEmpty(Nom.Text) = True Then
            query = $"SELECT nom FROM categoria"
        Else
            query = $"SELECT nom FROM categoria where nom LIKE '%{Nom.Text}%'"
        End If
        Connexions.connectar()
        'PASSAR DADES DE LA BD A UNA TAULA DE DADES DE VB'
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_categoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_categoria.DataSource = conjunt_dades
        Connexions.desconnectar()
    End Sub
End Class