Public Class AutorEN
#Region "Atributos"
    Dim _CodAutor As String
    Dim _NombreAutor As String
    Dim _Nacionalidad As String

#End Region

#Region "Constructores"
    ''' <summary>
    ''' Constructor vacio del objeto
    ''' </summary>
    Public Sub New()
        _CodAutor = String.Empty
        _NombreAutor = String.Empty
        _Nacionalidad = String.Empty


    End Sub

    ''' <summary>
    ''' Recibe todos los datos
    ''' </summary>
    ''' <param name="pCodAutor">Nombre de Usuario</param>
    ''' <param name="pNombreAutor">Nombre Completo</param>
    ''' <param name="pNacionalidad">Fecha de ingreso a la empresa</param>

    Public Sub New(ByVal pCodAutor As String,
                   ByVal pNombreAutor As String,
                   ByVal pNacionalidad As Date)

        _CodAutor = pCodAutor
        _NombreAutor = pNombreAutor
        _Nacionalidad = pNacionalidad

    End Sub

#End Region

#Region "Propiedades"
    Public Property CodAutor As String
        Set(value As String)
            _CodAutor = value
        End Set
        Get
            Return _CodAutor
        End Get
    End Property
    Public Property NombreAutor As String
        Set(value As String)
            _NombreAutor = value
        End Set
        Get
            Return _NombreAutor
        End Get
    End Property
    Public Property Nacionalidad As String
        Set(value As String)
            _Nacionalidad = value
        End Set
        Get
            Return _Nacionalidad
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
            "Login: " & _CodAutor & vbCrLf &
            "Clave: " & _NombreAutor & vbCrLf &
            "Nombre completo: " & _Nacionalidad & vbCrLf

        Return strDatos

    End Function


#End Region



End Class
