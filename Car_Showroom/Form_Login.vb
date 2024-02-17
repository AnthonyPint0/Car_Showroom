Imports System.Data.SqlClient
Imports System.Globalization

Public Class Form_Login
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public loggedIn As Boolean = False

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True 'Set the flag to indicate dragging is in progress
        mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_Login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        'Check if dragging is in progress
        If drag Then
            Dim newx As Integer
            Dim newy As Integer
            newx = System.Windows.Forms.Cursor.Position.X - mousex
            newy = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Location = New Point(newx, newy)
        End If
    End Sub

    Private Sub Form_Login_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False 'Reset the flag when dragging is complete
    End Sub
    Public con As New SqlConnection("Data Source=DESKTOP-R8V9OD0;Initial Catalog=Car_Showroom;Integrated Security=True;Encrypt=False")

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
        Try
            ' Open the database connection
            con.Open()

            ' Execute SQL command
            Dim sql As String = "SELECT * FROM customer WHERE Username = @Username AND Password = @Password"
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
                    Mainform.Show() ' To show the main form
                    Mainform.loggedIn = True ' Set loggedIn to True
                    loggedIn = True ' Set loggedIn to True
                    Mainform.Login_info1.Text = "User: " & username_txt.Text
                    Mainform.UpdateUI() ' Update the UI in MainForm
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
        ' Toggle the PasswordChar based on the CheckBox state
        If ShowPasswordCheckBox.Checked Then
            Password_txt.PasswordChar = ControlChars.NullChar ' Show characters
        Else
            Password_txt.PasswordChar = "*" ' Hide characters
        End If
    End Sub

    Private Sub Registerlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Registerlink.LinkClicked
        Me.Hide()
        Form_Register.Show()
        Mainform.loggedIn = False
        loggedIn = False ' Set loggedIn to False
    End Sub

    Private Sub Remove_user_btn_Click(sender As Object, e As EventArgs) Handles Remove_user_btn.Click
        ' Get the username from the user (you may use a TextBox or another input method)
        Dim usernameToRemove As String = InputBox("Enter the username to remove:", "Remove User")

        ' Call the RemoveUser function
        RemoveUser(usernameToRemove)
    End Sub

    Private Sub RemoveUser(username As String)
        Try
            ' Open the database connection
            con.Open()

            ' Execute SQL command to delete user by username
            Dim sql As String = "DELETE FROM customer WHERE Username = @Username"
            Using cmd As New SqlCommand(sql, con)
                ' Replace the parameter with the actual value
                cmd.Parameters.AddWithValue("@Username", username)

                ' Execute the command
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Check if any rows were affected to determine if the user was deleted
                If rowsAffected > 0 Then
                    MessageBox.Show("User removed successfully")
                Else
                    MessageBox.Show("User not found or could not be removed")
                End If
            End Using
        Catch ex As Exception
            ' Handle any exceptions that may occur during database operations
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the database connection in the finally block to ensure it's always closed
            con.Close()
        End Try
    End Sub

    Private Sub Password_txt_TextChanged(sender As Object, e As EventArgs) Handles Password_txt.TextChanged
        Password_txt.PasswordChar = "*" ' Hide characters
    End Sub

    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub guestL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles guestL.LinkClicked
        Me.Hide()
        Mainform.Show()
        Mainform.Login_info1.Text = ""
        Mainform.loggedIn = False
        loggedIn = False
        Mainform.UpdateUI()
    End Sub
End Class
