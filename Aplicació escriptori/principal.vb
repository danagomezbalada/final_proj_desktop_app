Public Class principal
    Private Sub administrar_activitats_Click(sender As Object, e As EventArgs) Handles activitats.Click
        Me.Hide()
        administrar_activitats.Show()
    End Sub

    Private Sub gestionar_activitats_Click(sender As Object, e As EventArgs) Handles gestionar_activitats.Click
        Me.Hide()
        gestio_activitats.Show()
    End Sub

    Private Sub administrar_esdeveniments_Click(sender As Object, e As EventArgs) Handles administrar_esdeveniments.Click
        Me.Hide()
        gestio_esdeveniment.Show()
    End Sub

    Private Sub gestionar_reserves_Click(sender As Object, e As EventArgs) Handles gestionar_reserves.Click
        Me.Hide()
        gestio_reserves.Show()
    End Sub
End Class