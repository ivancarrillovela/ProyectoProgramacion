Public Class Ods
    Implements IEquatable(Of Ods)

    Public Property Nombre As String
    Public Property NumOds As Integer
    Public Property Descripcion As String

    Public Sub New(numOds As Integer)
        Me.NumOds = numOds
    End Sub

    Public Sub New(numOds As Integer, nombre As String, descripcion As String)
        Me.NumOds = numOds
        Me.Nombre = nombre
        Me.Descripcion = descripcion
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Ods))
    End Function

    Public Overloads Function Equals(other As Ods) As Boolean Implements IEquatable(Of Ods).Equals
        Return other IsNot Nothing AndAlso
               NumOds = other.NumOds
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hashCode As Long = 1955207705
        hashCode = (hashCode * -1521134295 + NumOds.GetHashCode()).GetHashCode()
        Return hashCode
    End Function
End Class
