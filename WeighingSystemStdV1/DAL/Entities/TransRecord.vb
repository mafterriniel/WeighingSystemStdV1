Public Class TransRecord
    Private _RefNo As String
    Public Property RefNo() As String
        Get
            Return _RefNo
        End Get
        Set(ByVal value As String)
            _RefNo = value
        End Set
    End Property

    Private _PlateNo As String
    Public Property PlateNo() As String
        Get
            Return _PlateNo
        End Get
        Set(ByVal value As String)
            _PlateNo = value
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

    Private _CommodityCode As String
    Public Property CommodityCode() As String
        Get
            Return _CommodityCode
        End Get
        Set(ByVal value As String)
            _CommodityCode = value
        End Set
    End Property

    Private _WeigherIn As String
    Public Property WeigherIn() As String
        Get
            Return _WeigherIn
        End Get
        Set(ByVal value As String)
            _WeigherIn = value
        End Set
    End Property


    Private _WeigherOut As String
    Public Property WeigherOut() As String
        Get
            Return _WeigherOut
        End Get
        Set(ByVal value As String)
            _WeigherOut = value
        End Set
    End Property
End Class
