﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSystemSettings
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSystemSettings))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetToDefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefeshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pnl_Details = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Pnl_Ports = New System.Windows.Forms.Panel()
        Me.Pnl_Adv = New System.Windows.Forms.Panel()
        Me.CboPort = New System.Windows.Forms.ComboBox()
        Me.CboParity = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CboBitsPerSecond = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CboStopBits = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CboDataBits = New System.Windows.Forms.ComboBox()
        Me.BtnAdv = New MykeCtrlEx.PushButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LblPortError = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TV_Ports = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Pnl_Connection = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RdoSErver = New System.Windows.Forms.RadioButton()
        Me.RdoAccess = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PnlAccess = New System.Windows.Forms.Panel()
        Me.BtnBrowse = New MykeCtrlEx.PushButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtDBpath = New System.Windows.Forms.TextBox()
        Me.TxtAccessPwd = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PnlServer = New System.Windows.Forms.Panel()
        Me.CboServer = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboDB = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Pnl_refno = New System.Windows.Forms.Panel()
        Me.LblRefNoError = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.s = New System.Windows.Forms.Panel()
        Me.Tv_Printers = New System.Windows.Forms.TreeView()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Pnl_General = New System.Windows.Forms.Panel()
        Me.nupdTareWtTol = New System.Windows.Forms.NumericUpDown()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.RdoDKg = New System.Windows.Forms.RadioButton()
        Me.RdoDP = New System.Windows.Forms.RadioButton()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.cboConnType = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.CboIndicator = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.rdoWMStandard = New System.Windows.Forms.RadioButton()
        Me.rdoWMAxle = New System.Windows.Forms.RadioButton()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Rdo_SingleWeighing = New System.Windows.Forms.RadioButton()
        Me.Rdo_InOutWeighing = New System.Windows.Forms.RadioButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cboPrinter = New System.Windows.Forms.ComboBox()
        Me.Pnl_PrintInOut = New System.Windows.Forms.Panel()
        Me.RdoPrintAll = New System.Windows.Forms.RadioButton()
        Me.RdoPrintInOut = New System.Windows.Forms.RadioButton()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.RdoDisablePrint = New System.Windows.Forms.RadioButton()
        Me.RdoEnablePrint = New System.Windows.Forms.RadioButton()
        Me.Chk_EnableDeduction = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.RdoUKg = New System.Windows.Forms.RadioButton()
        Me.RdoUTons = New System.Windows.Forms.RadioButton()
        Me.Chk_EnablePricing = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.RdoPKg = New System.Windows.Forms.RadioButton()
        Me.RdoPTons = New System.Windows.Forms.RadioButton()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Pnl_Profile = New System.Windows.Forms.Panel()
        Me.BtnRemove = New MykeCtrlEx.PushButton()
        Me.BtnChange = New MykeCtrlEx.PushButton()
        Me.Pict = New System.Windows.Forms.PictureBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TxtCompanyAddr = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TxtCompanyNme = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Pnl_Backup = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.BtnBackupData = New MykeCtrlEx.PushButton()
        Me.Pnl_ActionBtns = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCancel = New MykeCtrlEx.PushButton()
        Me.BtnEdit = New MykeCtrlEx.PushButton()
        Me.BtnSave = New MykeCtrlEx.PushButton()
        Me.Pnl_Buttons = New System.Windows.Forms.Panel()
        Me.BtnBackup = New MykeCtrlEx.PushButton()
        Me.BtnProfile = New MykeCtrlEx.PushButton()
        Me.BtnGeneral = New MykeCtrlEx.PushButton()
        Me.BtnPrinters = New MykeCtrlEx.PushButton()
        Me.BtnRefNo = New MykeCtrlEx.PushButton()
        Me.BtnDbase = New MykeCtrlEx.PushButton()
        Me.BtnPorts = New MykeCtrlEx.PushButton()
        Me.Lbl_PortLabel = New System.Windows.Forms.Label()
        Me.SFDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Pnl_Details.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Pnl_Ports.SuspendLayout()
        Me.Pnl_Adv.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Pnl_Connection.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PnlAccess.SuspendLayout()
        Me.PnlServer.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Pnl_refno.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.s.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Pnl_General.SuspendLayout()
        CType(Me.nupdTareWtTol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Pnl_PrintInOut.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.Pnl_Profile.SuspendLayout()
        CType(Me.Pict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.Pnl_Backup.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_ActionBtns.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Pnl_Buttons.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ActionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(8, 8)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1274, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(141, 34)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ActionsToolStripMenuItem
        '
        Me.ActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetToDefaultToolStripMenuItem, Me.RefeshToolStripMenuItem})
        Me.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem"
        Me.ActionsToolStripMenuItem.Size = New System.Drawing.Size(87, 29)
        Me.ActionsToolStripMenuItem.Text = "&Actions"
        '
        'SetToDefaultToolStripMenuItem
        '
        Me.SetToDefaultToolStripMenuItem.Name = "SetToDefaultToolStripMenuItem"
        Me.SetToDefaultToolStripMenuItem.Size = New System.Drawing.Size(223, 34)
        Me.SetToDefaultToolStripMenuItem.Text = "&Set to Default"
        '
        'RefeshToolStripMenuItem
        '
        Me.RefeshToolStripMenuItem.Name = "RefeshToolStripMenuItem"
        Me.RefeshToolStripMenuItem.Size = New System.Drawing.Size(223, 34)
        Me.RefeshToolStripMenuItem.Text = "&Refesh"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Pnl_Details)
        Me.Panel1.Controls.Add(Me.Pnl_Buttons)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(8, 41)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel1.Size = New System.Drawing.Size(1274, 806)
        Me.Panel1.TabIndex = 1
        '
        'Pnl_Details
        '
        Me.Pnl_Details.BackColor = System.Drawing.Color.White
        Me.Pnl_Details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Details.Controls.Add(Me.TabControl1)
        Me.Pnl_Details.Controls.Add(Me.Pnl_ActionBtns)
        Me.Pnl_Details.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Details.Location = New System.Drawing.Point(351, 8)
        Me.Pnl_Details.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pnl_Details.Name = "Pnl_Details"
        Me.Pnl_Details.Size = New System.Drawing.Size(915, 790)
        Me.Pnl_Details.TabIndex = 6
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(913, 714)
        Me.TabControl1.TabIndex = 113
        Me.TabControl1.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Pnl_Ports)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(905, 681)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Pnl_Ports
        '
        Me.Pnl_Ports.Controls.Add(Me.Pnl_Adv)
        Me.Pnl_Ports.Controls.Add(Me.BtnAdv)
        Me.Pnl_Ports.Controls.Add(Me.Panel3)
        Me.Pnl_Ports.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Ports.Location = New System.Drawing.Point(4, 5)
        Me.Pnl_Ports.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pnl_Ports.Name = "Pnl_Ports"
        Me.Pnl_Ports.Padding = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Pnl_Ports.Size = New System.Drawing.Size(897, 658)
        Me.Pnl_Ports.TabIndex = 112
        Me.Pnl_Ports.Visible = False
        '
        'Pnl_Adv
        '
        Me.Pnl_Adv.AutoScroll = True
        Me.Pnl_Adv.Controls.Add(Me.CboPort)
        Me.Pnl_Adv.Controls.Add(Me.CboParity)
        Me.Pnl_Adv.Controls.Add(Me.Label16)
        Me.Pnl_Adv.Controls.Add(Me.CboBitsPerSecond)
        Me.Pnl_Adv.Controls.Add(Me.Label15)
        Me.Pnl_Adv.Controls.Add(Me.Label19)
        Me.Pnl_Adv.Controls.Add(Me.Label17)
        Me.Pnl_Adv.Controls.Add(Me.CboStopBits)
        Me.Pnl_Adv.Controls.Add(Me.Label18)
        Me.Pnl_Adv.Controls.Add(Me.CboDataBits)
        Me.Pnl_Adv.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Adv.Location = New System.Drawing.Point(0, 339)
        Me.Pnl_Adv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pnl_Adv.Name = "Pnl_Adv"
        Me.Pnl_Adv.Size = New System.Drawing.Size(897, 325)
        Me.Pnl_Adv.TabIndex = 114
        Me.Pnl_Adv.Visible = False
        '
        'CboPort
        '
        Me.CboPort.DropDownHeight = 90
        Me.CboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPort.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPort.FormattingEnabled = True
        Me.CboPort.IntegralHeight = False
        Me.CboPort.ItemHeight = 22
        Me.CboPort.Location = New System.Drawing.Point(197, 15)
        Me.CboPort.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CboPort.Name = "CboPort"
        Me.CboPort.Size = New System.Drawing.Size(268, 30)
        Me.CboPort.TabIndex = 0
        '
        'CboParity
        '
        Me.CboParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboParity.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboParity.FormattingEnabled = True
        Me.CboParity.Items.AddRange(New Object() {"Even", "Odd", "None", "Mark", "Space"})
        Me.CboParity.Location = New System.Drawing.Point(197, 140)
        Me.CboParity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CboParity.Name = "CboParity"
        Me.CboParity.Size = New System.Drawing.Size(268, 30)
        Me.CboParity.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(44, 205)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 24)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Data Bits"
        '
        'CboBitsPerSecond
        '
        Me.CboBitsPerSecond.DropDownHeight = 95
        Me.CboBitsPerSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBitsPerSecond.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboBitsPerSecond.FormattingEnabled = True
        Me.CboBitsPerSecond.IntegralHeight = False
        Me.CboBitsPerSecond.Items.AddRange(New Object() {"75", "110", "134", "150", "300", "600", "1200", "1800", "2400", "4800", "7200", "9600", "14400", "19200", "38400", "57600", "115200", "128000", ""})
        Me.CboBitsPerSecond.Location = New System.Drawing.Point(197, 78)
        Me.CboBitsPerSecond.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CboBitsPerSecond.Name = "CboBitsPerSecond"
        Me.CboBitsPerSecond.Size = New System.Drawing.Size(268, 30)
        Me.CboBitsPerSecond.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(44, 272)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 24)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Stop Bits"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(44, 15)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 24)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Port Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(44, 140)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 24)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Parity"
        '
        'CboStopBits
        '
        Me.CboStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboStopBits.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboStopBits.FormattingEnabled = True
        Me.CboStopBits.Items.AddRange(New Object() {"1", "1.2", "2"})
        Me.CboStopBits.Location = New System.Drawing.Point(197, 272)
        Me.CboStopBits.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CboStopBits.Name = "CboStopBits"
        Me.CboStopBits.Size = New System.Drawing.Size(268, 30)
        Me.CboStopBits.TabIndex = 39
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(44, 78)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 24)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Baud Rate"
        '
        'CboDataBits
        '
        Me.CboDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDataBits.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDataBits.FormattingEnabled = True
        Me.CboDataBits.Items.AddRange(New Object() {"4", "5", "6", "7", "8"})
        Me.CboDataBits.Location = New System.Drawing.Point(197, 205)
        Me.CboDataBits.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CboDataBits.Name = "CboDataBits"
        Me.CboDataBits.Size = New System.Drawing.Size(268, 30)
        Me.CboDataBits.TabIndex = 3
        '
        'BtnAdv
        '
        Me.BtnAdv.BackgroundImage = CType(resources.GetObject("BtnAdv.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdv.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAdv.FlatAppearance.BorderSize = 0
        Me.BtnAdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAdv.ForeColor = System.Drawing.Color.Black
        Me.BtnAdv.GUI_ACCSS = "JMoiakne122208"
        Me.BtnAdv.GUI_ENABLE_HOVER = True
        Me.BtnAdv.GUI_ENABLED = True
        Me.BtnAdv.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnAdv.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Down16
        Me.BtnAdv.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.LightBlue
        Me.BtnAdv.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnAdv.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnAdv.Image = CType(resources.GetObject("BtnAdv.Image"), System.Drawing.Image)
        Me.BtnAdv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdv.Location = New System.Drawing.Point(0, 299)
        Me.BtnAdv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAdv.Name = "BtnAdv"
        Me.BtnAdv.Size = New System.Drawing.Size(897, 40)
        Me.BtnAdv.TabIndex = 0
        Me.BtnAdv.Text = "       &Advanced Settings"
        Me.BtnAdv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdv.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label36)
        Me.Panel3.Controls.Add(Me.txtPort)
        Me.Panel3.Controls.Add(Me.Label34)
        Me.Panel3.Controls.Add(Me.txtIP)
        Me.Panel3.Controls.Add(Me.Label33)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.LblPortError)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.TV_Ports)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(897, 299)
        Me.Panel3.TabIndex = 110
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(15, 255)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(206, 34)
        Me.Label36.TabIndex = 128
        Me.Label36.Text = "IP Device Settings"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPort
        '
        Me.txtPort.Enabled = False
        Me.txtPort.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.Location = New System.Drawing.Point(701, 255)
        Me.txtPort.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPort.MaxLength = 40
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(147, 29)
        Me.txtPort.TabIndex = 127
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(636, 255)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(69, 34)
        Me.Label34.TabIndex = 126
        Me.Label34.Text = "Port"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIP
        '
        Me.txtIP.Enabled = False
        Me.txtIP.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP.Location = New System.Drawing.Point(393, 255)
        Me.txtIP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIP.MaxLength = 40
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(219, 29)
        Me.txtIP.TabIndex = 125
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(271, 255)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(112, 34)
        Me.Label33.TabIndex = 124
        Me.Label33.Text = "IP Address"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(603, 54)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(266, 145)
        Me.GroupBox2.TabIndex = 116
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(93, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 108)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Double click on the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "highlighted port to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "set it as default " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "port connection."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.WeighingSystemV1_1.My.Resources.Resources.Info_48
        Me.PictureBox2.Location = New System.Drawing.Point(10, 39)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 71)
        Me.PictureBox2.TabIndex = 116
        Me.PictureBox2.TabStop = False
        '
        'LblPortError
        '
        Me.LblPortError.BackColor = System.Drawing.Color.Transparent
        Me.LblPortError.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPortError.ForeColor = System.Drawing.Color.Black
        Me.LblPortError.Image = CType(resources.GetObject("LblPortError.Image"), System.Drawing.Image)
        Me.LblPortError.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LblPortError.Location = New System.Drawing.Point(15, 199)
        Me.LblPortError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPortError.Name = "LblPortError"
        Me.LblPortError.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblPortError.Size = New System.Drawing.Size(598, 42)
        Me.LblPortError.TabIndex = 35
        Me.LblPortError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(897, 51)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Available Ports "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TV_Ports
        '
        Me.TV_Ports.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TV_Ports.FullRowSelect = True
        Me.TV_Ports.ImageIndex = 0
        Me.TV_Ports.ImageList = Me.ImageList1
        Me.TV_Ports.Location = New System.Drawing.Point(17, 62)
        Me.TV_Ports.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TV_Ports.Name = "TV_Ports"
        Me.TV_Ports.SelectedImageIndex = 0
        Me.TV_Ports.ShowPlusMinus = False
        Me.TV_Ports.ShowRootLines = False
        Me.TV_Ports.Size = New System.Drawing.Size(566, 132)
        Me.TV_Ports.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "port-icon (1).png")
        Me.ImageList1.Images.SetKeyName(1, "1392890242_Check.png")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Pnl_Connection)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(905, 681)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Pnl_Connection
        '
        Me.Pnl_Connection.CausesValidation = False
        Me.Pnl_Connection.Controls.Add(Me.Panel5)
        Me.Pnl_Connection.Controls.Add(Me.Label3)
        Me.Pnl_Connection.Controls.Add(Me.PnlAccess)
        Me.Pnl_Connection.Controls.Add(Me.PnlServer)
        Me.Pnl_Connection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Connection.Location = New System.Drawing.Point(4, 5)
        Me.Pnl_Connection.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pnl_Connection.Name = "Pnl_Connection"
        Me.Pnl_Connection.Size = New System.Drawing.Size(897, 671)
        Me.Pnl_Connection.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.RdoSErver)
        Me.Panel5.Controls.Add(Me.RdoAccess)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 51)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(897, 41)
        Me.Panel5.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(8, 8)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 22)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Connection Type"
        '
        'RdoSErver
        '
        Me.RdoSErver.AutoSize = True
        Me.RdoSErver.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoSErver.Location = New System.Drawing.Point(291, 5)
        Me.RdoSErver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdoSErver.Name = "RdoSErver"
        Me.RdoSErver.Size = New System.Drawing.Size(126, 26)
        Me.RdoSErver.TabIndex = 2
        Me.RdoSErver.Text = "SQL SERVER"
        Me.RdoSErver.UseVisualStyleBackColor = True
        Me.RdoSErver.Visible = False
        '
        'RdoAccess
        '
        Me.RdoAccess.AutoSize = True
        Me.RdoAccess.Checked = True
        Me.RdoAccess.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoAccess.Location = New System.Drawing.Point(154, 5)
        Me.RdoAccess.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdoAccess.Name = "RdoAccess"
        Me.RdoAccess.Size = New System.Drawing.Size(127, 26)
        Me.RdoAccess.TabIndex = 1
        Me.RdoAccess.TabStop = True
        Me.RdoAccess.Text = "ACCESS FILE"
        Me.RdoAccess.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 31, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(897, 51)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Database Connection"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlAccess
        '
        Me.PnlAccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlAccess.Controls.Add(Me.BtnBrowse)
        Me.PnlAccess.Controls.Add(Me.Label10)
        Me.PnlAccess.Controls.Add(Me.TxtDBpath)
        Me.PnlAccess.Controls.Add(Me.TxtAccessPwd)
        Me.PnlAccess.Controls.Add(Me.Label11)
        Me.PnlAccess.Controls.Add(Me.Label9)
        Me.PnlAccess.Location = New System.Drawing.Point(18, 91)
        Me.PnlAccess.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PnlAccess.Name = "PnlAccess"
        Me.PnlAccess.Size = New System.Drawing.Size(816, 347)
        Me.PnlAccess.TabIndex = 2
        '
        'BtnBrowse
        '
        Me.BtnBrowse.BackgroundImage = CType(resources.GetObject("BtnBrowse.BackgroundImage"), System.Drawing.Image)
        Me.BtnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBrowse.FlatAppearance.BorderSize = 0
        Me.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrowse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnBrowse.ForeColor = System.Drawing.Color.Maroon
        Me.BtnBrowse.GUI_ACCSS = "JMoiakne122208"
        Me.BtnBrowse.GUI_ENABLE_HOVER = True
        Me.BtnBrowse.GUI_ENABLED = True
        Me.BtnBrowse.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnBrowse.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnBrowse.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnBrowse.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnBrowse.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnBrowse.Location = New System.Drawing.Point(532, 58)
        Me.BtnBrowse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(39, 34)
        Me.BtnBrowse.TabIndex = 1
        Me.BtnBrowse.Text = "..."
        Me.BtnBrowse.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 59)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 35)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Database File"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDBpath
        '
        Me.TxtDBpath.Enabled = False
        Me.TxtDBpath.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDBpath.Location = New System.Drawing.Point(152, 59)
        Me.TxtDBpath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtDBpath.MaxLength = 60
        Me.TxtDBpath.Name = "TxtDBpath"
        Me.TxtDBpath.Size = New System.Drawing.Size(370, 29)
        Me.TxtDBpath.TabIndex = 2
        '
        'TxtAccessPwd
        '
        Me.TxtAccessPwd.Enabled = False
        Me.TxtAccessPwd.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccessPwd.Location = New System.Drawing.Point(152, 109)
        Me.TxtAccessPwd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtAccessPwd.MaxLength = 40
        Me.TxtAccessPwd.Name = "TxtAccessPwd"
        Me.TxtAccessPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtAccessPwd.Size = New System.Drawing.Size(203, 29)
        Me.TxtAccessPwd.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 108)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 35)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Password"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 31, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.Label9.Size = New System.Drawing.Size(814, 42)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "ACCESS Database"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlServer
        '
        Me.PnlServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlServer.Controls.Add(Me.CboServer)
        Me.PnlServer.Controls.Add(Me.Label4)
        Me.PnlServer.Controls.Add(Me.CboDB)
        Me.PnlServer.Controls.Add(Me.Label12)
        Me.PnlServer.Controls.Add(Me.Label13)
        Me.PnlServer.Controls.Add(Me.Label14)
        Me.PnlServer.Controls.Add(Me.TxtUserName)
        Me.PnlServer.Controls.Add(Me.Label20)
        Me.PnlServer.Controls.Add(Me.TxtPassword)
        Me.PnlServer.Location = New System.Drawing.Point(19, 89)
        Me.PnlServer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PnlServer.Name = "PnlServer"
        Me.PnlServer.Size = New System.Drawing.Size(816, 347)
        Me.PnlServer.TabIndex = 112
        '
        'CboServer
        '
        Me.CboServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CboServer.FormattingEnabled = True
        Me.CboServer.Items.AddRange(New Object() {"..."})
        Me.CboServer.Location = New System.Drawing.Point(183, 69)
        Me.CboServer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CboServer.Name = "CboServer"
        Me.CboServer.Size = New System.Drawing.Size(364, 33)
        Me.CboServer.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 31, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(814, 42)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "SQL SERVER Engine"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CboDB
        '
        Me.CboDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDB.FormattingEnabled = True
        Me.CboDB.Location = New System.Drawing.Point(183, 120)
        Me.CboDB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CboDB.Name = "CboDB"
        Me.CboDB.Size = New System.Drawing.Size(336, 33)
        Me.CboDB.TabIndex = 0
        Me.CboDB.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(26, 259)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 60)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Password"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(22, 58)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 60)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Server Name"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(22, 205)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 60)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "User name"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtUserName
        '
        Me.TxtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserName.Location = New System.Drawing.Point(183, 222)
        Me.TxtUserName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(246, 30)
        Me.TxtUserName.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(22, 108)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(152, 60)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Database Name"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label20.Visible = False
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(183, 274)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(246, 30)
        Me.TxtPassword.TabIndex = 4
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Pnl_refno)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage3.Size = New System.Drawing.Size(905, 681)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Pnl_refno
        '
        Me.Pnl_refno.Controls.Add(Me.LblRefNoError)
        Me.Pnl_refno.Controls.Add(Me.GroupBox1)
        Me.Pnl_refno.Controls.Add(Me.Label6)
        Me.Pnl_refno.Controls.Add(Me.Label7)
        Me.Pnl_refno.Controls.Add(Me.TxtId)
        Me.Pnl_refno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_refno.Location = New System.Drawing.Point(4, 5)
        Me.Pnl_refno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pnl_refno.Name = "Pnl_refno"
        Me.Pnl_refno.Size = New System.Drawing.Size(897, 671)
        Me.Pnl_refno.TabIndex = 0
        '
        'LblRefNoError
        '
        Me.LblRefNoError.BackColor = System.Drawing.Color.Transparent
        Me.LblRefNoError.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRefNoError.ForeColor = System.Drawing.Color.Black
        Me.LblRefNoError.Image = CType(resources.GetObject("LblRefNoError.Image"), System.Drawing.Image)
        Me.LblRefNoError.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LblRefNoError.Location = New System.Drawing.Point(40, 269)
        Me.LblRefNoError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblRefNoError.Name = "LblRefNoError"
        Me.LblRefNoError.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblRefNoError.Size = New System.Drawing.Size(598, 42)
        Me.LblRefNoError.TabIndex = 116
        Me.LblRefNoError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblRefNoError.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 111)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(598, 154)
        Me.GroupBox1.TabIndex = 115
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.WeighingSystemV1_1.My.Resources.Resources.Info_48
        Me.PictureBox1.Location = New System.Drawing.Point(24, 48)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 71)
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(107, 39)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(468, 80)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Type the desired number where you want your transaction reference number to start" &
    "."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 31, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(897, 51)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Transaction Reference Number Maintenance"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(36, 66)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 40)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Reference No.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtId
        '
        Me.TxtId.AcceptsReturn = True
        Me.TxtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtId.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.Location = New System.Drawing.Point(197, 66)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtId.MaxLength = 15
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(201, 35)
        Me.TxtId.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.s)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage4.Size = New System.Drawing.Size(905, 681)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        's
        '
        Me.s.Controls.Add(Me.Tv_Printers)
        Me.s.Controls.Add(Me.Label21)
        Me.s.Dock = System.Windows.Forms.DockStyle.Fill
        Me.s.Location = New System.Drawing.Point(4, 5)
        Me.s.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(897, 671)
        Me.s.TabIndex = 0
        '
        'Tv_Printers
        '
        Me.Tv_Printers.ImageIndex = 0
        Me.Tv_Printers.ImageList = Me.ImageList1
        Me.Tv_Printers.Location = New System.Drawing.Point(12, 55)
        Me.Tv_Printers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tv_Printers.Name = "Tv_Printers"
        Me.Tv_Printers.SelectedImageIndex = 0
        Me.Tv_Printers.Size = New System.Drawing.Size(865, 132)
        Me.Tv_Printers.TabIndex = 115
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(0, 0)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 31, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.Label21.Size = New System.Drawing.Size(897, 42)
        Me.Label21.TabIndex = 114
        Me.Label21.Text = "Printers"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Pnl_General)
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage5.Size = New System.Drawing.Size(905, 681)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Pnl_General
        '
        Me.Pnl_General.AutoScroll = True
        Me.Pnl_General.Controls.Add(Me.Panel11)
        Me.Pnl_General.Controls.Add(Me.nupdTareWtTol)
        Me.Pnl_General.Controls.Add(Me.Label38)
        Me.Pnl_General.Controls.Add(Me.Label37)
        Me.Pnl_General.Controls.Add(Me.Panel10)
        Me.Pnl_General.Controls.Add(Me.Panel9)
        Me.Pnl_General.Controls.Add(Me.Panel8)
        Me.Pnl_General.Controls.Add(Me.Panel7)
        Me.Pnl_General.Controls.Add(Me.Chk_EnableDeduction)
        Me.Pnl_General.Controls.Add(Me.Label24)
        Me.Pnl_General.Controls.Add(Me.Panel6)
        Me.Pnl_General.Controls.Add(Me.Chk_EnablePricing)
        Me.Pnl_General.Controls.Add(Me.Panel4)
        Me.Pnl_General.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_General.Location = New System.Drawing.Point(4, 5)
        Me.Pnl_General.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pnl_General.Name = "Pnl_General"
        Me.Pnl_General.Size = New System.Drawing.Size(897, 671)
        Me.Pnl_General.TabIndex = 0
        '
        'nupdTareWtTol
        '
        Me.nupdTareWtTol.DecimalPlaces = 2
        Me.nupdTareWtTol.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.nupdTareWtTol.Location = New System.Drawing.Point(172, 715)
        Me.nupdTareWtTol.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nupdTareWtTol.Name = "nupdTareWtTol"
        Me.nupdTareWtTol.Size = New System.Drawing.Size(269, 29)
        Me.nupdTareWtTol.TabIndex = 120
        Me.nupdTareWtTol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(454, 722)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(23, 22)
        Me.Label38.TabIndex = 122
        Me.Label38.Text = "%"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(17, 720)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(143, 22)
        Me.Label37.TabIndex = 121
        Me.Label37.Text = "Tare Wt Tolerance"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.RdoDKg)
        Me.Panel10.Controls.Add(Me.RdoDP)
        Me.Panel10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel10.Location = New System.Drawing.Point(315, 295)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(309, 35)
        Me.Panel10.TabIndex = 119
        '
        'RdoDKg
        '
        Me.RdoDKg.AutoSize = True
        Me.RdoDKg.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoDKg.Location = New System.Drawing.Point(9, 2)
        Me.RdoDKg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdoDKg.Name = "RdoDKg"
        Me.RdoDKg.Size = New System.Drawing.Size(131, 26)
        Me.RdoDKg.TabIndex = 1
        Me.RdoDKg.TabStop = True
        Me.RdoDKg.Text = "Per Kilogram"
        Me.RdoDKg.UseVisualStyleBackColor = True
        '
        'RdoDP
        '
        Me.RdoDP.AutoSize = True
        Me.RdoDP.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoDP.Location = New System.Drawing.Point(152, 2)
        Me.RdoDP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdoDP.Name = "RdoDP"
        Me.RdoDP.Size = New System.Drawing.Size(120, 26)
        Me.RdoDP.TabIndex = 2
        Me.RdoDP.TabStop = True
        Me.RdoDP.Text = "Percentage"
        Me.RdoDP.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.cboConnType)
        Me.Panel9.Controls.Add(Me.Label35)
        Me.Panel9.Controls.Add(Me.CboIndicator)
        Me.Panel9.Controls.Add(Me.Label31)
        Me.Panel9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel9.Location = New System.Drawing.Point(12, 595)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(559, 99)
        Me.Panel9.TabIndex = 6
        '
        'cboConnType
        '
        Me.cboConnType.DropDownHeight = 90
        Me.cboConnType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConnType.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConnType.FormattingEnabled = True
        Me.cboConnType.IntegralHeight = False
        Me.cboConnType.ItemHeight = 22
        Me.cboConnType.Items.AddRange(New Object() {"GSE460", "RinstrumR323"})
        Me.cboConnType.Location = New System.Drawing.Point(160, 55)
        Me.cboConnType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboConnType.Name = "cboConnType"
        Me.cboConnType.Size = New System.Drawing.Size(268, 30)
        Me.cboConnType.TabIndex = 117
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(4, 55)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(94, 22)
        Me.Label35.TabIndex = 116
        Me.Label35.Text = "Connection"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CboIndicator
        '
        Me.CboIndicator.DropDownHeight = 90
        Me.CboIndicator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboIndicator.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboIndicator.FormattingEnabled = True
        Me.CboIndicator.IntegralHeight = False
        Me.CboIndicator.ItemHeight = 22
        Me.CboIndicator.Items.AddRange(New Object() {"GSE460", "GSE460V2", "RINSTRUMR323V2", "RINSTRUMR323V3", "RINSTRUMR323V4", "ZM201", "ZM405"})
        Me.CboIndicator.Location = New System.Drawing.Point(160, 12)
        Me.CboIndicator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CboIndicator.Name = "CboIndicator"
        Me.CboIndicator.Size = New System.Drawing.Size(268, 30)
        Me.CboIndicator.TabIndex = 0
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(4, 20)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(119, 22)
        Me.Label31.TabIndex = 115
        Me.Label31.Text = "Indicator Type:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label29)
        Me.Panel8.Controls.Add(Me.Rdo_SingleWeighing)
        Me.Panel8.Controls.Add(Me.Rdo_InOutWeighing)
        Me.Panel8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(4, 62)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(569, 59)
        Me.Panel8.TabIndex = 0
        '
        'rdoWMStandard
        '
        Me.rdoWMStandard.AutoSize = True
        Me.rdoWMStandard.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoWMStandard.Location = New System.Drawing.Point(164, 8)
        Me.rdoWMStandard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoWMStandard.Name = "rdoWMStandard"
        Me.rdoWMStandard.Size = New System.Drawing.Size(118, 26)
        Me.rdoWMStandard.TabIndex = 117
        Me.rdoWMStandard.TabStop = True
        Me.rdoWMStandard.Text = "STANDARD"
        Me.rdoWMStandard.UseVisualStyleBackColor = True
        '
        'rdoWMAxle
        '
        Me.rdoWMAxle.AutoSize = True
        Me.rdoWMAxle.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoWMAxle.Location = New System.Drawing.Point(344, 8)
        Me.rdoWMAxle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoWMAxle.Name = "rdoWMAxle"
        Me.rdoWMAxle.Size = New System.Drawing.Size(73, 26)
        Me.rdoWMAxle.TabIndex = 118
        Me.rdoWMAxle.TabStop = True
        Me.rdoWMAxle.Text = "AXLE"
        Me.rdoWMAxle.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(5, 8)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(123, 22)
        Me.Label40.TabIndex = 116
        Me.Label40.Text = "Weighing Mode"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(4, 20)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(119, 22)
        Me.Label29.TabIndex = 115
        Me.Label29.Text = "Weighing Type:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Rdo_SingleWeighing
        '
        Me.Rdo_SingleWeighing.AutoSize = True
        Me.Rdo_SingleWeighing.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdo_SingleWeighing.Location = New System.Drawing.Point(163, 20)
        Me.Rdo_SingleWeighing.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Rdo_SingleWeighing.Name = "Rdo_SingleWeighing"
        Me.Rdo_SingleWeighing.Size = New System.Drawing.Size(173, 26)
        Me.Rdo_SingleWeighing.TabIndex = 0
        Me.Rdo_SingleWeighing.TabStop = True
        Me.Rdo_SingleWeighing.Text = "SINGLE WEIGHING"
        Me.Rdo_SingleWeighing.UseVisualStyleBackColor = True
        '
        'Rdo_InOutWeighing
        '
        Me.Rdo_InOutWeighing.AutoSize = True
        Me.Rdo_InOutWeighing.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdo_InOutWeighing.Location = New System.Drawing.Point(343, 20)
        Me.Rdo_InOutWeighing.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Rdo_InOutWeighing.Name = "Rdo_InOutWeighing"
        Me.Rdo_InOutWeighing.Size = New System.Drawing.Size(211, 26)
        Me.Rdo_InOutWeighing.TabIndex = 1
        Me.Rdo_InOutWeighing.TabStop = True
        Me.Rdo_InOutWeighing.Text = "IN AND OUT WEIGHING"
        Me.Rdo_InOutWeighing.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label39)
        Me.Panel7.Controls.Add(Me.cboPrinter)
        Me.Panel7.Controls.Add(Me.Pnl_PrintInOut)
        Me.Panel7.Controls.Add(Me.Label30)
        Me.Panel7.Controls.Add(Me.RdoDisablePrint)
        Me.Panel7.Controls.Add(Me.RdoEnablePrint)
        Me.Panel7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(15, 336)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(558, 248)
        Me.Panel7.TabIndex = 5
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(2, 19)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(117, 22)
        Me.Label39.TabIndex = 127
        Me.Label39.Text = "Default Printer"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPrinter
        '
        Me.cboPrinter.DropDownHeight = 90
        Me.cboPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrinter.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPrinter.FormattingEnabled = True
        Me.cboPrinter.IntegralHeight = False
        Me.cboPrinter.ItemHeight = 22
        Me.cboPrinter.Location = New System.Drawing.Point(153, 15)
        Me.cboPrinter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboPrinter.Name = "cboPrinter"
        Me.cboPrinter.Size = New System.Drawing.Size(268, 30)
        Me.cboPrinter.TabIndex = 123
        '
        'Pnl_PrintInOut
        '
        Me.Pnl_PrintInOut.Controls.Add(Me.RdoPrintAll)
        Me.Pnl_PrintInOut.Controls.Add(Me.RdoPrintInOut)
        Me.Pnl_PrintInOut.Location = New System.Drawing.Point(70, 115)
        Me.Pnl_PrintInOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pnl_PrintInOut.Name = "Pnl_PrintInOut"
        Me.Pnl_PrintInOut.Size = New System.Drawing.Size(450, 81)
        Me.Pnl_PrintInOut.TabIndex = 2
        '
        'RdoPrintAll
        '
        Me.RdoPrintAll.AutoSize = True
        Me.RdoPrintAll.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoPrintAll.Location = New System.Drawing.Point(4, 41)
        Me.RdoPrintAll.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdoPrintAll.Name = "RdoPrintAll"
        Me.RdoPrintAll.Size = New System.Drawing.Size(277, 28)
        Me.RdoPrintAll.TabIndex = 4
        Me.RdoPrintAll.TabStop = True
        Me.RdoPrintAll.Text = "Print All details at Weigh-out"
        Me.RdoPrintAll.UseVisualStyleBackColor = True
        '
        'RdoPrintInOut
        '
        Me.RdoPrintInOut.AutoSize = True
        Me.RdoPrintInOut.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoPrintInOut.Location = New System.Drawing.Point(4, 9)
        Me.RdoPrintInOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdoPrintInOut.Name = "RdoPrintInOut"
        Me.RdoPrintInOut.Size = New System.Drawing.Size(252, 28)
        Me.RdoPrintInOut.TabIndex = 3
        Me.RdoPrintInOut.TabStop = True
        Me.RdoPrintInOut.Text = "Print In and Out Separetly"
        Me.RdoPrintInOut.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(70, 90)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(407, 22)
        Me.Label30.TabIndex = 126
        Me.Label30.Text = "Options below are not applicable to SINGLE WEIGHING"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RdoDisablePrint
        '
        Me.RdoDisablePrint.AutoSize = True
        Me.RdoDisablePrint.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoDisablePrint.Location = New System.Drawing.Point(-2, 206)
        Me.RdoDisablePrint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdoDisablePrint.Name = "RdoDisablePrint"
        Me.RdoDisablePrint.Size = New System.Drawing.Size(228, 28)
        Me.RdoDisablePrint.TabIndex = 1
        Me.RdoDisablePrint.TabStop = True
        Me.RdoDisablePrint.Text = "Disable Ticket Print-out"
        Me.RdoDisablePrint.UseVisualStyleBackColor = True
        '
        'RdoEnablePrint
        '
        Me.RdoEnablePrint.AutoSize = True
        Me.RdoEnablePrint.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoEnablePrint.Location = New System.Drawing.Point(-2, 58)
        Me.RdoEnablePrint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdoEnablePrint.Name = "RdoEnablePrint"
        Me.RdoEnablePrint.Size = New System.Drawing.Size(226, 28)
        Me.RdoEnablePrint.TabIndex = 0
        Me.RdoEnablePrint.TabStop = True
        Me.RdoEnablePrint.Text = "Enable Ticket Print-Out"
        Me.RdoEnablePrint.UseVisualStyleBackColor = True
        '
        'Chk_EnableDeduction
        '
        Me.Chk_EnableDeduction.AutoSize = True
        Me.Chk_EnableDeduction.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_EnableDeduction.Location = New System.Drawing.Point(15, 298)
        Me.Chk_EnableDeduction.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Chk_EnableDeduction.Name = "Chk_EnableDeduction"
        Me.Chk_EnableDeduction.Size = New System.Drawing.Size(313, 28)
        Me.Chk_EnableDeduction.TabIndex = 4
        Me.Chk_EnableDeduction.Text = "Enable Net Weight Deduction (%)"
        Me.Chk_EnableDeduction.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label24.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(0, 0)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 31, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.Label24.Size = New System.Drawing.Size(871, 51)
        Me.Label24.TabIndex = 118
        Me.Label24.Text = "General Settings"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label23)
        Me.Panel6.Controls.Add(Me.RdoUKg)
        Me.Panel6.Controls.Add(Me.RdoUTons)
        Me.Panel6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(4, 175)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(568, 59)
        Me.Panel6.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(4, 20)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(157, 22)
        Me.Label23.TabIndex = 115
        Me.Label23.Text = "System Unit Weight:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RdoUKg
        '
        Me.RdoUKg.AutoSize = True
        Me.RdoUKg.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoUKg.Location = New System.Drawing.Point(316, 20)
        Me.RdoUKg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdoUKg.Name = "RdoUKg"
        Me.RdoUKg.Size = New System.Drawing.Size(102, 26)
        Me.RdoUKg.TabIndex = 0
        Me.RdoUKg.TabStop = True
        Me.RdoUKg.Text = "Kilogram"
        Me.RdoUKg.UseVisualStyleBackColor = True
        '
        'RdoUTons
        '
        Me.RdoUTons.AutoSize = True
        Me.RdoUTons.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoUTons.Location = New System.Drawing.Point(459, 20)
        Me.RdoUTons.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdoUTons.Name = "RdoUTons"
        Me.RdoUTons.Size = New System.Drawing.Size(69, 26)
        Me.RdoUTons.TabIndex = 1
        Me.RdoUTons.TabStop = True
        Me.RdoUTons.Text = "Tons"
        Me.RdoUTons.UseVisualStyleBackColor = True
        '
        'Chk_EnablePricing
        '
        Me.Chk_EnablePricing.AutoSize = True
        Me.Chk_EnablePricing.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_EnablePricing.Location = New System.Drawing.Point(15, 245)
        Me.Chk_EnablePricing.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Chk_EnablePricing.Name = "Chk_EnablePricing"
        Me.Chk_EnablePricing.Size = New System.Drawing.Size(153, 28)
        Me.Chk_EnablePricing.TabIndex = 3
        Me.Chk_EnablePricing.Text = "Enable Pricing"
        Me.Chk_EnablePricing.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.RdoPKg)
        Me.Panel4.Controls.Add(Me.RdoPTons)
        Me.Panel4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(168, 243)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(405, 35)
        Me.Panel4.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(4, 6)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(114, 22)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Unit Per Price:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RdoPKg
        '
        Me.RdoPKg.AutoSize = True
        Me.RdoPKg.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoPKg.Location = New System.Drawing.Point(153, 2)
        Me.RdoPKg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdoPKg.Name = "RdoPKg"
        Me.RdoPKg.Size = New System.Drawing.Size(131, 26)
        Me.RdoPKg.TabIndex = 1
        Me.RdoPKg.TabStop = True
        Me.RdoPKg.Text = "Per Kilogram"
        Me.RdoPKg.UseVisualStyleBackColor = True
        '
        'RdoPTons
        '
        Me.RdoPTons.AutoSize = True
        Me.RdoPTons.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoPTons.Location = New System.Drawing.Point(296, 2)
        Me.RdoPTons.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdoPTons.Name = "RdoPTons"
        Me.RdoPTons.Size = New System.Drawing.Size(97, 26)
        Me.RdoPTons.TabIndex = 2
        Me.RdoPTons.TabStop = True
        Me.RdoPTons.Text = "Per tons"
        Me.RdoPTons.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Pnl_Profile)
        Me.TabPage6.Location = New System.Drawing.Point(4, 29)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage6.Size = New System.Drawing.Size(905, 681)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "TabPage6"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Pnl_Profile
        '
        Me.Pnl_Profile.Controls.Add(Me.BtnRemove)
        Me.Pnl_Profile.Controls.Add(Me.BtnChange)
        Me.Pnl_Profile.Controls.Add(Me.Pict)
        Me.Pnl_Profile.Controls.Add(Me.Label28)
        Me.Pnl_Profile.Controls.Add(Me.TxtCompanyAddr)
        Me.Pnl_Profile.Controls.Add(Me.Label27)
        Me.Pnl_Profile.Controls.Add(Me.TxtCompanyNme)
        Me.Pnl_Profile.Controls.Add(Me.Label26)
        Me.Pnl_Profile.Controls.Add(Me.Label25)
        Me.Pnl_Profile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Profile.Location = New System.Drawing.Point(4, 5)
        Me.Pnl_Profile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pnl_Profile.Name = "Pnl_Profile"
        Me.Pnl_Profile.Size = New System.Drawing.Size(897, 671)
        Me.Pnl_Profile.TabIndex = 1
        '
        'BtnRemove
        '
        Me.BtnRemove.BackgroundImage = CType(resources.GetObject("BtnRemove.BackgroundImage"), System.Drawing.Image)
        Me.BtnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemove.FlatAppearance.BorderSize = 0
        Me.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemove.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnRemove.ForeColor = System.Drawing.Color.Black
        Me.BtnRemove.GUI_ACCSS = "JMoiakne122208"
        Me.BtnRemove.GUI_ENABLE_HOVER = True
        Me.BtnRemove.GUI_ENABLED = True
        Me.BtnRemove.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnRemove.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnRemove.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnRemove.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnRemove.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRemove.Location = New System.Drawing.Point(309, 475)
        Me.BtnRemove.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(134, 40)
        Me.BtnRemove.TabIndex = 167
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnChange
        '
        Me.BtnChange.BackgroundImage = CType(resources.GetObject("BtnChange.BackgroundImage"), System.Drawing.Image)
        Me.BtnChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnChange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChange.FlatAppearance.BorderSize = 0
        Me.BtnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChange.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnChange.ForeColor = System.Drawing.Color.Black
        Me.BtnChange.GUI_ACCSS = "JMoiakne122208"
        Me.BtnChange.GUI_ENABLE_HOVER = True
        Me.BtnChange.GUI_ENABLED = True
        Me.BtnChange.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnChange.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnChange.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnChange.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnChange.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnChange.Location = New System.Drawing.Point(171, 475)
        Me.BtnChange.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnChange.Name = "BtnChange"
        Me.BtnChange.Size = New System.Drawing.Size(129, 40)
        Me.BtnChange.TabIndex = 166
        Me.BtnChange.Text = "Change"
        Me.BtnChange.UseVisualStyleBackColor = True
        '
        'Pict
        '
        Me.Pict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pict.Location = New System.Drawing.Point(171, 258)
        Me.Pict.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pict.Name = "Pict"
        Me.Pict.Size = New System.Drawing.Size(271, 208)
        Me.Pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pict.TabIndex = 165
        Me.Pict.TabStop = False
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(19, 258)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(143, 41)
        Me.Label28.TabIndex = 164
        Me.Label28.Text = "Company Logo"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCompanyAddr
        '
        Me.TxtCompanyAddr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtCompanyAddr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtCompanyAddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCompanyAddr.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCompanyAddr.Location = New System.Drawing.Point(171, 151)
        Me.TxtCompanyAddr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCompanyAddr.Multiline = True
        Me.TxtCompanyAddr.Name = "TxtCompanyAddr"
        Me.TxtCompanyAddr.Size = New System.Drawing.Size(635, 95)
        Me.TxtCompanyAddr.TabIndex = 163
        Me.TxtCompanyAddr.Text = "TERRINIEL SCALES INCORPORATED"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(19, 151)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(143, 41)
        Me.Label27.TabIndex = 162
        Me.Label27.Text = "Office Address:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCompanyNme
        '
        Me.TxtCompanyNme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtCompanyNme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtCompanyNme.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCompanyNme.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCompanyNme.Location = New System.Drawing.Point(171, 100)
        Me.TxtCompanyNme.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCompanyNme.Name = "TxtCompanyNme"
        Me.TxtCompanyNme.Size = New System.Drawing.Size(635, 37)
        Me.TxtCompanyNme.TabIndex = 161
        Me.TxtCompanyNme.Text = "TERRINIEL SCALES INCORPORATED"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(19, 100)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(143, 41)
        Me.Label26.TabIndex = 160
        Me.Label26.Text = "Company Name:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label25.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(0, 0)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 31, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.Label25.Size = New System.Drawing.Size(897, 51)
        Me.Label25.TabIndex = 118
        Me.Label25.Text = "Company Profile"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.Pnl_Backup)
        Me.TabPage7.Location = New System.Drawing.Point(4, 29)
        Me.TabPage7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage7.Size = New System.Drawing.Size(905, 681)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "TabPage7"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Pnl_Backup
        '
        Me.Pnl_Backup.Controls.Add(Me.GroupBox3)
        Me.Pnl_Backup.Controls.Add(Me.BtnBackupData)
        Me.Pnl_Backup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Backup.Location = New System.Drawing.Point(4, 5)
        Me.Pnl_Backup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pnl_Backup.Name = "Pnl_Backup"
        Me.Pnl_Backup.Size = New System.Drawing.Size(897, 671)
        Me.Pnl_Backup.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(39, 31)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(598, 154)
        Me.GroupBox3.TabIndex = 118
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Details"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = Global.WeighingSystemV1_1.My.Resources.Resources.Info_48
        Me.PictureBox3.Location = New System.Drawing.Point(24, 48)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(73, 71)
        Me.PictureBox3.TabIndex = 116
        Me.PictureBox3.TabStop = False
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label32.Location = New System.Drawing.Point(107, 39)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(468, 80)
        Me.Label32.TabIndex = 12
        Me.Label32.Text = "Get a copy of your Database(Access File)  by clicking the provided button below"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnBackupData
        '
        Me.BtnBackupData.BackgroundImage = CType(resources.GetObject("BtnBackupData.BackgroundImage"), System.Drawing.Image)
        Me.BtnBackupData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBackupData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBackupData.FlatAppearance.BorderSize = 0
        Me.BtnBackupData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBackupData.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnBackupData.ForeColor = System.Drawing.Color.Black
        Me.BtnBackupData.GUI_ACCSS = "JMoiakne122208"
        Me.BtnBackupData.GUI_ENABLE_HOVER = True
        Me.BtnBackupData.GUI_ENABLED = True
        Me.BtnBackupData.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnBackupData.GUI_ICONS = MykeCtrlEx.PushButton.Icons.User20
        Me.BtnBackupData.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnBackupData.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnBackupData.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnBackupData.Image = CType(resources.GetObject("BtnBackupData.Image"), System.Drawing.Image)
        Me.BtnBackupData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBackupData.Location = New System.Drawing.Point(63, 208)
        Me.BtnBackupData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBackupData.Name = "BtnBackupData"
        Me.BtnBackupData.Size = New System.Drawing.Size(315, 61)
        Me.BtnBackupData.TabIndex = 117
        Me.BtnBackupData.Text = "BACKUP DATABASE"
        Me.BtnBackupData.UseVisualStyleBackColor = True
        '
        'Pnl_ActionBtns
        '
        Me.Pnl_ActionBtns.Controls.Add(Me.Panel2)
        Me.Pnl_ActionBtns.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pnl_ActionBtns.Location = New System.Drawing.Point(0, 714)
        Me.Pnl_ActionBtns.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pnl_ActionBtns.Name = "Pnl_ActionBtns"
        Me.Pnl_ActionBtns.Size = New System.Drawing.Size(913, 74)
        Me.Pnl_ActionBtns.TabIndex = 1
        Me.Pnl_ActionBtns.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnCancel)
        Me.Panel2.Controls.Add(Me.BtnEdit)
        Me.Panel2.Controls.Add(Me.BtnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(418, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(495, 74)
        Me.Panel2.TabIndex = 0
        '
        'BtnCancel
        '
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnCancel.ForeColor = System.Drawing.Color.Maroon
        Me.BtnCancel.GUI_ACCSS = "JMoiakne122208"
        Me.BtnCancel.GUI_ENABLE_HOVER = True
        Me.BtnCancel.GUI_ENABLED = True
        Me.BtnCancel.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnCancel.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Cancel24
        Me.BtnCancel.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnCancel.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnCancel.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.Location = New System.Drawing.Point(338, 12)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(147, 58)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.BackgroundImage = CType(resources.GetObject("BtnEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnEdit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnEdit.GUI_ACCSS = "JMoiakne122208"
        Me.BtnEdit.GUI_ENABLE_HOVER = True
        Me.BtnEdit.GUI_ENABLED = True
        Me.BtnEdit.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnEdit.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Edit24
        Me.BtnEdit.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnEdit.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnEdit.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.Location = New System.Drawing.Point(26, 12)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(147, 58)
        Me.BtnEdit.TabIndex = 0
        Me.BtnEdit.Text = "&Edit"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSave.GUI_ACCSS = "JMoiakne122208"
        Me.BtnSave.GUI_ENABLE_HOVER = True
        Me.BtnSave.GUI_ENABLED = True
        Me.BtnSave.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnSave.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Save26
        Me.BtnSave.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnSave.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnSave.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(181, 12)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(147, 58)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Pnl_Buttons
        '
        Me.Pnl_Buttons.BackColor = System.Drawing.Color.White
        Me.Pnl_Buttons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Buttons.Controls.Add(Me.BtnBackup)
        Me.Pnl_Buttons.Controls.Add(Me.BtnProfile)
        Me.Pnl_Buttons.Controls.Add(Me.BtnGeneral)
        Me.Pnl_Buttons.Controls.Add(Me.BtnPrinters)
        Me.Pnl_Buttons.Controls.Add(Me.BtnRefNo)
        Me.Pnl_Buttons.Controls.Add(Me.BtnDbase)
        Me.Pnl_Buttons.Controls.Add(Me.BtnPorts)
        Me.Pnl_Buttons.Controls.Add(Me.Lbl_PortLabel)
        Me.Pnl_Buttons.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pnl_Buttons.Location = New System.Drawing.Point(8, 8)
        Me.Pnl_Buttons.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pnl_Buttons.Name = "Pnl_Buttons"
        Me.Pnl_Buttons.Size = New System.Drawing.Size(343, 790)
        Me.Pnl_Buttons.TabIndex = 0
        '
        'BtnBackup
        '
        Me.BtnBackup.BackgroundImage = CType(resources.GetObject("BtnBackup.BackgroundImage"), System.Drawing.Image)
        Me.BtnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBackup.FlatAppearance.BorderSize = 0
        Me.BtnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBackup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnBackup.ForeColor = System.Drawing.Color.Black
        Me.BtnBackup.GUI_ACCSS = "JMoiakne122208"
        Me.BtnBackup.GUI_ENABLE_HOVER = True
        Me.BtnBackup.GUI_ENABLED = True
        Me.BtnBackup.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnBackup.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnBackup.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnBackup.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnBackup.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBackup.Location = New System.Drawing.Point(17, 414)
        Me.BtnBackup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBackup.Name = "BtnBackup"
        Me.BtnBackup.Size = New System.Drawing.Size(315, 59)
        Me.BtnBackup.TabIndex = 111
        Me.BtnBackup.Text = "Backup Data"
        Me.BtnBackup.UseVisualStyleBackColor = True
        '
        'BtnProfile
        '
        Me.BtnProfile.BackgroundImage = CType(resources.GetObject("BtnProfile.BackgroundImage"), System.Drawing.Image)
        Me.BtnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProfile.FlatAppearance.BorderSize = 0
        Me.BtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProfile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnProfile.ForeColor = System.Drawing.Color.Black
        Me.BtnProfile.GUI_ACCSS = "JMoiakne122208"
        Me.BtnProfile.GUI_ENABLE_HOVER = True
        Me.BtnProfile.GUI_ENABLED = True
        Me.BtnProfile.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnProfile.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Settings20
        Me.BtnProfile.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnProfile.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnProfile.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnProfile.Image = CType(resources.GetObject("BtnProfile.Image"), System.Drawing.Image)
        Me.BtnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProfile.Location = New System.Drawing.Point(17, 346)
        Me.BtnProfile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnProfile.Name = "BtnProfile"
        Me.BtnProfile.Size = New System.Drawing.Size(315, 59)
        Me.BtnProfile.TabIndex = 110
        Me.BtnProfile.Text = "Company Profile"
        Me.BtnProfile.UseVisualStyleBackColor = True
        '
        'BtnGeneral
        '
        Me.BtnGeneral.BackgroundImage = CType(resources.GetObject("BtnGeneral.BackgroundImage"), System.Drawing.Image)
        Me.BtnGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGeneral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGeneral.FlatAppearance.BorderSize = 0
        Me.BtnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGeneral.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnGeneral.ForeColor = System.Drawing.Color.Black
        Me.BtnGeneral.GUI_ACCSS = "JMoiakne122208"
        Me.BtnGeneral.GUI_ENABLE_HOVER = True
        Me.BtnGeneral.GUI_ENABLED = True
        Me.BtnGeneral.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGeneral.GUI_ICONS = MykeCtrlEx.PushButton.Icons.User20
        Me.BtnGeneral.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnGeneral.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnGeneral.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnGeneral.Image = CType(resources.GetObject("BtnGeneral.Image"), System.Drawing.Image)
        Me.BtnGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGeneral.Location = New System.Drawing.Point(17, 69)
        Me.BtnGeneral.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnGeneral.Name = "BtnGeneral"
        Me.BtnGeneral.Size = New System.Drawing.Size(315, 61)
        Me.BtnGeneral.TabIndex = 109
        Me.BtnGeneral.Text = "General Settings"
        Me.BtnGeneral.UseVisualStyleBackColor = True
        '
        'BtnPrinters
        '
        Me.BtnPrinters.BackgroundImage = CType(resources.GetObject("BtnPrinters.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrinters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrinters.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrinters.FlatAppearance.BorderSize = 0
        Me.BtnPrinters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrinters.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnPrinters.ForeColor = System.Drawing.Color.Black
        Me.BtnPrinters.GUI_ACCSS = "JMoiakne122208"
        Me.BtnPrinters.GUI_ENABLE_HOVER = True
        Me.BtnPrinters.GUI_ENABLED = True
        Me.BtnPrinters.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPrinters.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Printer24
        Me.BtnPrinters.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnPrinters.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnPrinters.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnPrinters.Image = CType(resources.GetObject("BtnPrinters.Image"), System.Drawing.Image)
        Me.BtnPrinters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrinters.Location = New System.Drawing.Point(17, 485)
        Me.BtnPrinters.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnPrinters.Name = "BtnPrinters"
        Me.BtnPrinters.Size = New System.Drawing.Size(315, 59)
        Me.BtnPrinters.TabIndex = 3
        Me.BtnPrinters.Text = "Printers"
        Me.BtnPrinters.UseVisualStyleBackColor = True
        Me.BtnPrinters.Visible = False
        '
        'BtnRefNo
        '
        Me.BtnRefNo.BackgroundImage = CType(resources.GetObject("BtnRefNo.BackgroundImage"), System.Drawing.Image)
        Me.BtnRefNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRefNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefNo.FlatAppearance.BorderSize = 0
        Me.BtnRefNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnRefNo.ForeColor = System.Drawing.Color.Black
        Me.BtnRefNo.GUI_ACCSS = "JMoiakne122208"
        Me.BtnRefNo.GUI_ENABLE_HOVER = True
        Me.BtnRefNo.GUI_ENABLED = True
        Me.BtnRefNo.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnRefNo.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Cabinet26
        Me.BtnRefNo.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnRefNo.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnRefNo.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnRefNo.Image = CType(resources.GetObject("BtnRefNo.Image"), System.Drawing.Image)
        Me.BtnRefNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefNo.Location = New System.Drawing.Point(17, 279)
        Me.BtnRefNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRefNo.Name = "BtnRefNo"
        Me.BtnRefNo.Size = New System.Drawing.Size(315, 59)
        Me.BtnRefNo.TabIndex = 2
        Me.BtnRefNo.Text = "&Reference Number"
        Me.BtnRefNo.UseVisualStyleBackColor = True
        '
        'BtnDbase
        '
        Me.BtnDbase.BackgroundImage = CType(resources.GetObject("BtnDbase.BackgroundImage"), System.Drawing.Image)
        Me.BtnDbase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDbase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDbase.FlatAppearance.BorderSize = 0
        Me.BtnDbase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDbase.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnDbase.ForeColor = System.Drawing.Color.Black
        Me.BtnDbase.GUI_ACCSS = "JMoiakne122208"
        Me.BtnDbase.GUI_ENABLE_HOVER = True
        Me.BtnDbase.GUI_ENABLED = True
        Me.BtnDbase.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnDbase.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Database26
        Me.BtnDbase.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnDbase.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnDbase.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnDbase.Image = CType(resources.GetObject("BtnDbase.Image"), System.Drawing.Image)
        Me.BtnDbase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDbase.Location = New System.Drawing.Point(17, 211)
        Me.BtnDbase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDbase.Name = "BtnDbase"
        Me.BtnDbase.Size = New System.Drawing.Size(315, 59)
        Me.BtnDbase.TabIndex = 1
        Me.BtnDbase.Text = "&Database Connection"
        Me.BtnDbase.UseVisualStyleBackColor = True
        '
        'BtnPorts
        '
        Me.BtnPorts.BackgroundImage = CType(resources.GetObject("BtnPorts.BackgroundImage"), System.Drawing.Image)
        Me.BtnPorts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPorts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPorts.FlatAppearance.BorderSize = 0
        Me.BtnPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPorts.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnPorts.ForeColor = System.Drawing.Color.Black
        Me.BtnPorts.GUI_ACCSS = "JMoiakne122208"
        Me.BtnPorts.GUI_ENABLE_HOVER = True
        Me.BtnPorts.GUI_ENABLED = True
        Me.BtnPorts.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPorts.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Edit24
        Me.BtnPorts.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnPorts.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnPorts.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnPorts.Image = CType(resources.GetObject("BtnPorts.Image"), System.Drawing.Image)
        Me.BtnPorts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPorts.Location = New System.Drawing.Point(17, 140)
        Me.BtnPorts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnPorts.Name = "BtnPorts"
        Me.BtnPorts.Size = New System.Drawing.Size(315, 61)
        Me.BtnPorts.TabIndex = 0
        Me.BtnPorts.Text = "Serial/Comm Ports"
        Me.BtnPorts.UseVisualStyleBackColor = True
        '
        'Lbl_PortLabel
        '
        Me.Lbl_PortLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Lbl_PortLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lbl_PortLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PortLabel.ForeColor = System.Drawing.Color.Black
        Me.Lbl_PortLabel.Image = CType(resources.GetObject("Lbl_PortLabel.Image"), System.Drawing.Image)
        Me.Lbl_PortLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lbl_PortLabel.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_PortLabel.Margin = New System.Windows.Forms.Padding(4, 31, 4, 0)
        Me.Lbl_PortLabel.Name = "Lbl_PortLabel"
        Me.Lbl_PortLabel.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.Lbl_PortLabel.Size = New System.Drawing.Size(341, 51)
        Me.Lbl_PortLabel.TabIndex = 108
        Me.Lbl_PortLabel.Text = "SYSTEM SETTINGS"
        Me.Lbl_PortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Label40)
        Me.Panel11.Controls.Add(Me.rdoWMStandard)
        Me.Panel11.Controls.Add(Me.rdoWMAxle)
        Me.Panel11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel11.Location = New System.Drawing.Point(4, 126)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(568, 41)
        Me.Panel11.TabIndex = 123
        '
        'FrmSystemSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 855)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSystemSettings"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "System Settings"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Pnl_Details.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Pnl_Ports.ResumeLayout(False)
        Me.Pnl_Adv.ResumeLayout(False)
        Me.Pnl_Adv.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Pnl_Connection.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.PnlAccess.ResumeLayout(False)
        Me.PnlAccess.PerformLayout()
        Me.PnlServer.ResumeLayout(False)
        Me.PnlServer.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.Pnl_refno.ResumeLayout(False)
        Me.Pnl_refno.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.s.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.Pnl_General.ResumeLayout(False)
        Me.Pnl_General.PerformLayout()
        CType(Me.nupdTareWtTol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Pnl_PrintInOut.ResumeLayout(False)
        Me.Pnl_PrintInOut.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.Pnl_Profile.ResumeLayout(False)
        Me.Pnl_Profile.PerformLayout()
        CType(Me.Pict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.Pnl_Backup.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_ActionBtns.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Pnl_Buttons.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetToDefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Pnl_Buttons As System.Windows.Forms.Panel
    Friend WithEvents BtnRefNo As MykeCtrlEx.PushButton
    Friend WithEvents BtnDbase As MykeCtrlEx.PushButton
    Friend WithEvents BtnPorts As MykeCtrlEx.PushButton
    Friend WithEvents Lbl_PortLabel As System.Windows.Forms.Label
    Friend WithEvents Pnl_Details As System.Windows.Forms.Panel
    Friend WithEvents Pnl_ActionBtns As System.Windows.Forms.Panel
    Friend WithEvents BtnCancel As MykeCtrlEx.PushButton
    Friend WithEvents BtnSave As MykeCtrlEx.PushButton
    Friend WithEvents BtnEdit As MykeCtrlEx.PushButton
    Friend WithEvents BtnPrinters As MykeCtrlEx.PushButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RefeshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnGeneral As MykeCtrlEx.PushButton
    Friend WithEvents BtnProfile As MykeCtrlEx.PushButton
    Friend WithEvents BtnBackup As MykeCtrlEx.PushButton
    Friend WithEvents SFDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Pnl_Ports As System.Windows.Forms.Panel
    Friend WithEvents Pnl_Adv As System.Windows.Forms.Panel
    Friend WithEvents CboPort As System.Windows.Forms.ComboBox
    Friend WithEvents CboParity As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CboBitsPerSecond As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CboStopBits As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CboDataBits As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAdv As MykeCtrlEx.PushButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LblPortError As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TV_Ports As System.Windows.Forms.TreeView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Pnl_Connection As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RdoSErver As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAccess As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PnlAccess As System.Windows.Forms.Panel
    Friend WithEvents BtnBrowse As MykeCtrlEx.PushButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtDBpath As System.Windows.Forms.TextBox
    Friend WithEvents TxtAccessPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PnlServer As System.Windows.Forms.Panel
    Friend WithEvents CboServer As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboDB As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Pnl_refno As System.Windows.Forms.Panel
    Friend WithEvents LblRefNoError As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtId As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents s As System.Windows.Forms.Panel
    Friend WithEvents Tv_Printers As System.Windows.Forms.TreeView
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Pnl_General As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents CboIndicator As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Rdo_SingleWeighing As System.Windows.Forms.RadioButton
    Friend WithEvents Rdo_InOutWeighing As System.Windows.Forms.RadioButton
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Pnl_PrintInOut As System.Windows.Forms.Panel
    Friend WithEvents RdoPrintAll As System.Windows.Forms.RadioButton
    Friend WithEvents RdoPrintInOut As System.Windows.Forms.RadioButton
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents RdoDisablePrint As System.Windows.Forms.RadioButton
    Friend WithEvents RdoEnablePrint As System.Windows.Forms.RadioButton
    Friend WithEvents Chk_EnableDeduction As System.Windows.Forms.CheckBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents RdoUKg As System.Windows.Forms.RadioButton
    Friend WithEvents RdoUTons As System.Windows.Forms.RadioButton
    Friend WithEvents Chk_EnablePricing As System.Windows.Forms.CheckBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents RdoPKg As System.Windows.Forms.RadioButton
    Friend WithEvents RdoPTons As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Pnl_Profile As System.Windows.Forms.Panel
    Friend WithEvents BtnRemove As MykeCtrlEx.PushButton
    Friend WithEvents BtnChange As MykeCtrlEx.PushButton
    Friend WithEvents Pict As System.Windows.Forms.PictureBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TxtCompanyAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TxtCompanyNme As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents Pnl_Backup As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents BtnBackupData As MykeCtrlEx.PushButton
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents RdoDKg As System.Windows.Forms.RadioButton
    Friend WithEvents RdoDP As System.Windows.Forms.RadioButton
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cboConnType As System.Windows.Forms.ComboBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As Label
    Friend WithEvents nupdTareWtTol As NumericUpDown
    Friend WithEvents Label38 As Label
    Friend WithEvents cboPrinter As ComboBox
    Friend WithEvents Label39 As Label
    Friend WithEvents rdoWMStandard As RadioButton
    Friend WithEvents rdoWMAxle As RadioButton
    Friend WithEvents Label40 As Label
    Friend WithEvents Panel11 As Panel
End Class
