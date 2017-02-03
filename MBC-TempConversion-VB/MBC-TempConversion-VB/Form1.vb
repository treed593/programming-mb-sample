Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCelcius.Text = ""
        lblKelvin.Text = ""
        lblAdvice.Text = ""
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim tmpEntered, tmpCelcius As Double
        ' Create a variable as Double to store the kelvin temperature
        Dim tmpKelvin As Double

        tmpEntered = Double.Parse(txtTemperature.Text)
        tmpCelcius = ((5 / 9) * (tmpEntered - 32))
        lblCelcius.Text = tmpCelcius.ToString + " degrees Celcius"
        Me.lblCelcius.Left = Me.ClientSize.Width / 2 - Me.lblCelcius.Width / 2

        ' Calculate Kelvin Here
        tmpKelvin = ((tmpEntered + 459.67) * (5 / 9))

        ' Set lblKelvin to value of Kelvin variable
        lblKelvin.Text = tmpKelvin.ToString + " degrees Kelvin"
        Me.lblKelvin.Left = Me.ClientSize.Width / 2 - Me.lblKelvin.Width / 2

        If tmpEntered > 100 Then
            lblAdvice.ForeColor = Color.Red
            lblAdvice.Text = "Better Hydrate"
            Me.lblAdvice.Left = Me.ClientSize.Width / 2 - Me.lblAdvice.Width / 2
        ElseIf tmpEntered < 32 Then
            lblAdvice.ForeColor = Color.BlueViolet
            lblAdvice.Text = "It's Cold Outside, better dress warm"
            Me.lblAdvice.Left = Me.ClientSize.Width / 2 - Me.lblAdvice.Width / 2
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblCelcius.Text = ""
        lblKelvin.Text = ""
        lblAdvice.Text = ""
        txtTemperature.Text = ""
        txtTemperature.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
