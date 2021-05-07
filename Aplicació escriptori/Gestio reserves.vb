Imports MySql.Data.MySqlClient
Public Class gestio_reserves
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub
    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Me.Hide()
        editar_reserves.Show()
        Dim Fila As Integer
        Dim id As String
        Fila = taula_reserves.CurrentRow.Index
        id = taula_reserves.Rows(Fila).Cells(0).Value.ToString
        editar_reserves.identificador.Text = id
        editar_reserves.usuari.Text = taula_reserves.Rows(Fila).Cells(1).Value.ToString
        editar_reserves.activitat.Text = taula_reserves.Rows(Fila).Cells(2).Value.ToString
        editar_reserves.emplenarCamps()
    End Sub
    Private Sub Cercar_Click(sender As Object, e As EventArgs) Handles Cercar.Click

        If cercar_per_data.Checked = True And String.IsNullOrEmpty(estat.Text) Then
            query = $"SELECT r.id, u.email As `USUARI` , a.titol AS `ACTIVITAT`, r.data, r.codi_transaccio, 
            r.estat From reserva r Join activitat a ON r.id_activitat = a.id Join usuari u ON r.id_usuari = u.id
            WHERE r.data='{data.Value.ToString("yyyy-MM-dd")}'"
        ElseIf cercar_per_data.Checked = False And Not String.IsNullOrEmpty(estat.Text) Then
            query = $"SELECT r.id, u.email As `USUARI` , a.titol AS `ACTIVITAT`, r.data, r.codi_transaccio, 
            r.estat From reserva r Join activitat a ON r.id_activitat = a.id Join usuari u ON r.id_usuari = u.id
            WHERE r.estat='{estat.Text}'"
        ElseIf cercar_per_data.Checked = True And Not String.IsNullOrEmpty(estat.Text) Then
            query = $"SELECT r.id, u.email As `USUARI` , a.titol AS `ACTIVITAT`, r.data, r.codi_transaccio, 
            r.estat From reserva r Join activitat a ON r.id_activitat = a.id Join usuari u ON r.id_usuari = u.id 
            WHERE r.data='{data.Value.ToString("yyyy-MM-dd")}' AND r.estat='{estat.Text}'"
        Else
            query = $"SELECT r.id, u.email As `USUARI` , a.titol AS `ACTIVITAT`, r.data, r.codi_transaccio, 
            r.estat From reserva r Join activitat a ON r.id_activitat = a.id Join usuari u ON r.id_usuari = u.id"
        End If
        Connexions.connectar()
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_reserves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_reserves.DataSource = conjunt_dades
        taula_reserves.Columns(0).Visible = False
        Connexions.desconnectar()
    End Sub
    Function actualitzarTaula()
        If String.IsNullOrEmpty(estat.Text) = True Then
            query = $"SELECT * FROM reserva"
        Else
            query = $"SELECT * FROM reserva where estat='{estat.Text}'"
        End If
        Connexions.connectar()
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_reserves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_reserves.DataSource = conjunt_dades
        taula_reserves.Columns(0).Visible = False
        Connexions.desconnectar()
    End Function

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim id As String
        Dim Fila As Integer
        Dim missatge As MsgBoxResult = MsgBox("Vols eliminar el registre?", MsgBoxStyle.OkCancel, "Eliminar")
        If missatge = MsgBoxResult.Ok Then
            Fila = taula_reserves.CurrentRow.Index
            id = taula_reserves.Rows(Fila).Cells(0).Value
            query = $"DELETE FROM activitat where id = '{id}'"
            Connexions.connectar()
            Dim comanda As New MySqlCommand(query, Connexions.connexio)
            comanda.ExecuteNonQuery()
            Connexions.desconnectar()
            actualitzarTaula()
        End If
    End Sub
End Class
