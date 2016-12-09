Imports _03Entidades
Imports System.Data.OleDb
Public Class AutorAD

    ' Objeto que permite conectarse a la BD Access
    Dim miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Biblioteca.accdb")

    Public Sub New()

    End Sub

    Public Sub InsertarAutor(ByVal pAutor As AutorEN)
        Try

            Dim SQL_INSERT_AUTOR As String = "INSERT INTO AUTORES (CodAutor, NombreAutor, Nacionalidad) VALUES (@CodAutor, @NombreAutor, @Nacionalidad)"
            miConexion.Open()

            Dim cmdAutor As New OleDbCommand(SQL_INSERT_AUTOR, miConexion)

            cmdAutor.Parameters.Add("@CodAutor", OleDbType.VarChar).Value = pAutor.CodAutor
            cmdAutor.Parameters.Add("@NombreAutor", OleDbType.VarChar).Value = pAutor.NombreAutor
            cmdAutor.Parameters.Add("@Nacionalidad", OleDbType.VarChar).Value = pAutor.Nacionalidad


            cmdAutor.ExecuteNonQuery()

            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarAutor(ByVal pAutor As AutorEN)
        Try
            Dim SQL_UPDATE_Autor As String = "UPDATE AUTORES SET NombreAutor=@NombreAutor, Nacionalidad=@Nacionalidad WHERE CodAutor=@CodAutor"
            miConexion.Open()

            Dim cmdAutor As New OleDbCommand(SQL_UPDATE_Autor, miConexion)

            cmdAutor.Parameters.Add("@NombreAutor", OleDbType.VarChar).Value = pAutor.NombreAutor
            cmdAutor.Parameters.Add("@Nacionalidad", OleDbType.VarChar).Value = pAutor.Nacionalidad
            cmdAutor.Parameters.Add("@CodAutor", OleDbType.VarChar).Value = pAutor.CodAutor

            cmdAutor.ExecuteNonQuery()

            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarAutor(ByVal pAutor As AutorEN)
        Try
            Dim SQL_BORRAR_Autor As String = "DELETE FROM AUTORES WHERE CodAutor=@CodAutor"
            miConexion.Open()

            Dim cmdAutor As New OleDbCommand(SQL_BORRAR_Autor, miConexion)
            cmdAutor.Parameters.Add("@CodAutor", OleDbType.VarChar).Value = pAutor.CodAutor
            cmdAutor.ExecuteNonQuery()
            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerAutorPorCodAutor(ByVal pCodAutor As String) As AutorEN
        Try

            Dim SQL_OBTENER_UN_Autor As String = "SELECT CodAutor, NombreAutor, Nacionalidad FROM AUTORES WHERE CodAutor=@CodAutor"
            miConexion.Open()

            Dim cmdAutor As New OleDbCommand(SQL_OBTENER_UN_Autor, miConexion)
            cmdAutor.Parameters.Add("@CodAutor", OleDbType.VarChar).Value = pCodAutor
            Dim drAutor As OleDbDataReader
            drAutor = cmdAutor.ExecuteReader()
            Dim miUser As AutorEN = Nothing
            While drAutor.Read
                miUser = New AutorEN
                miUser.CodAutor = drAutor("CodAutor")
                miUser.NombreAutor = drAutor("NombreAutor")
                miUser.Nacionalidad = drAutor("Nacionalidad")

            End While
            drAutor.Close()
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

    Public Function obtenerTodosAUTORES() As List(Of AutorEN)
        Try
            Dim SQL_OBTENER_AUTORES As String = "SELECT CodAutor, NombreAutor, Nacionalidad, indAdministrador, indBibliotecario, indActivo FROM AUTORES"
            miConexion.Open()

            Dim cmdAutor As New OleDbCommand(SQL_OBTENER_AUTORES, miConexion)

            Dim drAutor As OleDbDataReader
            drAutor = cmdAutor.ExecuteReader()

            Dim lstAUTORES As New List(Of AutorEN)

            While drAutor.Read
                Dim miUser As New AutorEN
                miUser.CodAutor = drAutor("CodAutor")
                miUser.NombreAutor = drAutor("NombreAutor")
                miUser.Nacionalidad = drAutor("Nombre_Completo")
                lstAUTORES.Add(miUser)
            End While
            drAutor.Close()
            miConexion.Close()
            Return lstAUTORES

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function


End Class
