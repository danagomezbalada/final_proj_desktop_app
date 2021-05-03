Imports MySql.Data.MySqlClient

Public Class gestio_esdeveniment
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub afegir_Click(sender As Object, e As EventArgs) Handles afegir.Click
        Me.Hide()
        crear_esdeveniments.Show()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Me.Hide()
        editar_esdeveniments.Show()

        Dim Fila As Integer
        Dim id As String
        Fila = taula_esdeveniment.CurrentRow.Index
        id = taula_esdeveniment.Rows(Fila).Cells(0).Value.ToString
        editar_esdeveniments.any.Text = taula_esdeveniment.Rows(Fila).Cells(0).Value
        editar_esdeveniments.nom.Text = taula_esdeveniment.Rows(Fila).Cells(1).Value
        editar_esdeveniments.descripcio.Text = taula_esdeveniment.Rows(Fila).Cells(2).Value
        editar_esdeveniments.actiu.Text = taula_esdeveniment.Rows(Fila).Cells(3).Value
        editar_esdeveniments.identificador.Text = Fila + 1

    End Sub

    Private Sub Cerca_Click(sender As Object, e As EventArgs) Handles Cerca.Click
        If String.IsNullOrEmpty(Nom.Text) = True And String.IsNullOrEmpty(Any.Text) = True Then
            query = $"SELECT any, nom, descripcio, actiu FROM esdeveniment"
        ElseIf String.IsNullOrEmpty(Any.Text) = True Then
            query = $"SELECT any, nom, descripcio, actiu FROM esdeveniment where nom LIKE '%{Nom.Text}%'"
        ElseIf String.IsNullOrEmpty(Nom.Text) = True Then
            query = $"SELECT any, nom, descripcio, actiu FROM esdeveniment where any = {Any.Text}"
        Else
            query = $"SELECT any, nom, descripcio, actiu FROM esdeveniment where nom LIKE '%{Nom.Text}%' AND any = '{Any.Text}'"
        End If
        Connexions.connectar()
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_esdeveniment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_esdeveniment.DataSource = conjunt_dades
        Connexions.desconnectar()
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim any As Int32
        Dim nom As String
        Dim descripcio As String
        Dim actiu As Boolean
        Dim Fila As Integer
        Fila = taula_esdeveniment.CurrentRow.Index
        any = taula_esdeveniment.Rows(Fila).Cells(0).Value
        nom = taula_esdeveniment.Rows(Fila).Cells(1).Value
        descripcio = taula_esdeveniment.Rows(Fila).Cells(2).Value
        actiu = taula_esdeveniment.Rows(Fila).Cells(3).Value

        query = $"DELETE FROM esdeveniment where nom = '{nom}' and any = {any}"

        Connexions.connectar()
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_esdeveniment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_esdeveniment.DataSource = conjunt_dades
        Connexions.desconnectar()
    End Sub
End Class