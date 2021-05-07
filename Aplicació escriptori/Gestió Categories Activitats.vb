Imports MySql.Data.MySqlClient

Public Class gestio_categories_activitat
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

    Private Sub gestio_categories_activitat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim id As String
        Dim Fila As Integer
        Dim missatge As MsgBoxResult = MsgBox("Vols eliminar el registre?", MsgBoxStyle.OkCancel, "Eliminar")
        If missatge = MsgBoxResult.Ok Then
            Fila = taula_categoria_actuals.CurrentRow.Index
            id = taula_categoria_actuals.Rows(Fila).Cells(1).Value
            query = $"DELETE FROM activitat_categoria where id_categoria = '{id}'"
            Connexions.connectar()
            Dim comanda As New MySqlCommand(query, Connexions.connexio)
            comanda.ExecuteNonQuery()
            Connexions.desconnectar()
            actualitzarTaula()
        End If
    End Sub
    Function actualitzarTaula()
        Connexions.connectar()
        query = $"SELECT a.id ,c.id, c.nom AS `Nom` 
        FROM activitat a LEFT OUTER JOIN activitat_categoria ac ON 
        a.id = ac.id_activitat LEFT OUTER JOIN categoria c ON ac.id_categoria = c.id 
        where a.id='{editar_activitats.identificador.Text}'"
        query1 = $"SELECT id,nom AS 'Nom'FROM categoria where id NOT IN 
        (SELECT id_categoria FROM activitat_categoria where id_activitat ='{editar_activitats.identificador.Text}')"
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim comanda1 As New MySqlCommand(query1, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim adaptador1 As New MySqlDataAdapter(comanda1)
        Dim conjunt_dades As New DataTable()
        Dim conjunt_dades1 As New DataTable()
        adaptador.Fill(conjunt_dades)
        adaptador1.Fill(conjunt_dades1)
        taula_categoria_actuals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_categoria_actuals.DataSource = conjunt_dades
        taula_categoria_disponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_categoria_disponibles.DataSource = conjunt_dades1
        taula_categoria_disponibles.Columns(0).Visible = False
        taula_categoria_actuals.Columns(0).Visible = False
        taula_categoria_actuals.Columns(1).Visible = False
        Connexions.desconnectar()
    End Function

    Private Sub Afegir_Click(sender As Object, e As EventArgs) Handles afegir.Click
        Connexions.connectar()
        Dim Fila As Integer
        Fila = taula_categoria_disponibles.CurrentRow.Index
        query = $"INSERT INTO activitat_categoria (id_activitat,id_categoria) VALUES ('{editar_activitats.identificador.Text}', '{taula_categoria_disponibles.Rows(Fila).Cells(0).Value.ToString}')"
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        comanda.ExecuteNonQuery()
        Connexions.desconnectar()
        actualitzarTaula()
    End Sub
End Class