Imports _01AccesoDatos
Imports _03Entidades

Public Class AutorLN
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarAutor(ByVal pAutor As AutorEN)
        Try
            If (pAutor.CodAutor.Trim().Length = 0) Then
                Throw New Exception("El CodAutor Es Obligatorio")
            ElseIf (pAutor.NombreAutor.Trim().Length = 0) Then
                Throw New Exception("La Nombre es Obligatorio")
            ElseIf String.IsNullOrWhiteSpace(pAutor.Nacionalidad) Then
                Throw New Exception("La Nacionalidad es Obligatoria")
            End If

            Dim AutAD As New AutorAD
            If Not IsNothing(AutAD.ObtenerAutorPorCodAutor(pAutor.CodAutor)) Then
                Throw New Exception("YA EXISTE")
            End If
            AutAD.InsertarAutor(pAutor)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarAutor(ByVal pAutor As AutorEN)
        Try
            If (pAutor.CodAutor.Trim().Length = 0) Then
                Throw New Exception("El CodAutor Es Obligatorio")
            ElseIf (pAutor.NombreAutor.Trim().Length = 0) Then
                Throw New Exception("La Nombre es Obligatorio")
            ElseIf String.IsNullOrWhiteSpace(pAutor.Nacionalidad) Then
                Throw New Exception("La Nacionalidad es Obligatoria")
            End If

            Dim AutAD As New AutorAD
            If IsNothing(AutAD.ObtenerAutorPorCodAutor(pAutor.CodAutor)) Then
                Throw New Exception("NO EXISTE")
            End If
            AutAD.ModificarAutor(pAutor)


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarAutor(ByVal pAutor As AutorEN)
        Try

            Dim AutAD As New AutorAD
            If IsNothing(AutAD.ObtenerAutorPorCodAutor(pAutor.CodAutor)) Then
                Throw New Exception("No EXISTE, el Autor a borrar")
            End If
            AutAD.BorrarAutor(pAutor)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerAutorPorCodAutor(ByVal pCodAutor As String) As AutorEN
        Try
            If (pCodAutor.Trim().Length = 0) Then
                Throw New Exception("El CodAutor es obligatorio")
            End If

            Dim AutAD As New AutorAD
            Return AutAD.ObtenerAutorPorCodAutor(pCodAutor)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosAutors() As List(Of AutorEN)
        Try
            Dim AutAD As New AutorAD
            Return AutAD.obtenerTodosAUTORES()

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

End Class
