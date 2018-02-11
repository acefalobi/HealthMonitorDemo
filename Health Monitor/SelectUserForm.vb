Imports MaterialSkin
Imports System.Xml
Imports System.IO

Public Class SelectUserForm
    Dim myMaterialSkin As MaterialSkinManager
    Public selectedUser As String
    Private Sub SelectUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myMaterialSkin = MaterialSkinManager.Instance
        myMaterialSkin.AddFormToManage(Me)
        myMaterialSkin.ColorScheme = New ColorScheme(Primary.Teal800, Primary.Teal900, Primary.BlueGrey500, Accent.Teal700, TextShade.WHITE)

        Dim usersFiles As String() = Directory.GetFiles(Environment.CurrentDirectory)

        For i = 0 To usersFiles.Length
            If usersFiles(i).Contains("user") Then
                Dim count As Integer = 0
                Dim selected As String = ""
                Dim objReader As New StreamReader(usersFiles(i))
                Dim items As String() = {"", "", ""}

                Do While objReader.Peek() <> -1
                    If count = 0 Then
                        selected = objReader.ReadLine()
                        items(0) = objReader.ReadLine()
                        items(1) = objReader.ReadLine()
                        Dim dob As Date = objReader.ReadLine()
                        items(2) = dob.ToShortDateString()
                    End If
                    objReader.ReadLine()
                    count += 1
                Loop
                Dim item As ListViewItem = New ListViewItem(items)
                item.Tag = selected
                listUser.Items.Add(item)
            End If
        Next
    End Sub

    Private Sub SelectUserForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub listUser_DoubleClick(sender As Object, e As EventArgs) Handles listUser.DoubleClick
        selectedUser = listUser.SelectedItems.Item(0).Tag.ToString()
        MainForm.Show()
        Me.Hide()
    End Sub
End Class