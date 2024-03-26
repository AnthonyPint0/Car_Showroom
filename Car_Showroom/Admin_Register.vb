Imports System.Data.SqlClient
Imports System.Globalization

Public Class Admin_Register
    Public connector As String = Form_Login.connector

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        ' Display a message box with Yes and No buttons
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit this application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            ' If the user clicks Yes, close the application Hello
            Application.Exit()
        End If
    End Sub

    Public con As New SqlConnection(connector)
    Private Sub Register_btn_Click(sender As Object, e As EventArgs) Handles Register_btn.Click
        PerformRegistration()
    End Sub

    Private Sub PerformRegistration()
        Try
            ' Validate input: Check if all fields are provided
            If String.IsNullOrWhiteSpace(txtBfirstName.Text) OrElse
           String.IsNullOrWhiteSpace(txtBlastName.Text) OrElse
           String.IsNullOrWhiteSpace(comboRole.Text) OrElse
           String.IsNullOrWhiteSpace(comboDepartment.Text) OrElse
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
            Dim sql As String = "INSERT INTO admin (FirstName, LastName, Role, Department, Email, Address, ContactNumber, Username, Password) VALUES (@FirstName, @LastName, @Email, @Address, @ContactNumber, @Username, @Password)"
            Using cmd As New SqlCommand(sql, con)
                ' Set parameter values
                cmd.Parameters.AddWithValue("@FirstName", txtBfirstName.Text)
                cmd.Parameters.AddWithValue("@LastName", txtBlastName.Text)
                cmd.Parameters.AddWithValue("@Role", comboRole.SelectedItem.ToString()) ' Use selected item from comboRole
                cmd.Parameters.AddWithValue("@Department", comboDepartment.SelectedItem.ToString()) ' Use selected item from comboDepartment
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
        Admin_Mainform.Show()
    End Sub

    Private Sub Admin_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add items to the Role ComboBox
        comboRole.Items.AddRange({"Manager", "Salesman", "Accountant", "IT Staff", "HR Manager", "Marketing Specialist"})

        ' Add items to the Department ComboBox
        comboDepartment.Items.AddRange({"Sales", "Accounting", "IT", "Human Resources", "Marketing", "Administration"})

        ' Add items to the Role ComboBox
        ' comboRole.Items.AddRange({"Manager", "Salesman", "Accountant", "IT Staff", "HR Manager", "Marketing Specialist"})

        ' Add items to the Department ComboBox
        'comboDepartment.Items.AddRange({"Sales", "Accounting", "IT", "Human Resources", "Marketing", "Administration"})

    End Sub
End Class