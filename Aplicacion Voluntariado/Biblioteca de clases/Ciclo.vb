Public Class Ciclo
    Implements IEquatable(Of Ciclo)

    Public curso As Integer
    Public nombre As String

    Public Sub New(curso As Integer, nombre As String)
        Me.curso = curso
        Me.nombre = nombre
    End Sub
    Public Overrides Function ToString() As String
        Return nombre
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Ciclo))
    End Function

    Public Overloads Function Equals(other As Ciclo) As Boolean Implements IEquatable(Of Ciclo).Equals
        Return other IsNot Nothing AndAlso
               curso = other.curso AndAlso
               nombre.ToLower = other.nombre.ToLower
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return (curso, nombre).GetHashCode()
    End Function

End Class
