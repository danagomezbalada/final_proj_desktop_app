Imports MySql.Data.MySqlClient
Public Class gestio_activitats
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub
    Private Sub Afegir_Click(sender As Object, e As EventArgs) Handles Afegir.Click
        Me.Hide()
        crear_activitat.Show()
        crear_activitat.emplenarCamps()
    End Sub
    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Me.Hide()
        editar_activitats.Show()
        Dim Fila As Integer
        Dim id As String
        Fila = taula_activitats.CurrentRow.Index
        id = taula_activitats.Rows(Fila).Cells(0).Value.ToString
        editar_activitats.identificador.Text = id
        editar_activitats.emplenarCamps()
    End Sub
    Private Sub Cercar_Click(sender As Object, e As EventArgs) Handles Cercar.Click
        actualitzarTaula()
    End Sub
    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim id As String
        Dim Fila As Integer
        Dim missatge As MsgBoxResult = MsgBox("Vols eliminar el registre?", MsgBoxStyle.OkCancel, "Eliminar")
        If missatge = MsgBoxResult.Ok Then
            Fila = taula_activitats.CurrentRow.Index
            id = taula_activitats.Rows(Fila).Cells(0).Value
            query = $"DELETE FROM activitat where id = '{id}'"
            Connexions.connectar()
            Dim comanda As New MySqlCommand(query, Connexions.connexio)
            comanda.ExecuteNonQuery()
            Connexions.desconnectar()
            actualitzarTaula()
        End If
    End Sub
    Function actualitzarTaula()
        Connexions.connectar()
        If String.IsNullOrEmpty(nom.Text) = True Then
            query = $"SELECT a.id, a.titol, a.descripcio, a.preu, a.data, d.nom AS `Departament`, 
            e.nom AS `Esdeveniment`, u.nom AS `Ubicacio`FROM activitat a JOIN departament d ON 
            a.id_departament = d.id JOIN esdeveniment e ON a.id_esdeveniment = e.id JOIN ubicacio u ON 
            a.id_ubicacio = u.id "
        Else
            query = $"SELECT a.id,a.titol, a.descripcio, a.preu, a.data, d.nom AS `Departament`, 
            e.nom AS `Esdeveniment`, u.nom AS `Ubicacio`FROM activitat a JOIN departament d ON 
            a.id_departament = d.id JOIN esdeveniment e ON a.id_esdeveniment = e.id JOIN ubicacio u ON 
            a.id_ubicacio = u.id  
            where titol LIKE '%{nom.Text}%'"
        End If

        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_activitats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_activitats.DataSource = conjunt_dades
        taula_activitats.Columns(0).Visible = False
        Connexions.desconnectar()
        taula_activitats.Columns(1).HeaderCell.Value = "TITOL"
        taula_activitats.Columns(2).HeaderCell.Value = "DESCRIPCIÓ"
        taula_activitats.Columns(3).HeaderCell.Value = "PREU"
        taula_activitats.Columns(4).HeaderCell.Value = "DATA"
        taula_activitats.Columns(5).HeaderCell.Value = "DEPARTAMENT"
        taula_activitats.Columns(6).HeaderCell.Value = "ESDEVENIMENT"
        taula_activitats.Columns(7).HeaderCell.Value = "UBICACIÓ"
    End Function

    Private Sub gestio_activitats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualitzarTaula()
    End Sub
End Class