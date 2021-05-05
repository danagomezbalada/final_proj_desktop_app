Imports MySql.Data.MySqlClient
Public Class gestio_categoria
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub Afegir_Click(sender As Object, e As EventArgs) Handles Afegir.Click
        Me.Hide()
        crear_categories.Show()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Me.Hide()
        editar_categories.Show()
        Dim Fila As Integer
        Dim Id As String
        Fila = taula_categoria.CurrentRow.Index
        Id = taula_categoria.Rows(Fila).Cells(0).Value.ToString
        editar_categories.nom.Text = taula_categoria.Rows(Fila).Cells(1).Value
        editar_categories.identificador.Text = Id
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
        If missatge = MsgBoxResult.Ok Then
            Fila = taula_categoria.CurrentRow.Index
            id = taula_categoria.Rows(Fila).Cells(0).Value
            query = $"DELETE FROM categoria where id = '{id}'"
            Connexions.connectar()
            Dim comanda As New MySqlCommand(query, Connexions.connexio)
            comanda.ExecuteNonQuery()
            Connexions.desconnectar()
            actualitzarTaula()
        End If
    End Sub

    Function actualitzarTaula()
        If String.IsNullOrEmpty(Nom.Text) = True Then
            query = $"SELECT * FROM categoria"
        Else
            query = $"SELECT * FROM categoria where nom LIKE '%{Nom.Text}%'"
        End If
        Connexions.connectar()
        Dim comanda As New MySqlCommand(query, Connexions.connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_categoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        taula_categoria.DataSource = conjunt_dades
        taula_categoria.Columns(0).Visible = False
        Connexions.desconnectar()
    End Function
    Private Sub gestio_categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualitzarTaula()
    End Sub
End Class