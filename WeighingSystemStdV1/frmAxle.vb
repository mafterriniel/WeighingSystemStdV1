Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports WeighingSystemV1_1.My

Public Class frmAxle
    Private SysSettings As New settings

    Private AxleWts As New Dictionary(Of Integer, String)

    Private Sub lblAxle1_Click(sender As Object, e As EventArgs) Handles lblAxle1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblGrossWt.Click

    End Sub

    Private Sub frmAxle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SysSettings = New settings
        SysSettings.Load()

        SetPort(TxtOnline)



    End Sub


    Private Sub SetPort(ByRef Txt As WeightDev.WeightIndicator)
        Try
            Txt.CommPortName = SysSettings.comm_port
            Txt.CommBaudRate = SysSettings.baud_rate
            Txt.CommParity = SysSettings.parity
            Txt.CommDataBits = SysSettings.data_bits
            Txt.CommStopBits = SysSettings.stop_bits
            Txt.ConnectionType = SysSettings.DeviceConnectionType.ToString()
            Txt.IPAddress = SysSettings.IPAddress
            Txt.IPPort = SysSettings.IPPort
            Txt.IPReadTimeOut = 3000
            Txt.ReadingInterval = 100
            Txt.CommReadTimeout = 3000
            Txt.WeighingDevice = SysSettings.device
            Txt.WeighingMode = WeightDev.Enums.WeighingModeEnum.AXLE
            Txt.Start()
            LblError.Visible = False
        Catch ex As Exception
            TxtOnline.BackColor = Color.Red
            LblError.Text = "       " & ex.Message
            LblError.Visible = True
        End Try
    End Sub


    Private TotalAxleWt As Decimal
    Private Sub btnReset_Click(sender As Object, e As EventArgs)
        TxtOnline.ResetAxle()

        lblAxle1.Text = 0
        lblAxle2.Text = 0
        lblAxle3.Text = 0
        lblAxle4.Text = 0
        lblAxle5.Text = 0
        lblAxle6.Text = 0
        lblAxle7.Text = 0
        lblAxle8.Text = 0


    End Sub

    Private Sub TxtOnline_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblError_Click(sender As Object, e As EventArgs) Handles LblError.Click

    End Sub

    Private Sub TxtOnline_AxleWt_Added(sender As Object, e As WeightDev.Events.AxleWtAddedEventArgs)
        Select Case e.AxleNum
            Case 1
                lblAxle1.Invoke(New MethodInvoker(Sub()
                                                      lblAxle1.Text = e.Weight
                                                  End Sub))
                lblAxle1Date.Invoke(New MethodInvoker(Sub()
                                                          lblAxle1Date.Text = DateTime.Now
                                                      End Sub))

            Case 2
                lblAxle2.Invoke(New MethodInvoker(Sub()
                                                      lblAxle2.Text = e.Weight
                                                  End Sub))
                lblAxle2Date.Invoke(New MethodInvoker(Sub()
                                                          lblAxle2Date.Text = DateTime.Now
                                                      End Sub))

            Case 3
                lblAxle3.Invoke(New MethodInvoker(Sub()
                                                      lblAxle3.Text = e.Weight
                                                  End Sub))
                lblAxle3Date.Invoke(New MethodInvoker(Sub()
                                                          lblAxle3Date.Text = DateTime.Now
                                                      End Sub))

            Case 4
                lblAxle4.Invoke(New MethodInvoker(Sub()
                                                      lblAxle4.Text = e.Weight
                                                  End Sub))
                lblAxle4Date.Invoke(New MethodInvoker(Sub()
                                                          lblAxle4Date.Text = DateTime.Now
                                                      End Sub))
            Case 5
                lblAxle5.Invoke(New MethodInvoker(Sub()
                                                      lblAxle5.Text = e.Weight
                                                  End Sub))
                lblAxle5Date.Invoke(New MethodInvoker(Sub()
                                                          lblAxle5Date.Text = DateTime.Now
                                                      End Sub))
            Case 6
                lblAxle6.Invoke(New MethodInvoker(Sub()
                                                      lblAxle6.Text = e.Weight
                                                  End Sub))
                lblAxle6Date.Invoke(New MethodInvoker(Sub()
                                                          lblAxle6Date.Text = DateTime.Now
                                                      End Sub))
            Case 7
                lblAxle7.Invoke(New MethodInvoker(Sub()
                                                      lblAxle7.Text = e.Weight
                                                  End Sub))
                lblAxle7Date.Invoke(New MethodInvoker(Sub()
                                                          lblAxle7Date.Text = DateTime.Now
                                                      End Sub))
            Case 8
                lblAxle8.Invoke(New MethodInvoker(Sub()
                                                      lblAxle8.Text = e.Weight
                                                  End Sub))
                lblAxle8Date.Invoke(New MethodInvoker(Sub()
                                                          lblAxle8Date.Text = DateTime.Now
                                                      End Sub))
        End Select

        TotalAxleWt += e.Weight
        lblGrossWt.Invoke(New MethodInvoker(Sub()
                                                lblGrossWt.Text = TotalAxleWt
                                            End Sub))

        lblAxleCount.Invoke(New MethodInvoker(Sub()
                                                  lblAxleCount.Text = e.AxleNum
                                              End Sub))

    End Sub

    Private Sub frmAxle_ChangeUICues(sender As Object, e As UICuesEventArgs) Handles MyBase.ChangeUICues

    End Sub

    Private Sub frmAxle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TxtOnline.Stop()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PnlHeader_Paint(sender As Object, e As PaintEventArgs) Handles PnlHeader.Paint

    End Sub
End Class