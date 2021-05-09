Imports MySql.Data.MySqlClient
Public Class administrar_activitats
    Dim connexio As MySqlConnection
    Dim query As String
    Private Sub Activitat_Click(sender As Object, e As EventArgs)
        Me.Hide()
        gestio_activitats.Show()

    End Sub

    Private Sub Categoria_Click(sender As Object, e As EventArgs) Handles Categories.Click
        Me.Hide()
        gestio_categoria.Show()
        gestio_categoria.actualitzarTaula()
    End Sub

    Private Sub Ubicacio_Click(sender As Object, e As EventArgs) Handles Ubicacions.Click
        Me.Hide()
        gestio_ubicacions.Show()
        gestio_ubicacions.actualitzarTaula()
    End Sub

    Private Sub Departament_Click(sender As Object, e As EventArgs) Handles Departaments.Click
        Me.Hide()
        gestio_departament.Show()
        gestio_departament.actualitzarTaula()
    End Sub

    Private Sub Esdeveniment_Click(sender As Object, e As EventArgs)
        Me.Hide()
        gestio_esdeveniment.Show()
        gestio_esdeveniment.actualitzarTaula()
    End Sub

    Private Sub Ponent_Click(sender As Object, e As EventArgs) Handles Ponents.Click
        Me.Hide()
        gestio_ponent.Show()
        gestio_ponent.actualitzarTaula()
    End Sub
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub
End Class

