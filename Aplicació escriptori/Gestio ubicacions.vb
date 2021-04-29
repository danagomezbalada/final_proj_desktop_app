Imports MySql.Data.MySqlClient
Public Class gestio_ubicacions
    Dim query As String

    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub Afegir_Click(sender As Object, e As EventArgs) Handles Afegir.Click
        Me.Hide()
        crear_ubicacio.Show()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Me.Hide()
        editar_ubicacions.Show()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        administrar_activitats.Show()

    End Sub
    Private Sub Cercar_Click(sender As Object, e As EventArgs) Handles Cercar.Click
        If String.IsNullOrEmpty(Nom.Text) = True Then
            query = $"SELECT nom FROM ubicacio"
        Else
            query = $"SELECT nom FROM ubicacio where nom LIKE '%{Nom.Text}%'"
        End If
        Connexions.connectar()
        'PASSAR DADES DE LA BD A UNA TAULA DE DADES DE VB'
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_ubicacions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_ubicacions.DataSource = conjunt_dades
        Connexions.desconnectar()
    End Sub
    Private Sub taula_ubicacions_CellContentClick(sender As Object, e As EventArgs) Handles taula_ubicacions.CellContentClick

    End Sub
End Class