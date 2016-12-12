Imports _03Entidades
Imports System.Data.OleDb
Public Class PrestamoAD
    ' Objeto que permite conectarse a la BD Access
    Dim miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Biblioteca.accdb")

    Public Sub InsertarPrestamo(ByVal pPrestamo As PrestamoEN)
        Try

            Dim SQL_INSERT_Prestamo As String = "INSERT INTO PrestamoS (CodPrestamo, Cedula, ISBN, Monto, FecPrestamo, FecDevolucion, IndDevuelto, Observaciones, LoginUsuario) VALUES (@CodPrestamo, @Cedula, @ISBN, @Motno, @FecPrestamo, @FecDevolucion, @IndDevuelto, @Observaciones, @LoginUsuario)"
            miConexion.Open()

            Dim cmdPrestamo As New OleDbCommand(SQL_INSERT_Prestamo, miConexion)

            cmdPrestamo.Parameters.Add("@CodPrestamo", OleDbType.VarChar).Value = pPrestamo.CodPrestamo
            cmdPrestamo.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pPrestamo.Cedula
            cmdPrestamo.Parameters.Add("@ISBN", OleDbType.VarChar).Value = pPrestamo.ISBN
            cmdPrestamo.Parameters.Add("@Monto", OleDbType.Double).Value = pPrestamo.Monto
            cmdPrestamo.Parameters.Add("@FecPrestamo", OleDbType.Date).Value = pPrestamo.FecPrestamo
            cmdPrestamo.Parameters.Add("@FecDevolucion", OleDbType.Date).Value = pPrestamo.FecDevolucion
            cmdPrestamo.Parameters.Add("@IndDevuelto", OleDbType.Boolean).Value = pPrestamo.IndDevuelto
            cmdPrestamo.Parameters.Add("@Observaciones", OleDbType.VarChar).Value = pPrestamo.Observaciones
            cmdPrestamo.Parameters.Add("@LoginUsuario", OleDbType.VarChar).Value = pPrestamo.LoginUsuario


            cmdPrestamo.ExecuteNonQuery()

            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarPrestamo(ByVal pPrestamo As PrestamoEN)
        Try
            Dim SQL_UPDATE_Prestamo As String = "UPDATE PrestamoS SET  Cedula=@Cedula, ISBN=@ISBN, Monto=@Monto, FecPrestamo=@FecPrestamo, FecDevolucion=@FecDevolucion, IndDevuelto=@IndDevuelto, Observaciones=@Observaciones, LoginUsuario=@LoginUsuario WHERE CodPrestamo=@CodPrestamo"
            miConexion.Open()

            Dim cmdPrestamo As New OleDbCommand(SQL_UPDATE_Prestamo, miConexion)

            cmdPrestamo.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pPrestamo.Cedula
            cmdPrestamo.Parameters.Add("@ISBN", OleDbType.VarChar).Value = pPrestamo.ISBN
            cmdPrestamo.Parameters.Add("@Monto", OleDbType.Double).Value = pPrestamo.Monto
            cmdPrestamo.Parameters.Add("@FecPrestamo", OleDbType.Date).Value = pPrestamo.FecPrestamo
            cmdPrestamo.Parameters.Add("@FecDevolucion", OleDbType.Date).Value = pPrestamo.FecDevolucion
            cmdPrestamo.Parameters.Add("@IndDevuelto", OleDbType.Boolean).Value = pPrestamo.IndDevuelto
            cmdPrestamo.Parameters.Add("@Observaciones", OleDbType.VarChar).Value = pPrestamo.Observaciones
            cmdPrestamo.Parameters.Add("@LoginUsuario", OleDbType.VarChar).Value = pPrestamo.LoginUsuario
            cmdPrestamo.Parameters.Add("@CodPrestamo", OleDbType.VarChar).Value = pPrestamo.CodPrestamo

            cmdPrestamo.ExecuteNonQuery()

            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarPrestamo(ByVal pPrestamo As PrestamoEN)
        Try
            Dim SQL_BORRAR_Prestamo As String = "DELETE FROM PrestamoS WHERE CodPrestamo=@CodPrestamo"
            miConexion.Open()

            Dim cmdPrestamo As New OleDbCommand(SQL_BORRAR_Prestamo, miConexion)
            cmdPrestamo.Parameters.Add("@CodPrestamo", OleDbType.VarChar).Value = pPrestamo.CodPrestamo
            cmdPrestamo.ExecuteNonQuery()
            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerPrestamoPorCodPrestamo(ByVal pCodPrestamo As String) As PrestamoEN
        Try

            Dim SQL_OBTENER_UN_Prestamo As String = "SELECT CodPrestamo, Cedula, ISBN, Monto, FecPrestamo, FecDevolucion, IndDevuelto, Observaciones, LoginUsuario FROM Prestamos WHERE CodPrestamo=@CodPrestamo"
            miConexion.Open()

            Dim cmdPrestamo As New OleDbCommand(SQL_OBTENER_UN_Prestamo, miConexion)
            cmdPrestamo.Parameters.Add("@CodPrestamo", OleDbType.VarChar).Value = pCodPrestamo
            Dim drPrestamo As OleDbDataReader
            drPrestamo = cmdPrestamo.ExecuteReader()
            Dim miPrest As PrestamoEN = Nothing
            While drPrestamo.Read
                miPrest = New PrestamoEN
                miPrest.CodPrestamo = drPrestamo("CodPrestamo")
                miPrest.Cedula = drPrestamo("Cedula")
                miPrest.ISBN = drPrestamo("ISBN")
                miPrest.Monto = drPrestamo("Monto")
                miPrest.FecDevolucion = drPrestamo("FecDevolucion")
                miPrest.FecPrestamo = drPrestamo("FecPrestamo")
                miPrest.IndDevuelto = drPrestamo("IndDevuelto")
                miPrest.Observaciones = drPrestamo("Observaciones")
                miPrest.LoginUsuario = drPrestamo("LoginUsuario")
            End While
            drPrestamo.Close()
            miConexion.Close()
            Return miPrest
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosPrestamos() As List(Of PrestamoEN)
        Try
            Dim SQL_OBTENER_PrestamoS As String = "SELECT CodPrestamo, Cedula, ISBN, Monto, FecPrestamo, FecDevolucion, IndDevuelto, Observaciones, LoginUsuario FROM Prestamos"
            miConexion.Open()

            Dim cmdPrestamo As New OleDbCommand(SQL_OBTENER_PrestamoS, miConexion)

            Dim drPrestamo As OleDbDataReader
            drPrestamo = cmdPrestamo.ExecuteReader()

            Dim lstPrestamos As New List(Of PrestamoEN)

            While drPrestamo.Read
                Dim miPrest As New PrestamoEN
                miPrest = New PrestamoEN
                miPrest.CodPrestamo = drPrestamo("CodPrestamo")
                miPrest.Cedula = drPrestamo("Cedula")
                miPrest.ISBN = drPrestamo("ISBN")
                miPrest.Monto = drPrestamo("Monto")
                miPrest.FecDevolucion = drPrestamo("FecDevolucion")
                miPrest.FecPrestamo = drPrestamo("FecPrestamo")
                miPrest.IndDevuelto = drPrestamo("IndDevuelto")
                miPrest.Observaciones = drPrestamo("Observaciones")
                miPrest.LoginUsuario = drPrestamo("LoginUsuario")
            End While
            drPrestamo.Close()
            miConexion.Close()
            Return lstPrestamos

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
End Class
