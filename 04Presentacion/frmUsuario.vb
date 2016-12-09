Imports _03Entidades
Imports _02LogicaNegocios


Public Class frmUsuario


    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click

        Try
            Dim miUsu As New UsuarioEN()
            miUsu.Login = txtLogin.Text
            miUsu.NombreCompleto = txtNombre.Text
            miUsu.Clave = txtClave.Text
            If rbtnAdministrador.Checked Then
                miUsu.IndAdministrador = True
            End If
            If rbtnBibliotecario.Checked Then
                miUsu.IndBibliotecario = True
            End If
            If rbtnNo.Checked Then
                miUsu.IndActivo = False
            ElseIf rbtnSi.Checked Then
                miUsu.IndActivo = True
            End If

            Dim valida As New UsuarioLN
            valida.InsertarUsuario(miUsu)
            MessageBox.Show("El usuario ha sido Creado con Exito!")

            txtLogin.Clear()
            txtClave.Clear()
            txtNombre.Clear()
            rbtnAdministrador.Checked = False
            rbtnBibliotecario.Checked = False
            rbtnNo.Checked = False
            rbtnSi.Checked = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        txtLogin.Clear()
        txtClave.Clear()
        txtNombre.Clear()
        rbtnAdministrador.Checked = False
        rbtnBibliotecario.Checked = False
        rbtnNo.Checked = False
        rbtnSi.Checked = False
        btnInsertar.Enabled = False

        Try
            Dim strLogin As String
            strLogin = InputBox("Digite el Login del usuario a buscar")

            Dim miUsu As UsuarioEN = Nothing

            Dim valida As New UsuarioLN
            miUsu = valida.ObtenerUsuarioPorLogin(strLogin)

            If Not IsNothing(miUsu) Then
                txtLogin.Text = miUsu.Login
                txtNombre.Text = miUsu.NombreCompleto
                txtClave.Text = miUsu.Clave

                If miUsu.IndAdministrador = True Then
                    rbtnAdministrador.Checked = True
                End If

                If miUsu.IndBibliotecario = True Then
                    rbtnBibliotecario.Checked = True
                End If

                If miUsu.IndActivo Then
                    rbtnSi.Checked = True
                Else
                    rbtnNo.Checked = True
                End If

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
            Dim miUsu As New UsuarioEN()
            miUsu.Login = txtLogin.Text
            miUsu.NombreCompleto = txtNombre.Text
            miUsu.Clave = txtClave.Text

            If rbtnAdministrador.Checked Then
                miUsu.IndAdministrador = True
            Else
                miUsu.IndAdministrador = False
            End If

            If rbtnBibliotecario.Checked Then
                miUsu.IndBibliotecario = True
            Else
                miUsu.IndBibliotecario = False
            End If

            If rbtnNo.Checked Then
                miUsu.IndActivo = False
            ElseIf rbtnSi.Checked Then
                miUsu.IndActivo = True
            End If

            Dim valida As New UsuarioLN
            valida.ModificarUsuario(miUsu)
            MessageBox.Show("El usuario ha sido Modificado con Exito!")

            txtLogin.Clear()
            txtClave.Clear()
            txtNombre.Clear()
            rbtnAdministrador.Checked = False
            rbtnBibliotecario.Checked = False
            rbtnNo.Checked = False
            rbtnSi.Checked = False


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnInsertar.Enabled = True
        btnModificar.Enabled = False
        btnBorrar.Enabled = False
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        Try
            Dim miUsu As New UsuarioEN()
            miUsu.Login = txtLogin.Text
            miUsu.NombreCompleto = txtNombre.Text
            miUsu.Clave = txtClave.Text
            If rbtnAdministrador.Checked Then
                miUsu.IndAdministrador = True
            End If
            If rbtnBibliotecario.Checked Then
                miUsu.IndBibliotecario = True
            End If
            If rbtnNo.Checked Then
                miUsu.IndActivo = False
            ElseIf rbtnSi.Checked Then
                miUsu.IndActivo = True
            End If

            Dim valida As New UsuarioLN

            Dim intOption As Integer
            intOption = MessageBox.Show("Realmente Desea Eliminar el Usuario?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If intOption = 6 Then
                valida.BorrarUsuario(miUsu)
                txtLogin.Clear()
                txtClave.Clear()
                txtNombre.Clear()
                rbtnAdministrador.Checked = False
                rbtnBibliotecario.Checked = False
                rbtnNo.Checked = False
                rbtnSi.Checked = False
                MessageBox.Show("El usuario ha sido Eliminado con Exito!")
                btnInsertar.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnModificar.Enabled = False
        btnBorrar.Enabled = False
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        txtLogin.Clear()
        txtClave.Clear()
        txtNombre.Clear()
        rbtnAdministrador.Checked = False
        rbtnBibliotecario.Checked = False
        rbtnNo.Checked = False
        rbtnSi.Checked = False
        btnInsertar.Enabled = True

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnModificar.Enabled = False
        btnBorrar.Enabled = False
    End Sub
End Class