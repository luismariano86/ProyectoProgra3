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
        cboAutor.Text = ""
        'Cuadro de texto = text, en combo = selectedvalue


    End Sub
End Class