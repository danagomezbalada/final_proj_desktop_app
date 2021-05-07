Imports MySql.Data.MySqlClient

Public Class editar_reserves
    Dim query As String
    Dim usuariId As String
    Dim activitatId As String
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_reserves.Show()
    End Sub

    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub actualitzar_Click(sender As Object, e As EventArgs) Handles actualitzar.Click
        Connexions.connectar()
        Dim id As String
        id = identificador.Text
    End Sub
    Function emplenarCamps()
        Connexions.connectar()
        query = $"Select * from reserva where id='{identificador.Text}'"
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        usuari.Text = conjunt_dades.Rows(0).Item(1)
        activitat.Text = conjunt_dades.Rows(0).Item(2)
        data.Text = conjunt_dades.Rows(0).Item(3)
        codi_transaccio.Text = conjunt_dades.Rows(0).Item(4)
        estat.Text = conjunt_dades.Rows(0).Item(5)
        Connexions.desconnectar()
        'carregarUsuaris()
        'carregarActivitats()
    End Function
End Class