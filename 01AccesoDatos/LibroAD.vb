Imports _03Entidades
Imports System.Data.OleDb
Public Class LibroAD
    Dim miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Biblioteca.accdb")

    Public Sub InsertarLibro(ByVal pLibro As LibroEN)
        Try

            Dim SQL_INSERT_Libro As String = "INSERT INTO LibroS (ISBN, TituloCompleto, Editorial, Categoria, FecPublicacion, Pais, Descripcion, CodAutor) VALUES (@ISBN, @TituloCompleto, @Editorial, @Categoria, @FecPublicacion, @Pais, @Descripcion, @CodAutor)"

            miConexion.Open()

            Dim cmdLibro As New OleDbCommand(SQL_INSERT_Libro, miConexion)

            cmdLibro.Parameters.Add("@ISBN", OleDbType.VarChar).Value = pLibro.ISBN
            cmdLibro.Parameters.Add("@TituloCompleto", OleDbType.VarChar).Value = pLibro.TituloCompleto
            cmdLibro.Parameters.Add("@Editorial", OleDbType.VarChar).Value = pLibro.Editorial
            cmdLibro.Parameters.Add("@Categoria", OleDbType.VarChar).Value = pLibro.Categoria
            cmdLibro.Parameters.Add("@FecPublicacion", OleDbType.Date).Value = pLibro.FecPublicacion
            cmdLibro.Parameters.Add("@Pais", OleDbType.VarChar).Value = pLibro.Pais
            cmdLibro.Parameters.Add("@Descripcion", OleDbType.VarChar).Value = pLibro.Descripcion
            cmdLibro.Parameters.Add("@CodAutor", OleDbType.VarChar).Value = pLibro.CodAutor

            cmdLibro.ExecuteNonQuery()

            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarLibro(ByVal pLibro As LibroEN)
        Try
            Dim SQL_UPDATE_Libro As String = "UPDATE LibroS SET  TituloCompleto=@TituloCompleto, Editorial=@Editorial, Categoria=@Categoria, FecPublicacion=@FecPublicacion, Pais=@Pais, Descripcion=@Descripcion, CodAutor=@CodAutor WHERE ISBN=@ISBN"
            miConexion.Open()

            Dim cmdLibro As New OleDbCommand(SQL_UPDATE_Libro, miConexion)

            cmdLibro.Parameters.Add("@TituloCompleto", OleDbType.VarChar).Value = pLibro.TituloCompleto
            cmdLibro.Parameters.Add("@Editorial", OleDbType.VarChar).Value = pLibro.Editorial
            cmdLibro.Parameters.Add("@Categoria", OleDbType.VarChar).Value = pLibro.Categoria
            cmdLibro.Parameters.Add("@FecPublicacion", OleDbType.Date).Value = pLibro.FecPublicacion
            cmdLibro.Parameters.Add("@Pais", OleDbType.VarChar).Value = pLibro.Pais
            cmdLibro.Parameters.Add("@Descripcion", OleDbType.VarChar).Value = pLibro.Descripcion
            cmdLibro.Parameters.Add("@CodAutor", OleDbType.VarChar).Value = pLibro.CodAutor
            cmdLibro.Parameters.Add("@ISBN", OleDbType.VarChar).Value = pLibro.ISBN

            cmdLibro.ExecuteNonQuery()

            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarLibro(ByVal pLibro As LibroEN)
        Try
            Dim SQL_BORRAR_Libro As String = "DELETE FROM LibroS WHERE ISBN=@ISBN"
            miConexion.Open()

            Dim cmdLibro As New OleDbCommand(SQL_BORRAR_Libro, miConexion)
            cmdLibro.Parameters.Add("@ISBN", OleDbType.VarChar).Value = pLibro.ISBN
            cmdLibro.ExecuteNonQuery()
            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerLibroPorISBN(ByVal pISBN As String) As LibroEN
        Try

            Dim SQL_OBTENER_UN_Libro As String = "SELECT ISBN, TituloCompleto, Editorial, Categoria, FecPublicacion, Pais, Descripcion, CodAutor FROM Libros WHERE ISBN=@ISBN"
            miConexion.Open()

            Dim cmdLibro As New OleDbCommand(SQL_OBTENER_UN_Libro, miConexion)
            cmdLibro.Parameters.Add("@ISBN", OleDbType.VarChar).Value = pISBN
            Dim drLibro As OleDbDataReader
            drLibro = cmdLibro.ExecuteReader()
            Dim miLibro As LibroEN = Nothing
            While drLibro.Read
                miLibro = New LibroEN
                miLibro.ISBN = drLibro("ISBN")
                miLibro.TituloCompleto = drLibro("TituloCompleto")
                miLibro.Editorial = drLibro("Editorial")
                miLibro.Categoria = drLibro("Categoria")
                miLibro.Pais = drLibro("Pais")
                miLibro.FecPublicacion = drLibro("FecPublicacion")
                miLibro.Descripcion = drLibro("Descripcion")
                miLibro.CodAutor = drLibro("CodAutor")
            End While
            drLibro.Close()
            miConexion.Close()
            Return miLibro
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosLibros() As List(Of LibroEN)
        Try
            Dim SQL_OBTENER_LibroS As String = "SELECT ISBN, TituloCompleto, Editorial, Categoria, FecPublicacion, Pais, Descripcion, CodAutor FROM Libros"
            miConexion.Open()

            Dim cmdLibro As New OleDbCommand(SQL_OBTENER_LibroS, miConexion)

            Dim drLibro As OleDbDataReader
            drLibro = cmdLibro.ExecuteReader()

            Dim lstLibros As New List(Of LibroEN)

            While drLibro.Read
                Dim miLibro As New LibroEN
                miLibro.ISBN = drLibro("ISBN")
                miLibro.TituloCompleto = drLibro("TituloCompleto")
                miLibro.Editorial = drLibro("Editorial")
                miLibro.Categoria = drLibro("Categoria")
                miLibro.Pais = drLibro("Pais")
                miLibro.FecPublicacion = drLibro("FecPublicacion")
                miLibro.Descripcion = drLibro("Descripcion")
                miLibro.Descripcion = drLibro("CodAutor")
                lstLibros.Add(miLibro)
            End While
            drLibro.Close()
            miConexion.Close()
            Return lstLibros

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
End Class
