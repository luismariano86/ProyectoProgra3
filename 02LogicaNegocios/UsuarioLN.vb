Imports _03Entidades
Imports _01AccesoDatos
Public Class UsuarioLN

    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarUsuario(ByVal pUsuario As UsuarioEN)
        Try


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarUsuario(ByVal pUsuario As UsuarioEN)
        Try


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarUsuario(ByVal pUsuario As UsuarioEN)
        Try

            Dim UsuAD As New UsuarioAD
            If IsNothing(UsuAD.ObtenerUsuarioPorLogin(pUsuario.Login)) Then
                Throw New Exception("No EXISTE, el Usuario a borrar")
            End If
            UsuAD.BorrarUsuario(pUsuario)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerUsuarioPorLogin(ByVal pLogin As String) As UsuarioEN
        Try
            If (pLogin.Trim().Length = 0) Then
                Throw New Exception("El Login es obligatorio")
            End If

            Dim UsuAD As New UsuarioAD
            Return UsuAD.ObtenerUsuarioPorLogin(pLogin)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosUsuarios() As List(Of UsuarioEN)
        Try
            Dim UsuAD As New UsuarioAD
            Return UsuAD.obtenerTodosUsuarios()

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

End Class
