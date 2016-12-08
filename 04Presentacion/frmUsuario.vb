Imports _03Entidades
Imports _02LogicaNegocios


Public Class frmUsuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Try
            Dim miUsu As New UsuarioEN()
            miUsu.Login = txtLogin.Text
            miUsu.NombreCompleto = txtNombre.Text
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

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim strLogin As String
            strLogin = InputBox("Digite el Login del usuario a buscar")

            Dim miUsu As UsuarioEN = Nothing

            Dim valida As New UsuarioLN
            miUsu = valida.ObtenerUsuarioPorLogin(strLogin)

            If Not IsNothing(miUsu) Then
                txtLogin.Text = miUsu.Login
                txtNombre.Text = miUsu.NombreCompleto

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
            Else
                MessageBox.Show("No existe")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class