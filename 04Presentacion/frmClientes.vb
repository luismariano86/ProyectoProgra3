Imports _03Entidades
Imports _02LogicaNegocios

Public Class frmClientes

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click

        Try
            Dim miCli As New ClienteEN()
            miCli.Cedula = txtCedula.Text
            miCli.NombreCompleto = txtNombre.Text
            miCli.Telefono = txtTelefono.Text
            miCli.FecNacimiento = dtpFecNacimiento.Text
            miCli.FecRegistro = dtpFecRegistro.Text
            miCli.DireccionExacta = txtDireccionExacta.Text

            Dim valida As New ClienteLN
            valida.InsertarCliente(miCli)
            MessageBox.Show("El Cliente ha sido Creado con Exito!")

            txtCedula.Clear()
            txtTelefono.Clear()
            txtNombre.Clear()
            txtDireccionExacta.Clear()
            dtpFecNacimiento.ResetText()
            dtpFecRegistro.ResetText()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        txtCedula.Clear()
        txtTelefono.Clear()
        txtNombre.Clear()
        btnInsertar.Enabled = False

        Try
            Dim strCedula As String
            strCedula = InputBox("Digite la Cedula del Cliente a buscar")

            Dim miCli As ClienteEN = Nothing

            Dim valida As New ClienteLN
            miCli = valida.ObtenerClientePorCedula(strCedula)

            If Not IsNothing(miCli) Then
                txtCedula.Text = miCli.Cedula
                txtNombre.Text = miCli.NombreCompleto
                txtTelefono.Text = miCli.Telefono
                dtpFecNacimiento.Text = miCli.FecNacimiento
                dtpFecRegistro.Text = miCli.FecRegistro
                txtDireccionExacta.Text = miCli.DireccionExacta

                btnModificar.Enabled = True
                btnBorrar.Enabled = True
            Else
                MessageBox.Show("No existe")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim miCli As New ClienteEN()
            miCli.Cedula = txtCedula.Text
            miCli.NombreCompleto = txtNombre.Text
            miCli.Telefono = txtTelefono.Text
            dtpFecNacimiento.Text = miCli.FecNacimiento
            dtpFecRegistro.Text = miCli.FecRegistro
            miCli.DireccionExacta = txtDireccionExacta.Text

            Dim valida As New ClienteLN
            valida.ModificarCliente(miCli)
            MessageBox.Show("El Cliente ha sido Modificado con Exito!")

            txtCedula.Clear()
            txtTelefono.Clear()
            txtNombre.Clear()
            txtDireccionExacta.Clear()
            dtpFecNacimiento.ResetText()
            dtpFecRegistro.ResetText()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnInsertar.Enabled = True
        btnModificar.Enabled = False
        btnBorrar.Enabled = False
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        Try
            Dim miCli As New ClienteEN()
            miCli.Cedula = txtCedula.Text
            miCli.NombreCompleto = txtNombre.Text
            miCli.Telefono = txtTelefono.Text
            dtpFecNacimiento.Text = miCli.FecNacimiento
            dtpFecRegistro.Text = miCli.FecRegistro
            miCli.DireccionExacta = txtDireccionExacta.Text

            Dim valida As New ClienteLN

            Dim intOption As Integer
            intOption = MessageBox.Show("Realmente Desea Eliminar el Cliente?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If intOption = 6 Then
                valida.BorrarCliente(miCli)
                txtCedula.Clear()
                txtTelefono.Clear()
                txtNombre.Clear()
                txtDireccionExacta.Clear()

                MessageBox.Show("El Cliente ha sido Eliminado con Exito!")
                btnInsertar.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnModificar.Enabled = False
        btnBorrar.Enabled = False
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) 
        txtCedula.Clear()
        txtTelefono.Clear()
        txtNombre.Clear()
        txtDireccionExacta.Clear()
        btnInsertar.Enabled = True
        dtpFecNacimiento.ResetText()
        dtpFecRegistro.ResetText()


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnModificar.Enabled = False
        btnBorrar.Enabled = False
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) 
        Dim Pantalla As New frmReportes
        Dim Reporte As New rptListaClientes
        Dim dstDatosReporte As New DataSet
        Dim strConsulta As String = "SELECT Cedula, NombreCompleto, Telefono, FecNacimiento, FecRegistro, DireccionExacta FROM Clientes"
        Dim adpLista As New OleDb.OleDbDataAdapter(strConsulta, miConexion)
        adpLista.Fill(dstDatosReporte, "ListaClientes")
        Reporte.SetDataSource(dstDatosReporte)
        Pantalla.crvVisorReportes.ReportSource = Reporte
        Pantalla.Text = “Listado de Clientes”
        Pantalla.ShowDialog()
    End Sub
End Class