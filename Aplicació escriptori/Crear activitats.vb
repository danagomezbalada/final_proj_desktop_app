Imports MySql.Data.MySqlClient

Public Class crear_activitat
    Public query As String
    Public id As String
    Private Sub titol_TextChanged(sender As Object, e As EventArgs) Handles titol.TextChanged

    End Sub

    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub crear_Click(sender As Object, e As EventArgs) Handles crear.Click
        Insertar()
        MessageBox.Show("Valor afegit")
    End Sub

    Function Insertar()
        '''Connexions.connectar()
        '''Dim title As String
        '''Dim dates As String
        '''Dim price As Double
        ''' Dim description As String
        ''' Dim total_places As Integer
        '''Dim data_fi As String
        '''Dim data_inici As String
        '''Dim nomEsdeveniment As Integer
        '''Dim nomUbicacio As Integer
        '''Dim nomDepartament As Integer

        '''title = titol.Text
        '''dates = data.Value.ToString("yyyy-MM-dd")
        '''price = preu.Text
        '''description = descripcio.Text
        '''total_places = places_totals.Text
        '''data_fi = data_fi_mostra.Value.ToString("yyyy-MM-dd")
        '''data_inici = data_inici_mostra.Value.ToString("yyyy-MM-dd")
        '''nomEsdeveniment = esdeveniment.Text
        '''nomUbicacio = ubicacio.Text
        '''nomD epartament = id_departament.Text

        '''query = $"INSERT INTO `activitat` (`titol`,`data`,`descripcio`,`preu`,`places_totals`,`id_esdeveniment`,
        '''`data_inici_mostra`,`data_fi_mostra`,`id_ubicacio`,`id_departament`) 
        '''VALUES ('{title}','{dates}','{description}','{price}','{total_places}','{esdeveniment}','{data_inici}',
        ''''{data_fi}','{ubicacio}','{departament}');"
        ''' Dim comanda = New MySqlCommand(query, Connexions.connexio)
        '''comanda.ExecuteNonQuery()
        '''Connexions.desconnectar()
    End Function

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_activitats.Show()
    End Sub

    Private Sub gestionar_ponents_activitat_Click(sender As Object, e As EventArgs) Handles gestionar_ponents_activitat.Click
        Me.Hide()
        gestio_ponents_activitat.Show()
        editar_activitats.pantalla = "Crear"
        'id = $"SELECT id from activitat"
    End Sub

    Private Sub egstionar_categories_activitat_Click(sender As Object, e As EventArgs) Handles egstionar_categories_activitat.Click
        Me.Hide()
        gestio_categories_activitat.Show()
    End Sub
End Class