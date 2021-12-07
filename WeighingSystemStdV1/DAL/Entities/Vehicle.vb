Public Class Vehicle
    Private _plateNo As String
    Public Property PlateNo() As String
        Get
            Return _plateNo
        End Get
        Set(ByVal value As String)
            _plateNo = value
        End Set
    End Property

    Private _Prev_Tare As Double
    Public Property Prev_TareWt() As Double
        Get
            Return _Prev_Tare
        End Get
        Set(ByVal value As Double)
            _Prev_Tare = value
        End Set
    End Property

    Private _DriverName As String
    Public Property DriverName() As String
        Get
            Return _DriverName
        End Get
        Set(ByVal value As String)
            _DriverName = value
        End Set
    End Property

    Private _CustCode As String
    Public Property CustCode() As String
        Get
            Return _CustCode
        End Get
        Set(ByVal value As String)
            _CustCode = value
        End Set
    End Property

    Private _SupCode As String
    Public Property SupCode() As String
        Get
            Return _SupCode
        End Get
        Set(ByVal value As String)
            _SupCode = value
        End Set
    End Property

    Private _HaulerCode As String
    Public Property HaulerCode() As String
        Get
            Return _HaulerCode
        End Get
        Set(ByVal value As String)
            _HaulerCode = value
        End Set
    End Property

    Private _PActive As Boolean
    Public Property PActive() As Boolean
        Get
            Return _PActive
        End Get
        Set(ByVal value As Boolean)
            _PActive = value
        End Set
    End Property
End Class
