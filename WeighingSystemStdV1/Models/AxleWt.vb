Public Class AxleResult

    Public Sub New(Num As Integer, Weight As Decimal, DateCaptured As Nullable(Of DateTime))
        Me.Num = Num
        Me.Weight = Weight
        Me.DateCaptured = DateCaptured
    End Sub

    Public Num As Integer
    Public Weight As Decimal
    Public DateCaptured As Nullable(Of DateTime)
End Class
