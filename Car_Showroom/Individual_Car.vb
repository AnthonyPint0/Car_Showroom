Imports System.Drawing.Drawing2D
Imports System.Data.SqlClient
Imports System.Security.Policy

Public Class Individual_Car
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public loggedIn As Boolean = False
    Private selectedButton As Button = Nothing
    Public CustReviewLink As String
    Public carID As String
    Public colour1 As String
    Public colour2 As String
    Public colour3 As String


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

    ' Define a connection string to connect to your SQL Server database
    Private connectionString As String = "Data Source=DESKTOP-R8V9OD0;Initial Catalog=Car_ShowroomA;Integrated Security=True;Encrypt=True; Encrypt=False"
    Dim a As String
    ' Define a method to retrieve and display car details based on CarID
    Public Sub DisplayCarDetails(ByVal carID As String)
        Dim imageName As String = carID ' Assuming carID contains "SwiftC1"
        CarImage.Image = My.Resources.ResourceManager.GetObject(imageName)
        Try
            ' Create a SqlConnection using the connection string
            Using connection As New SqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Define a SQL query to retrieve car details based on CarID
                Dim query As String = "SELECT * FROM Cars WHERE CarId = @CarId"

                ' Create a SqlCommand with the query and connection
                Using command As New SqlCommand(query, connection)
                    ' Add a parameter for CarID to the SqlCommand
                    command.Parameters.AddWithValue("@CarId", carID)

                    ' Execute the SQL query and retrieve the results
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Check if there are any rows returned
                        If reader.Read() Then
                            ' Populate labels with the retrieved data
                            CarMainTitle.Text = reader("CarName").ToString()
                            CarTitle2.Text = reader("CarName").ToString()
                            Specification.Text = reader("CarName").ToString()
                            EngineLabel.Text = reader("Engine").ToString()
                            MileageLabel.Text = reader("Mileage").ToString()
                            TransmissionLabel.Text = reader("Transmission").ToString()
                            FuelTypeLabel.Text = reader("FuelType").ToString()
                            MaxPowerLabel.Text = reader("MaxPower").ToString()
                            SeatingCapacityLabel.Text = reader("SeatingCapacity").ToString()
                            DriverTypeLabel.Text = reader("DriverType").ToString()
                            BodyTypeLabel.Text = reader("BodyType").ToString()
                            DescriptionRichtext.Text = reader("Description").ToString()
                            a = reader("Price").ToString()
                            PriceLabel.Text = "₹ " & a & " /-"
                            CustReviewLabel.Text = reader("CustReview").ToString() & "/5 Customer Rating"
                            CustReviewLink = reader("CustReviewLink").ToString()
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

    Public Sub ColorsDisplay(ByVal carID As String)
        Try
            ' Create a SqlConnection using the connection string
            Using connection As New SqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Define a SQL query to retrieve car details based on CarID
                Dim query As String = "SELECT * FROM CarColors WHERE CarId = @CarId"

                ' Create a SqlCommand with the query and connection
                Using command As New SqlCommand(query, connection)
                    ' Add a parameter for CarID to the SqlCommand
                    command.Parameters.AddWithValue("@CarId", carID)

                    ' Execute the SQL query and retrieve the results
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Check if there are any rows returned
                        If reader.Read() Then
                            ' Populate labels with the retrieved data
                            Color1.Text = reader("Color1").ToString()
                            Color2.Text = reader("Color2").ToString()
                            Color3.Text = reader("Color3").ToString()
                            Color1Pic.Image = My.Resources.ResourceManager.GetObject(Color1.Text)
                            Color2Pic.Image = My.Resources.ResourceManager.GetObject(Color2.Text)
                            Color3Pic.Image = My.Resources.ResourceManager.GetObject(Color3.Text)
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

    ' Call the DisplayCarDetails method when the form loads
    Private Sub Individual_Car_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateUI()
        ' Set the "Allbel" button as the initially selected button
        selectedButton = Homebel
        Homebel.BackColor = Color.FromArgb(0, 0, 64) ' Set dark blue color for selected button

        ' Enable MouseEnter and MouseLeave events for all buttons except the selected one
        For Each button As Button In {Homebel}
            If button IsNot selectedButton Then
                AddHandler button.MouseEnter, AddressOf Button_MouseEnter
                AddHandler button.MouseLeave, AddressOf Button_MouseLeave
            End If
        Next
        ' Set the value of CarID (you can replace this with your actual CarID value)


        ' Call the DisplayCarDetails method with the specified CarID
        ' Construct the file path for the image using the carID
    End Sub

    Private Sub Registerlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Registerlink.LinkClicked
        Me.Hide()
        Form_Login.Show()
        Registerlink.Visible = True
        Logout.Text = ""
        Profile.Visible = False
        Profile.Visible = False
        Logout.Visible = False
        Form_Login.loggedIn = False
        Form_Login.username_txt.Text = ""
        Form_Login.Password_txt.Text = ""
    End Sub

    Private Sub Profile_Paint(sender As Object, e As PaintEventArgs)
        ' Define the region for rounded edges
        Dim panelRegion As New Region(New Rectangle(0, 0, Profile.Width, Profile.Height))
        Dim panelPath As New GraphicsPath()
        Dim radius As Integer = 10 ' Adjust the radius to control the roundness of edges

        ' Draw rounded rectangle
        panelPath.AddArc(New Rectangle(0, 0, 2 * radius, 2 * radius), 180, 90)
        panelPath.AddArc(New Rectangle(Profile.Width - 2 * radius, 0, 2 * radius, 2 * radius), 270, 90)
        panelPath.AddArc(New Rectangle(Profile.Width - 2 * radius, Profile.Height - 2 * radius, 2 * radius, 2 * radius), 0, 90)
        panelPath.AddArc(New Rectangle(0, Profile.Height - 2 * radius, 2 * radius, 2 * radius), 90, 90)
        panelPath.CloseAllFigures()

        ' Apply the rounded rectangle region to the panel
        panelRegion = New Region(panelPath)
        Profile.Region = panelRegion

        ' Optionally, you can set a background color or image for the panel
        ' Profile.BackColor = Color.White
        ' Profile.BackgroundImage = YourImage
    End Sub

    Public Sub UpdateUI()
        If loggedIn Then
            Registerlink.Visible = False
            Profile.Visible = True
            Logout.Text = "Log out"
            Logout.Visible = True
        Else
            Registerlink.Visible = True
            Logout.Text = ""
            Profile.Visible = False
            Logout.Visible = False
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        ' Display a message box with Yes and No buttons
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        ' Check the user's response
        If result = DialogResult.Yes Then
            ' If the user clicks Yes, close the application
            Me.Hide()
            Form_Login.Show()
            loggedIn = False
            Form_Login.loggedIn = False
            Form_Login.username_txt.Text = ""
            Form_Login.Password_txt.Text = ""
        End If
    End Sub
    Private Sub Allbel_Click(sender As Object, e As EventArgs) Handles Homebel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Homebel)
    End Sub

    Private Sub HandleButtonClick(clickedButton As Button)
        ' Check if a button is already selected
        If selectedButton IsNot Nothing Then
            ' Restore the appearance of the previously selected button
            selectedButton.BackColor = Color.Transparent
            ' Disable MouseEnter and MouseLeave events for the previously selected button
            RemoveHandler selectedButton.MouseEnter, AddressOf Button_MouseEnter
            RemoveHandler selectedButton.MouseLeave, AddressOf Button_MouseLeave
        End If

        ' Update the selected button to the clicked button
        selectedButton = clickedButton
        ' Set the background color of the clicked button to dark blue
        clickedButton.BackColor = Color.FromArgb(0, 0, 64)

        ' Disable MouseEnter and MouseLeave events for the clicked button
        RemoveHandler clickedButton.MouseEnter, AddressOf Button_MouseEnter
        RemoveHandler clickedButton.MouseLeave, AddressOf Button_MouseLeave

        ' Enable MouseEnter and MouseLeave events for all other buttons
        For Each button As Button In {Homebel}
            If button IsNot clickedButton Then
                AddHandler button.MouseEnter, AddressOf Button_MouseEnter
                AddHandler button.MouseLeave, AddressOf Button_MouseLeave
            End If
        Next
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        ' Check if the button is not the selected button
        If sender IsNot selectedButton Then
            ' Set the background color of the button to a lighter shade of blue on mouse enter
            Dim button As Button = DirectCast(sender, Button)
            button.BackColor = Color.FromArgb(115, 128, 244)
        End If
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        ' Check if the button is not the selected button
        If sender IsNot selectedButton Then
            ' Restore the background color of the button to transparent on mouse leave
            Dim button As Button = DirectCast(sender, Button)
            button.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Mainform.Show()
        Mainform.loggedIn = loggedIn ' Set loggedIn to True
        Mainform.Profile.Text = "" & Profile.Text
        Mainform.UpdateUI() ' Update the UI in MainForm
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Mainform.Show()
        Mainform.loggedIn = loggedIn ' Set loggedIn to True
        Mainform.Profile.Text = "" & Profile.Text
        Mainform.UpdateUI() ' Update the UI in MainForm
    End Sub

    Private Sub back_icon_Click(sender As Object, e As EventArgs) Handles back_icon.Click
        Me.Hide()
        Mainform.Show()
        Mainform.loggedIn = loggedIn ' Set loggedIn to True
        Mainform.Profile.Text = "" & Profile.Text
        Mainform.UpdateUI() ' Update the UI in MainForm
    End Sub

    Private Sub CustReviewLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CustReviewLabel.LinkClicked
        Process.Start(CustReviewLink)
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Color1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles Color1Pic.Click

    End Sub
End Class