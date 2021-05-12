Imports MySql.Data.MySqlClient
Public Class gestio_ponent
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub Afegir_Click(sender As Object, e As EventArgs) Handles Afegir.Click
        Me.Hide()
        crear_ponents.Show()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Me.Hide()
        editar_ponents.Show()
        Dim Fila As Integer
        Dim id As String
        Fila = taula_ponent.CurrentRow.Index
        'Agafem les dades de la taula
        id = taula_ponent.Rows(Fila).Cells(0).Value.ToString
        editar_ponents.nom.Text = taula_ponent.Rows(Fila).Cells(1).Value
        editar_ponents.cognom.Text = taula_ponent.Rows(Fila).Cells(2).Value
        editar_ponents.telefon.Text = taula_ponent.Rows(Fila).Cells(3).Value
        editar_ponents.email.Text = taula_ponent.Rows(Fila).Cells(4).Value
        editar_ponents.identificador.Text = id
    End Sub
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        administrar_activitats.Show()
    End Sub
    Private Sub Cerca_Click(sender As Object, e As EventArgs) Handles Cerca.Click
        actualitzarTaula()
    End Sub
    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim id As String
        Dim Fila As Integer
        Dim missatge As MsgBoxResult = MsgBox("Vols eliminar el registre?", MsgBoxStyle.OkCancel, "Eliminar")
        'Control de si estan segurs que volen eliminar el registre
        If missatge = MsgBoxResult.Ok Then
            Fila = taula_ponent.CurrentRow.Index
            id = taula_ponent.Rows(Fila).Cells(0).Value
            'Delete del registre seleccionat
            query = $"DELETE FROM ponent where id = '{id}'"
            Connexions.connectar()
            Dim comanda As New MySqlCommand(query, Connexions.connexio)
            comanda.ExecuteNonQuery()
            Connexions.desconnectar()
            actualitzarTaula()
        End If
    End Sub
    Function actualitzarTaula()
        'mirem els criteris de cerca
        If String.IsNullOrEmpty(Nom.Text) = True And String.IsNullOrEmpty(Cognom.Text) = True Then
            'Select de les dades
            query = $"SELECT * FROM ponent"
            'mirem els criteris de cerca
        ElseIf String.IsNullOrEmpty(Cognom.Text) = True Then
            'Select de les dades
            query = $"SELECT * FROM ponent where nom LIKE '%{Nom.Text}%'"
            'mirem els criteris de cerca
        ElseIf String.IsNullOrEmpty(Nom.Text) = True Then
            'Select de les dades
            query = $"SELECT * FROM ponent where cognoms LIKE '%{Cognom.Text}%'"
        Else
            'Select de les dades
            query = $"SELECT * FROM ponent where nom LIKE '%{Nom.Text}%' AND cognoms LIKE '%{Cognom.Text}%'"
        End If
        Connexions.connectar()
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        'Creació de la taula
        taula_ponent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_ponent.DataSource = conjunt_dades
        taula_ponent.Columns(0).Visible = False
        Connexions.desconnectar()
        'Edició dels noms de la taula
        taula_ponent.Columns(1).HeaderCell.Value = "NOM"
        taula_ponent.Columns(2).HeaderCell.Value = "COGNOMS"
        taula_ponent.Columns(3).HeaderCell.Value = "TELEFON"
        taula_ponent.Columns(4).HeaderCell.Value = "EMAIL"
    End Function
    Private Sub gestio_ponents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualitzarTaula()
    End Sub
End Class