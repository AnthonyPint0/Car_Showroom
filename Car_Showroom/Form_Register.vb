Imports System.Data.SqlClient
Imports System.Globalization

Public Class Form_Register
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
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

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        ' Display a message box with Yes and No buttons
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit this application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            ' If the user clicks Yes, close the application
            Application.Exit()
        End If
    End Sub

    Public con As New SqlConnection("Data Source=DESKTOP-COMG-76;Initial Catalog=Car_Showroom;Integrated Security=True;Encrypt=False")
    Private Sub Register_btn_Click(sender As Object, e As EventArgs) Handles Register_btn.Click
        PerformRegistration()
    End Sub

    Private Sub PerformRegistration()
        Try
            ' Validate input: Check if all fields are provided
            If String.IsNullOrWhiteSpace(txtBfirstName.Text) OrElse
           String.IsNullOrWhiteSpace(txtBlastName.Text) OrElse
           String.IsNullOrWhiteSpace(txtBemail.Text) OrElse
           String.IsNullOrWhiteSpace(txtBaddress.Text) OrElse
           String.IsNullOrWhiteSpace(txtBcontactNumber.Text) OrElse
           String.IsNullOrWhiteSpace(txtBusername.Text) OrElse
           String.IsNullOrWhiteSpace(txtBpassword.Text) Then
                MessageBox.Show("Please fill in all fields.")
                Return ' Exit the method without proceeding to database operations
            End If

            ' Open the database connection
            con.Open()

            ' Execute SQL command to insert new user registration
            Dim sql As String = "INSERT INTO customer (FirstName, LastName, Email, Address, ContactNumber, Username, Password) VALUES (@FirstName, @LastName, @Email, @Address, @ContactNumber, @Username, @Password)"
            Using cmd As New SqlCommand(sql, con)
                ' Set parameter values
                cmd.Parameters.AddWithValue("@FirstName", txtBfirstName.Text)
                cmd.Parameters.AddWithValue("@LastName", txtBlastName.Text)
                cmd.Parameters.AddWithValue("@Email", txtBemail.Text)
                cmd.Parameters.AddWithValue("@Address", txtBaddress.Text)
                cmd.Parameters.AddWithValue("@ContactNumber", txtBcontactNumber.Text)
                cmd.Parameters.AddWithValue("@Username", txtBusername.Text)
                cmd.Parameters.AddWithValue("@Password", txtBpassword.Text)

                ' Execute the command
                cmd.ExecuteNonQuery()

                ' Display registration success message
                MessageBox.Show("Registration successful")
                Me.Hide()
                Form_Login.Show()
            End Using
        Catch ex As Exception
            ' Handle any exceptions that may occur during database operations
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the database connection in the finally block to ensure it's always closed
            con.Close()
        End Try
    End Sub

    Private Sub ShowPasswordCheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        ' Toggle the PasswordChar based on the CheckBox state
        If ShowPasswordCheckBox.Checked Then
            txtBpassword.PasswordChar = ControlChars.NullChar ' Show characters
        Else
            txtBpassword.PasswordChar = "*" ' Hide characters
        End If
    End Sub

    Private Sub Register_password_TextChanged(sender As Object, e As EventArgs) Handles txtBpassword.TextChanged
        txtBpassword.PasswordChar = "*"
    End Sub
    Private Sub Back_Btn_Click(sender As Object, e As EventArgs) Handles Back_Btn.Click
        Me.Hide()
        Form_Login.Show()
    End Sub

    Private Sub Form_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Protected Sub guestL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles guestL.LinkClicked
        Me.Hide()
        Mainform.loggedIn = False ' Set loggedIn to False
        Mainform.Show() ' To show the main form
        Mainform.UpdateUI() ' Update the UI in MainForm
    End Sub

    Private Sub Loginlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Loginlink.LinkClicked
        Me.Show()
        Form_Login.Show()
    End Sub
End Class