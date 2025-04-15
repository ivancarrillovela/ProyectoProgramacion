Public Class TipoActividad
    Implements IEquatable(Of TipoActividad)

    Public Property Nombre As String

    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, TipoActividad))
    End Function

    Public Overloads Function Equals(other As TipoActividad) As Boolean Implements IEquatable(Of TipoActividad).Equals
        Return other IsNot Nothing AndAlso
               Nombre.ToLower = other.Nombre.ToLower
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hashCode As Long = 510151744
        hashCode = (hashCode * -1521134295 + EqualityComparer(Of String).Default.GetHashCode(Nombre)).GetHashCode()
        Return hashCode
    End Function
End Class
