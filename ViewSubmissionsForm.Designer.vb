<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblGitHub = New System.Windows.Forms.Label()
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.lblStopWatch = New System.Windows.Forms.Label()
        Me.txtStopWatch = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AccessibleName = "lblTitle"
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(141, 58)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(450, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "John Doe, Slidely Task 2 - View Submissions"
        '
        'txtName
        '
        Me.txtName.AccessibleName = "txtName"
        Me.txtName.Location = New System.Drawing.Point(364, 112)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(227, 22)
        Me.txtName.TabIndex = 1
        Me.txtName.Text = "John Doe"
        '
        'lblName
        '
        Me.lblName.AccessibleName = "lblName"
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(143, 118)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'lblEmail
        '
        Me.lblEmail.AccessibleName = "lblEmail"
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(143, 149)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(364, 143)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(227, 22)
        Me.txtEmail.TabIndex = 3
        Me.txtEmail.Text = "johndoe@gmail.com"
        '
        'lblPhone
        '
        Me.lblPhone.AccessibleName = "lblPhone"
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(143, 180)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(46, 16)
        Me.lblPhone.TabIndex = 6
        Me.lblPhone.Text = "Phone"
        '
        'txtPhone
        '
        Me.txtPhone.AccessibleName = "txtPhone"
        Me.txtPhone.Location = New System.Drawing.Point(364, 180)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(227, 22)
        Me.txtPhone.TabIndex = 5
        Me.txtPhone.Text = "1234567890"
        '
        'lblGitHub
        '
        Me.lblGitHub.AccessibleName = "lblGitHub"
        Me.lblGitHub.AutoSize = True
        Me.lblGitHub.Location = New System.Drawing.Point(143, 208)
        Me.lblGitHub.Name = "lblGitHub"
        Me.lblGitHub.Size = New System.Drawing.Size(137, 32)
        Me.lblGitHub.TabIndex = 8
        Me.lblGitHub.Text = "GitHub Link for Task 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtGitHub
        '
        Me.txtGitHub.AccessibleName = "txtGitHub"
        Me.txtGitHub.Location = New System.Drawing.Point(364, 208)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.ReadOnly = True
        Me.txtGitHub.Size = New System.Drawing.Size(227, 22)
        Me.txtGitHub.TabIndex = 7
        Me.txtGitHub.Text = "https://github.com/john_doe/my_slidely_task/"
        '
        'lblStopWatch
        '
        Me.lblStopWatch.AccessibleName = "lblStopWatch"
        Me.lblStopWatch.AutoSize = True
        Me.lblStopWatch.Location = New System.Drawing.Point(143, 244)
        Me.lblStopWatch.Name = "lblStopWatch"
        Me.lblStopWatch.Size = New System.Drawing.Size(107, 16)
        Me.lblStopWatch.TabIndex = 10
        Me.lblStopWatch.Text = "StopWatch Time"
        '
        'txtStopWatch
        '
        Me.txtStopWatch.AccessibleName = "txtStopWatch"
        Me.txtStopWatch.Location = New System.Drawing.Point(364, 238)
        Me.txtStopWatch.Name = "txtStopWatch"
        Me.txtStopWatch.ReadOnly = True
        Me.txtStopWatch.Size = New System.Drawing.Size(227, 22)
        Me.txtStopWatch.TabIndex = 9
        Me.txtStopWatch.Text = "00:01:19"
        '
        'btnPrevious
        '
        Me.btnPrevious.AccessibleName = "btnPrevious"
        Me.btnPrevious.BackColor = System.Drawing.Color.Yellow
        Me.btnPrevious.Location = New System.Drawing.Point(146, 285)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(212, 42)
        Me.btnPrevious.TabIndex = 11
        Me.btnPrevious.Text = "PREVIOUS (CTRL+P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.AccessibleName = "btnNext"
        Me.btnNext.BackColor = System.Drawing.Color.LightBlue
        Me.btnNext.Location = New System.Drawing.Point(364, 285)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(227, 42)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "NEXT (CTRL+N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblStopWatch)
        Me.Controls.Add(Me.txtStopWatch)
        Me.Controls.Add(Me.lblGitHub)
        Me.Controls.Add(Me.txtGitHub)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblGitHub As Label
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents lblStopWatch As Label
    Friend WithEvents txtStopWatch As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
