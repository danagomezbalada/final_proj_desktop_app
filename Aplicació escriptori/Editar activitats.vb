Public Class editar_activitats
    Private Sub actualitzar_Click(sender As Object, e As EventArgs) Handles actualitzar.Click

    End Sub

    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_activitats.Show()
    End Sub

    Private Sub gestionar_ponents_activitat_Click(sender As Object, e As EventArgs) Handles gestionar_ponents_activitat.Click
        Me.Hide()
        gestio_ponents_activitat.Show()
    End Sub

    Private Sub egstionar_categories_activitat_Click(sender As Object, e As EventArgs) Handles egstionar_categories_activitat.Click
        Me.Hide()
        gestio_categories_activitat.Show()
    End Sub

    Private Sub editar_activitats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class