Public Class Actividad
    Implements IEquatable(Of Actividad)

    Public Property CodActividad As Integer
    Public Property Nombre As String
    Public Property Estado As String
    Public Property Direccion As String
    Public Property Max_participantes As Integer
    Public Property Fecha_incio As Date
    Public Property Fecha_fin As Date
    Public Property Cif As String

    Public Sub New(codActividad As Integer)
        Me.CodActividad = codActividad
    End Sub



    Public Sub New(codActividad As Integer, nombre As String, estado As String, direccion As String, max_participantes As Integer, fecha_incio As Date, fecha_fin As Date, cif As String)
        Me.CodActividad = codActividad
        Me.Nombre = nombre
        Me.Estado = estado
        Me.Direccion = direccion
        Me.Max_participantes = max_participantes
        Me.Fecha_incio = fecha_incio
        Me.Fecha_fin = fecha_fin
        Me.Cif = cif
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Actividad))
    End Function

    Public Overloads Function Equals(other As Actividad) As Boolean Implements IEquatable(Of Actividad).Equals
        Return other IsNot Nothing AndAlso
               CodActividad = other.CodActividad
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hashCode As Long = -315266820
        hashCode = (hashCode * -1521134295 + CodActividad.GetHashCode()).GetHashCode()
        Return hashCode
    End Function
End Class
