Public Class MiString
    Public Shared Function CaracteresValidosEnTexto(caracteresValidos As String, texto As String) As Boolean
        For Each caracter As Char In texto
            If Not caracteresValidos.Contains(caracter) Then
                Return False
            End If
        Next
        Return True
    End Function
    Public Shared Function EsAlfabetico(texto As String) As Boolean
        If String.IsNullOrEmpty(texto) OrElse String.IsNullOrWhiteSpace(texto) Then
            Return False
        End If
        If CaracteresValidosEnTexto("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ ÁÉÍÓÚÜ,.", texto.ToUpper) Then
            Return True
        End If
        Return False
    End Function
    Public Shared Function EsPalindroma(texto As String) As Boolean
        If texto = StrReverse(texto) Then
            Return True
        End If
        Return False
    End Function
    Public Shared Function EsPalindroma(sinEspacios As Boolean, texto As String) As Boolean
        If sinEspacios AndAlso texto.Replace(" ", "") = StrReverse(texto.Replace(" ", "")) AndAlso texto.Replace(",", "") = StrReverse(texto.Replace(",", "")) Then
            Return True
        End If
        Return False
    End Function

    Public Shared Function EstaVacio(texto As String) As Boolean
        If String.IsNullOrEmpty(texto) OrElse String.IsNullOrWhiteSpace(texto) Then
            Return True
        End If
        Return False
    End Function
End Class
