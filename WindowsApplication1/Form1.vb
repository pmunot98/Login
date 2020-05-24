Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        Label4.Visible = False
        ProgressBar1.Visible = False

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 5
        Label4.Text = ProgressBar1.Value & "%" & "Completed"
        If ProgressBar1.Value >= 100 Then
            Timer1.Enabled = False
            If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
                MsgBox("Login Sucessfull", MsgBoxStyle.Information, "Pop Up")
                ProgressBar1.Value = 0
                Close()
            Else
                MsgBox("Invalid User Name and Password", MsgBoxStyle.Information, "Pop Up")
                ProgressBar1.Value = 0
                TextBox1.Focus()
                TextBox1.Text = ""
                TextBox2.Text = ""
                ProgressBar1.Visible = False
                Label4.Visible = False
                Button1.Visible = True

            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label4.Visible = True
        ProgressBar1.Visible = True
        Button1.Visible = False
        Timer1.Enabled = True

    End Sub
End Class
