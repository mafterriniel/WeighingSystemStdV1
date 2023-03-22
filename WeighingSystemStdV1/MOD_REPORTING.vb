Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Printing
Imports System.Linq
Imports System.Net.Sockets
Imports WeightDev.Enums

Module MOD_REPORTING
    Public Sub PrintToPrinter__OLD(ByVal ReportFile As String, ByVal SelectionFormula As String,
                          ByVal RR As CrystalDecisions.CrystalReports.Engine.ReportDocument, Optional ByVal refno As String = "")
        Try
            Dim SysSettings As New settings
            SysSettings.Load()
            If IsNothing(RR) Then
                RR = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                RR.Load(ReportFile)
                'SetConnectionString(RR)
                'RR.RecordSelectionFormula = SelectionFormula
            End If


            Dim dds As ds = New ds()
            Dim outbount_tbl As String = "Select * from Outbound_tbl where refno = '" & refno & "'"
            Dim comm_tbl As String = ""
            Dim sup_tbl As String = ""
            Dim cust_tbl As String = ""
            Dim useraccounts1 As String = ""
            Dim useraccounts2 As String = ""
            Dim compnyProf As String = ""
            Dim sa As New OleDb.OleDbDataAdapter


            RR.DataDefinition.FormulaFields.Item("unitweight").Text = "'" & SysSettings.UnitWeight & "'"
            RR.DataDefinition.FormulaFields.Item("DeductUnit").Text = "'" & SysSettings.DeductUnit & "'"
            RR.DataDefinition.FormulaFields.Item("TicketType").Text = "'" & SysSettings.DeductUnit & "'"
            'RR.DataDefinition.FormulaFields.Item("unitweight").Text = "'" & SysSettings.UnitWeight & "'"

            If String.IsNullOrEmpty(refno).Equals(False) Then
                Dim Src As String =
            "SELECT " &
            "(SELECT CUSTNAME FROM CUST_TBL WHERE CUSTCODE = CustomerCode)" &
              ",(SELECT CUSTAddr FROM CUST_TBL WHERE CUSTCODE = CustomerCode)" &
",(SELECT SUPNAME FROM SUP_TBL WHERE SUPCODE =SupplierCode)" &
",(SELECT SupAddr FROM SUP_TBL WHERE SUPCODE =SupplierCode)" &
",(SELECT COMMDESC FROM COMM_TBL WHERE COMMCODE = CommodityCode)" &
",(SELECT PRICING FROM COMM_TBL WHERE COMMCODE = CommodityCode)" &
",(SELECT USER_DISPLAYNAME FROM USERACCOUNTS WHERE User_id = WeigherIn),* FROM OUTBOUND_TBL where RefNo = '" & refno & "'"
                Dim cls As New CLS_OLE_DB
                cls.CONNECTION = OLEDBCONX
                cls.Source = Src
                cls.OpenSource()
                Dim gr As String = 0
                Dim tr As String = 0
                Dim nt As String = 0
                Dim dtout As String = 0
                Dim tbl As New DataTable()

                With cls.DATAREADER
                    If .HasRows Then
                        While .Read
                            comm_tbl = "select * from  comm_tbl where  COMMCODE = '" & .Item("CommodityCode") & "'"
                            sup_tbl = "select * from  sup_tbl where  supcode = '" & .Item("supplierCode") & "'"
                            cust_tbl = "select * from  cust_tbl where  custcode = '" & .Item("customerCode") & "'"
                            useraccounts1 = "select * from  useraccounts where  user_id = '" & .Item("WeigherIn") & "'"
                            useraccounts2 = "select * from  useraccounts where  user_id = '" & .Item("WeigherOut") & "'"
                            compnyProf = "select * from companyProfile"
                        End While
                        .Close()

                        sa = New OleDb.OleDbDataAdapter(comm_tbl, OLEDBCONX)
                        sa.Fill(dds, "Comm_Tbl")

                        sa = New OleDb.OleDbDataAdapter(outbount_tbl, OLEDBCONX)
                        sa.Fill(dds, "Outbound_tbl")


                        sa = New OleDb.OleDbDataAdapter(sup_tbl, OLEDBCONX)
                        sa.Fill(dds, "sup_tbl")

                        sa = New OleDb.OleDbDataAdapter(cust_tbl, OLEDBCONX)
                        sa.Fill(dds, "cust_tbl")

                        sa = New OleDb.OleDbDataAdapter(useraccounts1, OLEDBCONX)
                        sa.Fill(dds, "useraccounts")

                        sa = New OleDb.OleDbDataAdapter(useraccounts2, OLEDBCONX)
                        sa.Fill(dds, "useraccounts_1")

                        sa = New OleDb.OleDbDataAdapter(compnyProf, OLEDBCONX)
                        sa.Fill(dds, "CompanyProfile")
                    End If
                End With
            End If


            RR.SetDataSource(dds)
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
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    Public Sub PrintToPrinter(ticketType As TicketTypeEnum, Optional ByVal refno As String = "")
        Try
            Dim SysSettings As New settings
            SysSettings.Load()

            Dim repotFile As String = String.Empty
            If (SysSettings.WeighingMode = WeighingModeEnum.STANDARD.ToString()) Then
                repotFile = Application.StartupPath & "\Reports\" & "TcktStd.rpt"
            ElseIf (SysSettings.WeighingMode = WeighingModeEnum.AXLE.ToString()) Then
                repotFile = Application.StartupPath & "\Reports\" & "TcktAxle.rpt"
            End If

            Dim RR = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            RR.Load(repotFile)

            Dim dds As ds = New ds()
            Dim outbount_tbl As String = "Select * from Outbound_tbl where refno = '" & refno & "'"
            Dim comm_tbl As String = ""
            Dim sup_tbl As String = ""
            Dim cust_tbl As String = ""
            Dim useraccounts1 As String = ""
            Dim useraccounts2 As String = ""
            Dim compnyProf As String = ""
            Dim sa As New OleDb.OleDbDataAdapter


            RR.DataDefinition.FormulaFields.Item("unitweight").Text = "'" & SysSettings.UnitWeight & "'"
            RR.DataDefinition.FormulaFields.Item("DeductUnit").Text = "'" & SysSettings.DeductUnit & "'"
            RR.DataDefinition.FormulaFields.Item("TicketType").Text = "'" & ticketType.ToString() & "'"

            If String.IsNullOrEmpty(refno).Equals(False) Then
                Dim Src As String =
            "SELECT " &
            "(SELECT CUSTNAME FROM CUST_TBL WHERE CUSTCODE = CustomerCode)" &
              ",(SELECT CUSTAddr FROM CUST_TBL WHERE CUSTCODE = CustomerCode)" &
",(SELECT SUPNAME FROM SUP_TBL WHERE SUPCODE =SupplierCode)" &
",(SELECT SupAddr FROM SUP_TBL WHERE SUPCODE =SupplierCode)" &
",(SELECT COMMDESC FROM COMM_TBL WHERE COMMCODE = CommodityCode)" &
",(SELECT PRICING FROM COMM_TBL WHERE COMMCODE = CommodityCode)" &
",(SELECT USER_DISPLAYNAME FROM USERACCOUNTS WHERE User_id = WeigherIn),* FROM OUTBOUND_TBL where RefNo = '" & refno & "'"
                Dim cls As New CLS_OLE_DB
                cls.CONNECTION = OLEDBCONX


                cls.Source = Src
                cls.OpenSource()
                Dim gr As String = 0
                Dim tr As String = 0
                Dim nt As String = 0
                Dim dtout As String = 0
                Dim tbl As New DataTable()

                With cls.DATAREADER
                    If .HasRows Then
                        While .Read
                            comm_tbl = "select * from  comm_tbl where  COMMCODE = '" & .Item("CommodityCode") & "'"
                            sup_tbl = "select * from  sup_tbl where  supcode = '" & .Item("supplierCode") & "'"
                            cust_tbl = "select * from  cust_tbl where  custcode = '" & .Item("customerCode") & "'"
                            useraccounts1 = "select * from  useraccounts where  user_id = '" & .Item("WeigherIn") & "'"
                            useraccounts2 = "select * from  useraccounts where  user_id = '" & .Item("WeigherOut") & "'"
                            compnyProf = "select * from companyProfile"
                        End While
                        .Close()

                        sa = New OleDb.OleDbDataAdapter(comm_tbl, OLEDBCONX)
                        sa.Fill(dds, "Comm_Tbl")

                        sa = New OleDb.OleDbDataAdapter(outbount_tbl, OLEDBCONX)
                        sa.Fill(dds, "Outbound_tbl")


                        sa = New OleDb.OleDbDataAdapter(sup_tbl, OLEDBCONX)
                        sa.Fill(dds, "sup_tbl")

                        sa = New OleDb.OleDbDataAdapter(cust_tbl, OLEDBCONX)
                        sa.Fill(dds, "cust_tbl")

                        sa = New OleDb.OleDbDataAdapter(useraccounts1, OLEDBCONX)
                        sa.Fill(dds, "useraccounts")

                        sa = New OleDb.OleDbDataAdapter(useraccounts2, OLEDBCONX)
                        sa.Fill(dds, "useraccounts_1")

                        sa = New OleDb.OleDbDataAdapter(compnyProf, OLEDBCONX)
                        sa.Fill(dds, "CompanyProfile")
                    End If
                End With
            End If


            RR.SetDataSource(dds)


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

            If (String.IsNullOrEmpty(SysSettings.DefaultPrinter)) Then
                printPrompt.PrinterSettings.PrinterName = GetDefaultPrinter()
            Else
                printPrompt.PrinterSettings.PrinterName = SysSettings.DefaultPrinter
            End If

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
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function GetDefaultPrinter() As String
        Dim Result As String = ""

        Dim _SEARCHER = New System.Management.ManagementObjectSearcher(
    "Select Caption from  Win32_Printer Where Default = True")

        For Each _QUERYJOB As System.Management.ManagementObject In _SEARCHER.Get()
            If _QUERYJOB("Default") = True Then
                Result = _QUERYJOB("Caption")
            End If
        Next
        Return Result
    End Function

    Public Function GetDefaultPrinter2() As String

        Dim defaultPrinter As String

        Dim ps = New LocalPrintServer()
        With ps
            defaultPrinter = ps.DefaultPrintQueue.FullName
        End With

        Return defaultPrinter
    End Function

    Public Function ListPrinters() As List(Of String)

        '    Dim r As New List(Of String)

        '    Dim printers = New System.Management.ManagementObjectSearcher(
        '"Select * from  Win32_Printer")

        '    For Each _QUERYJOB As System.Management.ManagementObject In printers.Get()
        '        r.Add(_QUERYJOB("Caption"))
        '    Next

        '    Return r


        Dim prs = System.Drawing.Printing.PrinterSettings.InstalledPrinters
        Return prs.Cast(Of String)().ToList()
    End Function

    Public Sub ViewReport(ByVal crviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer,
                          ByVal ReportFile As String, ByVal sqlQuery As String,
                          ByVal RR As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal DTFrom As String,
                          ByVal DTTO As String, ByVal PreparedBy As String,
                          ByVal SortFieldTable As String, ByVal SortField As String, ByVal SortFieldOrder As CrystalDecisions.Shared.SortDirection,
                          ByVal Groupings As String)
        Try

            RR = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            RR.Load(ReportFile)

            Dim sysSettings = New settings()
            sysSettings.Load()

            RR.DataDefinition.FormulaFields.Item("From").Text = "'" & DTFrom & "'"
            RR.DataDefinition.FormulaFields.Item("To").Text = "'" & DTTO & "'"
            RR.DataDefinition.FormulaFields.Item("PreparedBy").Text = "'" & PreparedBy & "'"
            RR.DataDefinition.FormulaFields.Item("DeductUnit").Text = "'" & sysSettings.DeductUnit & "'"

            If IsNothing(SortFieldTable) = False Then
                Dim SortFieldData As CrystalDecisions.CrystalReports.Engine.FieldDefinition
                SortFieldData = RR.Database.Tables(SortFieldTable).Fields(SortField)
                RR.DataDefinition.SortFields(0).Field = SortFieldData
                If (SortFieldOrder = CrystalDecisions.Shared.SortDirection.TopNOrder) = False Then
                    RR.DataDefinition.SortFields(0).SortDirection = SortFieldOrder
                End If
            End If
            Dim dds As ds = New ds()
            Dim outbount_tbl As String = sqlQuery
            Dim comm_tbl As String = ""
            Dim sup_tbl As String = ""
            Dim cust_tbl As String = ""
            Dim useraccounts1 As String = ""
            Dim useraccounts2 As String = ""
            Dim compnyProf As String = ""
            Dim sa As New OleDb.OleDbDataAdapter


            Dim cls As New CLS_OLE_DB
            cls.CONNECTION = OLEDBCONX

            cls.Source = outbount_tbl
            cls.OpenSource()
            Dim gr As String = 0
            Dim tr As String = 0
            Dim nt As String = 0
            Dim dtout As String = 0
            Dim tbl As New DataTable()

            With cls.DATAREADER
                If .HasRows Then
                    While .Read
                        comm_tbl = "select * from  comm_tbl where  COMMCODE = '" & .Item("CommodityCode") & "'"
                        sup_tbl = "select * from  sup_tbl where  supcode = '" & .Item("supplierCode") & "'"
                        cust_tbl = "select * from  cust_tbl where  custcode = '" & .Item("customerCode") & "'"
                        useraccounts1 = "select * from  useraccounts where  user_id = '" & .Item("WeigherIn") & "'"
                        useraccounts2 = "select * from  useraccounts where  user_id = '" & .Item("WeigherOut") & "'"
                        compnyProf = "select * from companyProfile"
                    End While
                    .Close()

                    sa = New OleDb.OleDbDataAdapter(comm_tbl, OLEDBCONX)
                    sa.Fill(dds, "Comm_Tbl")

                    sa = New OleDb.OleDbDataAdapter(outbount_tbl, OLEDBCONX)
                    sa.Fill(dds, "Outbound_tbl")


                    sa = New OleDb.OleDbDataAdapter(sup_tbl, OLEDBCONX)
                    sa.Fill(dds, "sup_tbl")

                    sa = New OleDb.OleDbDataAdapter(cust_tbl, OLEDBCONX)
                    sa.Fill(dds, "cust_tbl")

                    sa = New OleDb.OleDbDataAdapter(useraccounts1, OLEDBCONX)
                    sa.Fill(dds, "useraccounts")

                    sa = New OleDb.OleDbDataAdapter(useraccounts2, OLEDBCONX)
                    sa.Fill(dds, "useraccounts_1")

                    sa = New OleDb.OleDbDataAdapter(compnyProf, OLEDBCONX)
                    sa.Fill(dds, "CompanyProfile")
                End If
            End With


            RR.SetDataSource(dds)

            RR.Refresh()
            crviewer.ReportSource = RR
            'If IsNothing(sqlQuery) = False Then
            '    crviewer.SelectionFormula = sqlQuery
            'End If
            crviewer.Refresh()



        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub ViewReport_Old(ByVal crviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer,
                          ByVal ReportFile As String, ByVal SelectionFormula As String,
                          ByVal RR As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal DTFrom As String,
                          ByVal DTTO As String, ByVal PreparedBy As String,
                          ByVal SortFieldTable As String, ByVal SortField As String, ByVal SortFieldOrder As CrystalDecisions.Shared.SortDirection,
                          ByVal Groupings As String)
        Try

            Dim ConnInfo As New CrystalDecisions.Shared.ConnectionInfo
            If IsNothing(RR) Then
                RR = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                RR.Load(ReportFile)
                RR.RecordSelectionFormula = SelectionFormula
                SetConnectionString(RR)
            End If

            Dim sysSettings = New settings()
            sysSettings.Load()

            RR.DataDefinition.FormulaFields.Item("From").Text = "'" & DTFrom & "'"
            RR.DataDefinition.FormulaFields.Item("To").Text = "'" & DTTO & "'"
            RR.DataDefinition.FormulaFields.Item("PreparedBy").Text = "'" & PreparedBy & "'"
            RR.DataDefinition.FormulaFields.Item("DeductUnit").Text = "'" & sysSettings.DeductUnit & "'"

            If IsNothing(SortFieldTable) = False Then
                Dim SortFieldData As CrystalDecisions.CrystalReports.Engine.FieldDefinition
                SortFieldData = RR.Database.Tables(SortFieldTable).Fields(SortField)
                RR.DataDefinition.SortFields(0).Field = SortFieldData
                If (SortFieldOrder = CrystalDecisions.Shared.SortDirection.TopNOrder) = False Then
                    RR.DataDefinition.SortFields(0).SortDirection = SortFieldOrder
                End If
            End If

            'If IsNothing(Groupings) = False Then
            '    Dim GroupFieldData As CrystalDecisions.CrystalReports.Engine.GroupNa

            '    MessageBox.Show(RR.DataDefinition.GroupNameFields(0).Name)

            'End If

            RR.Refresh()
            crviewer.ReportSource = RR
            If IsNothing(SelectionFormula) = False Then
                crviewer.SelectionFormula = SelectionFormula
            End If
            crviewer.Refresh()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub



    Private Sub SetConnectionString(ByRef Rp As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Try
            Dim ConStr As String = ""
            Dim ConInfo As New CrystalDecisions.Shared.ConnectionInfo
            Dim RpTbl As CrystalDecisions.CrystalReports.Engine.Tables = Rp.Database.Tables
            Dim SysSettings As New settings
            SysSettings.Load()

            Select Case SysSettings.ConnectionType
                Case "OLEDB"
                    With ConInfo
                        .DatabaseName = SysSettings.access_file_path
                        .Password = SysSettings.access_pwd
                        .AllowCustomConnection = True

                    End With
                Case "SQL"
                    With ConInfo
                        .ServerName = SysSettings.sql_server_name
                        .DatabaseName = SysSettings.sql_server_catalog
                        .UserID = SysSettings.sql_server_uid
                        .Password = SysSettings.sql_server_pwd
                    End With
            End Select


            For Each tbl As CrystalDecisions.CrystalReports.Engine.Table In RpTbl
                Dim tblLogInfo As CrystalDecisions.Shared.TableLogOnInfo = tbl.LogOnInfo
                tbl.LogOnInfo.ConnectionInfo = ConInfo
                tbl.ApplyLogOnInfo(tblLogInfo)
            Next


            If SysSettings.ConnectionType = "SQL" Then
                Dim sqlConnInfo As System.Data.SqlClient.SqlConnectionStringBuilder = New System.Data.SqlClient.SqlConnectionStringBuilder(SQLCONX.ConnectionString)
                For Each connection As CrystalDecisions.CrystalReports.Engine.InternalConnectionInfo In Rp.DataSourceConnections
                    If sqlConnInfo.IntegratedSecurity Then
                        connection.SetConnection(sqlConnInfo.DataSource, sqlConnInfo.InitialCatalog, True)

                    Else
                        connection.SetConnection(sqlConnInfo.DataSource, sqlConnInfo.InitialCatalog, sqlConnInfo.UserID, sqlConnInfo.Password)
                        connection.IntegratedSecurity = False
                    End If
                Next
            End If


        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try


    End Sub


    Public Sub LoadReportDoc(ByRef reportfile As String, ByRef MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument)

        MyReport.Load(reportfile)
        SetConnectionString(MyReport)
    End Sub
End Module

Module _PROC

End Module
