Imports _03Entidades
Imports _02LogicaNegocios
Imports System.Globalization
Public Class frmLibros
    Private Sub frmLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each objCultureInfo As CultureInfo In CultureInfo.GetCultures(System.Globalization.CultureTypes.SpecificCultures)
            Dim objRegionInfo As New RegionInfo(objCultureInfo.Name)
            If Not cboPais.Items.Contains(objRegionInfo.DisplayName) Then
                cboPais.Items.Add(objRegionInfo.DisplayName)
            End If
        Next
        cboPais.Sorted = True

        Dim lstAutores As New List(Of AutorEN)
        Dim valida As New AutorLN
        lstAutores = valida.obtenerTodosAutores

        cboAutor.DataSource = lstAutores
        cboAutor.DisplayMember = "NombreAutor" 'Propiedad EN (Visualiza)
        cboAutor.ValueMember = "CodAutor" 'Propiedad EN (Valor Interno)



    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click

        Try
            Dim miLib As New LibroEN()
            miLib.ISBN = txtISBN.Text
            miLib.TituloCompleto = txtNombre.Text
            miLib.Editorial = txtEditorial.Text
            miLib.Categoria = txtCategoria.Text
            miLib.FecPublicacion = dtpFecPublicacion.Text
            miLib.Pais = cboPais.Text
            miLib.Descripcion = txtDescripcion.Text
            miLib.CodAutor = cboAutor.SelectedValue

            Dim valida As New LibroLN
            valida.InsertarLibro(miLib)
            MessageBox.Show("El Libro ha sido Creado con Exito!")

            txtISBN.Clear()
            txtEditorial.Clear()
            txtNombre.Clear()
            txtCategoria.Clear()
            dtpFecPublicacion.ResetText()
            txtDescripcion.Clear()
            cboPais.ResetText()
            cboPais.ResetText()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        txtISBN.Clear()
        txtEditorial.Clear()
        txtNombre.Clear()
        btnInsertar.Enabled = False

        Try
            Dim strISBN As String
            strISBN = InputBox("Digite el ISBN del Libro a buscar")

            Dim miLib As LibroEN = Nothing

            Dim valida As New LibroLN
            miLib = valida.ObtenerLibroPorISBN(strISBN)

            If Not IsNothing(miLib) Then
                txtISBN.Text = miLib.ISBN
                txtNombre.Text = miLib.TituloCompleto
                txtEditorial.Text = miLib.Editorial
                txtCategoria.Text = miLib.Categoria
                dtpFecPublicacion.Text = miLib.FecPublicacion
                cboPais.Text = miLib.Pais
                txtCategoria.Text = miLib.Categoria
                txtDescripcion.Text = miLib.Descripcion
                miLib.CodAutor = cboAutor.SelectedValue

                btnModificar.Enabled = True
                btnBorrar.Enabled = True
            Else
                MessageBox.Show("No existe")
                btnInsertar.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim miLib As New LibroEN()
            miLib.ISBN = txtISBN.Text
            miLib.TituloCompleto = txtNombre.Text
            miLib.Editorial = txtEditorial.Text
            miLib.Categoria = txtCategoria.Text
            miLib.FecPublicacion = dtpFecPublicacion.Text
            miLib.Pais = cboPais.Text
            miLib.Descripcion = txtDescripcion.Text
            miLib.CodAutor = cboAutor.SelectedValue

            Dim valida As New LibroLN
            valida.ModificarLibro(miLib)
            MessageBox.Show("El Libro ha sido Modificado con Exito!")

            txtISBN.Clear()
            txtEditorial.Clear()
            txtNombre.Clear()
            txtCategoria.Clear()
            dtpFecPublicacion.ResetText()
            txtDescripcion.Clear()
            cboPais.ResetText()
            cboPais.ResetText()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnInsertar.Enabled = True
        btnModificar.Enabled = False
        btnBorrar.Enabled = False
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        Try
            Dim miLib As New LibroEN()
            miLib.ISBN = txtISBN.Text
            miLib.TituloCompleto = txtNombre.Text
            miLib.Editorial = txtEditorial.Text
            miLib.Categoria = txtCategoria.Text
            miLib.FecPublicacion = dtpFecPublicacion.Text
            miLib.Pais = cboPais.Text
            miLib.Descripcion = txtDescripcion.Text
            miLib.CodAutor = cboAutor.SelectedValue

            Dim valida As New LibroLN

            Dim intOption As Integer
            intOption = MessageBox.Show("Realmente Desea Eliminar el Libro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If intOption = 6 Then
                valida.BorrarLibro(miLib)
                txtISBN.Clear()
                txtEditorial.Clear()
                txtNombre.Clear()
                txtCategoria.Clear()
                dtpFecPublicacion.ResetText()
                txtDescripcion.Clear()
                cboPais.ResetText()
                cboPais.ResetText()

                MessageBox.Show("El Libro ha sido Eliminado con Exito!")
                btnInsertar.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnModificar.Enabled = False
        btnBorrar.Enabled = False
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        txtISBN.Clear()
        txtEditorial.Clear()
        txtNombre.Clear()
        txtCategoria.Clear()
        btnInsertar.Enabled = True
        dtpFecPublicacion.ResetText()
        txtDescripcion.Clear()
        cboPais.ResetText()
        cboPais.ResetText()


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnModificar.Enabled = False
        btnBorrar.Enabled = False
    End Sub
End Class