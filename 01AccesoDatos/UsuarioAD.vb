Imports _03Entidades
Imports System.Data.OleDb
'Imports System.Data.SqlClient

Public Class UsuarioAD

    ' Objeto que permite conectarse a la BD Access
    Dim miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Biblioteca.accdb")

    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarUsuario(ByVal pUsuario As UsuarioEN)
        Try

            Dim SQL_INSERT_USUARIO As String = "INSERT INTO USUARIOS (Login, Clave, NombreCompleto, indAdministrador, indBibliotecario, IndActivo) VALUES (@Cedula, @Nombre, @FechaIngreso, @Horas, @PrecioHora, @IndActivo)"
            miConexion.Open()

            Dim cmdUsuario As New OleDbCommand(SQL_INSERT_USUARIO, miConexion)

            cmdUsuario.Parameters.Add("@Login", OleDbType.VarChar).Value = pUsuario.Login
            cmdUsuario.Parameters.Add("@Clave", OleDbType.VarChar).Value = pUsuario.Clave
            cmdUsuario.Parameters.Add("@NombreCompleto", OleDbType.Date).Value = pUsuario.Nombre
            cmdUsuario.Parameters.Add("@indAdministrador", OleDbType.Integer).Value = pUsuario.Administrador
            cmdUsuario.Parameters.Add("@indBibliotecario", OleDbType.Double).Value = pUsuario.Bibliotecario
            cmdUsuario.Parameters.Add("@indActivo", OleDbType.Boolean).Value = pUsuario.Activo

            cmdUsuario.ExecuteNonQuery()

            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarUsuario(ByVal pUsuario As UsuarioEN)
        Try
            Dim SQL_UPDATE_USUARIO As String = "UPDATE USUARIOS SET NombreCompleto=@NombreCompleto, ClaveAdministrador=@ClaveAdministrador, indBibliotecario=@indBibliotecario, indActivo=@indActivo WHERE Login=@Login"
            miConexion.Open()

            Dim cmdUsuario As New OleDbCommand(SQL_UPDATE_USUARIO, miConexion)

            cmdUsuario.Parameters.Add("@Clave", OleDbType.VarChar).Value = pUsuario.Clave
            cmdUsuario.Parameters.Add("@NombreCompleto", OleDbType.Date).Value = pUsuario.Nombre
            cmdUsuario.Parameters.Add("@indAdministrador", OleDbType.Integer).Value = pUsuario.Administrador
            cmdUsuario.Parameters.Add("@indBibliotecario", OleDbType.Double).Value = pUsuario.Bibliotecario
            cmdUsuario.Parameters.Add("@indActivo", OleDbType.Boolean).Value = pUsuario.Activo
            cmdUsuario.Parameters.Add("@Login", OleDbType.VarChar).Value = pUsuario.Login

            cmdUsuario.ExecuteNonQuery()

            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarUsuario(ByVal pUsuario As UsuarioEN)
        Try
            Dim SQL_BORRAR_Usuario As String = "DELETE FROM Usuario WHERE Login=@Login"
            miConexion.Open()

            Dim cmdUsuario As New OleDbCommand(SQL_BORRAR_Usuario, miConexion)
            cmdUsuario.Parameters.Add("@Login", OleDbType.VarChar).Value = pUsuario.Login
            cmdUsuario.ExecuteNonQuery()
            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerUsuarioPorLogin(ByVal pLogin As String) As UsuarioEN
        Try

            Dim SQL_OBTENER_UN_Usuario As String = "SELECT Login, Clave, NombreCompleto, indAdministrador, indBibliotecario, indActivo FROM Usuarios WHERE Login=@Login"
            miConexion.Open()

            Dim cmdUsuario As New OleDbCommand(SQL_OBTENER_UN_Usuario, miConexion)
            cmdUsuario.Parameters.Add("@Login", OleDbType.VarChar).Value = pLogin
            Dim drUsuario As OleDbDataReader
            drUsuario = cmdUsuario.ExecuteReader()
            Dim miUser As UsuarioEN = Nothing
            While drUsuario.Read
                miUser = New UsuarioEN
                miUser.Login = drUsuario("Login")
                miUser.Clave = drUsuario("Clave")
                miUser.Nombre = drUsuario("NombreCompleto")
                miUser.Bibliotecario = drUsuario("indBibliotecario")
                miUser.Administrador = drUsuario("indAdministrador")
                miUser.Activo = drUsuario("indActivo")
            End While
            drUsuario.Close()
            miConexion.Close()
            Return miUser
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosUsuarios() As List(Of UsuarioEN)
        Try
            Dim SQL_OBTENER_UsuarioS As String = "SELECT Login, Clave, NombreCompleto, indAdministrador, indBibliotecario, indActivo FROM Usuarios"
            miConexion.Open()

            Dim cmdUsuario As New OleDbCommand(SQL_OBTENER_UsuarioS, miConexion)

            Dim drUsuario As OleDbDataReader
            drUsuario = cmdUsuario.ExecuteReader()

            Dim lstUsuarios As New List(Of UsuarioEN)

            While drUsuario.Read
                Dim miUser As New UsuarioEN
                miUser.Login = drUsuario("Login")
                miUser.Clave = drUsuario("Clave")
                miUser.Nombre = drUsuario("Nombre_Completo")
                miUser.Bibliotecario = drUsuario("Ind_Bibliotecario")
                miUser.Administrador = drUsuario("Ind_Administrador")
                miUser.Activo = drUsuario("Ind_Activo")
                lstUsuarios.Add(miUser)
            End While
            drUsuario.Close()
            miConexion.Close()
            Return lstUsuarios

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

End Class
