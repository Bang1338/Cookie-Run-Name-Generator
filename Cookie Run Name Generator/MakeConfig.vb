'This one is since 1.2, enough talking.
Public Class MakeConfig

    Private Sub MakeConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Check if empty
        If RichTextBox1.TextLength = 0 Then
            MessageBox.Show("Please load.", "CRNG")
            Exit Sub
        End If

        'Save location
        Dim save As String = SaveFileDialog1.FileName

        'Save
        SaveFileDialog1.Title = "Please select the place where you keep config file"
        SaveFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath
        SaveFileDialog1.Filter = "config.ini|config.ini"

        SaveFileDialog1.ShowDialog()
        'Check if have a place to save or not
        If save > "" Then
            My.Computer.FileSystem.WriteAllText(save, "" & RichTextBox1.Text, True)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'Clear RTB before making it
        'idk why the answer from GDye get 3 downvote
        'https://stackoverflow.com/questions/10805134/how-to-clear-text-content-in-richtextbox
        RichTextBox1.Clear()

        'Generate first part
        RichTextBox1.Text = "[first]"
        RichTextBox1.Text += Environment.NewLine + "a = " + TextBox1.Text
        RichTextBox1.Text += Environment.NewLine + "b = " + TextBox2.Text
        RichTextBox1.Text += Environment.NewLine + "c = " + TextBox3.Text
        RichTextBox1.Text += Environment.NewLine + "d = " + TextBox4.Text
        RichTextBox1.Text += Environment.NewLine + "e = " + TextBox5.Text
        RichTextBox1.Text += Environment.NewLine + "f = " + TextBox6.Text
        RichTextBox1.Text += Environment.NewLine + "g = " + TextBox7.Text
        RichTextBox1.Text += Environment.NewLine + "h = " + TextBox8.Text
        RichTextBox1.Text += Environment.NewLine + "i = " + TextBox9.Text
        RichTextBox1.Text += Environment.NewLine + "j = " + TextBox10.Text
        RichTextBox1.Text += Environment.NewLine + "k = " + TextBox11.Text
        RichTextBox1.Text += Environment.NewLine + "l = " + TextBox12.Text
        RichTextBox1.Text += Environment.NewLine + "m = " + TextBox13.Text
        RichTextBox1.Text += Environment.NewLine + "n = " + TextBox14.Text
        RichTextBox1.Text += Environment.NewLine + "o = " + TextBox15.Text
        RichTextBox1.Text += Environment.NewLine + "p = " + TextBox16.Text
        RichTextBox1.Text += Environment.NewLine + "q = " + TextBox17.Text
        RichTextBox1.Text += Environment.NewLine + "r = " + TextBox18.Text
        RichTextBox1.Text += Environment.NewLine + "s = " + TextBox19.Text
        RichTextBox1.Text += Environment.NewLine + "t = " + TextBox20.Text
        RichTextBox1.Text += Environment.NewLine + "u = " + TextBox21.Text
        RichTextBox1.Text += Environment.NewLine + "v = " + TextBox22.Text
        RichTextBox1.Text += Environment.NewLine + "w = " + TextBox23.Text
        RichTextBox1.Text += Environment.NewLine + "x = " + TextBox24.Text
        RichTextBox1.Text += Environment.NewLine + "y = " + TextBox25.Text
        RichTextBox1.Text += Environment.NewLine + "z = " + TextBox26.Text

        'Generate last part
        RichTextBox1.Text += Environment.NewLine + "[last]"
        RichTextBox1.Text += Environment.NewLine + "a = " + TextBox27.Text
        RichTextBox1.Text += Environment.NewLine + "b = " + TextBox28.Text
        RichTextBox1.Text += Environment.NewLine + "c = " + TextBox29.Text
        RichTextBox1.Text += Environment.NewLine + "d = " + TextBox30.Text
        RichTextBox1.Text += Environment.NewLine + "e = " + TextBox31.Text
        RichTextBox1.Text += Environment.NewLine + "f = " + TextBox32.Text
        RichTextBox1.Text += Environment.NewLine + "g = " + TextBox33.Text
        RichTextBox1.Text += Environment.NewLine + "h = " + TextBox34.Text
        RichTextBox1.Text += Environment.NewLine + "i = " + TextBox35.Text
        RichTextBox1.Text += Environment.NewLine + "j = " + TextBox36.Text
        RichTextBox1.Text += Environment.NewLine + "k = " + TextBox37.Text
        RichTextBox1.Text += Environment.NewLine + "l = " + TextBox38.Text
        RichTextBox1.Text += Environment.NewLine + "m = " + TextBox39.Text
        RichTextBox1.Text += Environment.NewLine + "n = " + TextBox40.Text
        RichTextBox1.Text += Environment.NewLine + "o = " + TextBox41.Text
        RichTextBox1.Text += Environment.NewLine + "p = " + TextBox42.Text
        RichTextBox1.Text += Environment.NewLine + "q = " + TextBox43.Text
        RichTextBox1.Text += Environment.NewLine + "r = " + TextBox44.Text
        RichTextBox1.Text += Environment.NewLine + "s = " + TextBox45.Text
        RichTextBox1.Text += Environment.NewLine + "t = " + TextBox46.Text
        RichTextBox1.Text += Environment.NewLine + "u = " + TextBox47.Text
        RichTextBox1.Text += Environment.NewLine + "v = " + TextBox48.Text
        RichTextBox1.Text += Environment.NewLine + "w = " + TextBox49.Text
        RichTextBox1.Text += Environment.NewLine + "x = " + TextBox50.Text
        RichTextBox1.Text += Environment.NewLine + "y = " + TextBox51.Text
        RichTextBox1.Text += Environment.NewLine + "z = " + TextBox52.Text

        'Generate author
        RichTextBox1.Text += Environment.NewLine + "[author]"
        RichTextBox1.Text += Environment.NewLine + "by = " + bywho.Text
    End Sub
End Class