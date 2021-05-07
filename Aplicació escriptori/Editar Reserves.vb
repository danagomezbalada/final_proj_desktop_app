Imports MySql.Data.MySqlClient

Public Class editar_reserves
    Dim query As String
    Dim estatId As String
    Dim codi_estat As String
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
        Dim estatSeleccionat As String
        If pendent.Checked = True Then
            estatSeleccionat = 0
        ElseIf confirmada.Checked = True Then
            estatSeleccionat = 1
        Else
            estatSeleccionat = 2
        End If
        query = $"Update reserva SET estat = ('{estatSeleccionat}') 
            WHERE id = ('{identificador.Text}')"
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        comanda.ExecuteNonQuery()
        Connexions.desconnectar()
    End Sub
    Function emplenarCamps()
        Connexions.connectar()
        query = $"Select * from reserva where id='{identificador.Text}'"
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        'usuari.Text = conjunt_dades.Rows(0).Item(1)
        'activitat.Text = conjunt_dades.Rows(0).Item(2)
        data.Text = conjunt_dades.Rows(0).Item(3)
        codi_transaccio.Text = conjunt_dades.Rows(0).Item(4)
        codi_estat = conjunt_dades.Rows(0).Item(5)
        If codi_estat = 0 Then
            pendent.Checked = True
        ElseIf codi_estat = 1 Then
            confirmada.Checked = True
        Else
            rebutjada.Checked = True
        End If
        Connexions.desconnectar()
    End Function
End Class