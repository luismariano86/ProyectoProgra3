Public Class ClienteEN

#Region "Atributos"
    Dim _Cedula As String
    Dim _Telefono As String
    Dim _DireccionExacta As String
    Dim _NombreCompleto As String
    Dim _FecNacimiento As Date
    Dim _FecRegistro As Date
#End Region

#Region "Constructores"
    ''' <summary>
    ''' Constructor vacio del objeto
    ''' </summary>
    Public Sub New()
        _Cedula = String.Empty
        _Telefono = String.Empty
        _DireccionExacta = String.Empty
        _NombreCompleto = String.Empty
        _FecNacimiento = CType("01/01/1900", Date)
        _FecRegistro = CType("01/01/1900", Date)

    End Sub

    ''' <summary>
    ''' Recibe todos los datos
    ''' </summary>
    ''' <param name="pCedula">Nombre de Usuario</param>
    ''' <param name="pTelefono">Nombre de Usuario</param>
    ''' <param name="pDireccionExacta">Nombre Completo</param>
    ''' <param name="pNombreCompleto">Fecha de ingreso a la empresa</param>
    ''' <param name="pFecNacimiento">Horas trabajadas en la semana</param>
    ''' <param name="pFecRegistro">Precio de cada hora</param>

    Public Sub New(ByVal pCedula As String,
                   ByVal pTelefono As String,
                   ByVal pDireccionExacta As String,
                   ByVal pNombreCompleto As Date,
                   ByVal pFecNacimiento As Date,
                   ByVal pFecRegistro As Date)

        _Cedula = pCedula
        _Telefono = pTelefono
        _DireccionExacta = pDireccionExacta
        _NombreCompleto = pNombreCompleto
        _FecNacimiento = pFecNacimiento
        _FecRegistro = pFecRegistro

    End Sub

#End Region

#Region "Propiedades"
    Public Property Cedula As String
        Set(value As String)
            _Cedula = value
        End Set
        Get
            Return _Cedula
        End Get
    End Property
    Public Property Telefono As String
        Set(value As String)
            _Telefono = value
        End Set
        Get
            Return _Telefono
        End Get
    End Property
    Public Property DireccionExacta As String
        Set(value As String)
            _DireccionExacta = value
        End Set
        Get
            Return _DireccionExacta
        End Get
    End Property
    Public Property NombreCompleto As String
        Set(value As String)
            _NombreCompleto = value
        End Set
        Get
            Return _NombreCompleto
        End Get
    End Property
    Public Property FecRegistro As Date
        Set(value As Date)
            _FecNacimiento = value
        End Set
        Get
            Return _FecNacimiento
        End Get
    End Property
    Public Property FecNacimiento As Date
        Set(value As Date)
            _FecRegistro = value
        End Set
        Get
            Return _FecRegistro
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
            "Cedula: " & _Cedula & vbCrLf &
            "Telefono: " & _Telefono & vbCrLf &
            "DireccionExacta: " & _DireccionExacta & vbCrLf &
            "Nombre completo: " & _NombreCompleto & vbCrLf &
            "Administrador del Sistema: " & IIf(_FecNacimiento.ToShortDateString, "Es Administrador", "No es Administrador") &
            "Nivel Bibliotecario: " & IIf(_FecRegistro.ToShortDateString, "Activo", "Renuncio")

        Return strDatos

    End Function


#End Region


End Class
