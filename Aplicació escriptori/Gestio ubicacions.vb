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

        Dim Fila As Integer
        Dim id As String
        Fila = taula_ubicacions.CurrentRow.Index
        id = taula_ubicacions.Rows(Fila).Cells(0).Value.ToString
        editar_ubicacions.Nom.Text = taula_ubicacions.Rows(Fila).Cells(0).Value
        editar_ubicacions.identificador.Text = Fila + 1
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
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_ubicacions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_ubicacions.DataSource = conjunt_dades
        Connexions.desconnectar()
    End Sub
    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim nom As String
        Dim Fila As Integer
        Fila = taula_ubicacions.CurrentRow.Index
        nom = taula_ubicacions.Rows(Fila).Cells(0).Value
        query = $"DELETE FROM ubicacio where nom = '{nom}'"

        Connexions.connectar()
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