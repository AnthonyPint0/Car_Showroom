Imports System.Data.SqlClient

Public Class User_Profile
    Private Sub User_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private connectionString As String = "Data Source=DESKTOP-R8V9OD0;Initial Catalog=Car_ShowroomA;Integrated Security=True;Encrypt=True; Encrypt=False"

    Public Sub DisplayCarDetails(ByVal carID As String)
        Dim imageName As String = carID ' Assuming carID contains "SwiftC1"
        CarImage.Image = My.Resources.ResourceManager.GetObject(imageName)
        Try
            ' Create a SqlConnection using the connection string
            Using connection As New SqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Define a SQL query to retrieve car details based on CarID
                Dim query As String = "SELECT * FROM customer WHERE CarId = @CarId"

                ' Create a SqlCommand with the query and connection
                Using command As New SqlCommand(query, connection)
                    ' Add a parameter for CarID to the SqlCommand
                    command.Parameters.AddWithValue("@CarId", carID)

                    ' Execute the SQL query and retrieve the results
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Check if there are any rows returned
                        If reader.Read() Then
                            ' Populate labels with the retrieved data
                            usernameTxt.Text = reader("Username").ToString()
                            FirstNTxt.Text = reader("FirstName").ToString()
                            LastNTxt.Text = reader("LastName").ToString()
                            EmailTxt.Text = reader("Email").ToString()
                            ContactNoTxt.Text = reader("ContactNumber").ToString()
                            AddressTxt.Text = reader("Address").ToString()
                        Else
                            ' If no rows are returned, display a message
                            MessageBox.Show("No car found with the specified CarID.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions that may occur
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class

