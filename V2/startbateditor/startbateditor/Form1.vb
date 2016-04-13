Public Class Form1
    Private Sub HuraButton1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If HuraComboBox1.SelectedItem = "512 MB" Then
            If HuraRadioButton3.Checked = True Then
                HuraTextBox1.Text = ("java -Xms512M -Xmx512M -jar " & HuraTextBox2.Text & " -o true")
            Else
                If HuraRadioButton4.Checked = True Then
                    HuraTextBox1.Text = ("java -Xms512M -Xmx512M -jar " & HuraTextBox2.Text & " -o false")
                End If
            End If
        Else
            If HuraComboBox1.SelectedItem = "1 GB" Then
                If HuraRadioButton3.Checked = True Then
                    HuraTextBox1.Text = ("java -Xms1024M -Xmx1024M -jar " & HuraTextBox2.Text & " -o true")
                Else
                    If HuraRadioButton4.Checked = True Then
                        HuraTextBox1.Text = ("java -Xms1024M -Xmx1024M -jar " & HuraTextBox2.Text & " -o false")
                    End If
                End If
            Else
                If HuraComboBox1.SelectedItem = "2 GB" Then
                    If HuraRadioButton3.Checked = True Then
                        HuraTextBox1.Text = ("java -Xms2048M -Xmx2048M -jar " & HuraTextBox2.Text & " -o true")
                    Else
                        If HuraRadioButton4.Checked = True Then
                            HuraTextBox1.Text = ("java -Xms2048M -Xms2048M -jar " & HuraTextBox2.Text & " -o false")
                        End If
                    End If
                Else
                    If HuraComboBox1.SelectedItem = "3 GB" Then
                        If HuraRadioButton3.Checked = True Then
                            HuraTextBox1.Text = ("java -Xms3072M -Xms3072M -jar " & HuraTextBox2.Text & " -o true")
                        Else
                            If HuraRadioButton4.Checked = True Then
                                HuraTextBox1.Text = ("java -Xms3072M -Xms3072M -jar " & HuraTextBox2.Text & " -o false")
                            End If
                        End If
                    Else
                        If HuraComboBox1.SelectedItem = "4 GB" Then
                            If HuraRadioButton3.Checked = True Then
                                HuraTextBox1.Text = ("java -Xms4096M -Xms4096M -jar " & HuraTextBox2.Text & " -o true")
                            Else
                                If HuraRadioButton4.Checked = True Then
                                    HuraTextBox1.Text = ("java -Xms4096M -Xms4096M -jar " & HuraTextBox2.Text & " -o false")
                                End If
                            End If
                        Else
                            If HuraComboBox1.SelectedItem = "5 GB" Then
                                If HuraRadioButton3.Checked = True Then
                                    HuraTextBox1.Text = ("java -Xms5120M -Xms5120M -jar " & HuraTextBox2.Text & " -o true")
                                Else
                                    If HuraRadioButton4.Checked = True Then
                                        HuraTextBox1.Text = ("java -Xms5120M -Xms5120M -jar " & HuraTextBox2.Text & " -o false")
                                    End If
                                End If
                            Else
                                If HuraComboBox1.SelectedItem = "6 GB" Then
                                    If HuraRadioButton3.Checked = True Then
                                        HuraTextBox1.Text = ("java -Xms6144M -Xms6144M -jar " & HuraTextBox2.Text & " -o true")
                                    Else
                                        If HuraRadioButton4.Checked = True Then
                                            HuraTextBox1.Text = ("java -Xms6144M -Xms6144M -jar " & HuraTextBox2.Text & " -o false")
                                        End If
                                    End If
                                Else
                                    If HuraComboBox1.SelectedItem = "7 GB" Then
                                        If HuraRadioButton3.Checked = True Then
                                            HuraTextBox1.Text = ("java -Xms7168M -Xms7168M -jar " & HuraTextBox2.Text & " -o true")
                                        Else
                                            If HuraRadioButton4.Checked = True Then
                                                HuraTextBox1.Text = ("java -Xms7168M -Xms7168M -jar " & HuraTextBox2.Text & " -o false")
                                            End If
                                        End If
                                    Else
                                        If HuraComboBox1.SelectedItem = "8 GB" Then
                                            If HuraRadioButton3.Checked = True Then
                                                HuraTextBox1.Text = ("java -Xms8192M -Xms8192M -jar " & HuraTextBox2.Text & " -o true")
                                            Else
                                                If HuraRadioButton4.Checked = True Then
                                                    HuraTextBox1.Text = ("java -Xms8192M -Xms8192M -jar " & HuraTextBox2.Text & " -o false")
                                                End If
                                            End If
                                        Else
                                            If HuraComboBox1.SelectedItem = "9 GB" Then
                                                If HuraRadioButton3.Checked = True Then
                                                    HuraTextBox1.Text = ("java -Xms9216M -Xms9216M -jar " & HuraTextBox2.Text & " -o true")
                                                Else
                                                    If HuraRadioButton4.Checked = True Then
                                                        HuraTextBox1.Text = ("java -Xms9216M -Xms9216M -jar " & HuraTextBox2.Text & " -o false")
                                                    End If
                                                End If
                                            Else
                                                If HuraComboBox1.SelectedItem = "10 GB" Then
                                                    If HuraRadioButton3.Checked = True Then
                                                        HuraTextBox1.Text = ("java -Xms10240M -Xmx10240M -jar " & HuraTextBox2.Text & " -o true")
                                                    Else
                                                        If HuraRadioButton4.Checked = True Then
                                                            HuraTextBox1.Text = ("java -Xms10240M -Xmx10240M -jar " & HuraTextBox2.Text & " -o false")
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        TextBox1.text = HuraTextBox1.Text
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
        'HuraRadioButton1.Checked = False
        'HuraRadioButton2.Checked = False
        'HuraRadioButton3.Checked = False
        'HuraRadioButton4.Checked = False
        'HuraRadioButton5.Checked = False
        'HuraRadioButton6.Checked = False
        'HuraRadioButton7.Checked = False
        'HuraTextBox1.Text = ""
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
