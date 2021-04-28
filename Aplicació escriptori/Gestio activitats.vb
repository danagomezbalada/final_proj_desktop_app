Public Class gestio_activitats
    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Activitat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub Afegir_Click(sender As Object, e As EventArgs) Handles Afegir.Click
        Me.Hide()
        crear_activitat.Show()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Me.Hide()
        editar_activitats.Show()
    End Sub
End Class