Imports MySql.Data.MySqlClient
Public Class gestio_ubicacions
    Dim query As String

    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub Afegir_Click(sender As Object, e As EventArgs) Handles Afegir.Click
        Me.Hide()
        crear_ubicacio.Show()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Me.Hide()
        editar_ubicacions.Show()
        Dim Fila As Integer
        Dim id As String
        Fila = taula_ubicacions.CurrentRow.Index
        'Agafem la id
        id = taula_ubicacions.Rows(Fila).Cells(0).Value.ToString
        editar_ubicacions.Nom.Text = taula_ubicacions.Rows(Fila).Cells(1).Value
        editar_ubicacions.identificador.Text = id
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        administrar_activitats.Show()

    End Sub
    Private Sub Cercar_Click(sender As Object, e As EventArgs) Handles Cercar.Click
        actualitzarTaula()
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim id As String
        Dim Fila As Integer
        Dim missatge As MsgBoxResult = MsgBox("Vols eliminar el registre?", MsgBoxStyle.OkCancel, "Eliminar")
        'Control de si estan segurs que volen eliminar el registre
        If missatge = MsgBoxResult.Ok Then
            Fila = taula_ubicacions.CurrentRow.Index
            id = taula_ubicacions.Rows(Fila).Cells(0).Value
            'Delete del registre seleccionat
            query = $"DELETE FROM ubicacio where id = '{id}'"
            Connexions.connectar()
            Dim comanda As New MySqlCommand(query, Connexions.connexio)
            comanda.ExecuteNonQuery()
            Connexions.desconnectar()
            actualitzarTaula()
        End If
    End Sub

    Function actualitzarTaula()
        'mirem els criteris de cerca
        If String.IsNullOrEmpty(Nom.Text) = True Then
            'Select de les dades
            query = $"SELECT * FROM ubicacio"
        Else
            'Select de les dades
            query = $"SELECT * FROM ubicacio where nom LIKE '%{Nom.Text}%'"
        End If
        Connexions.connectar()
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        'Creació de la taula
        taula_ubicacions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_ubicacions.DataSource = conjunt_dades
        taula_ubicacions.Columns(0).Visible = False
        Connexions.desconnectar()
        'Edició dels noms de la taula
        taula_ubicacions.Columns(1).HeaderCell.Value = "NOM"
    End Function
    Private Sub gestio_ubicacions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualitzarTaula()
    End Sub
End Class