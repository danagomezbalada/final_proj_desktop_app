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
        actualitzarTaula()
    End Sub
    Function actualitzarTaula()
        If cercar_per_data.Checked = True And String.IsNullOrEmpty(estat.Text) Then
            query = $"SELECT r.id, r.email As `USUARI` , a.titol AS `ACTIVITAT`, r.data, r.codi_transaccio, 
            r.estat From reserva r Join activitat a ON r.id_activitat = a.id
            WHERE r.data='{data.Value.ToString("yyyy-MM-dd")}'"
        ElseIf cercar_per_data.Checked = False And Not String.IsNullOrEmpty(estat.Text) Then
            query = $"SELECT r.id, r.email As `USUARI` , a.titol AS `ACTIVITAT`, r.data, r.codi_transaccio, 
            r.estat From reserva r Join activitat a ON r.id_activitat = a.id 
            WHERE r.estat='{estat.Text}'"
        ElseIf cercar_per_data.Checked = True And Not String.IsNullOrEmpty(estat.Text) Then
            query = $"SELECT r.id, r.email As `USUARI` , a.titol AS `ACTIVITAT`, r.data, r.codi_transaccio, 
            r.estat From reserva r Join activitat a ON r.id_activitat = a.id 
            WHERE r.data='{data.Value.ToString("yyyy-MM-dd")}' AND r.estat='{estat.Text}'"
        Else
            query = $"SELECT r.id, r.email As `USUARI` , a.titol AS `ACTIVITAT`, r.data, r.codi_transaccio, 
            r.estat From reserva r Join activitat a ON r.id_activitat = a.id "
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
        taula_reserves.Columns(3).HeaderCell.Value = "DATA"
        taula_reserves.Columns(4).HeaderCell.Value = "CODI TRANSACCIÓ"
        taula_reserves.Columns(5).HeaderCell.Value = "ESTAT"
    End Function

    Private Sub gestio_reserves_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualitzarTaula()
    End Sub
End Class
