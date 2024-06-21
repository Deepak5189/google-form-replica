Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text

Public Class CreateSubmissionForm

    Private stopwatch As New Stopwatch()
    Private stopwatchRunning As Boolean = False

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the form's KeyPreview property to True to receive key events
        Me.KeyPreview = True
        lblStopWatch.Text = "00:00:00"
    End Sub

    Private Sub btnToggleStopWatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopWatch.Click
        If stopwatchRunning Then
            stopwatch.Stop()
            'btnStopWatch.Text = "Resume"
        Else
            stopwatch.Start()
            'btnStopWatch.Text = "Pause"
        End If
        stopwatchRunning = Not stopwatchRunning
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblStopWatch.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub

    Private Async Sub btnSubmitData_Click(sender As Object, e As EventArgs) Handles btnSubmitData.Click
        Dim submission = New With {
            Key .name = txtName.Text,
            Key .email = txtEmail.Text,
            Key .phone = txtPhone.Text,
            Key .github_link = txtGitHub.Text,
            Key .stopwatch_time = lblStopWatch.Text
        }

        Try
            Using client As New HttpClient()
                Dim jsonContent As String = JsonConvert.SerializeObject(submission)
                Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")

                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
                response.EnsureSuccessStatusCode()

                MessageBox.Show("Submission saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error submitting the form: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmitData.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopWatch.PerformClick()
        End If
    End Sub
End Class
