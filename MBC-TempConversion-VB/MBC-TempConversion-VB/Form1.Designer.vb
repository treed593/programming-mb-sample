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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCelcius = New System.Windows.Forms.Label()
        Me.lblKelvin = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAdvice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Temperature"
        '
        'txtTemperature
        '
        Me.txtTemperature.Location = New System.Drawing.Point(203, 37)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(100, 26)
        Me.txtTemperature.TabIndex = 1
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(189, 106)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(124, 57)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Convert Temperature"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "The Converted Temperature is:"
        '
        'lblCelcius
        '
        Me.lblCelcius.AutoSize = True
        Me.lblCelcius.Location = New System.Drawing.Point(221, 230)
        Me.lblCelcius.Name = "lblCelcius"
        Me.lblCelcius.Size = New System.Drawing.Size(60, 20)
        Me.lblCelcius.TabIndex = 3
        Me.lblCelcius.Text = "Celcius"
        '
        'lblKelvin
        '
        Me.lblKelvin.AutoSize = True
        Me.lblKelvin.Location = New System.Drawing.Point(221, 261)
        Me.lblKelvin.Name = "lblKelvin"
        Me.lblKelvin.Size = New System.Drawing.Size(50, 20)
        Me.lblKelvin.TabIndex = 3
        Me.lblKelvin.Text = "Kelvin"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(38, 331)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(86, 35)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(389, 331)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 35)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAdvice
        '
        Me.lblAdvice.AutoSize = True
        Me.lblAdvice.Location = New System.Drawing.Point(221, 292)
        Me.lblAdvice.Name = "lblAdvice"
        Me.lblAdvice.Size = New System.Drawing.Size(56, 20)
        Me.lblAdvice.TabIndex = 3
        Me.lblAdvice.Text = "Advice"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 390)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblAdvice)
        Me.Controls.Add(Me.lblKelvin)
        Me.Controls.Add(Me.lblCelcius)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtTemperature)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programming Merit Badge - VB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCelcius As Label
    Friend WithEvents lblKelvin As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAdvice As Label
End Class
