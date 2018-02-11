<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectUserForm
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
        Me.listUser = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'listUser
        '
        Me.listUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.listUser.Depth = 0
        Me.listUser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.listUser.Font = New System.Drawing.Font("Roboto", 24.0!)
        Me.listUser.FullRowSelect = True
        Me.listUser.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listUser.Location = New System.Drawing.Point(0, 64)
        Me.listUser.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.listUser.MouseState = MaterialSkin.MouseState.OUT
        Me.listUser.Name = "listUser"
        Me.listUser.OwnerDraw = True
        Me.listUser.Size = New System.Drawing.Size(475, 251)
        Me.listUser.TabIndex = 0
        Me.listUser.UseCompatibleStateImageBehavior = False
        Me.listUser.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Full Name"
        Me.ColumnHeader1.Width = 155
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Gender"
        Me.ColumnHeader2.Width = 155
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date Of Birth"
        Me.ColumnHeader3.Width = 165
        '
        'SelectUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 315)
        Me.Controls.Add(Me.listUser)
        Me.MaximizeBox = False
        Me.Name = "SelectUserForm"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select User"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listUser As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
