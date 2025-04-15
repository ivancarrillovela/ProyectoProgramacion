Public Class MisMatematicas

    Public Shared Function Factorial(numero As Integer) As Double
        Dim resultado As Double = 1
        For i As Integer = 2 To numero
            resultado = resultado * i
        Next
        Return resultado
    End Function

    Public Shared Function Permutacion(numero As Integer) As Double
        Return Factorial(numero)
    End Function

    Public Shared Function Combinaciones(numero1 As Integer, numero2 As Integer) As Double
        Return Factorial(numero1) / (Factorial(numero2) * Factorial(numero1 - numero2))
    End Function

    Public Shared Function Variaciones(numero1 As Integer, numero2 As Integer) As Double
        Return Combinaciones(numero1, numero2) * Permutacion(numero1)
    End Function

End Class
