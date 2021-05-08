Imports MySql.Data.MySqlClient
Public Class editar_activitats
    Dim query As String
    Public pantalla As String
    Dim esdevenimentId As String
    Dim ubicacioId As String
    Dim departamentId As String

    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_activitats.Show()
    End Sub

    Private Sub gestionar_ponents_activitat_Click(sender As Object, e As EventArgs) Handles gestionar_ponents_activitat.Click
        Me.Hide()
        gestio_ponents_activitat.Show()
        pantalla = "Editar"
        gestio_ponents_activitat.actualitzarTaula()
    End Sub

    Private Sub egstionar_categories_activitat_Click(sender As Object, e As EventArgs) Handles egstionar_categories_activitat.Click
        Me.Hide()
        gestio_categories_activitat.Show()
        pantalla = "Editar"
        gestio_categories_activitat.actualitzarTaula()
    End Sub
    Function emplenarCamps()
        Connexions.connectar()
        query = $"Select * from activitat where id='{identificador.Text}'"
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        titol.Text = conjunt_dades.Rows(0).Item(1)
        data.Text = conjunt_dades.Rows(0).Item(2)
        descripcio.Text = conjunt_dades.Rows(0).Item(3)
        preu.Text = conjunt_dades.Rows(0).Item(4)
        places_totals.Text = conjunt_dades.Rows(0).Item(5)
        places_actuals.Text = conjunt_dades.Rows(0).Item(6)
        esdevenimentId = conjunt_dades.Rows(0).Item(7)
        data_inici_mostra.Text = conjunt_dades.Rows(0).Item(8)
        data_fi_mostra.Text = conjunt_dades.Rows(0).Item(9)
        ubicacioId = conjunt_dades.Rows(0).Item(10)
        departamentId = conjunt_dades.Rows(0).Item(11)
        Connexions.desconnectar()
        carregarEsdeveniments()
        carregarUbicacio()
        carregarDepartament()
    End Function
    Function carregarEsdeveniments()
        Connexions.connectar()
        query = $"SELECT id,nom FROM esdeveniment"
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        Dim dt As New DataTable()
        dt.Load(comanda.ExecuteReader)
        esdeveniment.DataSource = dt
        esdeveniment.DisplayMember = "nom"
        esdeveniment.ValueMember = "id"
        esdeveniment.SelectedValue = esdevenimentId
    End Function

    Function carregarUbicacio()
        Connexions.connectar()
        query = $"SELECT id,nom FROM ubicacio"
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)

        Dim dt As New DataTable()
        dt.Load(comanda.ExecuteReader)
        ubicacio.DataSource = dt
        ubicacio.DisplayMember = "nom"
        ubicacio.ValueMember = "id"
        ubicacio.SelectedValue = ubicacioId
    End Function

    Function carregarDepartament()
        Connexions.connectar()
        query = $"SELECT id,nom FROM departament"
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)

        Dim dt As New DataTable()
        dt.Load(comanda.ExecuteReader)
        departament.DataSource = dt
        departament.DisplayMember = "nom"
        departament.ValueMember = "id"
        departament.SelectedValue = departamentId
    End Function
    Private Sub actualitzar_Click(sender As Object, e As EventArgs) Handles actualitzar.Click
        Connexions.connectar()
        If titol.Text.Contains("'") Or descripcio.Text.Contains("'") Then
            titol.Text = titol.Text.Replace("'", "’")
            descripcio.Text = descripcio.Text.Replace("'", "’")
            query = $"UPDATE activitat SET titol = ('{titol.Text}'),data= ('{data.Value.ToString("yyyy-MM-dd")}'),
            descripcio = ('{descripcio.Text}'),preu = ('{preu.Text}'),places_totals = ('{places_totals.Text}'),
            places_actuals= ('{places_actuals.Text}'),id_esdeveniment= ('{esdeveniment.SelectedValue}'),
            data_inici_mostra= ('{data_inici_mostra.Value.ToString("yyyy-MM-dd")}'),
            data_fi_mostra = ('{data_fi_mostra.Value.ToString("yyyy-MM-dd")}'),
            id_ubicacio = ('{ubicacio.SelectedValue}'),id_departament= ('{departament.SelectedValue}')
            where id = ('{identificador.Text}')"
        Else
            query = $"Update activitat SET titol = ('{titol.Text}'),data= ('{data.Value.ToString("yyyy-MM-dd")}'),
            descripcio = ('{descripcio.Text}'),preu = ('{preu.Text}'),places_totals = ('{places_totals.Text}'),
            places_actuals= ('{places_actuals.Text}'),id_esdeveniment= ('{esdeveniment.SelectedValue}'),
            data_inici_mostra= ('{data_inici_mostra.Value.ToString("yyyy-MM-dd")}'),
            data_fi_mostra = ('{data_fi_mostra.Value.ToString("yyyy-MM-dd")}'),
            id_ubicacio = ('{ubicacio.SelectedValue}'),id_departament= ('{departament.SelectedValue}')
            where id = ('{identificador.Text}')"
        End If
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        comanda.ExecuteNonQuery()
        MessageBox.Show("Activitat actualitzada")
        Connexions.desconnectar()
    End Sub
End Class