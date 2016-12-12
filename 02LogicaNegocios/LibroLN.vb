Imports _03Entidades
Imports _01AccesoDatos
Public Class LibroLN
    Public Sub InsertarLibro(ByVal pLibro As LibroEN)
        Try
            If (pLibro.ISBN.Trim().Length = 0) Then
                Throw New Exception("El ISBN Es Obligatorio")
            ElseIf (pLibro.ISBN.Trim().Length > 20) Then
                Throw New Exception("El ISBN no puede ser mayor a 20 caracteres")
            ElseIf (pLibro.TituloCompleto.Trim().Length = 0) Then
                Throw New Exception("El TituloCompleto Es Obligatorio")
            ElseIf (pLibro.TituloCompleto.Trim().Length < 6) Then
                Throw New Exception("El TituloCompleto tiene tener minimo 6 digitos")
            End If

            Dim LibAD As New LibroAD
            If Not IsNothing(LibAD.ObtenerLibroPorISBN(pLibro.ISBN)) Then
                Throw New Exception("YA EXISTE")
            End If
            LibAD.InsertarLibro(pLibro)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarLibro(ByVal pLibro As LibroEN)
        Try
            If (pLibro.ISBN.Trim().Length = 0) Then
                Throw New Exception("El ISBN Es Obligatorio")
            ElseIf (pLibro.ISBN.Trim().Length > 10) Then
                Throw New Exception("El ISBN no puede ser mayor a 10 digitos")
            ElseIf (pLibro.TituloCompleto.Trim().Length = 0) Then
                Throw New Exception("El TituloCompleto Es Obligatorio")
            ElseIf (pLibro.TituloCompleto.Trim().Length < 8) Then
                Throw New Exception("El TituloCompleto tiene tener minimo 8 digitos")
            End If

            Dim LibAD As New LibroAD
            If IsNothing(LibAD.ObtenerLibroPorISBN(pLibro.ISBN)) Then
                Throw New Exception("NO EXISTE")
            End If
            LibAD.ModificarLibro(pLibro)


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarLibro(ByVal pLibro As LibroEN)
        Try

            Dim LibAD As New LibroAD
            If IsNothing(LibAD.ObtenerLibroPorISBN(pLibro.ISBN)) Then
                Throw New Exception("No EXISTE, el Libro a borrar")
            End If
            LibAD.BorrarLibro(pLibro)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerLibroPorISBN(ByVal pISBN As String) As LibroEN
        Try
            If (pISBN.Trim().Length = 0) Then
                Throw New Exception("El ISBN es obligatorio")
            End If

            Dim LibAD As New LibroAD
            Return LibAD.ObtenerLibroPorISBN(pISBN)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosLibros() As List(Of LibroEN)
        Try
            Dim LibAD As New LibroAD
            Return LibAD.obtenerTodosLibros()

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
End Class
