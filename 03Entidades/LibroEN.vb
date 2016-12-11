Public Class LibroEN
#Region "Atributos"
    Dim _ISBN As String
    Dim _TituloCompleto As String
    Dim _Editorial As String
    Dim _Categoria As String
    Dim _FecPublicacion As Date
    Dim _Pais As String
    Dim _Descripcion As String
    Dim _CodAutor As String
#End Region

#Region "Constructores"
    ''' <summary>
    ''' Constructor vacio del objeto
    ''' </summary>
    Public Sub New()
        _ISBN = String.Empty
        _TituloCompleto = String.Empty
        _Editorial = String.Empty
        _Categoria = String.Empty
        _FecPublicacion = CType("01/01/1900", Date)
        _Pais = String.Empty
        _Descripcion = String.Empty
        _CodAutor = String.Empty

    End Sub

    ''' <summary>
    ''' Recibe todos los datos
    ''' </summary>
    ''' <param name="pISBN">Nombre de Usuario</param>
    ''' <param name="pTituloCompleto">Nombre de Usuario</param>
    ''' <param name="pEditorial">Nombre Completo</param>
    ''' <param name="pCategoria">Fecha de ingreso a la empresa</param>
    ''' <param name="pFecPublicacion">Horas trabajadas en la semana</param>
    ''' <param name="pFecRegistro">Precio de cada hora</param>
    ''' <param name="pPais">Precio de cada hora</param>
    ''' <param name="pDescripcion">Precio de cada hora</param>
    ''' <param name="pCodAutor">Precio de cada hora</param>

    Public Sub New(ByVal pISBN As String,
                   ByVal pTituloCompleto As String,
                   ByVal pEditorial As String,
                   ByVal pCategoria As Date,
                   ByVal pFecPublicacion As Date,
                   ByVal pFecRegistro As Date,
                   ByVal pPais As Date,
                   ByVal pDescripcion As Date,
                   ByVal pCodAutor As Date)

        _ISBN = pISBN
        _TituloCompleto = pTituloCompleto
        _Editorial = pEditorial
        _Categoria = pCategoria
        _FecPublicacion = pFecPublicacion
        _Pais = pPais
        _Descripcion = pDescripcion
        _CodAutor = pCodAutor

    End Sub

#End Region

#Region "Propiedades"
    Public Property ISBN As String
        Set(value As String)
            _ISBN = value
        End Set
        Get
            Return _ISBN
        End Get
    End Property
    Public Property TituloCompleto As String
        Set(value As String)
            _TituloCompleto = value
        End Set
        Get
            Return _TituloCompleto
        End Get
    End Property
    Public Property Editorial As String
        Set(value As String)
            _Editorial = value
        End Set
        Get
            Return _Editorial
        End Get
    End Property
    Public Property Categoria As String
        Set(value As String)
            _Categoria = value
        End Set
        Get
            Return _Categoria
        End Get
    End Property
    Public Property FecPublicacion As Date
        Set(value As Date)
            _FecPublicacion = value
        End Set
        Get
            Return _FecPublicacion
        End Get
    End Property

    Public Property Pais As String
        Set(value As String)
            _Pais = value
        End Set
        Get
            Return _Pais
        End Get
    End Property

    Public Property Descripcion As String
        Set(value As String)
            _Descripcion = value
        End Set
        Get
            Return _Descripcion
        End Get
    End Property

    Public Property CodAutor As String
        Set(value As String)
            _CodAutor = value
        End Set
        Get
            Return _CodAutor
        End Get
    End Property

#End Region

#Region "Metodos"
    ''' <summary>
    ''' Cadena con los valores del objeto
    ''' </summary>
    ''' <returns>Cadena con los valores del objeto</returns>
    Public Overrides Function ToString() As String
        Dim strDatos As String

        strDatos =
            "ISBN: " & _ISBN & vbCrLf &
            "TituloCompleto: " & _TituloCompleto & vbCrLf &
            "Editorial: " & _Editorial & vbCrLf &
            "Categoria: " & _Categoria & vbCrLf &
            "Fecha de Publicacion: " & _FecPublicacion.ToShortDateString &
            "Pais: " & _Pais & vbCrLf &
            "Descripcion: " & _Descripcion & vbCrLf &
            "Codigo Autor: " & _CodAutor & vbCrLf

        Return strDatos

    End Function


#End Region
End Class
