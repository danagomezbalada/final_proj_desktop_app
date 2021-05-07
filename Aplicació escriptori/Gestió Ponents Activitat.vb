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
            id = taula_ponents_actuals.Rows(Fila).Cells(1).Value
            query = $"DELETE FROM activitat_ponent where id_ponent = '{id}'"
            Connexions.connectar()
            Dim comanda As New MySqlCommand(query, Connexions.connexio)
            comanda.ExecuteNonQuery()
            Connexions.desconnectar()
            actualitzarTaula()
        End If
    End Sub
    Function actualitzarTaula()
        Connexions.connectar()
        query = $"SELECT a.id ,p.id, p.nom AS `Nom`, p.cognoms AS 'Cognoms' 
        FROM activitat a LEFT OUTER JOIN activitat_ponent ap ON 
        a.id = ap.id_activitat LEFT OUTER JOIN ponent p ON ap.id_ponent = p.id 
        where a.id='{editar_activitats.identificador.Text}'"

        query1 = $"SELECT id,nom AS 'Nom',cognoms AS 'Cognoms' FROM ponent where id NOT IN 
        (SELECT id_ponent FROM activitat_ponent where id_activitat ='{editar_activitats.identificador.Text}')"
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
        taula_ponents_disponibles.Columns(0).Visible = False
        taula_ponents_actuals.Columns(0).Visible = False
        taula_ponents_actuals.Columns(1).Visible = False
        Connexions.desconnectar()
    End Function

    Private Sub Afegir_Click(sender As Object, e As EventArgs) Handles Afegir.Click
        Connexions.connectar()
        Dim Fila As Integer
        Fila = taula_ponents_disponibles.CurrentRow.Index
        query = $"INSERT INTO activitat_ponent (id_activitat,id_ponent) VALUES ('{editar_activitats.identificador.Text}', '{taula_ponents_disponibles.Rows(Fila).Cells(0).Value.ToString}')"
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        comanda.ExecuteNonQuery()
        Connexions.desconnectar()
        actualitzarTaula()
    End Sub
End Class