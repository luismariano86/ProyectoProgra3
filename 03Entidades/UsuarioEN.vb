Public Class UsuarioEN

#Region "Atributos"

    Dim _Nombre_completo As String
    Dim _Ind_Administrador As Boolean
    Dim _Ind_Bibliotecario As Boolean
    Dim _Ind_Activo As Boolean
#End Region

#Region "Constructores"
    ''' <summary>
    ''' Constructor vacio del objeto
    ''' </summary>
    Public Sub New()

    End Sub

    ''' <summary>
    ''' Recibe todos los datos
    ''' </summary>
    ''' <param name="pCedula">Id del Cliente</param>
    ''' <param name="pNombre">Nombre Completo</param>
    ''' <param name="pFecha">Fecha de ingreso a la empresa</param>
    ''' <param name="pHoras">Horas trabajadas en la semana</param>
    ''' <param name="pPrecio">Precio de cada hora</param>
    ''' <param name="pActivo">Indica si esta activo el empleado</param>
    Public Sub New(ByVal pCedula As String,
                   ByVal pNombre As String,
                   ByVal pFecha As Date,
                   ByVal pHoras As Integer,
                   ByVal pPrecio As Double,
                   ByVal pActivo As Boolean)


    End Sub

#End Region

    Public Property Login As String
    Public Property Clave As String
    Public Property Nombre As String
    Public Property Bibliotecario As Boolean
    Public Property Administrador As Boolean
    Public Property Activo As Boolean





End Class
