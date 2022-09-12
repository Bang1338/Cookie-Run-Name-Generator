Public Class Help
    Private Sub Help_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        RichTextBox1.Clear()

        RichTextBox1.Text = "How to use:"
        RichTextBox1.Text += Environment.NewLine
        RichTextBox1.Text += Environment.NewLine + "1. Put config.ini to the place where this program file in here (along with exe file for short)"
        RichTextBox1.Text += Environment.NewLine + "2. Run the program, put your name, and generate it."
        RichTextBox1.Text += Environment.NewLine + "If you don't have config.ini, simply use  P U R E  R A N D O M  by ticking Checkbox and generate it"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RichTextBox1.Clear()

        RichTextBox1.Text = "How to make config:"
        RichTextBox1.Text += Environment.NewLine
        RichTextBox1.Text += Environment.NewLine + "In top-left side of a program, press 'ConfigMaker'"
        RichTextBox1.Text += Environment.NewLine + "1. Fill all field"
        RichTextBox1.Text += Environment.NewLine + "2. Load 'Expected Output' (MUST)"
        RichTextBox1.Text += Environment.NewLine + "3. Save the file, and ready to use."
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        RichTextBox1.Clear()

        RichTextBox1.Text = "Same as this, but this using command line. Faster but not very friendly."
        RichTextBox1.Text += Environment.NewLine + "Also this will appear in 1.31"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        RichTextBox1.Clear()
        RichTextBox1.Text = "YOU ARE GOING TO GITHUB"

        Process.Start("https://github.com/Bang1338/Cookie-Run-Name-Generator/issues")
    End Sub
End Class