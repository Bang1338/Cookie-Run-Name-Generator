Imports System.IO
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Form1

    <DllImport("kernel32")>
    Private Shared Function GetPrivateProfileString(ByVal section As String, ByVal key As String, ByVal def As String, ByVal retVal As StringBuilder, ByVal size As Integer, ByVal filePath As String) As Integer
    End Function

    Public Function GetIniValue(ByVal section As String, ByVal key As String, ByVal filename As String, Optional ByVal defaultValue As String = "") As String
        Dim sb As New StringBuilder(500)
        If GetPrivateProfileString(section, key, defaultValue, sb, sb.Capacity, filename) > 0 Then
            Return sb.ToString
        Else
            Return defaultValue
        End If
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        'Load first board
        TextBox3.Text = GetIniValue("first", "a", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox4.Text = GetIniValue("first", "b", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox5.Text = GetIniValue("first", "c", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox6.Text = GetIniValue("first", "d", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox7.Text = GetIniValue("first", "e", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox8.Text = GetIniValue("first", "f", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox9.Text = GetIniValue("first", "g", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox10.Text = GetIniValue("first", "h", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox11.Text = GetIniValue("first", "i", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox12.Text = GetIniValue("first", "j", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox13.Text = GetIniValue("first", "k", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox14.Text = GetIniValue("first", "l", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox15.Text = GetIniValue("first", "m", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox16.Text = GetIniValue("first", "n", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox17.Text = GetIniValue("first", "o", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox18.Text = GetIniValue("first", "p", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox19.Text = GetIniValue("first", "q", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox20.Text = GetIniValue("first", "r", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox21.Text = GetIniValue("first", "s", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox22.Text = GetIniValue("first", "t", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox23.Text = GetIniValue("first", "u", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox24.Text = GetIniValue("first", "v", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox25.Text = GetIniValue("first", "w", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox26.Text = GetIniValue("first", "x", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox27.Text = GetIniValue("first", "y", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox28.Text = GetIniValue("first", "z", My.Application.Info.DirectoryPath & "\config.ini")

        'Load last board
        TextBox29.Text = GetIniValue("last", "a", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox30.Text = GetIniValue("last", "b", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox31.Text = GetIniValue("last", "c", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox32.Text = GetIniValue("last", "d", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox33.Text = GetIniValue("last", "e", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox34.Text = GetIniValue("last", "f", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox35.Text = GetIniValue("last", "g", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox36.Text = GetIniValue("last", "h", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox37.Text = GetIniValue("last", "i", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox38.Text = GetIniValue("last", "j", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox39.Text = GetIniValue("last", "k", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox40.Text = GetIniValue("last", "l", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox41.Text = GetIniValue("last", "m", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox42.Text = GetIniValue("last", "n", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox43.Text = GetIniValue("last", "o", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox44.Text = GetIniValue("last", "p", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox45.Text = GetIniValue("last", "q", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox46.Text = GetIniValue("last", "r", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox47.Text = GetIniValue("last", "s", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox48.Text = GetIniValue("last", "t", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox49.Text = GetIniValue("last", "u", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox50.Text = GetIniValue("last", "v", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox51.Text = GetIniValue("last", "w", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox52.Text = GetIniValue("last", "x", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox53.Text = GetIniValue("last", "y", My.Application.Info.DirectoryPath & "\config.ini")
        TextBox54.Text = GetIniValue("last", "z", My.Application.Info.DirectoryPath & "\config.ini")

        ' Display the config author
        bywho.Text = GetIniValue("Auth", "by", My.Application.Info.DirectoryPath & "\config.ini")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Check if textbox is empty
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("Please put your name.", "CRNG")
            Exit Sub
        End If

        'Get first and last char
        Dim first As String
        first = TextBox1.Text
        Dim fchar As Char
        fchar = first.Substring(0, 1)
        Dim last As String = TextBox1.Text
        Dim lchar As Char = last(last.Length - 1)

        'Check the char if having only 2 char, number and special char
        If TextBox1.TextLength < 3 Then
            MessageBox.Show("Please put more than two characters", "CRNG")
        ElseIf Regex.IsMatch(fchar, "^[0-9 ]+$") Then
            MessageBox.Show("This does not support number in first and last characters", "CRNG")
        ElseIf Regex.IsMatch(lchar, "^[0-9 ]+$") Then
            MessageBox.Show("This does not support number in first and last characters", "CRNG")
        ElseIf Regex.IsMatch(fchar, "[!""#$%&'()*+,\-.\/:;<=>?@[\\\]^_`{|}~\s]") Then
            MessageBox.Show("This does not support special characters", "CRNG")
        ElseIf Regex.IsMatch(lchar, "[!""#$%&'()*+,\-.\/:;<=>?@[\\\]^_`{|}~\s]") Then
            MessageBox.Show("This does not support special characters", "CRNG")
        Else
            TextBox2.Text = GetIniValue("first", fchar, My.Application.Info.DirectoryPath & "\config.ini") & " " & GetIniValue("last", lchar, My.Application.Info.DirectoryPath & "\config.ini")
        End If
    End Sub
End Class
