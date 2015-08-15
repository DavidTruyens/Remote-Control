<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SerialPortList = New System.Windows.Forms.ComboBox()
        Me.ButtonDown = New System.Windows.Forms.Button()
        Me.ButtonUp = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SettingsButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMDIn = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPortList
        '
        Me.SerialPortList.FormattingEnabled = True
        Me.SerialPortList.Location = New System.Drawing.Point(12, 64)
        Me.SerialPortList.Name = "SerialPortList"
        Me.SerialPortList.Size = New System.Drawing.Size(178, 21)
        Me.SerialPortList.TabIndex = 5
        '
        'ButtonDown
        '
        Me.ButtonDown.Location = New System.Drawing.Point(104, 35)
        Me.ButtonDown.Name = "ButtonDown"
        Me.ButtonDown.Size = New System.Drawing.Size(86, 23)
        Me.ButtonDown.TabIndex = 4
        Me.ButtonDown.Text = "Volume Down"
        Me.ButtonDown.UseVisualStyleBackColor = True
        '
        'ButtonUp
        '
        Me.ButtonUp.Location = New System.Drawing.Point(12, 35)
        Me.ButtonUp.Name = "ButtonUp"
        Me.ButtonUp.Size = New System.Drawing.Size(86, 23)
        Me.ButtonUp.TabIndex = 3
        Me.ButtonUp.Text = "Volume Up"
        Me.ButtonUp.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(372, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsButton})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripDropDownButton1.Text = "Menu"
        '
        'SettingsButton
        '
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(116, 22)
        Me.SettingsButton.Text = "Settings"
        '
        'CMDIn
        '
        Me.CMDIn.Location = New System.Drawing.Point(12, 91)
        Me.CMDIn.Name = "CMDIn"
        Me.CMDIn.Size = New System.Drawing.Size(178, 20)
        Me.CMDIn.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 181)
        Me.Controls.Add(Me.CMDIn)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.SerialPortList)
        Me.Controls.Add(Me.ButtonDown)
        Me.Controls.Add(Me.ButtonUp)
        Me.Name = "Form1"
        Me.Text = "Remote Control"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPortList As ComboBox
    Friend WithEvents ButtonDown As Button
    Friend WithEvents ButtonUp As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents SettingsButton As ToolStripMenuItem
    Friend WithEvents CMDIn As TextBox
End Class
