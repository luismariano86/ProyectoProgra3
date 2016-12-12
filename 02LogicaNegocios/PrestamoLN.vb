Imports _03Entidades
Imports _01AccesoDatos
Public Class PrestamoLN
    Public Sub InsertarPrestamo(ByVal pPrestamo As PrestamoEN)
        Try
            If (pPrestamo.CodPrestamo.Trim().Length = 0) Then
                Throw New Exception("El CodPrestamo Es Obligatorio")
            ElseIf (pPrestamo.CodPrestamo.Trim().Length < 4) Then
                Throw New Exception("El codigo tiene que ser Mayor o igual 4 y menor que 8 caracteres")
            ElseIf (pPrestamo.CodPrestamo.Trim().Length > 8) Then
                Throw New Exception("El Codigo tiene que ser Mayor a 4 y menor que 8 caracteres")
            ElseIf String.IsNullOrWhiteSpace(pPrestamo.Monto) Then
                Throw New Exception("Nombre es obligatorio")
            End If

            Dim PrestAD As New PrestamoAD
            If Not IsNothing(PrestAD.ObtenerPrestamoPorCodPrestamo(pPrestamo.CodPrestamo)) Then
                Throw New Exception("YA EXISTE")
            End If
            PrestAD.InsertarPrestamo(pPrestamo)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarPrestamo(ByVal pPrestamo As PrestamoEN)
        Try
            If (pPrestamo.CodPrestamo.Trim().Length = 0) Then
                Throw New Exception("El CodPrestamo Es Obligatorio")
            ElseIf (pPrestamo.CodPrestamo.Trim().Length < 4) Then
                Throw New Exception("El codigo tiene que ser Mayor o igual 4 y menor que 8 caracteres")
            ElseIf (pPrestamo.CodPrestamo.Trim().Length > 8) Then
                Throw New Exception("El Codigo tiene que ser Mayor a 4 y menor que 8 caracteres")
            ElseIf String.IsNullOrWhiteSpace(pPrestamo.Monto) Then
                Throw New Exception("Nombre es obligatorio")
            End If

            Dim PrestAD As New PrestamoAD
            If IsNothing(PrestAD.ObtenerPrestamoPorCodPrestamo(pPrestamo.CodPrestamo)) Then
                Throw New Exception("NO EXISTE")
            End If
            PrestAD.ModificarPrestamo(pPrestamo)


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarPrestamo(ByVal pPrestamo As PrestamoEN)
        Try

            Dim PrestAD As New PrestamoAD
            If IsNothing(PrestAD.ObtenerPrestamoPorCodPrestamo(pPrestamo.CodPrestamo)) Then
                Throw New Exception("No EXISTE, el Prestamo a borrar")
            End If
            PrestAD.BorrarPrestamo(pPrestamo)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerPrestamoPorCodPrestamo(ByVal pCodPrestamo As String) As PrestamoEN
        Try
            If (pCodPrestamo.Trim().Length = 0) Then
                Throw New Exception("El Codigo de Prestamo es obligatorio")
            End If

            Dim PrestAD As New PrestamoAD
            Return PrestAD.ObtenerPrestamoPorCodPrestamo(pCodPrestamo)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosPrestamos() As List(Of PrestamoEN)
        Try
            Dim PrestAD As New PrestamoAD
            Return PrestAD.obtenerTodosPrestamos()

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
End Class
