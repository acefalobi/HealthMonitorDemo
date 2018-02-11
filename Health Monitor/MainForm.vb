Imports MaterialSkin
Imports System.Xml
Imports System.IO

Public Class MainForm
    Dim myMaterialSkin As MaterialSkinManager

    Dim patientName As String
    Dim patientGender As String
    Dim patientAge As Integer
    Dim patientDateOfBirth As Date
    Dim patientHeight As String
    Dim patientWeight As String
    Dim patientBloodGroup As String
    Dim patientGenotype As String

    Dim aveHeartRate As Integer
    Dim avePressure As Integer
    Dim aveTemperature As Integer

    Dim sumHeartRate As Integer
    Dim sumPressure As Integer
    Dim sumTemperature As Integer

    Dim count As Integer = 0

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myMaterialSkin.AddFormToManage(Me)
        myMaterialSkin.ColorScheme = New ColorScheme(Primary.Teal800, Primary.Teal900, Primary.BlueGrey500, Accent.Teal700, TextShade.WHITE)

        loadUserInfo()

        lblInfo.Text = "This is a Health Monitor that monitors the health statistics of a patient under observation in a clinic. The info chart tab displays a "
        lblInfo.Text += Environment.NewLine
        lblInfo.Text += "line graph showing the various values being measured from the patient. The patient information displays information about the patient"
        lblInfo.Text += Environment.NewLine
        lblInfo.Text += "such as blood group, genotype, etc. The home tab shows basic information and stats from the patient such as the name, average"
        lblInfo.Text += Environment.NewLine
        lblInfo.Text += "pressure, etc."

        Timer1.Start()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        myMaterialSkin = MaterialSkinManager.Instance

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub loadUserInfo()

        Dim usersFiles As String() = Directory.GetFiles(Environment.CurrentDirectory)
        Dim userFile As String = ""

        For Each user As String In usersFiles
            If user.Contains("user" + SelectUserForm.selectedUser) Then
                userFile = user
            End If
        Next

        Dim countLine = 0
        Dim objReader As StreamReader = New StreamReader(userFile)
        Do While objReader.Peek() <> -1
            Select Case countLine
                Case 0
                    Dim id = objReader.ReadLine()
                    patientName = objReader.ReadLine()
                    patientGender = objReader.ReadLine()
                    patientDateOfBirth = objReader.ReadLine()
                    patientAge = Date.Today.Subtract(patientDateOfBirth).TotalDays
                    patientAge = patientAge / 365.25
                    patientHeight = objReader.ReadLine()
                    patientWeight = objReader.ReadLine()
                    patientBloodGroup = objReader.ReadLine()
                    patientGenotype = objReader.ReadLine()
            End Select
            objReader.ReadLine()
            countLine += 1
        Loop

        lblFullName.Text = patientName
        lblSex.Text = patientGender
        lblHeight.Text = patientHeight + "m"
        lblWeight.Text = patientWeight + "kg"
        lblDateOfBirth.Text = patientDateOfBirth.Day.ToString() + " - " + patientDateOfBirth.Month.ToString() + " - " + patientDateOfBirth.Year.ToString()
        lblBloodGroup.Text = patientBloodGroup
        lblGenotype.Text = patientGenotype

        lblPatientName.Text = patientName + "  " + patientGender + "  " + patientAge.ToString() + " yrs"
    End Sub

    Private Sub checkPressure_CheckedChanged(sender As Object, e As EventArgs) Handles checkPressure.CheckedChanged
        HealthChart.Series("Pressure").Enabled = checkPressure.Checked
    End Sub

    Private Sub checkHeartRate_CheckedChanged(sender As Object, e As EventArgs) Handles checkHeartRate.CheckedChanged
        HealthChart.Series("Heart Rate").Enabled = checkHeartRate.Checked
    End Sub

    Private Sub checkTemperature_CheckedChanged(sender As Object, e As EventArgs) Handles checkTemperature.CheckedChanged
        HealthChart.Series("Temperature").Enabled = checkTemperature.Checked
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim hRate As Integer = New Random().Next(35, 120)
        Dim prssure As Integer = New Random().Next(90, 240)
        Dim tmp As Integer = New Random().Next(30, 45)
        sumHeartRate += hRate
        sumPressure += prssure
        sumTemperature += tmp
        HealthChart.Series("Heart Rate").Points.AddXY(count + 1, hRate)
        HealthChart.Series("Pressure").Points.AddXY(count + 1, prssure)
        HealthChart.Series("Temperature").Points.AddXY(count + 1, tmp)

        If count > 10 Then
            HealthChart.Series("Heart Rate").Points.Clear()
            HealthChart.Series("Pressure").Points.Clear()
            HealthChart.Series("Temperature").Points.Clear()
            count = 0
            HealthChart.Series("Heart Rate").Points.AddXY(count + 1, hRate)
            HealthChart.Series("Pressure").Points.AddXY(count + 1, prssure)
            HealthChart.Series("Temperature").Points.AddXY(count + 1, tmp)
        End If

        aveHeartRate = sumHeartRate / (count + 1)
        avePressure = sumPressure / (count + 1)
        aveTemperature = sumTemperature / (count + 1)

        lblAveStats.Text = "Average Heart Rate: " + aveHeartRate.ToString() + "bpm     Average Pressure: " + avePressure.ToString() + "mmHg     Average Temperature: " + aveTemperature.ToString() + "C"
        count += 1
        Timer1.Start()
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class

