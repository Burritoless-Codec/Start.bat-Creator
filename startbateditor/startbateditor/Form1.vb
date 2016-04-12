Public Class Form1
    Private Sub HuraButton1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If HuraRadioButton1.Checked = True Then
            If HuraRadioButton3.Checked = True Then
                HuraTextBox1.Text = ("java -Xms512M -Xmx512M -jar " & HuraTextBox2.Text & " -o true")
            Else
                If HuraRadioButton4.Checked = True Then
                    HuraTextBox1.Text = ("java -Xms512M -Xmx512M -jar " & HuraTextBox2.Text & " -o false")
                End If
            End If
        Else
            If HuraRadioButton2.Checked = True Then
                If HuraRadioButton3.Checked = True Then
                    HuraTextBox1.Text = ("java -Xms1024M -Xmx1024M -jar " & HuraTextBox2.Text & " -o true")
                Else
                    If HuraRadioButton4.Checked = True Then
                        HuraTextBox1.Text = ("java -Xms1024M -Xmx1024M -jar " & HuraTextBox2.Text & " -o false")
                    End If
                End If
            Else
                If HuraRadioButton5.Checked = True Then
                    If HuraRadioButton3.Checked = True Then
                        HuraTextBox1.Text = ("java -Xms2048M -Xms2048M -jar " & HuraTextBox2.Text & " -o true")
                    Else
                        If HuraRadioButton4.Checked = True Then
                            HuraTextBox1.Text = ("java -Xms2048M -Xms2048M -jar " & HuraTextBox2.Text & " -o false")
                        End If
                    End If
                Else
                    If HuraRadioButton6.Checked = True Then
                        If HuraRadioButton3.Checked = True Then
                            HuraTextBox1.Text = ("java -Xms3072M -Xms3072M -jar " & HuraTextBox2.Text & " -o true")
                        Else
                            If HuraRadioButton4.Checked = True Then
                                HuraTextBox1.Text = ("java -Xms3072M -Xms3072M -jar " & HuraTextBox2.Text & " -o false")
                            End If
                        End If
                    Else
                        If HuraRadioButton7.Checked = True Then
                            If HuraRadioButton3.Checked = True Then
                                HuraTextBox1.Text = ("java -Xms4096M -Xms4096M -jar " & HuraTextBox2.Text & " -o true")
                            Else
                                If HuraRadioButton4.Checked = True Then
                                    HuraTextBox1.Text = ("java -Xms4096M -Xms4096M -jar " & HuraTextBox2.Text & " -o false")
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Textbox1.text = HuraTextBox1.Text
    End Sub

    Private Sub HuraButton1_Click_1(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Dim sfd = New SaveFileDialog
        sfd.Filter = "Batch (*.bat)|*.bat"
        sfd.FileName = "Start"
        If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim sw As New System.IO.StreamWriter(sfd.FileName)
            sw.Write(Me.HuraTextBox1.Text)
            sw.WriteLine("pause")
            sw.Close()
        End If
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        TextBox1.SelectAll()
        TextBox1.Copy()
    End Sub

    Private Sub HuraButton3_Click(sender As Object, e As EventArgs) Handles HuraButton3.Click
        HuraRadioButton1.Checked = False
        HuraRadioButton2.Checked = False
        HuraRadioButton3.Checked = False
        HuraRadioButton4.Checked = False
        HuraRadioButton5.Checked = False
        HuraRadioButton6.Checked = False
        HuraRadioButton7.Checked = False
        HuraTextBox1.Text = ""
    End Sub

    Private Sub HuraButton4_Click(sender As Object, e As EventArgs) Handles HuraButton4.Click
        Me.Close()
    End Sub

    Private Sub HuraButton5_Click(sender As Object, e As EventArgs) Handles HuraButton5.Click
        Form2.Show()
    End Sub

    Private Sub HuraButton6_Click(sender As Object, e As EventArgs) Handles HuraButton6.Click
        Help.show
    End Sub
End Class
