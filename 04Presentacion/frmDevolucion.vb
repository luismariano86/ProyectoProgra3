Imports _03Entidades
Imports _02LogicaNegocios


Public Class frmDevolucion
    Dim lstClientes As New List(Of ClienteEN)
    Dim lstLibros As New List(Of LibroEN)

    Private Sub frmDevolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsuActivo.Text = user.Login

        Dim validaClientes As New ClienteLN
        lstClientes = validaClientes.obtenerTodosClientes
        cboClientes.DataSource = lstClientes
        cboClientes.DisplayMember = "NombreCompleto" 'Propiedad EN (Visualiza)
        cboClientes.ValueMember = "Cedula" 'Propiedad EN (Valor Interno)
        cboClientes.Text = ""

        Dim validaLibros As New LibroLN
        lstLibros = validaLibros.obtenerTodosLibros
        cboLibros.DataSource = lstLibros
        cboLibros.DisplayMember = "TituloCompleto" 'Propiedad EN (Visualiza)
        cboLibros.ValueMember = "ISBN" 'Propiedad EN (Valor Interno)
        cboLibros.Text = ""


    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        txtCodPrestamo.Clear()
        rbtnSi.Checked = False
        rbtnNo.Checked = False
        txtObservacion.Clear()
        txtMonto.Clear()
        cboClientes.Text = ""
        cboLibros.Text = ""
        dtpFecDevolucion.Value = Today
        dtpFecPrestamo.Value = Today


        Try
            Dim strCodPrestamo As String
            strCodPrestamo = InputBox("Digite el CodPrestamo del Prestamo para Devolver")

            Dim miPrest As PrestamoEN = Nothing

            Dim valida As New PrestamoLN
            miPrest = valida.ObtenerPrestamoPorCodPrestamo(strCodPrestamo)

            If Not IsNothing(miPrest) Then
                txtCodPrestamo.Text = miPrest.CodPrestamo
                For Each item As ClienteEN In lstClientes
                    If (miPrest.Cedula = item.Cedula) Then
                        cboClientes.Text = item.NombreCompleto
                        Exit For
                    End If
                Next
                For Each item As LibroEN In lstLibros
                    If (miPrest.ISBN = item.ISBN) Then
                        cboLibros.Text = item.TituloCompleto
                        Exit For
                    End If
                Next
                txtMonto.Text = miPrest.Monto
                dtpFecPrestamo.Text = miPrest.FecPrestamo
                dtpFecDevolucion.Text = miPrest.FecDevolucion
                If miPrest.IndDevuelto = True Then
                    rbtnSi.Checked = True
                    rbtnNo.Checked = False
                Else
                    rbtnSi.Checked = False
                    rbtnNo.Checked = True
                End If
                txtObservacion.Text = miPrest.Observaciones
                lblUsuActivo.Text = miPrest.LoginUsuario

                btnModificar.Enabled = True

            Else
                MessageBox.Show("No existe")


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim miPrest As New PrestamoEN()
            miPrest.CodPrestamo = txtCodPrestamo.Text
            miPrest.Cedula = cboClientes.SelectedValue
            miPrest.ISBN = cboLibros.SelectedValue
            miPrest.Monto = txtMonto.Text
            miPrest.FecPrestamo = dtpFecPrestamo.Text
            miPrest.FecDevolucion = dtpFecDevolucion.Text
            If rbtnSi.Checked Then
                miPrest.IndDevuelto = True
            End If
            If rbtnNo.Checked Then
                miPrest.IndDevuelto = True
            End If
            miPrest.Observaciones = txtObservacion.Text
            miPrest.LoginUsuario = lblUsuActivo.Text

            Dim valida As New PrestamoLN
            valida.ModificarPrestamo(miPrest)
            MessageBox.Show("El Prestamo ha sido Modificado con Exito!")

            txtCodPrestamo.Clear()
            rbtnSi.Checked = False
            rbtnNo.Checked = False
            txtObservacion.Clear()
            txtMonto.Clear()
            cboClientes.Text = ""
            cboLibros.Text = ""
            dtpFecDevolucion.Value = Today
            dtpFecPrestamo.Value = Today


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnModificar.Enabled = False

    End Sub
    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        txtCodPrestamo.Clear()
        rbtnSi.Checked = False
        rbtnNo.Checked = False
        txtObservacion.Clear()
        txtMonto.Clear()
        cboClientes.Text = ""
        cboLibros.Text = ""
        dtpFecDevolucion.Value = Today
        dtpFecPrestamo.Value = Today

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


End Class