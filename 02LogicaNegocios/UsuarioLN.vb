Imports _03Entidades
Imports _01AccesoDatos
Public Class UsuarioLN

    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarUsuario(ByVal pUsuario As UsuarioEN)
        Try
            If (pEmpleado.Cedula.Trim().Length = 0) Then
                Throw New Exception("La Cedula es obligatoria")
            ElseIf pEmpleado.Cedula.Trim().Length < 9 Then
                Throw New Exception("Caracteres minimos son 9")
            ElseIf pEmpleado.Cedula.Trim().Length > 15 Then
                Throw New Exception("Cèdula de Maximos 15 caracteres")
            ElseIf String.IsNullOrWhiteSpace(pEmpleado.NombreCompleto) Then
                Throw New Exception("Nombre es obligatorio")
            ElseIf pEmpleado.HorasTrabajadas <= 0 Then
                Throw New Exception("Horas debe ser mayor a CERO")
            ElseIf pEmpleado.FechaIngreso > Date.Today Then
                Throw New Exception("La fecha no puede ser mayor a hoy")
            End If

            Dim EmpAD As New EmpleadoAD
            If Not IsNothing(EmpAD.ObtenerEmpleadoPorCedula(pEmpleado.Cedula)) Then
                Throw New Exception("YA EXISTE")
            End If
            EmpAD.InsertarEmpleado(pEmpleado)

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
