Public Class ParaConsola
    Public Shared Sub MostrarMensaje(mensaje As String, color As ConsoleColor)
        Console.ForegroundColor = color
        Console.WriteLine(mensaje)
        Console.ResetColor()
    End Sub
    Public Shared Sub MostrarMensaje(saltoLinea As Boolean, mensaje As String, color As ConsoleColor)
        Console.ForegroundColor = color
        Console.Write(mensaje)
        Console.ResetColor()
        If saltoLinea Then
            Console.WriteLine()
        End If
    End Sub
    Public Shared Function ColorReadLine(color As ConsoleColor)
        Try
            Console.ForegroundColor = color
            Return Console.ReadLine()
        Finally
            Console.ResetColor()
        End Try
    End Function
    Public Shared Function ColorReadLine(mayuscula As Boolean, color As ConsoleColor)
        Try
            Console.ForegroundColor = color
            If mayuscula Then
                Return Console.ReadLine().ToUpper
            Else
                Return Console.ReadLine()
            End If
        Finally
            Console.ResetColor()
        End Try
    End Function
End Class
