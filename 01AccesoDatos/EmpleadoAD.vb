Imports _03Entidades
Imports System.Data.OleDb
'Imports System.Data.SqlClient

Public Class EmpleadoAD

    ' Objeto que permite conectarse a la BD Access
    Dim miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Planilla.accdb")

    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarEmpleado(ByVal pEmpleado As EmpleadoEN)
        Try

            Dim SQL_INSERT_EMPLEADO As String = "INSERT INTO Empleado (Cedula, Nombre, FechaIngreso, Horas, PrecioHora, IndActivo) VALUES (@Cedula, @Nombre, @FechaIngreso, @Horas, @PrecioHora, @IndActivo)"
            miConexion.Open()

            Dim cmdEmpleado As New OleDbCommand(SQL_INSERT_EMPLEADO, miConexion)

            cmdEmpleado.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pEmpleado.Cedula
            cmdEmpleado.Parameters.Add("@Nombre", OleDbType.VarChar).Value = pEmpleado.NombreCompleto
            cmdEmpleado.Parameters.Add("@FechaIngreso", OleDbType.Date).Value = pEmpleado.FechaIngreso
            cmdEmpleado.Parameters.Add("@Horas", OleDbType.Integer).Value = pEmpleado.HorasTrabajadas
            cmdEmpleado.Parameters.Add("@PrecioHora", OleDbType.Double).Value = pEmpleado.PrecioPorHora
            cmdEmpleado.Parameters.Add("@IndActivo", OleDbType.Boolean).Value = pEmpleado.IndicadorActivo

            cmdEmpleado.ExecuteNonQuery()

            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarEmpleado(ByVal pEmpleado As EmpleadoEN)
        Try
            Dim SQL_UPDATE_EMPLEADO As String = "UPDATE Empleado SET Nombre=@Nombre, FechaIngreso=@FechaIngreso, Horas=@Horas, PrecioHora=@PrecioHora, IndActivo=@IndActivo WHERE Cedula=@Cedula"
            miConexion.Open()

            Dim cmdEmpleado As New OleDbCommand(SQL_UPDATE_EMPLEADO, miConexion)

            cmdEmpleado.Parameters.Add("@Nombre", OleDbType.VarChar).Value = pEmpleado.NombreCompleto
            cmdEmpleado.Parameters.Add("@FechaIngreso", OleDbType.Date).Value = pEmpleado.FechaIngreso
            cmdEmpleado.Parameters.Add("@Horas", OleDbType.Integer).Value = pEmpleado.HorasTrabajadas
            cmdEmpleado.Parameters.Add("@PrecioHora", OleDbType.Double).Value = pEmpleado.PrecioPorHora
            cmdEmpleado.Parameters.Add("@IndActivo", OleDbType.Boolean).Value = pEmpleado.IndicadorActivo
            cmdEmpleado.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pEmpleado.Cedula

            cmdEmpleado.ExecuteNonQuery()

            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarEmpleado(ByVal pEmpleado As EmpleadoEN)
        Try
            Dim SQL_BORRAR_EMPLEADO As String = "DELETE FROM Empleado WHERE Cedula=@Cedula"
            miConexion.Open()

            Dim cmdEmpleado As New OleDbCommand(SQL_BORRAR_EMPLEADO, miConexion)
            cmdEmpleado.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pEmpleado.Cedula
            cmdEmpleado.ExecuteNonQuery()
            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerEmpleadoPorCedula(ByVal pCedula As String) As EmpleadoEN
        Try

            Dim SQL_OBTENER_UN_EMPLEADO As String = "SELECT Cedula, Nombre, FechaIngreso, Horas, PrecioHora, IndActivo FROM Empleado WHERE Cedula=@Cedula"
            miConexion.Open()

            Dim cmdEmpleado As New OleDbCommand(SQL_OBTENER_UN_EMPLEADO, miConexion)
            cmdEmpleado.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pCedula
            Dim drEmpleado As OleDbDataReader
            drEmpleado = cmdEmpleado.ExecuteReader()
            Dim miEmp As EmpleadoEN = Nothing
            While drEmpleado.Read
                miEmp = New EmpleadoEN
                miEmp.Cedula = drEmpleado("Cedula")
                miEmp.NombreCompleto = drEmpleado("Nombre")
                miEmp.FechaIngreso = drEmpleado("FechaIngreso")
                miEmp.HorasTrabajadas = drEmpleado("Horas")
                miEmp.PrecioPorHora = drEmpleado("PrecioHora")
                miEmp.IndicadorActivo = drEmpleado("IndActivo")
            End While
            drEmpleado.Close()
            miConexion.Close()
            Return miEmp
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosEmpleados() As List(Of EmpleadoEN)
        Try
            Dim SQL_OBTENER_EMPLEADOS As String = "SELECT Cedula, Nombre, FechaIngreso, Horas, PrecioHora, IndActivo FROM Empleado"
            miConexion.Open()

            Dim cmdEmpleado As New OleDbCommand(SQL_OBTENER_EMPLEADOS, miConexion)

            Dim drEmpleado As OleDbDataReader
            drEmpleado = cmdEmpleado.ExecuteReader()

            Dim lstEmpl As New List(Of EmpleadoEN)

            While drEmpleado.Read
                Dim miEmp As New EmpleadoEN
                miEmp.Cedula = drEmpleado("Cedula")
                miEmp.NombreCompleto = drEmpleado("Nombre")
                miEmp.FechaIngreso = drEmpleado("FechaIngreso")
                miEmp.HorasTrabajadas = drEmpleado("Horas")
                miEmp.PrecioPorHora = drEmpleado("PrecioHora")
                miEmp.IndicadorActivo = drEmpleado("IndActivo")
                lstEmpl.Add(miEmp)
            End While
            drEmpleado.Close()
            miConexion.Close()
            Return lstEmpl

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function


End Class
