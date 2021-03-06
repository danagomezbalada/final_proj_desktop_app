Imports MySql.Data.MySqlClient

Public Class editar_reserves
    Dim query As String
    Dim estatId As String
    Dim activitatId As Int32
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
        actualitzarPlaces()

        Dim estatSeleccionat As String
        'Mirem l'estat de la reserva
        If pendent.Checked = True Then
            estatSeleccionat = 0
        ElseIf confirmada.Checked = True Then
            estatSeleccionat = 1
        Else
            estatSeleccionat = 2
        End If
        'Update de les dades
        query = $"Update reserva SET estat = ('{estatSeleccionat}') 
            WHERE id = ('{identificador.Text}')"
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        comanda.ExecuteNonQuery()
        Connexions.desconnectar()
        MessageBox.Show("Reserva actualitzada")
        gestio_reserves.actualitzarTaula()
    End Sub
    Function emplenarCamps()
        Connexions.connectar()
        'Update de les dades
        'Select Case de les dades
        query = $"Select * from reserva where id='{identificador.Text}'"
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        data.Text = conjunt_dades.Rows(0).Item(3).ToString
        'Update de les dades
        If estat_text.Text = 0 Then
            pendent.Checked = True
        ElseIf estat_text.Text = 1 Then
            confirmada.Checked = True
        Else
            rebutjada.Checked = True
        End If
        Connexions.desconnectar()
    End Function
    Function actualitzarPlaces()
        Connexions.connectar()
        'Cerquem la id de l'activitat
        query = $"Select id_activitat from reserva where id='{identificador.Text}'"
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        'Agafem el valor
        activitatId = conjunt_dades.Rows(0).Item(0).ToString
        'Actualitzem les places actuals de la reserva
        If estat_text.Text = 0 And confirmada.Checked Then
            query = $"Update activitat SET places_actuals = places_actuals - 1 where id = ('{activitatId}')"
        ElseIf estat_text.Text = 1 And rebutjada.Checked Then
            query = $"Update activitat SET places_actuals = places_actuals + 1 where id = ('{activitatId}')"
        End If
        Dim comanda1 As New MySqlCommand(query, Connexions.connexio)
        comanda1.ExecuteNonQuery()

    End Function
End Class