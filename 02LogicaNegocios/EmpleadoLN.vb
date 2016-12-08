Imports _03Entidades
Imports _01AccesoDatos
Public Class EmpleadoLN

    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarEmpleado(ByVal pEmpleado As EmpleadoEN)
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

    Public Sub ModificarEmpleado(ByVal pEmpleado As EmpleadoEN)
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
            If IsNothing(EmpAD.ObtenerEmpleadoPorCedula(pEmpleado.Cedula)) Then
                Throw New Exception("NO EXISTE")
            End If
            EmpAD.ModificarEmpleado(pEmpleado)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarEmpleado(ByVal pEmpleado As EmpleadoEN)
        Try

            Dim EmpAD As New EmpleadoAD
            If IsNothing(EmpAD.ObtenerEmpleadoPorCedula(pEmpleado.Cedula)) Then
                Throw New Exception("No EXISTE, el empleado a borrar")
            End If
            EmpAD.BorrarEmpleado(pEmpleado)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerEmpleadoPorCedula(ByVal pCedula As String) As EmpleadoEN
        Try
            If (pCedula.Trim().Length = 0) Then
                Throw New Exception("La Cedula es obligatoria")
            ElseIf pCedula.Trim().Length < 9 Then
                Throw New Exception("Caracteres minimos son 9")
            ElseIf pCedula.Trim().Length > 15 Then
                Throw New Exception("Cèdula de Maximos 15 caracteres")
            End If


            Dim EmpAD As New EmpleadoAD
            Return EmpAD.ObtenerEmpleadoPorCedula(pCedula)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosEmpleados() As List(Of EmpleadoEN)
        Try
            Dim EmpAD As New EmpleadoAD
            Return EmpAD.obtenerTodosEmpleados()

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function



End Class
