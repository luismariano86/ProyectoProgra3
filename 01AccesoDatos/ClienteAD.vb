Imports _03Entidades
Imports System.Data.OleDb
Public Class ClienteAD

    ' Objeto que permite conectarse a la BD Access
    Dim miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Biblioteca.accdb")

    Public Sub New()

    End Sub

    Public Sub InsertarCliente(ByVal pCliente As ClienteEN)
        Try

            Dim SQL_INSERT_Cliente As String = "INSERT INTO CLIENTES (Cedula, NombreCompleto, Telefono, FecNacimiento, FecRegistro, DireccionExacta) VALUES (@Cedula, @NombreCompleto, @Telefono, @FecNacimiento, @FecRegistro, @DireccionExacta)"
            miConexion.Open()

            Dim cmdCliente As New OleDbCommand(SQL_INSERT_Cliente, miConexion)

            cmdCliente.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pCliente.Cedula
            cmdCliente.Parameters.Add("@NombreCompleto", OleDbType.VarChar).Value = pCliente.NombreCompleto
            cmdCliente.Parameters.Add("@Telefono", OleDbType.VarChar).Value = pCliente.Telefono
            cmdCliente.Parameters.Add("@FecNacimiento", OleDbType.Date).Value = pCliente.FecNacimiento
            cmdCliente.Parameters.Add("@FecRegistro", OleDbType.Date).Value = pCliente.FecRegistro
            cmdCliente.Parameters.Add("@DireccionExacta", OleDbType.VarChar).Value = pCliente.DireccionExacta


            cmdCliente.ExecuteNonQuery()

            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarCliente(ByVal pCliente As ClienteEN)
        Try
            Dim SQL_UPDATE_Cliente As String = "UPDATE CLIENTES SET  NombreCompleto=@NombreCompleto, Telefono=@Telefono, FecNacimiento=@FecNacimiento, FecRegistro=@FecRegistro, DireccionExacta=@DireccionExacta WHERE Cedula=@Cedula"
            miConexion.Open()

            Dim cmdCliente As New OleDbCommand(SQL_UPDATE_Cliente, miConexion)

            cmdCliente.Parameters.Add("@NombreCompleto", OleDbType.VarChar).Value = pCliente.NombreCompleto
            cmdCliente.Parameters.Add("@Telefono", OleDbType.VarChar).Value = pCliente.Telefono
            cmdCliente.Parameters.Add("@FecNacimiento", OleDbType.Date).Value = pCliente.FecNacimiento
            cmdCliente.Parameters.Add("@FecRegistro", OleDbType.Date).Value = pCliente.FecRegistro
            cmdCliente.Parameters.Add("@DireccionExacta", OleDbType.VarChar).Value = pCliente.DireccionExacta
            cmdCliente.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pCliente.Cedula

            cmdCliente.ExecuteNonQuery()

            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarCliente(ByVal pCliente As ClienteEN)
        Try
            Dim SQL_BORRAR_Cliente As String = "DELETE FROM CLIENTES WHERE Cedula=@Cedula"
            miConexion.Open()

            Dim cmdCliente As New OleDbCommand(SQL_BORRAR_Cliente, miConexion)
            cmdCliente.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pCliente.Cedula
            cmdCliente.ExecuteNonQuery()
            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerClientePorCedula(ByVal pCedula As String) As ClienteEN
        Try

            Dim SQL_OBTENER_UN_Cliente As String = "SELECT Cedula, NombreCompleto, Telefono, FecNacimiento, FecRegistro, DireccionExacta FROM Clientes WHERE Cedula=@Cedula"
            miConexion.Open()

            Dim cmdCliente As New OleDbCommand(SQL_OBTENER_UN_Cliente, miConexion)
            cmdCliente.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pCedula
            Dim drCliente As OleDbDataReader
            drCliente = cmdCliente.ExecuteReader()
            Dim miUser As ClienteEN = Nothing
            While drCliente.Read
                miUser = New ClienteEN
                miUser.Cedula = drCliente("Cedula")
                miUser.NombreCompleto = drCliente("NombreCompleto")
                miUser.Telefono = drCliente("Telefono")
                miUser.FecRegistro = drCliente("FecRegistro")
                miUser.FecNacimiento = drCliente("FecNacimiento")
                miUser.DireccionExacta = drCliente("DireccionExacta")
            End While
            drCliente.Close()
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

    Public Function obtenerTodosClientes() As List(Of ClienteEN)
        Try
            Dim SQL_OBTENER_ClienteS As String = "SELECT Cedula, NombreCompleto, Telefono, FecNacimiento, FecRegistro, DireccionExacta FROM Clientes"
            miConexion.Open()

            Dim cmdCliente As New OleDbCommand(SQL_OBTENER_ClienteS, miConexion)

            Dim drCliente As OleDbDataReader
            drCliente = cmdCliente.ExecuteReader()

            Dim lstClientes As New List(Of ClienteEN)

            While drCliente.Read
                Dim miUser As New ClienteEN
                miUser.Cedula = drCliente("Cedula")
                miUser.NombreCompleto = drCliente("NombreCompleto")
                miUser.Telefono = drCliente("Telefono")
                miUser.FecRegistro = drCliente("FecRegistro")
                miUser.FecNacimiento = drCliente("FecNacimiento")
                miUser.DireccionExacta = drCliente("DireccionExacta")
                lstClientes.Add(miUser)
            End While
            drCliente.Close()
            miConexion.Close()
            Return lstClientes

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
End Class
