<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnCreateSubmission = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.AccessibleName = "btnViewSubmissions"
        Me.btnViewSubmissions.BackColor = System.Drawing.Color.Yellow
        Me.btnViewSubmissions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewSubmissions.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewSubmissions.Location = New System.Drawing.Point(127, 190)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(476, 46)
        Me.btnViewSubmissions.TabIndex = 0
        Me.btnViewSubmissions.Text = "View Submission (CTRL+V)"
        Me.btnViewSubmissions.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnCreateSubmission
        '
        Me.btnCreateSubmission.AccessibleName = "btnCreateSubmission"
        Me.btnCreateSubmission.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCreateSubmission.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateSubmission.FlatAppearance.BorderSize = 20
        Me.btnCreateSubmission.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateSubmission.Location = New System.Drawing.Point(127, 242)
        Me.btnCreateSubmission.Name = "btnCreateSubmission"
        Me.btnCreateSubmission.Size = New System.Drawing.Size(476, 46)
        Me.btnCreateSubmission.TabIndex = 1
        Me.btnCreateSubmission.Text = "Create New Submission (CTRL+N)"
        Me.btnCreateSubmission.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCreateSubmission)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "l"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents btnCreateSubmission As Button
End Class
