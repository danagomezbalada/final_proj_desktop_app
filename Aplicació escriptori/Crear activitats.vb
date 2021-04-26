Imports MySql.Data.MySqlClient

Public Class crear_activitat
    Public query As String
    Private Sub titol_TextChanged(sender As Object, e As EventArgs) Handles titol.TextChanged

    End Sub

    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        Principal.Show()
    End Sub

    Private Sub crear_Click(sender As Object, e As EventArgs) Handles crear.Click
        Insertar()
        MessageBox.Show("Valor afegit")
    End Sub

    Function Insertar()
        Connexions.connectar()
        Dim title As String
        Dim dates As String
        Dim price As Double
        Dim description As String
        Dim total_places As Integer
        Dim data_fi As String
        Dim data_inici As String
        Dim esdeveniment As Integer
        Dim ubicacio As Integer
        Dim departament As Integer

        title = titol.Text
        dates = data.Text
        price = preu.Text
        description = descripcio.Text
        total_places = places_totals.Text
        data_fi = data_fi_mostra.Text
        data_inici = data_inici_mostra.Text
        esdeveniment = id_esdeveniment.Text
        ubicacio = id_ubicacio.Text
        departament = id_departament.Text

        query = $"INSERT INTO `activitat` (`titol`,`data`,`descripcio`,`preu`,`places_totals`,`id_esdeveniment`,
        `data_inici_mostra`,`data_fi_mostra`,`id_ubicacio`,`id_departament`) 
        VALUES ('{title}','{dates}','{description}','{price}','{total_places}','{esdeveniment}','{data_inici}',
        '{data_fi}','{ubicacio}','{departament}');"
        Dim comanda = New MySqlCommand(query, Connexions.connexio)
        comanda.ExecuteNonQuery()
        Connexions.desconnectar()
    End Function

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class