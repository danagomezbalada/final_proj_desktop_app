Imports MySql.Data.MySqlClient

Public Class gestio_esdeveniment
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub afegir_Click(sender As Object, e As EventArgs) Handles afegir.Click
        Me.Hide()
        crear_esdeveniments.Show()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Me.Hide()
        editar_esdeveniments.Show()
        Dim Fila As Integer
        Dim id As String
        Fila = taula_esdeveniment.CurrentRow.Index
        id = taula_esdeveniment.Rows(Fila).Cells(0).Value.ToString
        'Agafem tota la informació de la base de dades
        editar_esdeveniments.any.Text = taula_esdeveniment.Rows(Fila).Cells(1).Value
        editar_esdeveniments.nom.Text = taula_esdeveniment.Rows(Fila).Cells(2).Value
        editar_esdeveniments.descripcio.Text = taula_esdeveniment.Rows(Fila).Cells(3).Value
        editar_esdeveniments.actiu.Text = taula_esdeveniment.Rows(Fila).Cells(4).Value
        editar_esdeveniments.identificador.Text = id
    End Sub

    Private Sub Cerca_Click(sender As Object, e As EventArgs) Handles Cerca.Click
        actualitzarTaula()
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim id As String
        Dim Fila As Integer
        Dim missatge As MsgBoxResult = MsgBox("Vols eliminar el registre?", MsgBoxStyle.OkCancel, "Eliminar")
        'Control de si estan segurs que volen eliminar el registre
        If missatge = MsgBoxResult.Ok Then
            Fila = taula_esdeveniment.CurrentRow.Index
            id = taula_esdeveniment.Rows(Fila).Cells(0).Value
            'Delete del registre seleccionat
            query = $"DELETE FROM esdeveniment where id = '{id}'"
            Connexions.connectar()
            Dim comanda As New MySqlCommand(query, Connexions.connexio)
            comanda.ExecuteNonQuery()
            Connexions.desconnectar()
            actualitzarTaula()
        End If
    End Sub
    Function actualitzarTaula()
        'mirem els criteris de cerca
        If String.IsNullOrEmpty(Nom.Text) = True And String.IsNullOrEmpty(Any.Text) = True Then
            'Select de les dades
            query = $"SELECT * FROM esdeveniment"
            'mirem els criteris de cerca
        ElseIf String.IsNullOrEmpty(Any.Text) = True Then
            'Select de les dades
            query = $"SELECT * FROM esdeveniment where nom LIKE '%{Nom.Text}%'"
            'mirem els criteris de cerca
        ElseIf String.IsNullOrEmpty(Nom.Text) = True Then
            'Select de les dades
            query = $"SELECT * FROM esdeveniment where any = {Any.Text}"
        Else
            'Select de les dades
            query = $"SELECT * FROM esdeveniment where nom LIKE '%{Nom.Text}%' AND any = '{Any.Text}'"
        End If
        Connexions.connectar()
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        'Creació de la taula
        taula_esdeveniment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_esdeveniment.DataSource = conjunt_dades
        taula_esdeveniment.Columns(0).Visible = False
        Connexions.desconnectar()
        'Edició dels noms de la taula
        taula_esdeveniment.Columns(1).HeaderCell.Value = "ANY"
        taula_esdeveniment.Columns(2).HeaderCell.Value = "NOM"
        taula_esdeveniment.Columns(3).HeaderCell.Value = "DESCRIPCIÓ"
        taula_esdeveniment.Columns(4).HeaderCell.Value = "ACTIU"
    End Function
    Private Sub gestio_esdeveniment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualitzarTaula()
    End Sub
End Class