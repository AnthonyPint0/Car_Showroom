Imports System.Data.SqlClient
Imports System.Globalization

Public Class Admin_Login
    Private Sub Admin_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Password_txt.PasswordChar = If(ShowPasswordCheckBox.Checked, ControlChars.NullChar, "*")
    End Sub

    Public loggedIn As Boolean = False
    Public connector As String = Form_Login.connector
    Public con As New SqlConnection(connector)

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click
        ' Call a method to handle login function
        PerformLogin()
    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        ' Display a message box with Yes and No buttons
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit this application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            ' If the user clicks Yes, close the application
            Application.Exit()
        End If
    End Sub

    Private Sub PerformLogin()
        If username_txt.Text = "admin" And username_txt.Text = "admin" Then
            Me.Hide()
            Admin_Register.Show()
            username_txt.Text = ""
            Password_txt.Text = ""
            Form_Login.username_txt.Text = ""
            Form_Login.Password_txt.Text = ""
            Exit Sub
        End If
        Try
            ' Open the database connection
            con.Open()

            ' Execute SQL command
            Dim sql As String = "SELECT * FROM admin WHERE Username = @Username AND Password = @Password"
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@Username", username_txt.Text)
                cmd.Parameters.AddWithValue("@Password", Password_txt.Text)

                ' Execute the command
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                ' Check if there is a row with matching username and password
                If reader.HasRows Then
                    ' User is authenticated
                    MessageBox.Show("Login successful")
                    Me.Hide() ' To hide the login form
                    Admin_Mainform.Show() ' To show the main form
                    Admin_Mainform.loggedIn = True ' Set loggedIn to True
                    loggedIn = True ' Set loggedIn to True
                    Admin_Mainform.Profile.Text = "" & username_txt.Text
                    Admin_Mainform.UpdateUI() ' Update the UI in MainForm
                Else
                    ' User authentication failed
                    MessageBox.Show("Invalid username or password")
                End If

                ' Close the SqlDataReader
                reader.Close()
            End Using
        Catch ex As Exception
            ' Handle any exceptions that may occur during database operations
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the database connection in the finally block to ensure it's always closed
            con.Close()
        End Try
    End Sub

    Private Sub ShowPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        Password_txt.PasswordChar = If(ShowPasswordCheckBox.Checked, ControlChars.NullChar, "*")
    End Sub

    Private Sub Clear_user_btn_Click(sender As Object, e As EventArgs) Handles Clear_user_btn.Click
        username_txt.Clear()
        Password_txt.Clear()
    End Sub


    Private Sub Password_txt_TextChanged(sender As Object, e As EventArgs) Handles Password_txt.TextChanged
        Password_txt.PasswordChar = "*" ' Hide characters
    End Sub

    Private Sub GuestL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles guestL.LinkClicked
        Me.Close()
        Form_Login.Show()
        Form_Login.username_txt.Text = ""
        Form_Login.Password_txt.Text = ""
    End Sub


    'Private Sub guestL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles guestL.LinkClicked
    'Me.Hide()
    '   Mainform.Show()
    '    Mainform.Profile.Text = ""
    '   Mainform.loggedIn = False
    '  loggedIn = False
    ' Mainform.UpdateUI()
    ' End Sub
End Class