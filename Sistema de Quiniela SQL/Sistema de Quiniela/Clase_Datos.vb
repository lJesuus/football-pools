
Public Class Clase_Datos
#Region "REGISTRO"
    Private _NOM_USUARIO As String
    Private _CEDULA As Integer
    Private _NOMBRES As String
    Private _APELLIDOS As String
    Private _EMAIL As String
    Private _PASSWORD As String

    Public Property NOM_USUARIO() As String
        Get
            Return _NOM_USUARIO
        End Get
        Set(ByVal value As String)
            _NOM_USUARIO = value
        End Set
    End Property

    Public Property CEDULA() As Integer
        Get
            Return _CEDULA
        End Get
        Set(ByVal value As Integer)
            _CEDULA = value
        End Set
    End Property

    Public Property NOMBRES() As String
        Get
            Return _NOMBRES
        End Get
        Set(ByVal value As String)
            _NOMBRES = value
        End Set
    End Property

    Public Property APELLIDOS() As String
        Get
            Return _APELLIDOS
        End Get
        Set(ByVal value As String)
            _APELLIDOS = value
        End Set
    End Property

    Public Property EMAIL() As String
        Get
            Return _EMAIL
        End Get
        Set(ByVal value As String)
            _EMAIL = value
        End Set
    End Property

    Public Property PASSWORD() As String
        Get
            Return _PASSWORD
        End Get
        Set(ByVal value As String)
            _PASSWORD = value
        End Set
    End Property
#End Region
End Class
