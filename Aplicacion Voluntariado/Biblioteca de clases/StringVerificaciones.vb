Public Class StringVerificaciones
    Public Shared Function CaracteresValidosEnTexto(caracteresValidos As String, textoAValidar As String) As Boolean
        For Each character In textoAValidar
            If Not caracteresValidos.ToLower.Contains(caracteresValidos.ToLower) Then
                Return False
            End If
        Next
        Return True
    End Function
    Public Shared Function EsAlfabetico(textoAValidar As String) As Boolean
        Dim caracteresValidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        If CaracteresValidosEnTexto(caracteresValidos, textoAValidar) = True Then
            Return True
        End If
        Return False

    End Function

    Public Shared Function EsAlfabetico(textoAValidar As String, admiteTildes As Boolean) As Boolean
        Dim caracteresValidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZüïÜÏñÑáéíóúÁÉÍÓÚ"
        If CaracteresValidosEnTexto(caracteresValidos, textoAValidar) = True Then
            Return True
        End If
        Return False
    End Function
    Public Shared Function EsPalindroma(frase As String) As Boolean
        Dim fraselimpia As String = LimpiarFrase(frase)
        Dim longitud As Integer = fraselimpia.Length
        For i As Integer = 0 To (longitud \ 2) - 1
            If fraselimpia(i) <> fraselimpia(longitud - i - 1) Then
                Return False
            End If
        Next
        Return True
    End Function
    Public Shared Function LimpiarFrase(frase As String) As String
        Dim fraselimpia As String = frase.ToLower.Replace(" ", "").
            Replace("á", "a").
            Replace("é", "e").
            Replace("í", "i").
            Replace("ó", "o").
            Replace("ú", "u").
            Replace("ü", "u").
            Replace(" ", "").
            Replace(",", "").
            Replace(".", "").
            Replace("!", "").
            Replace("?", "")
        Return fraselimpia
    End Function
End Class
