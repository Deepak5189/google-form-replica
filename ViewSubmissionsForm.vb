Imports System.Net
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0

    Private submission As Submission


    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the form's KeyPreview property to True to receive key events
        Me.KeyPreview = True
        Await LoadSubmissions(currentIndex)
        DisplaySubmission()
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If submission IsNot Nothing Then
            currentIndex += 1
            'If currentIndex >= submissions.Count Then
            '    currentIndex = 0 ' Wrap around to the first submission
            'End If
            Await LoadSubmissions(currentIndex)
            DisplaySubmission()
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub

    Private Async Sub DisplaySubmission()
        ' Display the current submission if available, otherwise clear the fields
        If submission IsNot Nothing Then
            txtName.Text = submission.name
            txtEmail.Text = submission.email
            txtPhone.Text = submission.phone
            txtGitHub.Text = submission.gitHub_link
            txtStopWatch.Text = submission.stopwatch_time
            ' Enable navigation buttons
            btnPrevious.Enabled = True
            btnNext.Enabled = True
        Else
            If currentIndex < 0 Then
                currentIndex = 0
                Await LoadSubmissions(currentIndex)
                DisplaySubmission()
                btnPrevious.Enabled = False
            ElseIf currentIndex = 0 Then
                ' Clear the fields
                txtName.Text = String.Empty
                txtEmail.Text = String.Empty
                txtPhone.Text = String.Empty
                txtGitHub.Text = String.Empty
                txtStopWatch.Text = String.Empty
                ' Disable navigation buttons
                btnPrevious.Enabled = False
                btnNext.Enabled = False
            Else
                currentIndex -= 1
                Await LoadSubmissions(currentIndex)
                DisplaySubmission()
                btnNext.Enabled = False
            End If
        End If
    End Sub


    Private Async Function LoadSubmissions(index As Integer) As Task
        ' Initialize the submissions list
        submission = New Submission()

        Try
            ' Create an HttpClient instance
            Using client As New HttpClient()
                ' Send a GET request to the backend server
                Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
                response.EnsureSuccessStatusCode()

                ' Read the response content as a string
                Dim jsonString As String = Await response.Content.ReadAsStringAsync()

                ' Deserialize the JSON response into the submissions list
                submission = JsonConvert.DeserializeObject(Of Submission)(jsonString)

                ' Check if the list is empty
                If submission Is Nothing Then
                    MessageBox.Show("No submissions found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading submissions: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If submission IsNot Nothing Then
            currentIndex -= 1
            'If currentIndex < 0 Then
            '    currentIndex = submissions.Count - 1 ' Wrap around to the last submission
            'End If
            Await LoadSubmissions(currentIndex)
            DisplaySubmission()
        End If
    End Sub
End Class

Public Class Submission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property gitHub_link As String
    Public Property stopwatch_time As String
End Class