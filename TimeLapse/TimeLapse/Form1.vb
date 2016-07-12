Imports System
Imports System.IO.Ports
Imports System.Threading


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        start_Dir.SelectedIndex = 0
        getCom()
        ' port_Connection.SelectedIndex = 0
        baud_Connection.SelectedIndex = 0
    End Sub
    Private Sub getCom()
        port_Connection.Items.Clear()
        Dim myPort As Array
        myPort = IO.Ports.SerialPort.GetPortNames() 'Get all com ports available
        For i = 0 To UBound(myPort)
            port_Connection.Items.Add(myPort(i))
        Next
        port_Connection.SelectedIndex = 0
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getCom()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case Button2.Text
            Case "Connect"
                '  MsgBox("We are conneecting")
                ' Button2.Text = "Disconnect"
                ConnectSerial()

            Case "Disconnect"
                '  MsgBox("We are Dis-conneecting")
                DisconnectSerial()
                ' Button2.Text = "Connect"
        End Select
    End Sub

    Private Sub ConnectSerial()

        Try
            SerialPort1.PortName = port_Connection.Text
            SerialPort1.Close()
            SerialPort1.BaudRate = baud_Connection.Text
            SerialPort1.DataBits = 8
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.Handshake = Handshake.None
            SerialPort1.Encoding = System.Text.Encoding.UTF8
            SerialPort1.ReadTimeout = 10000
            SerialPort1.Open()
            Button2.Text = "Disconnect"
            port_Connection.Enabled = False
            baud_Connection.Enabled = False
            status.BackColor = Color.Green
            SerialText.AppendText("Connected on: " & SerialPort1.PortName & vbNewLine & TimeOfDay & vbNewLine & "-------------------------------" & vbNewLine)
            Me.Text = "Time/Lapse Connected @ " & SerialPort1.PortName
        Catch ex As Exception
            MsgBox("Port is busy...")
            status.BackColor = Color.Yellow
        End Try

    End Sub
    Private Sub DisconnectSerial()
        SerialPort1.Close()
        Button2.Text = "Connect"
        port_Connection.Enabled = True
        baud_Connection.Enabled = True
        status.BackColor = Color.Red
        Me.Text = "Time/Lapse "
    End Sub
    Private Sub Quit_mMenu_Click(sender As Object, e As EventArgs) Handles Quit_mMenu.Click
        DisconnectSerial()
        Me.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SerialText.Text = ""
    End Sub

    Delegate Sub myMethodDelegate(ByVal [text] As String)
    Dim myD1 As New myMethodDelegate(AddressOf myShowStringMethod)
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim str As String = SerialPort1.ReadExisting()
        Invoke(myD1, str)
    End Sub
    Sub myShowStringMethod(ByVal myString As String)
        SerialText.AppendText(myString)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DisconnectSerial()
    End Sub
End Class
