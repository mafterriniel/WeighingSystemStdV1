﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReports))
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.Pnl_Setup = New System.Windows.Forms.Panel()
        Me.PushButton3 = New MykeCtrlEx.PushButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboReportType = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboWeigher = New System.Windows.Forms.ComboBox()
        Me.TxtDriver = New System.Windows.Forms.TextBox()
        Me.ChkDriver = New System.Windows.Forms.CheckBox()
        Me.ChkTrans = New System.Windows.Forms.CheckBox()
        Me.PnlTrans = New System.Windows.Forms.Panel()
        Me.RdoTBoth = New System.Windows.Forms.RadioButton()
        Me.RdoOutBound = New System.Windows.Forms.RadioButton()
        Me.RdoInbound = New System.Windows.Forms.RadioButton()
        Me.PnlClientType = New System.Windows.Forms.Panel()
        Me.RdoSup = New System.Windows.Forms.RadioButton()
        Me.RdoCust = New System.Windows.Forms.RadioButton()
        Me.CboClient = New System.Windows.Forms.ComboBox()
        Me.TxtPlateNo = New System.Windows.Forms.TextBox()
        Me.ChkPlateNo = New System.Windows.Forms.CheckBox()
        Me.ChkMaterial = New System.Windows.Forms.CheckBox()
        Me.ChkNone = New System.Windows.Forms.CheckBox()
        Me.ChkClient = New System.Windows.Forms.CheckBox()
        Me.CboMaterial = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CboOrder = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboSort = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.RdoDateOut = New System.Windows.Forms.RadioButton()
        Me.RdoDateIn = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTto = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTFrom = New System.Windows.Forms.DateTimePicker()
        Me.PushButton1 = New MykeCtrlEx.PushButton()
        Me.BtnPreview = New MykeCtrlEx.PushButton()
        Me.CrViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.chkByWeigher = New System.Windows.Forms.CheckBox()
        Me.Pnl_Setup.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PnlTrans.SuspendLayout()
        Me.PnlClientType.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.White
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(1821, 36)
        Me.PnlHeader.TabIndex = 4
        '
        'Pnl_Setup
        '
        Me.Pnl_Setup.AutoScroll = True
        Me.Pnl_Setup.BackColor = System.Drawing.Color.White
        Me.Pnl_Setup.Controls.Add(Me.PushButton3)
        Me.Pnl_Setup.Controls.Add(Me.Label5)
        Me.Pnl_Setup.Controls.Add(Me.CboReportType)
        Me.Pnl_Setup.Controls.Add(Me.Panel1)
        Me.Pnl_Setup.Controls.Add(Me.Panel3)
        Me.Pnl_Setup.Controls.Add(Me.PushButton1)
        Me.Pnl_Setup.Controls.Add(Me.BtnPreview)
        Me.Pnl_Setup.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pnl_Setup.Location = New System.Drawing.Point(0, 36)
        Me.Pnl_Setup.Margin = New System.Windows.Forms.Padding(4)
        Me.Pnl_Setup.Name = "Pnl_Setup"
        Me.Pnl_Setup.Size = New System.Drawing.Size(571, 702)
        Me.Pnl_Setup.TabIndex = 5
        '
        'PushButton3
        '
        Me.PushButton3.BackgroundImage = CType(resources.GetObject("PushButton3.BackgroundImage"), System.Drawing.Image)
        Me.PushButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PushButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PushButton3.FlatAppearance.BorderSize = 0
        Me.PushButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PushButton3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PushButton3.ForeColor = System.Drawing.Color.Black
        Me.PushButton3.GUI_ACCSS = "JMoiakne122208"
        Me.PushButton3.GUI_ENABLE_HOVER = True
        Me.PushButton3.GUI_ENABLED = True
        Me.PushButton3.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PushButton3.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Printer24
        Me.PushButton3.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.PushButton3.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.PushButton3.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.PushButton3.Image = CType(resources.GetObject("PushButton3.Image"), System.Drawing.Image)
        Me.PushButton3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.PushButton3.Location = New System.Drawing.Point(175, 18)
        Me.PushButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.PushButton3.Name = "PushButton3"
        Me.PushButton3.Padding = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.PushButton3.Size = New System.Drawing.Size(147, 76)
        Me.PushButton3.TabIndex = 281
        Me.PushButton3.Text = "&PRINT"
        Me.PushButton3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PushButton3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(20, 116)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 280
        Me.Label5.Text = "Report Type"
        '
        'CboReportType
        '
        Me.CboReportType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboReportType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboReportType.BackColor = System.Drawing.Color.White
        Me.CboReportType.DropDownHeight = 150
        Me.CboReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboReportType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboReportType.FormattingEnabled = True
        Me.CboReportType.IntegralHeight = False
        Me.CboReportType.Items.AddRange(New Object() {"General Report"})
        Me.CboReportType.Location = New System.Drawing.Point(164, 112)
        Me.CboReportType.Margin = New System.Windows.Forms.Padding(4)
        Me.CboReportType.MaxLength = 50
        Me.CboReportType.Name = "CboReportType"
        Me.CboReportType.Size = New System.Drawing.Size(332, 28)
        Me.CboReportType.Sorted = True
        Me.CboReportType.TabIndex = 279
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkByWeigher)
        Me.Panel1.Controls.Add(Me.cboWeigher)
        Me.Panel1.Controls.Add(Me.TxtDriver)
        Me.Panel1.Controls.Add(Me.ChkDriver)
        Me.Panel1.Controls.Add(Me.ChkTrans)
        Me.Panel1.Controls.Add(Me.PnlTrans)
        Me.Panel1.Controls.Add(Me.PnlClientType)
        Me.Panel1.Controls.Add(Me.TxtPlateNo)
        Me.Panel1.Controls.Add(Me.ChkPlateNo)
        Me.Panel1.Controls.Add(Me.ChkMaterial)
        Me.Panel1.Controls.Add(Me.ChkNone)
        Me.Panel1.Controls.Add(Me.ChkClient)
        Me.Panel1.Controls.Add(Me.CboMaterial)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(9, 364)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 325)
        Me.Panel1.TabIndex = 278
        '
        'cboWeigher
        '
        Me.cboWeigher.AccessibleDescription = ""
        Me.cboWeigher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboWeigher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboWeigher.BackColor = System.Drawing.Color.White
        Me.cboWeigher.DropDownHeight = 150
        Me.cboWeigher.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboWeigher.FormattingEnabled = True
        Me.cboWeigher.IntegralHeight = False
        Me.cboWeigher.Location = New System.Drawing.Point(159, 279)
        Me.cboWeigher.Margin = New System.Windows.Forms.Padding(4)
        Me.cboWeigher.MaxLength = 50
        Me.cboWeigher.Name = "cboWeigher"
        Me.cboWeigher.Size = New System.Drawing.Size(349, 28)
        Me.cboWeigher.Sorted = True
        Me.cboWeigher.TabIndex = 287
        '
        'TxtDriver
        '
        Me.TxtDriver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtDriver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtDriver.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDriver.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDriver.Location = New System.Drawing.Point(159, 244)
        Me.TxtDriver.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDriver.MaxLength = 35
        Me.TxtDriver.Name = "TxtDriver"
        Me.TxtDriver.Size = New System.Drawing.Size(349, 27)
        Me.TxtDriver.TabIndex = 286
        '
        'ChkDriver
        '
        Me.ChkDriver.AutoSize = True
        Me.ChkDriver.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDriver.ForeColor = System.Drawing.Color.Black
        Me.ChkDriver.Location = New System.Drawing.Point(12, 242)
        Me.ChkDriver.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkDriver.Name = "ChkDriver"
        Me.ChkDriver.Size = New System.Drawing.Size(91, 24)
        Me.ChkDriver.TabIndex = 285
        Me.ChkDriver.Text = "By Driver"
        Me.ChkDriver.UseVisualStyleBackColor = True
        '
        'ChkTrans
        '
        Me.ChkTrans.AutoSize = True
        Me.ChkTrans.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTrans.ForeColor = System.Drawing.Color.Black
        Me.ChkTrans.Location = New System.Drawing.Point(11, 65)
        Me.ChkTrans.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkTrans.Name = "ChkTrans"
        Me.ChkTrans.Size = New System.Drawing.Size(106, 24)
        Me.ChkTrans.TabIndex = 284
        Me.ChkTrans.Text = "Transaction"
        Me.ChkTrans.UseVisualStyleBackColor = True
        '
        'PnlTrans
        '
        Me.PnlTrans.Controls.Add(Me.RdoTBoth)
        Me.PnlTrans.Controls.Add(Me.RdoOutBound)
        Me.PnlTrans.Controls.Add(Me.RdoInbound)
        Me.PnlTrans.Location = New System.Drawing.Point(157, 65)
        Me.PnlTrans.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlTrans.Name = "PnlTrans"
        Me.PnlTrans.Size = New System.Drawing.Size(329, 33)
        Me.PnlTrans.TabIndex = 283
        '
        'RdoTBoth
        '
        Me.RdoTBoth.AutoSize = True
        Me.RdoTBoth.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoTBoth.Location = New System.Drawing.Point(232, 2)
        Me.RdoTBoth.Margin = New System.Windows.Forms.Padding(4)
        Me.RdoTBoth.Name = "RdoTBoth"
        Me.RdoTBoth.Size = New System.Drawing.Size(48, 24)
        Me.RdoTBoth.TabIndex = 285
        Me.RdoTBoth.TabStop = True
        Me.RdoTBoth.Text = "All"
        Me.RdoTBoth.UseVisualStyleBackColor = True
        '
        'RdoOutBound
        '
        Me.RdoOutBound.AutoSize = True
        Me.RdoOutBound.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoOutBound.Location = New System.Drawing.Point(120, 1)
        Me.RdoOutBound.Margin = New System.Windows.Forms.Padding(4)
        Me.RdoOutBound.Name = "RdoOutBound"
        Me.RdoOutBound.Size = New System.Drawing.Size(97, 24)
        Me.RdoOutBound.TabIndex = 284
        Me.RdoOutBound.TabStop = True
        Me.RdoOutBound.Text = "Outbound"
        Me.RdoOutBound.UseVisualStyleBackColor = True
        '
        'RdoInbound
        '
        Me.RdoInbound.AutoSize = True
        Me.RdoInbound.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoInbound.Location = New System.Drawing.Point(7, 1)
        Me.RdoInbound.Margin = New System.Windows.Forms.Padding(4)
        Me.RdoInbound.Name = "RdoInbound"
        Me.RdoInbound.Size = New System.Drawing.Size(85, 24)
        Me.RdoInbound.TabIndex = 283
        Me.RdoInbound.TabStop = True
        Me.RdoInbound.Text = "Inbound"
        Me.RdoInbound.UseVisualStyleBackColor = True
        '
        'PnlClientType
        '
        Me.PnlClientType.Controls.Add(Me.RdoSup)
        Me.PnlClientType.Controls.Add(Me.RdoCust)
        Me.PnlClientType.Controls.Add(Me.CboClient)
        Me.PnlClientType.Location = New System.Drawing.Point(157, 137)
        Me.PnlClientType.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlClientType.Name = "PnlClientType"
        Me.PnlClientType.Size = New System.Drawing.Size(360, 68)
        Me.PnlClientType.TabIndex = 279
        '
        'RdoSup
        '
        Me.RdoSup.AutoSize = True
        Me.RdoSup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoSup.Location = New System.Drawing.Point(120, 1)
        Me.RdoSup.Margin = New System.Windows.Forms.Padding(4)
        Me.RdoSup.Name = "RdoSup"
        Me.RdoSup.Size = New System.Drawing.Size(85, 24)
        Me.RdoSup.TabIndex = 284
        Me.RdoSup.TabStop = True
        Me.RdoSup.Text = "Supplier"
        Me.RdoSup.UseVisualStyleBackColor = True
        '
        'RdoCust
        '
        Me.RdoCust.AutoSize = True
        Me.RdoCust.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoCust.Location = New System.Drawing.Point(7, 1)
        Me.RdoCust.Margin = New System.Windows.Forms.Padding(4)
        Me.RdoCust.Name = "RdoCust"
        Me.RdoCust.Size = New System.Drawing.Size(93, 24)
        Me.RdoCust.TabIndex = 283
        Me.RdoCust.TabStop = True
        Me.RdoCust.Text = "Customer"
        Me.RdoCust.UseVisualStyleBackColor = True
        '
        'CboClient
        '
        Me.CboClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboClient.BackColor = System.Drawing.Color.White
        Me.CboClient.DropDownHeight = 150
        Me.CboClient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboClient.FormattingEnabled = True
        Me.CboClient.IntegralHeight = False
        Me.CboClient.Location = New System.Drawing.Point(0, 31)
        Me.CboClient.Margin = New System.Windows.Forms.Padding(4)
        Me.CboClient.MaxLength = 50
        Me.CboClient.Name = "CboClient"
        Me.CboClient.Size = New System.Drawing.Size(349, 28)
        Me.CboClient.Sorted = True
        Me.CboClient.TabIndex = 269
        '
        'TxtPlateNo
        '
        Me.TxtPlateNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtPlateNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtPlateNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPlateNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlateNo.Location = New System.Drawing.Point(157, 105)
        Me.TxtPlateNo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPlateNo.MaxLength = 20
        Me.TxtPlateNo.Name = "TxtPlateNo"
        Me.TxtPlateNo.Size = New System.Drawing.Size(349, 27)
        Me.TxtPlateNo.TabIndex = 282
        '
        'ChkPlateNo
        '
        Me.ChkPlateNo.AutoSize = True
        Me.ChkPlateNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPlateNo.ForeColor = System.Drawing.Color.Black
        Me.ChkPlateNo.Location = New System.Drawing.Point(12, 102)
        Me.ChkPlateNo.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkPlateNo.Name = "ChkPlateNo"
        Me.ChkPlateNo.Size = New System.Drawing.Size(97, 24)
        Me.ChkPlateNo.TabIndex = 273
        Me.ChkPlateNo.Text = "By Plate #"
        Me.ChkPlateNo.UseVisualStyleBackColor = True
        '
        'ChkMaterial
        '
        Me.ChkMaterial.AutoSize = True
        Me.ChkMaterial.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMaterial.ForeColor = System.Drawing.Color.Black
        Me.ChkMaterial.Location = New System.Drawing.Point(12, 208)
        Me.ChkMaterial.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkMaterial.Name = "ChkMaterial"
        Me.ChkMaterial.Size = New System.Drawing.Size(129, 24)
        Me.ChkMaterial.TabIndex = 272
        Me.ChkMaterial.Text = "By Commodity"
        Me.ChkMaterial.UseVisualStyleBackColor = True
        '
        'ChkNone
        '
        Me.ChkNone.AutoSize = True
        Me.ChkNone.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNone.ForeColor = System.Drawing.Color.Black
        Me.ChkNone.Location = New System.Drawing.Point(12, 34)
        Me.ChkNone.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkNone.Name = "ChkNone"
        Me.ChkNone.Size = New System.Drawing.Size(65, 24)
        Me.ChkNone.TabIndex = 274
        Me.ChkNone.Text = "None"
        Me.ChkNone.UseVisualStyleBackColor = True
        '
        'ChkClient
        '
        Me.ChkClient.AutoSize = True
        Me.ChkClient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkClient.ForeColor = System.Drawing.Color.Black
        Me.ChkClient.Location = New System.Drawing.Point(12, 133)
        Me.ChkClient.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkClient.Name = "ChkClient"
        Me.ChkClient.Size = New System.Drawing.Size(89, 24)
        Me.ChkClient.TabIndex = 271
        Me.ChkClient.Text = "By Client"
        Me.ChkClient.UseVisualStyleBackColor = True
        '
        'CboMaterial
        '
        Me.CboMaterial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboMaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboMaterial.BackColor = System.Drawing.Color.White
        Me.CboMaterial.DropDownHeight = 150
        Me.CboMaterial.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMaterial.FormattingEnabled = True
        Me.CboMaterial.IntegralHeight = False
        Me.CboMaterial.Location = New System.Drawing.Point(159, 212)
        Me.CboMaterial.Margin = New System.Windows.Forms.Padding(4)
        Me.CboMaterial.MaxLength = 50
        Me.CboMaterial.Name = "CboMaterial"
        Me.CboMaterial.Size = New System.Drawing.Size(349, 28)
        Me.CboMaterial.Sorted = True
        Me.CboMaterial.TabIndex = 267
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 266
        Me.Label4.Text = "Filtering"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.CboOrder)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.CboSort)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.DTto)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.DTFrom)
        Me.Panel3.Location = New System.Drawing.Point(9, 148)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(553, 209)
        Me.Panel3.TabIndex = 277
        '
        'CboOrder
        '
        Me.CboOrder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboOrder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboOrder.BackColor = System.Drawing.Color.White
        Me.CboOrder.DropDownHeight = 150
        Me.CboOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboOrder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboOrder.FormattingEnabled = True
        Me.CboOrder.IntegralHeight = False
        Me.CboOrder.Items.AddRange(New Object() {"Ascending", "Descending", "Original Position"})
        Me.CboOrder.Location = New System.Drawing.Point(155, 150)
        Me.CboOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.CboOrder.MaxLength = 50
        Me.CboOrder.Name = "CboOrder"
        Me.CboOrder.Size = New System.Drawing.Size(193, 28)
        Me.CboOrder.Sorted = True
        Me.CboOrder.TabIndex = 288
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 156)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 20)
        Me.Label7.TabIndex = 287
        Me.Label7.Text = "Order"
        '
        'CboSort
        '
        Me.CboSort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSort.BackColor = System.Drawing.Color.White
        Me.CboSort.DropDownHeight = 150
        Me.CboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSort.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSort.FormattingEnabled = True
        Me.CboSort.IntegralHeight = False
        Me.CboSort.Items.AddRange(New Object() {"Date In", "Date Out", "Final Net", "Reference No."})
        Me.CboSort.Location = New System.Drawing.Point(155, 107)
        Me.CboSort.Margin = New System.Windows.Forms.Padding(4)
        Me.CboSort.MaxLength = 50
        Me.CboSort.Name = "CboSort"
        Me.CboSort.Size = New System.Drawing.Size(152, 28)
        Me.CboSort.Sorted = True
        Me.CboSort.TabIndex = 286
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 113)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 285
        Me.Label6.Text = "Sort By"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.RdoDateOut)
        Me.Panel5.Controls.Add(Me.RdoDateIn)
        Me.Panel5.Location = New System.Drawing.Point(155, 6)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(329, 33)
        Me.Panel5.TabIndex = 284
        '
        'RdoDateOut
        '
        Me.RdoDateOut.AutoSize = True
        Me.RdoDateOut.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoDateOut.Location = New System.Drawing.Point(109, 4)
        Me.RdoDateOut.Margin = New System.Windows.Forms.Padding(4)
        Me.RdoDateOut.Name = "RdoDateOut"
        Me.RdoDateOut.Size = New System.Drawing.Size(110, 24)
        Me.RdoDateOut.TabIndex = 284
        Me.RdoDateOut.Text = "By Date Out"
        Me.RdoDateOut.UseVisualStyleBackColor = True
        '
        'RdoDateIn
        '
        Me.RdoDateIn.AutoSize = True
        Me.RdoDateIn.Checked = True
        Me.RdoDateIn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoDateIn.Location = New System.Drawing.Point(0, 4)
        Me.RdoDateIn.Margin = New System.Windows.Forms.Padding(4)
        Me.RdoDateIn.Name = "RdoDateIn"
        Me.RdoDateIn.Size = New System.Drawing.Size(98, 24)
        Me.RdoDateIn.TabIndex = 283
        Me.RdoDateIn.TabStop = True
        Me.RdoDateIn.Text = "By Date In"
        Me.RdoDateIn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 266
        Me.Label3.Text = "Date Range"
        '
        'DTto
        '
        Me.DTto.CustomFormat = "MM-dd-yyyy"
        Me.DTto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTto.Location = New System.Drawing.Point(404, 47)
        Me.DTto.Margin = New System.Windows.Forms.Padding(4)
        Me.DTto.Name = "DTto"
        Me.DTto.Size = New System.Drawing.Size(132, 29)
        Me.DTto.TabIndex = 263
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(153, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 264
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(364, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 20)
        Me.Label2.TabIndex = 265
        Me.Label2.Text = "To:"
        '
        'DTFrom
        '
        Me.DTFrom.CustomFormat = "MM-dd-yyyy"
        Me.DTFrom.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTFrom.Location = New System.Drawing.Point(212, 47)
        Me.DTFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.DTFrom.Name = "DTFrom"
        Me.DTFrom.Size = New System.Drawing.Size(136, 29)
        Me.DTFrom.TabIndex = 262
        '
        'PushButton1
        '
        Me.PushButton1.BackgroundImage = CType(resources.GetObject("PushButton1.BackgroundImage"), System.Drawing.Image)
        Me.PushButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PushButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PushButton1.FlatAppearance.BorderSize = 0
        Me.PushButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PushButton1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PushButton1.ForeColor = System.Drawing.Color.Black
        Me.PushButton1.GUI_ACCSS = "JMoiakne122208"
        Me.PushButton1.GUI_ENABLE_HOVER = True
        Me.PushButton1.GUI_ENABLED = True
        Me.PushButton1.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PushButton1.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Exit26
        Me.PushButton1.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.PushButton1.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.PushButton1.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.PushButton1.Image = CType(resources.GetObject("PushButton1.Image"), System.Drawing.Image)
        Me.PushButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.PushButton1.Location = New System.Drawing.Point(351, 18)
        Me.PushButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.PushButton1.Name = "PushButton1"
        Me.PushButton1.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.PushButton1.Size = New System.Drawing.Size(147, 76)
        Me.PushButton1.TabIndex = 7
        Me.PushButton1.Text = "E&XIT"
        Me.PushButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PushButton1.UseVisualStyleBackColor = True
        '
        'BtnPreview
        '
        Me.BtnPreview.BackgroundImage = CType(resources.GetObject("BtnPreview.BackgroundImage"), System.Drawing.Image)
        Me.BtnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPreview.FlatAppearance.BorderSize = 0
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPreview.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreview.ForeColor = System.Drawing.Color.Black
        Me.BtnPreview.GUI_ACCSS = "JMoiakne122208"
        Me.BtnPreview.GUI_ENABLE_HOVER = True
        Me.BtnPreview.GUI_ENABLED = True
        Me.BtnPreview.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPreview.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnPreview.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnPreview.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnPreview.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnPreview.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPreview.Location = New System.Drawing.Point(9, 18)
        Me.BtnPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Padding = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.BtnPreview.Size = New System.Drawing.Size(147, 76)
        Me.BtnPreview.TabIndex = 0
        Me.BtnPreview.Text = "P&REVIEW"
        Me.BtnPreview.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPreview.UseVisualStyleBackColor = True
        '
        'CrViewer
        '
        Me.CrViewer.ActiveViewIndex = -1
        Me.CrViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrViewer.Location = New System.Drawing.Point(571, 36)
        Me.CrViewer.Margin = New System.Windows.Forms.Padding(4)
        Me.CrViewer.Name = "CrViewer"
        Me.CrViewer.ShowCloseButton = False
        Me.CrViewer.ShowGroupTreeButton = False
        Me.CrViewer.ShowLogo = False
        Me.CrViewer.ShowPrintButton = False
        Me.CrViewer.ShowTextSearchButton = False
        Me.CrViewer.Size = New System.Drawing.Size(1250, 702)
        Me.CrViewer.TabIndex = 239
        Me.CrViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'chkByWeigher
        '
        Me.chkByWeigher.AutoSize = True
        Me.chkByWeigher.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkByWeigher.ForeColor = System.Drawing.Color.Black
        Me.chkByWeigher.Location = New System.Drawing.Point(13, 281)
        Me.chkByWeigher.Margin = New System.Windows.Forms.Padding(4)
        Me.chkByWeigher.Name = "chkByWeigher"
        Me.chkByWeigher.Size = New System.Drawing.Size(106, 24)
        Me.chkByWeigher.TabIndex = 288
        Me.chkByWeigher.Text = "By Weigher"
        Me.chkByWeigher.UseVisualStyleBackColor = True
        '
        'FrmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1821, 738)
        Me.Controls.Add(Me.CrViewer)
        Me.Controls.Add(Me.Pnl_Setup)
        Me.Controls.Add(Me.PnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmReports"
        Me.Text = "FrmReports"
        Me.Pnl_Setup.ResumeLayout(False)
        Me.Pnl_Setup.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlTrans.ResumeLayout(False)
        Me.PnlTrans.PerformLayout()
        Me.PnlClientType.ResumeLayout(False)
        Me.PnlClientType.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents Pnl_Setup As System.Windows.Forms.Panel
    Friend WithEvents PushButton1 As MykeCtrlEx.PushButton
    Friend WithEvents BtnPreview As MykeCtrlEx.PushButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChkPlateNo As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMaterial As System.Windows.Forms.CheckBox
    Friend WithEvents CboClient As System.Windows.Forms.ComboBox
    Friend WithEvents ChkNone As System.Windows.Forms.CheckBox
    Friend WithEvents ChkClient As System.Windows.Forms.CheckBox
    Friend WithEvents CboMaterial As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPlateNo As System.Windows.Forms.TextBox
    Friend WithEvents PnlClientType As System.Windows.Forms.Panel
    Friend WithEvents RdoSup As System.Windows.Forms.RadioButton
    Friend WithEvents RdoCust As System.Windows.Forms.RadioButton
    Friend WithEvents PnlTrans As System.Windows.Forms.Panel
    Friend WithEvents RdoTBoth As System.Windows.Forms.RadioButton
    Friend WithEvents RdoOutBound As System.Windows.Forms.RadioButton
    Friend WithEvents RdoInbound As System.Windows.Forms.RadioButton
    Friend WithEvents ChkTrans As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDriver As System.Windows.Forms.CheckBox
    Friend WithEvents TxtDriver As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CboReportType As System.Windows.Forms.ComboBox
    Friend WithEvents CrViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PushButton3 As MykeCtrlEx.PushButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents RdoDateOut As System.Windows.Forms.RadioButton
    Friend WithEvents RdoDateIn As System.Windows.Forms.RadioButton
    Friend WithEvents CboSort As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CboOrder As System.Windows.Forms.ComboBox
    Friend WithEvents cboWeigher As ComboBox
    Friend WithEvents chkByWeigher As CheckBox
End Class
