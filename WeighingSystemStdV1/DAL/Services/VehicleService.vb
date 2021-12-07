Public NotInheritable Class VehicleService
    Public Shared Sub Create(vehicle As Vehicle)
        Dim qry = "INSERT INTO Vehicle_Tbl (PlateNo, Prev_tareWt, DriverName, PActive) VALUES(" &
                            "'" & Trim(vehicle.PlateNo) & "'" &
                               ",'" & vehicle.Prev_TareWt & "'" &
                                ",'" & vehicle.DriverName & "'" &
                                  "," & vehicle.PActive & ")"

        DBContextFactory.Query(qry)
    End Sub

    Public Shared Function GetByPlateNo(plateNo As String) As Vehicle
        Dim qry = $"SELECT * FROM Vehicle_Tbl WHERE PlateNo = '{plateNo}'"

        Dim rd = DBContextFactory.Execute(qry)

        Dim vehicle As Vehicle = Nothing
        If (rd.Tables(0).Rows.Count) > 0 Then
            vehicle = New Vehicle()
            Dim dataRow As DataRow = rd.Tables(0).Rows(0)
            vehicle.PlateNo = dataRow.Field(Of String)("PlateNo")
            vehicle.Prev_TareWt = dataRow.Field(Of Double)("Prev_TareWt")
            vehicle.DriverName = dataRow.Field(Of String)("DriverName")
            vehicle.CustCode = dataRow.Field(Of String)("CustCode")
            vehicle.SupCode = dataRow.Field(Of String)("SupCode")
            vehicle.HaulerCode = dataRow.Field(Of String)("HaulerCode")
            vehicle.PActive = dataRow.Field(Of Boolean)("PActive")
        End If

        Return vehicle
    End Function


    Public Shared Sub Update(vehicle As Vehicle)

        Dim qry = $"UPDATE Vehicle_Tbl set DriverName= '{Trim(vehicle.DriverName)}'" &
                    $",CustCode = '{vehicle.CustCode}'" &
                $",SupCode = '{vehicle.SupCode}'" &
               $" where PlateNo = '{vehicle.PlateNo}'"

        DBContextFactory.Query(qry)
    End Sub

    Public Shared Sub UpdateTare(plateNo As String, prev_tare As Decimal)
        Dim qry = $"UPDATE Vehicle_Tbl SET Prev_tareWt = {Trim(prev_tare)}" &
                    $" WHERE PlateNo = '{Trim(plateNo)}'"

        DBContextFactory.Query(qry)
    End Sub


    Public Shared Function ValidateTareWt(plateNo As String, tareWt As Decimal) As Boolean
        Dim vehicle = GetByPlateNo(plateNo)
        If (IsNothing(vehicle)) Then Return True

        Dim tareWtTol = DBContextGlobalVariable.SysSettings.TareWtTolerance

        If (tareWtTol = 0) Then Return True
        If (vehicle.Prev_TareWt = 0) Then) Return True

        Dim minTol = vehicle.Prev_TareWt - (vehicle.Prev_TareWt * (tareWtTol / 100))
        Dim maxTol = vehicle.Prev_TareWt + (vehicle.Prev_TareWt * (tareWtTol / 100))

        If (tareWt >= minTol And tareWt <= maxTol) Then Return True

        Return False

    End Function
End Class
