<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

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
        Me.btnSubmitData = New System.Windows.Forms.Button()
        Me.btnToggleStopWatch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblStopWatch = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnSubmitData
        '
        Me.btnSubmitData.AccessibleName = "btnSubmitData"
        Me.btnSubmitData.BackColor = System.Drawing.Color.LightBlue
        Me.btnSubmitData.Location = New System.Drawing.Point(180, 345)
        Me.btnSubmitData.Name = "btnSubmitData"
        Me.btnSubmitData.Size = New System.Drawing.Size(445, 42)
        Me.btnSubmitData.TabIndex = 25
        Me.btnSubmitData.Text = "SUBMIT (CTRL+S)"
        Me.btnSubmitData.UseVisualStyleBackColor = False
        '
        'btnToggleStopWatch
        '
        Me.btnToggleStopWatch.AccessibleName = "btnToggleStopWatch"
        Me.btnToggleStopWatch.BackColor = System.Drawing.Color.Yellow
        Me.btnToggleStopWatch.Location = New System.Drawing.Point(180, 289)
        Me.btnToggleStopWatch.Name = "btnToggleStopWatch"
        Me.btnToggleStopWatch.Size = New System.Drawing.Size(239, 38)
        Me.btnToggleStopWatch.TabIndex = 24
        Me.btnToggleStopWatch.Text = "TOGGLE STOPWATCH (CTRL+T)"
        Me.btnToggleStopWatch.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AccessibleName = "lblGitHub"
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(177, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 32)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "GitHub Link for Task 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtGitHub
        '
        Me.txtGitHub.AccessibleName = "txtGitHub"
        Me.txtGitHub.Location = New System.Drawing.Point(398, 241)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.Size = New System.Drawing.Size(227, 22)
        Me.txtGitHub.TabIndex = 20
        '
        'lblPhone
        '
        Me.lblPhone.AccessibleName = "lblPhone"
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(177, 213)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(46, 16)
        Me.lblPhone.TabIndex = 19
        Me.lblPhone.Text = "Phone"
        '
        'txtPhone
        '
        Me.txtPhone.AccessibleName = "txtPhone"
        Me.txtPhone.Location = New System.Drawing.Point(398, 213)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(227, 22)
        Me.txtPhone.TabIndex = 18
        '
        'lblEmail
        '
        Me.lblEmail.AccessibleName = "lblEmail"
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(177, 182)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblEmail.TabIndex = 17
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(398, 176)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(227, 22)
        Me.txtEmail.TabIndex = 16
        '
        'lblName
        '
        Me.lblName.AccessibleName = "lblName"
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(177, 151)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 15
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.AccessibleName = "txtName"
        Me.txtName.Location = New System.Drawing.Point(398, 145)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(227, 22)
        Me.txtName.TabIndex = 14
        '
        'lblTitle
        '
        Me.lblTitle.AccessibleName = "lblTitle"
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(132, 92)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(516, 25)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "John Doe, Slidely Task 2 - Create New Submissions"
        '
        'lblStopWatch
        '
        Me.lblStopWatch.AccessibleName = "lblStopWatch"
        Me.lblStopWatch.AutoSize = True
        Me.lblStopWatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStopWatch.Location = New System.Drawing.Point(544, 297)
        Me.lblStopWatch.Name = "lblStopWatch"
        Me.lblStopWatch.Size = New System.Drawing.Size(81, 20)
        Me.lblStopWatch.TabIndex = 26
        Me.lblStopWatch.Text = "00:00:00"
        Me.lblStopWatch.UseWaitCursor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblStopWatch)
        Me.Controls.Add(Me.btnSubmitData)
        Me.Controls.Add(Me.btnToggleStopWatch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtGitHub)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmitData As Button
    Friend WithEvents btnToggleStopWatch As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStopWatch As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
