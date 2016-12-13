Imports _03Entidades
Imports _02LogicaNegocios

Public Class frmLogin
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim strLogin As String = txtLogin.Text



        Dim valida As New UsuarioLN
        user = valida.ObtenerUsuarioPorLogin(strLogin)

        If IsNothing(user) Then
            MessageBox.Show("No existe el usuario")
            Application.Exit()
        ElseIf Not user.Clave = txtClave.Text Then
            MessageBox.Show("No coincide su clave")
            Application.Exit()
        ElseIf user.IndActivo = False
            MessageBox.Show("Su Usuario esta Inactivo, contactar al administrador")
        Else
            MessageBox.Show("Bienvenido " & vbCrLf &
                            "Sistema de Gestion Bibliotecario")
            Me.DialogResult = DialogResult.Yes
        End If

    End Sub
End Class
