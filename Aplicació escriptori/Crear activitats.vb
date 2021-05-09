Imports MySql.Data.MySqlClient

Public Class crear_activitat
    Public query As String
    Public id As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub crear_Click(sender As Object, e As EventArgs) Handles crear.Click
        Insertar()
        MessageBox.Show("Valor afegit")
        gestio_activitats.actualitzarTaula()
    End Sub
    Function Insertar()
        Connexions.connectar()
        If titol.Text.Contains("'") Or descripcio.Text.Contains("'") Then
            titol.Text = titol.Text.Replace("'", "’")
            descripcio.Text = descripcio.Text.Replace("'", "’")
            query = $"INSERT INTO `activitat`(`titol`, `data`, `descripcio`, `preu`, `places_totals`,`places_actuals`, 
            `id_esdeveniment`, `data_inici_mostra`, `data_fi_mostra`, `id_ubicacio`, `id_departament`) 
            VALUES ('{titol.Text}','{data.Value.ToString("yyyy-MM-dd")}','{descripcio.Text}','{preu.Text}',
            '{places_totals.Text}','{places_actuals.Text}','{esdeveniment.SelectedValue}',
            '{data_inici_mostra.Value.ToString("yyyy-MM-dd")}','{data_fi_mostra.Value.ToString("yyyy-MM-dd")}',
            '{ubicacio.SelectedValue}','{departament.SelectedValue}')"
        Else
            query = $"INSERT INTO `activitat`(`titol`, `data`, `descripcio`, `preu`, `places_totals`,`places_actuals`, 
            `id_esdeveniment`, `data_inici_mostra`, `data_fi_mostra`, `id_ubicacio`, `id_departament`) 
            VALUES ('{titol.Text}','{data.Value.ToString("yyyy-MM-dd")}','{descripcio.Text}','{preu.Text}',
            '{places_totals.Text}','{places_actuals.Text}','{esdeveniment.SelectedValue}',
            '{data_inici_mostra.Value.ToString("yyyy-MM-dd")}','{data_fi_mostra.Value.ToString("yyyy-MM-dd")}',
            '{ubicacio.SelectedValue}','{departament.SelectedValue}')"
        End If
        Dim comanda = New MySqlCommand(query, Connexions.connexio)
        comanda.ExecuteNonQuery()
        Connexions.desconnectar()
    End Function
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_activitats.Show()
    End Sub
    Function emplenarCamps()
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

    End Function

    Private Sub crear_activitat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class