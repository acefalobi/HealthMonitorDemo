<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.MaterialTabSelector = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.MainTabPage = New System.Windows.Forms.TabPage()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblAveStats = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.HomeTabPage = New System.Windows.Forms.TabPage()
        Me.HealthChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ButtonPanel = New System.Windows.Forms.Panel()
        Me.checkTemperature = New MaterialSkin.Controls.MaterialCheckBox()
        Me.checkHeartRate = New MaterialSkin.Controls.MaterialCheckBox()
        Me.checkPressure = New MaterialSkin.Controls.MaterialCheckBox()
        Me.PatientTabPage = New System.Windows.Forms.TabPage()
        Me.lblGenotype = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblBloodGroup = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialTabControl.SuspendLayout()
        Me.MainTabPage.SuspendLayout()
        Me.HomeTabPage.SuspendLayout()
        CType(Me.HealthChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonPanel.SuspendLayout()
        Me.PatientTabPage.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialTabSelector
        '
        Me.MaterialTabSelector.BaseTabControl = Me.MaterialTabControl
        Me.MaterialTabSelector.Depth = 0
        Me.MaterialTabSelector.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialTabSelector.Location = New System.Drawing.Point(0, 0)
        Me.MaterialTabSelector.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector.Name = "MaterialTabSelector"
        Me.MaterialTabSelector.Size = New System.Drawing.Size(961, 65)
        Me.MaterialTabSelector.TabIndex = 0
        Me.MaterialTabSelector.Text = "MaterialTabSelector"
        '
        'MaterialTabControl
        '
        Me.MaterialTabControl.Controls.Add(Me.MainTabPage)
        Me.MaterialTabControl.Controls.Add(Me.HomeTabPage)
        Me.MaterialTabControl.Controls.Add(Me.PatientTabPage)
        Me.MaterialTabControl.Depth = 0
        Me.MaterialTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabControl.Location = New System.Drawing.Point(0, 65)
        Me.MaterialTabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl.Name = "MaterialTabControl"
        Me.MaterialTabControl.SelectedIndex = 0
        Me.MaterialTabControl.Size = New System.Drawing.Size(961, 484)
        Me.MaterialTabControl.TabIndex = 1
        '
        'MainTabPage
        '
        Me.MainTabPage.AutoScroll = True
        Me.MainTabPage.Controls.Add(Me.lblInfo)
        Me.MainTabPage.Controls.Add(Me.lblAveStats)
        Me.MainTabPage.Controls.Add(Me.lblPatientName)
        Me.MainTabPage.Location = New System.Drawing.Point(4, 22)
        Me.MainTabPage.Name = "MainTabPage"
        Me.MainTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.MainTabPage.Size = New System.Drawing.Size(953, 458)
        Me.MainTabPage.TabIndex = 2
        Me.MainTabPage.Text = "Home"
        Me.MainTabPage.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(38, 164)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(78, 20)
        Me.lblInfo.TabIndex = 2
        Me.lblInfo.Text = "Loading..."
        '
        'lblAveStats
        '
        Me.lblAveStats.AutoSize = True
        Me.lblAveStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAveStats.Location = New System.Drawing.Point(36, 88)
        Me.lblAveStats.Name = "lblAveStats"
        Me.lblAveStats.Size = New System.Drawing.Size(93, 24)
        Me.lblAveStats.TabIndex = 1
        Me.lblAveStats.Text = "Loading..."
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.Location = New System.Drawing.Point(34, 26)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(134, 31)
        Me.lblPatientName.TabIndex = 0
        Me.lblPatientName.Text = "Loading..."
        '
        'HomeTabPage
        '
        Me.HomeTabPage.Controls.Add(Me.HealthChart)
        Me.HomeTabPage.Controls.Add(Me.ButtonPanel)
        Me.HomeTabPage.Location = New System.Drawing.Point(4, 22)
        Me.HomeTabPage.Name = "HomeTabPage"
        Me.HomeTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.HomeTabPage.Size = New System.Drawing.Size(953, 458)
        Me.HomeTabPage.TabIndex = 0
        Me.HomeTabPage.Text = "Info Charts"
        Me.HomeTabPage.UseVisualStyleBackColor = True
        '
        'HealthChart
        '
        ChartArea2.AxisX.MajorGrid.Enabled = False
        ChartArea2.AxisY.MajorGrid.Enabled = False
        ChartArea2.Name = "ChartArea1"
        Me.HealthChart.ChartAreas.Add(ChartArea2)
        Me.HealthChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.HealthChart.Legends.Add(Legend2)
        Me.HealthChart.Location = New System.Drawing.Point(3, 64)
        Me.HealthChart.Name = "HealthChart"
        Me.HealthChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Legend = "Legend1"
        Series4.Name = "Pressure"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Legend = "Legend1"
        Series5.Name = "Heart Rate"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Legend = "Legend1"
        Series6.Name = "Temperature"
        Me.HealthChart.Series.Add(Series4)
        Me.HealthChart.Series.Add(Series5)
        Me.HealthChart.Series.Add(Series6)
        Me.HealthChart.Size = New System.Drawing.Size(947, 391)
        Me.HealthChart.TabIndex = 0
        Me.HealthChart.Text = "Health Chart"
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Title2.Name = "ChartTitle"
        Title2.Text = "Health Chart"
        Me.HealthChart.Titles.Add(Title2)
        '
        'ButtonPanel
        '
        Me.ButtonPanel.BackColor = System.Drawing.Color.White
        Me.ButtonPanel.Controls.Add(Me.checkTemperature)
        Me.ButtonPanel.Controls.Add(Me.checkHeartRate)
        Me.ButtonPanel.Controls.Add(Me.checkPressure)
        Me.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonPanel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonPanel.Location = New System.Drawing.Point(3, 3)
        Me.ButtonPanel.Name = "ButtonPanel"
        Me.ButtonPanel.Size = New System.Drawing.Size(947, 61)
        Me.ButtonPanel.TabIndex = 1
        '
        'checkTemperature
        '
        Me.checkTemperature.AutoSize = True
        Me.checkTemperature.Checked = True
        Me.checkTemperature.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkTemperature.Depth = 0
        Me.checkTemperature.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.checkTemperature.Location = New System.Drawing.Point(246, 14)
        Me.checkTemperature.Margin = New System.Windows.Forms.Padding(0)
        Me.checkTemperature.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.checkTemperature.MouseState = MaterialSkin.MouseState.HOVER
        Me.checkTemperature.Name = "checkTemperature"
        Me.checkTemperature.Ripple = True
        Me.checkTemperature.Size = New System.Drawing.Size(109, 30)
        Me.checkTemperature.TabIndex = 2
        Me.checkTemperature.Text = "Temperature"
        Me.checkTemperature.UseVisualStyleBackColor = True
        '
        'checkHeartRate
        '
        Me.checkHeartRate.AutoSize = True
        Me.checkHeartRate.Checked = True
        Me.checkHeartRate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkHeartRate.Depth = 0
        Me.checkHeartRate.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.checkHeartRate.Location = New System.Drawing.Point(115, 14)
        Me.checkHeartRate.Margin = New System.Windows.Forms.Padding(0)
        Me.checkHeartRate.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.checkHeartRate.MouseState = MaterialSkin.MouseState.HOVER
        Me.checkHeartRate.Name = "checkHeartRate"
        Me.checkHeartRate.Ripple = True
        Me.checkHeartRate.Size = New System.Drawing.Size(95, 30)
        Me.checkHeartRate.TabIndex = 1
        Me.checkHeartRate.Text = "Heart Rate"
        Me.checkHeartRate.UseVisualStyleBackColor = True
        '
        'checkPressure
        '
        Me.checkPressure.AutoSize = True
        Me.checkPressure.Checked = True
        Me.checkPressure.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkPressure.Depth = 0
        Me.checkPressure.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.checkPressure.Location = New System.Drawing.Point(2, 14)
        Me.checkPressure.Margin = New System.Windows.Forms.Padding(0)
        Me.checkPressure.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.checkPressure.MouseState = MaterialSkin.MouseState.HOVER
        Me.checkPressure.Name = "checkPressure"
        Me.checkPressure.Ripple = True
        Me.checkPressure.Size = New System.Drawing.Size(85, 30)
        Me.checkPressure.TabIndex = 0
        Me.checkPressure.Text = "Pressure"
        Me.checkPressure.UseVisualStyleBackColor = True
        '
        'PatientTabPage
        '
        Me.PatientTabPage.Controls.Add(Me.lblGenotype)
        Me.PatientTabPage.Controls.Add(Me.Label8)
        Me.PatientTabPage.Controls.Add(Me.lblBloodGroup)
        Me.PatientTabPage.Controls.Add(Me.Label7)
        Me.PatientTabPage.Controls.Add(Me.lblDateOfBirth)
        Me.PatientTabPage.Controls.Add(Me.Label6)
        Me.PatientTabPage.Controls.Add(Me.lblWeight)
        Me.PatientTabPage.Controls.Add(Me.Label5)
        Me.PatientTabPage.Controls.Add(Me.lblHeight)
        Me.PatientTabPage.Controls.Add(Me.Label4)
        Me.PatientTabPage.Controls.Add(Me.lblSex)
        Me.PatientTabPage.Controls.Add(Me.Label3)
        Me.PatientTabPage.Controls.Add(Me.lblFullName)
        Me.PatientTabPage.Controls.Add(Me.Label1)
        Me.PatientTabPage.Location = New System.Drawing.Point(4, 22)
        Me.PatientTabPage.Name = "PatientTabPage"
        Me.PatientTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.PatientTabPage.Size = New System.Drawing.Size(953, 458)
        Me.PatientTabPage.TabIndex = 1
        Me.PatientTabPage.Text = "Patient Information"
        Me.PatientTabPage.UseVisualStyleBackColor = True
        '
        'lblGenotype
        '
        Me.lblGenotype.AutoSize = True
        Me.lblGenotype.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenotype.Location = New System.Drawing.Point(203, 317)
        Me.lblGenotype.Name = "lblGenotype"
        Me.lblGenotype.Size = New System.Drawing.Size(134, 31)
        Me.lblGenotype.TabIndex = 13
        Me.lblGenotype.Text = "Loading..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 31)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Genotype:  "
        '
        'lblBloodGroup
        '
        Me.lblBloodGroup.AutoSize = True
        Me.lblBloodGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBloodGroup.Location = New System.Drawing.Point(203, 269)
        Me.lblBloodGroup.Name = "lblBloodGroup"
        Me.lblBloodGroup.Size = New System.Drawing.Size(134, 31)
        Me.lblBloodGroup.TabIndex = 11
        Me.lblBloodGroup.Text = "Loading..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 31)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Blood Group:  "
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOfBirth.Location = New System.Drawing.Point(203, 222)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(134, 31)
        Me.lblDateOfBirth.TabIndex = 9
        Me.lblDateOfBirth.Text = "Loading..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 31)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Date of Birth: "
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(203, 172)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(134, 31)
        Me.lblWeight.TabIndex = 7
        Me.lblWeight.Text = "Loading..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 31)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Weight: "
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(203, 125)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(134, 31)
        Me.lblHeight.TabIndex = 5
        Me.lblHeight.Text = "Loading..."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 31)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Height: "
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.Location = New System.Drawing.Point(203, 73)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(134, 31)
        Me.lblSex.TabIndex = 3
        Me.lblSex.Text = "Loading..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sex:  "
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(203, 21)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(134, 31)
        Me.lblFullName.TabIndex = 1
        Me.lblFullName.Text = "Loading..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name: "
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainPanel.Controls.Add(Me.MaterialTabControl)
        Me.MainPanel.Controls.Add(Me.MaterialTabSelector)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MainPanel.Location = New System.Drawing.Point(0, 61)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(961, 549)
        Me.MainPanel.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(961, 610)
        Me.Controls.Add(Me.MainPanel)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Health Monitor"
        Me.MaterialTabControl.ResumeLayout(False)
        Me.MainTabPage.ResumeLayout(False)
        Me.MainTabPage.PerformLayout()
        Me.HomeTabPage.ResumeLayout(False)
        CType(Me.HealthChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonPanel.ResumeLayout(False)
        Me.ButtonPanel.PerformLayout()
        Me.PatientTabPage.ResumeLayout(False)
        Me.PatientTabPage.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MaterialTabSelector As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents HomeTabPage As System.Windows.Forms.TabPage
    Friend WithEvents PatientTabPage As System.Windows.Forms.TabPage
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents HealthChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ButtonPanel As System.Windows.Forms.Panel
    Friend WithEvents checkPressure As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents checkHeartRate As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents checkTemperature As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MainTabPage As System.Windows.Forms.TabPage
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents lblAveStats As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDateOfBirth As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblBloodGroup As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblGenotype As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
