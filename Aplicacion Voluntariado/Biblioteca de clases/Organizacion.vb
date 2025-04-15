Public Class Organizacion
    Implements IEquatable(Of Organizacion)

    Public Property Cif As String
    Public Property Nombre As String
    Public Property Direccion As String
    Public Property Cp As Integer
    Public Property Localidad As String
    Public Property Descripcion As String
    Public Property Contacto As String

    Public Sub New(cif As String)
        Me.Cif = cif
    End Sub

    Public Sub New(cif As String, nombre As String, direccion As String, cp As Integer, localidad As String, descripcion As String, contacto As String)
        Me.New(cif)
        Me.Nombre = nombre
        Me.Direccion = direccion
        Me.Cp = cp
        Me.Localidad = localidad
        Me.Descripcion = descripcion
        Me.Contacto = contacto
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Organizacion))
    End Function

    Public Overloads Function Equals(other As Organizacion) As Boolean Implements IEquatable(Of Organizacion).Equals
        Return other IsNot Nothing AndAlso
               Cif.ToLower = other.Cif.ToLower
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hashCode As Long = 1259593509
        hashCode = (hashCode * -1521134295 + EqualityComparer(Of String).Default.GetHashCode(Cif)).GetHashCode()
        Return hashCode
    End Function
End Class
