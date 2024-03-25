Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.Devices

Public Class Payment
    Private connectionString As String = Form_Login.connector
    Public CustID As Integer
    Public carID As String
    Public price As String

    Private Sub OrderBtn_Click(sender As Object, e As EventArgs) Handles OrderBtn.Click
        Ordering()
    End Sub

    Private Sub Ordering()
        Dim loggedIn As Boolean = True
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Pay Now?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        ' Check the user's response
        If result = DialogResult.Yes Then
            Try
                Using connectionorder As New SqlConnection(connectionString)
                    connectionorder.Open()
                    Dim queryorder As String = "UPDATE Orders SET Cart = 0, Ordered = 1, Delivered = 0 WHERE CustomerID = @custID"
                    Using commandorder As New SqlCommand(queryorder, connectionorder)
                        commandorder.Parameters.AddWithValue("@custID", CustID)
                        commandorder.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Payment Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim query As String = "UPDATE InventoryStatus SET AvailableCount = AvailableCount - 1 WHERE CarID = @carID"
                Try
                    ' Create a SqlConnection using the provided connection string
                    Using connection As New SqlConnection(connectionString)
                        ' Create a SqlCommand with the query and connection
                        Using command As New SqlCommand(query, connection)
                            ' Add a parameter for CarID to the SqlCommand
                            command.Parameters.AddWithValue("@carID", carID)

                            ' Open the connection
                            connection.Open()

                            ' Execute the SQL query
                            Dim rowsAffected As Integer = command.ExecuteNonQuery()

                            ' Check if any rows were affected by the update
                            If rowsAffected > 0 Then
                                Console.WriteLine("Inventory status updated successfully.")
                            Else
                                MessageBox.Show("Some Errors has Occured", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Console.WriteLine("No rows updated. CarID not found or AvailableCount is already 0.")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    ' Handle any exceptions that may occur
                    Console.WriteLine("Error updating inventory status: " & ex.Message)
                End Try
                User_Profile.CustID = CustID
                HomeForm.CustID = CustID
                Individual_Car.CustID = CustID
                User_Profile.loggedIn = True
                HomeForm.loggedIn = True
                Individual_Car.loggedIn = True
                HomeForm.Show()
                User_Profile.Close()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error marking order as successful: " & ex.Message)
            Finally
                Console.WriteLine(CustID)
                User_Profile.CustID = CustID
                HomeForm.CustID = CustID
                Individual_Car.CustID = CustID
                User_Profile.loggedIn = True
                HomeForm.loggedIn = True
                Individual_Car.loggedIn = True
            End Try
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Cancel the Payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        ' Check the user's response
        If result = DialogResult.Yes Then
            MessageBox.Show("Payment Cancel!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = price
        Label5.Text = price
        Console.WriteLine(CustID)
        User_Profile.CustID = CustID
        HomeForm.CustID = CustID
        Individual_Car.CustID = CustID
    End Sub
End Class