Imports System.Runtime.InteropServices
Imports System.IO.Ports
Imports System.Management


Public Class Form1

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Long) As Integer
    Private Const APPCOMMAND_VOLUME_MUTE As Integer = &H80000
    Private Const APPCOMMAND_VOLUME_DOWN As Integer = &H90000
    Private Const APPCOMMAND_VOLUME_UP As Integer = &HA0000
    Private Const WM_APPCOMMAND As Integer = &H319

    Delegate Sub StringInput(ByVal StringOut As String)

    <DllImport("user32.dll")>
    Public Shared Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Try
            Dim searcher As New ManagementObjectSearcher("root\cimv2", "SELECT * FROM Win32_SerialPort")

            For Each SerialPort As ManagementObject In searcher.Get()
                SerialPortList.Items.Add(SerialPort("name"))
            Next

        Catch err As ManagementException
            MessageBox.Show("An error occured while querying for WMI data: " & err.Message)

        End Try

        Dim arduino As Boolean = False

        For Each item As Object In SerialPortList.Items

            If item.ToString.Contains("Arduino") Then
                SerialPortList.Text = item.ToString
                arduino = True
                Exit For
            ElseIf item.ToString.Contains("Blu") Then
                SerialPortList.Text = item.ToString
                arduino = True
                Exit For
            End If
        Next

        If Not arduino Then
            MsgBox("No Arduino can be found..")
            'SerialPortList.Text = SerialPortList.Items.Item(0).ToString
            Me.BackColor = Color.Orange

        End If

    End Sub

    Public Sub connect()
        Dim portname As String
        portname = "COM" & GetPortNumber()

        Try
            SerialPort1.PortName = portname
            SerialPort1.BaudRate = My.Settings.LatestBaudRate
            SerialPort1.Open()
            Me.BackColor = Color.Green

        Catch ex As Exception
            MsgBox("Arduino detected, but no connection could be made")
            Me.BackColor = Color.Red
        End Try

    End Sub

    Private Function GetPortNumber() As String
        Dim com As String = "COM"
        Dim x As Integer = InStr(SerialPortList.Text, com)
        Dim string_after As String = SerialPortList.Text.Substring(x + com.Length - 1)

        Dim closingbracket As String = ")"
        Dim y As Integer = InStr(string_after, closingbracket)
        Dim portnumber As String = string_after.Substring(0, y - 1)

        Return portnumber
    End Function

    Private Sub SerialPort1_DataRecieved(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim StringOut As String
        Try
            StringOut = SerialPort1.ReadLine
            Invoke(New StringInput(AddressOf CMDCom), StringOut)

        Catch ex As Exception
            MsgBox("Check BaudRate")

        End Try
    End Sub

    Private Sub CMDCom(ByVal StringOut As String)
        CMDIn.Text = StringOut
        If StringOut.Contains("UP") Then
            SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_UP))
        ElseIf StringOut.Contains("DOWN") Then
            SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_DOWN))
        End If
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        SerialPort1.Close()
        My.Forms.Settings.Show()
    End Sub

    Private Sub SerialPortList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SerialPortList.SelectedIndexChanged
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
        connect()
    End Sub

    Private Sub SerialPortList_DropDown(sender As Object, e As EventArgs) Handles SerialPortList.DropDown
        Me.BackColor = Color.Orange
    End Sub
End Class
