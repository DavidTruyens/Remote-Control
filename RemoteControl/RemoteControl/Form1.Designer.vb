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
        Me.SerialPortList = New System.Windows.Forms.ComboBox()
        Me.ButtonDown = New System.Windows.Forms.Button()
        Me.ButtonUp = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'SerialPortList
        '
        Me.SerialPortList.FormattingEnabled = True
        Me.SerialPortList.Location = New System.Drawing.Point(3, 41)
        Me.SerialPortList.Name = "SerialPortList"
        Me.SerialPortList.Size = New System.Drawing.Size(178, 21)
        Me.SerialPortList.TabIndex = 5
        '
        'ButtonDown
        '
        Me.ButtonDown.Location = New System.Drawing.Point(95, 12)
        Me.ButtonDown.Name = "ButtonDown"
        Me.ButtonDown.Size = New System.Drawing.Size(86, 23)
        Me.ButtonDown.TabIndex = 4
        Me.ButtonDown.Text = "Volume Down"
        Me.ButtonDown.UseVisualStyleBackColor = True
        '
        'ButtonUp
        '
        Me.ButtonUp.Location = New System.Drawing.Point(3, 12)
        Me.ButtonUp.Name = "ButtonUp"
        Me.ButtonUp.Size = New System.Drawing.Size(86, 23)
        Me.ButtonUp.TabIndex = 3
        Me.ButtonUp.Text = "Volume Up"
        Me.ButtonUp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(186, 76)
        Me.Controls.Add(Me.SerialPortList)
        Me.Controls.Add(Me.ButtonDown)
        Me.Controls.Add(Me.ButtonUp)
        Me.Name = "Form1"
        Me.Text = "Remote Control"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialPortList As ComboBox
    Friend WithEvents ButtonDown As Button
    Friend WithEvents ButtonUp As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
