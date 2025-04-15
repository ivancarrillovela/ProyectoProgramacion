Public Class Ciclo
    Implements IEquatable(Of Ciclo)

    Public nombre As String

    Public Sub New(nombre As String)
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
               nombre = other.nombre
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hashCode As Long = -1449437152
        hashCode = (hashCode * -1521134295 + EqualityComparer(Of String).Default.GetHashCode(nombre)).GetHashCode()
        Return hashCode
    End Function
End Class
