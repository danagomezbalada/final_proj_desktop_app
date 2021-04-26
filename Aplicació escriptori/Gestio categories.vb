Public Class gestio_categoria
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        Principal.Show()
    End Sub

    Private Sub Afegir_Click(sender As Object, e As EventArgs) Handles Afegir.Click
        Me.Hide()
        crear_categories.Show()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Me.Hide()
        editar_categories.Show()
    End Sub
End Class