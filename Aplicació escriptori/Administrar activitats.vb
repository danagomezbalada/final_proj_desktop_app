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
    End Sub

    Private Sub Ubicacio_Click(sender As Object, e As EventArgs) Handles Ubicacions.Click
        Me.Hide()
        gestio_ubicacions.Show()

    End Sub

    Private Sub Departament_Click(sender As Object, e As EventArgs) Handles Departaments.Click
        Me.Hide()
        gestio_departament.Show()

    End Sub

    Private Sub Esdeveniment_Click(sender As Object, e As EventArgs)
        Me.Hide()
        gestio_esdeveniment.Show()
    End Sub

    Private Sub Ponent_Click(sender As Object, e As EventArgs) Handles Ponents.Click
        Me.Hide()
        gestio_ponent.Show()
    End Sub

    Private Sub reserves_Click(sender As Object, e As EventArgs)
        Me.Hide()
        gestio_reserves.Show()
    End Sub

    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub
End Class

