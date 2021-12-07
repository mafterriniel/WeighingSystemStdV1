Public NotInheritable Class ReportingService
    Public Shared Sub PrintSlip(ticketType As TicketTypeEnum, receiptNum As String)
        Try

            Dim repotFile As String = Application.StartupPath & "\Reports\" & "TcktInOutAll.rpt"

            Dim RR = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            RR.Load(repotFile)

            Dim sysSettings = New settings()
            sysSettings.Load()
            RR.DataDefinition.FormulaFields.Item("unitweight").Text = "'" & sysSettings.UnitWeight & "'"
            RR.DataDefinition.FormulaFields.Item("DeductUnit").Text = "'" & sysSettings.DeductUnit & "'"
            RR.DataDefinition.FormulaFields.Item("TicketType").Text = "'" & ticketType.ToString() & "'"

            Using conn As OleDb.OleDbConnection = New OleDb.OleDbConnection(DBContextFactory.GetConnectionString())
                conn.Open()

                Dim ds As ds = New ds()
                Dim da As New OleDb.OleDbDataAdapter
                Dim cmd As OleDb.OleDbCommand

                Dim Src As String =
            "SELECT " &
            "(SELECT CUSTNAME FROM CUST_TBL WHERE CUSTCODE = CustomerCode) AS CustomerName" &
              ",(SELECT CUSTAddr FROM CUST_TBL WHERE CUSTCODE = CustomerCode) AS CustomerAddress" &
",(SELECT SUPNAME FROM SUP_TBL WHERE SUPCODE =SupplierCode) AS SupplierName" &
",(SELECT SupAddr FROM SUP_TBL WHERE SUPCODE =SupplierCode) AS SupplierAddress" &
",(SELECT COMMDESC FROM COMM_TBL WHERE COMMCODE = CommodityCode) AS CommodityDesc" &
",(SELECT PRICING FROM COMM_TBL WHERE COMMCODE = CommodityCode) AS CommodityPrice" &
",(SELECT USER_DISPLAYNAME FROM USERACCOUNTS WHERE User_id = WeigherIn) WeigherInName" &
",(SELECT USER_DISPLAYNAME FROM USERACCOUNTS WHERE User_id = WeigherOut) WeigherOutName" &
",* FROM OUTBOUND_TBL where RefNo = '" & receiptNum & "'"
                cmd = New OleDb.OleDbCommand(Src, conn)
                da = New OleDb.OleDbDataAdapter(cmd)
                da.Fill(ds, "Outbound_Tbl")


                Dim companyProfileQry = "SELECT  FROM CompanyProfile"
                cmd = New OleDb.OleDbCommand(companyProfileQry, conn)
                da = New OleDb.OleDbDataAdapter(cmd)
                da.Fill(ds, "CompanyProfile")

                RR.SetDataSource(ds)
                RR.PrintOptions.PrinterName = GetDefaultPrinter()
                '  RR.SaveAs(Application.StartupPath & "\Reports\tmp.rpt")
                'Dim margins As CrystalDecisions.Shared.PageMargins

                'margins = RR.PrintOptions.PageMargins
                'margins.bottomMargin = 0
                'margins.leftMargin = 0
                'margins.rightMargin = 0.0
                'margins.topMargin = 100
                'RR.PrintOptions.ApplyPageMargins(margins)
                Dim printPrompt As New Windows.Forms.PrintDialog
                printPrompt.PrinterSettings = New System.Drawing.Printing.PrinterSettings
                printPrompt.AllowSomePages = True '
                'printPrompt.PrinterSettings.PrinterName = "Send To OneNote 2013"
                ' printPrompt.PrinterSettings.PrinterName = "Microsoft XPS Document Writer"

                printPrompt.PrinterSettings.DefaultPageSettings.Margins.Bottom = 0
                printPrompt.PrinterSettings.DefaultPageSettings.Margins.Top = 0
                printPrompt.PrinterSettings.DefaultPageSettings.Margins.Left = 0
                printPrompt.PrinterSettings.DefaultPageSettings.Margins.Right = 0
                RR.Refresh()
                RR.PrintToPrinter(printPrompt.PrinterSettings, printPrompt.PrinterSettings.DefaultPageSettings, False)
                RR.Close()
                RR.Dispose()
                '  RR.PrintToPrinter(1, False, 0, 0)
                'RR.SaveAs(Application.StartupPath & "\Reports\tmp.rpt")

            End Using

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Shared Function GetDefaultPrinter() As String
        Dim Result As String = ""

        Dim _SEARCHER = New System.Management.ManagementObjectSearcher(
    "Select * from  Win32_Printer")

        For Each _QUERYJOB As System.Management.ManagementObject In _SEARCHER.Get()
            If _QUERYJOB("Default") = True Then
                Result = _QUERYJOB("Caption")
            End If
        Next
        Return Result
    End Function

End Class
