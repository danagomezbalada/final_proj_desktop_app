Imports MySql.Data.MySqlClient
Public Class gestio_ponents_activitat
    Dim query As String
    Dim query1 As String
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        If editar_activitats.pantalla = "Editar" Then
            Me.Hide()
            editar_activitats.Show()
        Else
            Me.Hide()
            crear_activitat.Show()
        End If
    End Sub
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub
    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim id As String
        Dim Fila As Integer
        Dim missatge As MsgBoxResult = MsgBox("Vols eliminar el registre?", MsgBoxStyle.OkCancel, "Eliminar")
        If missatge = MsgBoxResult.Ok Then
            Fila = taula_ponents_actuals.CurrentRow.Index
            id = taula_ponents_actuals.Rows(Fila).Cells(0).Value
            query = $"DELETE FROM activitat_ponent where id = '{id}'"
            Connexions.connectar()
            Dim comanda As New MySqlCommand(query, Connexions.connexio)
            comanda.ExecuteNonQuery()
            Connexions.desconnectar()
            actualitzarTaula()
        End If
    End Sub
    Private Sub gestio_ponents_activitat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualitzarTaula()
    End Sub
    Function actualitzarTaula()
        Connexions.connectar()
        query = $"SELECT a.titol AS 'Nom_Activitat', p.nom AS `Nom_Ponent`, p.cognoms AS 'Cognoms_Ponent' 
        FROM activitat a LEFT OUTER JOIN activitat_ponent ap ON 
        a.id = ap.id_activitat LEFT OUTER JOIN ponent p ON ap.id_ponent = p.id "
        query1 = $"SELECT nom AS 'Nom_Ponent',cognoms AS 'Cognoms_Ponent' FROM ponent"
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim comanda1 As New MySqlCommand(query1, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim adaptador1 As New MySqlDataAdapter(comanda1)
        Dim conjunt_dades As New DataTable()
        Dim conjunt_dades1 As New DataTable()
        adaptador.Fill(conjunt_dades)
        adaptador1.Fill(conjunt_dades1)
        taula_ponents_actuals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_ponents_actuals.DataSource = conjunt_dades
        taula_ponents_disponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_ponents_disponibles.DataSource = conjunt_dades1
        Connexions.desconnectar()
    End Function

End Class