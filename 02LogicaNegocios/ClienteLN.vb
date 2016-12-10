Imports _03Entidades
Imports _01AccesoDatos
Public Class ClienteLN
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarCliente(ByVal pCliente As ClienteEN)
        Try
            If (pCliente.Cedula.Trim().Length = 0) Then
                Throw New Exception("La Cedula Es Obligatorio")
            ElseIf (pCliente.Cedula.Trim().Length < 9) Then
                Throw New Exception("La Cedula tiene que tener como minimo 9 digitos")
            ElseIf (pCliente.Cedula.Trim().Length > 15) Then
                Throw New Exception("La cedula no puede ser mayor a 15 digitos")
            ElseIf (pCliente.Telefono.Trim().Length = 0) Then
                Throw New Exception("El Telefono Es Obligatorio")
            ElseIf (pCliente.Telefono.Trim().Length < 8) Then
                Throw New Exception("El Telefono tiene tener minimo 8 digitos")
            ElseIf String.IsNullOrWhiteSpace(pCliente.NombreCompleto) Then
                Throw New Exception("El Nombre es obligatorio")
            ElseIf String.IsNullOrWhiteSpace(pCliente.DireccionExacta) Then
                Throw New Exception("La DireccionExacta es obligatorio")
            End If

            Dim CliAD As New ClienteAD
            If Not IsNothing(CliAD.ObtenerClientePorCedula(pCliente.Cedula)) Then
                Throw New Exception("YA EXISTE")
            End If
            CliAD.InsertarCliente(pCliente)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarCliente(ByVal pCliente As ClienteEN)
        Try
            If (pCliente.Cedula.Trim().Length = 0) Then
                Throw New Exception("La Cedula Es Obligatorio")
            ElseIf (pCliente.Cedula.Trim().Length < 9) Then
                Throw New Exception("La Cedula tiene que tener como minimo 9 digitos")
            ElseIf (pCliente.Cedula.Trim().Length > 15) Then
                Throw New Exception("La cedula no puede ser mayor a 15 digitos")
            ElseIf (pCliente.Telefono.Trim().Length = 0) Then
                Throw New Exception("El Telefono Es Obligatorio")
            ElseIf (pCliente.Telefono.Trim().Length < 8) Then
                Throw New Exception("El Telefono tiene tener minimo 8 digitos")
            ElseIf String.IsNullOrWhiteSpace(pCliente.NombreCompleto) Then
                Throw New Exception("El Nombre es obligatorio")
            ElseIf String.IsNullOrWhiteSpace(pCliente.DireccionExacta) Then
                Throw New Exception("La DireccionExacta es obligatorio")
            End If

            Dim CliAD As New ClienteAD
            If IsNothing(CliAD.ObtenerClientePorCedula(pCliente.Cedula)) Then
                Throw New Exception("NO EXISTE")
            End If
            CliAD.ModificarCliente(pCliente)


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarCliente(ByVal pCliente As ClienteEN)
        Try

            Dim CliAD As New ClienteAD
            If IsNothing(CliAD.ObtenerClientePorCedula(pCliente.Cedula)) Then
                Throw New Exception("No EXISTE, el Cliente a borrar")
            End If
            CliAD.BorrarCliente(pCliente)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerClientePorCedula(ByVal pCedula As String) As ClienteEN
        Try
            If (pCedula.Trim().Length = 0) Then
                Throw New Exception("La Cedula es obligatoria")
            End If

            Dim CliAD As New ClienteAD
            Return CliAD.ObtenerClientePorCedula(pCedula)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosClientes() As List(Of ClienteEN)
        Try
            Dim CliAD As New ClienteAD
            Return CliAD.obtenerTodosClientes()

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
End Class
