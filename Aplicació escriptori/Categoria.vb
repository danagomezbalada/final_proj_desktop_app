Public Class Categoria
    Dim id As Int32
    Dim nom As String

    Public Sub New(id As Int32, nom As String)
        Me.id = id
        Me.nom = nom
    End Sub

    Public Sub setNom(ByVal nom As String)
        Me.nom = nom
    End Sub

    Public Function getNom() As String
        Return Me.nom
    End Function

    Public Sub setId(id As Int32)
        Me.id = id
    End Sub

    Public Function getId() As Int32
        Return Me.id
    End Function
End Class

