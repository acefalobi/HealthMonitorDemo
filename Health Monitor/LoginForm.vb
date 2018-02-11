Imports System.IO
Imports MaterialSkin
Imports System.Xml

Public Class LoginForm

    Dim myMaterialSkin As MaterialSkinManager
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myMaterialSkin = MaterialSkinManager.Instance

        myMaterialSkin.AddFormToManage(Me)
        myMaterialSkin.ColorScheme = New ColorScheme(Primary.Teal800, Primary.Teal900, Primary.BlueGrey500, Accent.Teal700, TextShade.WHITE)
    End Sub

    Private Sub checkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles checkShowPassword.CheckedChanged
        txtPassoword.UseSystemPasswordChar = Not checkShowPassword.Checked
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim isCorrect As Boolean = False

        Dim count As Integer = 0
        Dim objReader As New StreamReader(Environment.CurrentDirectory + "/login_info.txt")

        Do While objReader.Peek() <> -1
            If count = 0 Then
                Dim loginDetails As String = objReader.ReadLine()
                isCorrect = loginDetails.Split(",")(0).Equals(txtUsername.Text) And loginDetails.Split(",")(1).Equals(txtPassoword.Text)
            End If
            objReader.ReadLine()
            count += 1
        Loop

        If isCorrect Then
            MsgBox("Logged In!")
            SelectUserForm.Show()
            Me.Hide()
        Else
            MsgBox("Invalid Login Details!")
        End If

    End Sub
End Class