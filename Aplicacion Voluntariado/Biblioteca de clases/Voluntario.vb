Public Class Voluntario
    Implements IEquatable(Of Voluntario)

    Public Property Dni As String
    Public Property Nombre As String
    Public Property Apellido1 As String
    Public Property Apellido2 As String
    Public Property Correo As String
    Public Property Coche As Boolean
    Public Property Fecha_nacimiento As Date
    Public Property Experiencia As String

    Public Property Nombre_Ciclos As String

    Public Sub New(dni As String)
        Me.Dni = dni
    End Sub

    Public Sub New(dni As String, nombre As String, apellido1 As String, apellido2 As String, correo As String, coche As Boolean, fecha_nacimiento As Date, experiencia As String, Nombre_Ciclos As String)
        Me.New(dni)
        Me.Nombre = nombre
        Me.Apellido1 = apellido1
        Me.Apellido2 = apellido2
        Me.Correo = correo
        Me.Coche = coche
        Me.Fecha_nacimiento = fecha_nacimiento
        Me.Experiencia = experiencia
        Me.Nombre_Ciclos = Nombre_Ciclos
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Voluntario))
    End Function

    Public Overloads Function Equals(other As Voluntario) As Boolean Implements IEquatable(Of Voluntario).Equals
        Return other IsNot Nothing AndAlso
               Dni.ToLower = other.Dni.ToLower
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hashCode As Long = 963633130
        hashCode = (hashCode * -1521134295 + EqualityComparer(Of String).Default.GetHashCode(Dni)).GetHashCode()
        Return hashCode
    End Function
End Class
