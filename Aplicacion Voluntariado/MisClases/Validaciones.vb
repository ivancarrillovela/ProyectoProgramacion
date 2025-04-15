Imports System.Runtime.CompilerServices
Imports System.Runtime.Remoting.Messaging

Public Class Validaciones
    Public Shared Function LetraDNI(numEntero As Integer)
        If numEntero.ToString.Length = 8 Then
            Dim resto As Integer = numEntero Mod 23
            Dim letra As String = "TRWAGMYFPDXBNJZSQVHLCKE"
            Return letra.Chars(resto)
        Else
            Return ""
        End If
    End Function
    Public Shared Function ValidarDNI(dni As String) As Boolean
        Dim numDNI As Integer
        If dni.Length = 9 AndAlso Integer.TryParse(dni.Substring(0, 8), numDNI) AndAlso dni.ToUpper.Chars(8) = LetraDNI(numDNI) Then
            Return True
        Else
            Return False
        End If
    End Function


End Class
