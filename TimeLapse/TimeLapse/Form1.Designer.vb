<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.start_Dir = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_Main = New System.Windows.Forms.TabPage()
        Me.tab_Connect = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.baud_Connection = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.port_Connection = New System.Windows.Forms.ComboBox()
        Me.mMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.New_mMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Open_mMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Close_mMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Save_mMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAs_mMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Quit_mMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialText = New System.Windows.Forms.TextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1.SuspendLayout()
        Me.tab_Main.SuspendLayout()
        Me.tab_Connect.SuspendLayout()
        Me.mMenu.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'start_Dir
        '
        Me.start_Dir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.start_Dir.FormattingEnabled = True
        Me.start_Dir.Items.AddRange(New Object() {"Default", "R/L", "L/R"})
        Me.start_Dir.Location = New System.Drawing.Point(99, 6)
        Me.start_Dir.Name = "start_Dir"
        Me.start_Dir.Size = New System.Drawing.Size(121, 21)
        Me.start_Dir.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Start Direction:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_Main)
        Me.TabControl1.Controls.Add(Me.tab_Connect)
        Me.TabControl1.Location = New System.Drawing.Point(641, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(234, 368)
        Me.TabControl1.TabIndex = 2
        '
        'tab_Main
        '
        Me.tab_Main.Controls.Add(Me.start_Dir)
        Me.tab_Main.Controls.Add(Me.Label1)
        Me.tab_Main.Location = New System.Drawing.Point(4, 22)
        Me.tab_Main.Name = "tab_Main"
        Me.tab_Main.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Main.Size = New System.Drawing.Size(226, 342)
        Me.tab_Main.TabIndex = 0
        Me.tab_Main.Text = "Main"
        Me.tab_Main.UseVisualStyleBackColor = True
        '
        'tab_Connect
        '
        Me.tab_Connect.Controls.Add(Me.Button2)
        Me.tab_Connect.Controls.Add(Me.baud_Connection)
        Me.tab_Connect.Controls.Add(Me.Label3)
        Me.tab_Connect.Controls.Add(Me.Button1)
        Me.tab_Connect.Controls.Add(Me.Label2)
        Me.tab_Connect.Controls.Add(Me.port_Connection)
        Me.tab_Connect.Location = New System.Drawing.Point(4, 22)
        Me.tab_Connect.Name = "tab_Connect"
        Me.tab_Connect.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Connect.Size = New System.Drawing.Size(226, 342)
        Me.tab_Connect.TabIndex = 1
        Me.tab_Connect.Text = "Connection"
        Me.tab_Connect.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(145, 89)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Connect"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'baud_Connection
        '
        Me.baud_Connection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.baud_Connection.FormattingEnabled = True
        Me.baud_Connection.Items.AddRange(New Object() {"9600", "57600"})
        Me.baud_Connection.Location = New System.Drawing.Point(102, 62)
        Me.baud_Connection.Name = "baud_Connection"
        Me.baud_Connection.Size = New System.Drawing.Size(121, 21)
        Me.baud_Connection.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Baud Rate:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(145, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Port:"
        '
        'port_Connection
        '
        Me.port_Connection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.port_Connection.FormattingEnabled = True
        Me.port_Connection.Location = New System.Drawing.Point(99, 6)
        Me.port_Connection.Name = "port_Connection"
        Me.port_Connection.Size = New System.Drawing.Size(121, 21)
        Me.port_Connection.TabIndex = 3
        '
        'mMenu
        '
        Me.mMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mMenu.Location = New System.Drawing.Point(0, 0)
        Me.mMenu.Name = "mMenu"
        Me.mMenu.Size = New System.Drawing.Size(887, 24)
        Me.mMenu.TabIndex = 4
        Me.mMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.New_mMenu, Me.Open_mMenu, Me.Close_mMenu, Me.Save_mMenu, Me.SaveAs_mMenu, Me.ToolStripSeparator1, Me.Quit_mMenu})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'New_mMenu
        '
        Me.New_mMenu.Name = "New_mMenu"
        Me.New_mMenu.Size = New System.Drawing.Size(125, 22)
        Me.New_mMenu.Text = "New"
        '
        'Open_mMenu
        '
        Me.Open_mMenu.Name = "Open_mMenu"
        Me.Open_mMenu.Size = New System.Drawing.Size(125, 22)
        Me.Open_mMenu.Text = "Open"
        '
        'Close_mMenu
        '
        Me.Close_mMenu.Name = "Close_mMenu"
        Me.Close_mMenu.Size = New System.Drawing.Size(125, 22)
        Me.Close_mMenu.Text = "Close"
        '
        'Save_mMenu
        '
        Me.Save_mMenu.Name = "Save_mMenu"
        Me.Save_mMenu.Size = New System.Drawing.Size(125, 22)
        Me.Save_mMenu.Text = "Save"
        '
        'SaveAs_mMenu
        '
        Me.SaveAs_mMenu.Name = "SaveAs_mMenu"
        Me.SaveAs_mMenu.Size = New System.Drawing.Size(125, 22)
        Me.SaveAs_mMenu.Text = "Save As..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(122, 6)
        '
        'Quit_mMenu
        '
        Me.Quit_mMenu.Name = "Quit_mMenu"
        Me.Quit_mMenu.Size = New System.Drawing.Size(125, 22)
        Me.Quit_mMenu.Text = "Quit"
        '
        'SerialText
        '
        Me.SerialText.Location = New System.Drawing.Point(12, 27)
        Me.SerialText.Multiline = True
        Me.SerialText.Name = "SerialText"
        Me.SerialText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SerialText.Size = New System.Drawing.Size(623, 297)
        Me.SerialText.TabIndex = 5
        '
        'SerialPort1
        '
        Me.SerialPort1.DtrEnable = True
        Me.SerialPort1.RtsEnable = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 330)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 462)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(887, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status
        '
        Me.status.AutoSize = False
        Me.status.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(17, 17)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 484)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.SerialText)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.mMenu)
        Me.MainMenuStrip = Me.mMenu
        Me.Name = "Form1"
        Me.Text = "Time/Lapse"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_Main.ResumeLayout(False)
        Me.tab_Main.PerformLayout()
        Me.tab_Connect.ResumeLayout(False)
        Me.tab_Connect.PerformLayout()
        Me.mMenu.ResumeLayout(False)
        Me.mMenu.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents start_Dir As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_Main As System.Windows.Forms.TabPage
    Friend WithEvents tab_Connect As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents port_Connection As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents baud_Connection As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents mMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents New_mMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Open_mMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Close_mMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Save_mMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAs_mMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Quit_mMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SerialText As System.Windows.Forms.TextBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents status As System.Windows.Forms.ToolStripStatusLabel

End Class
