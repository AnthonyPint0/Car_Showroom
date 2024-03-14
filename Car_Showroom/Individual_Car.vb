Imports System.Drawing.Drawing2D
Imports System.Data.SqlClient
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Runtime.CompilerServices
Imports System.IO

Public Class Individual_Car
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public loggedIn As Boolean
    Private selectedButton As Button = Nothing
    Public CustReviewLink As String
    Public carID As String
    Public colour1 As String
    Public colour2 As String
    Public colour3 As String
    Public CustID As Integer
    Private connectionString As String = Form1.conectionString

    Private a As String

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

    ' Define a method to retrieve and display car details based on CarID
    Public Sub DisplayCarDetails(ByVal carID As String)
        ' Load the image from the resources folder using the CarID as the resource name
        Dim image As Image = Nothing

        Try
            ' Try to load the image from resources using the CarID
            image = My.Resources.ResourceManager.GetObject(carID)
        Catch ex As Exception
            ' Handle any exceptions that occur while loading the image from resources
            MessageBox.Show("Error loading image from resources: " & ex.Message)
        End Try

        ' If the image is still null, try loading it from the "Images" folder
        If image Is Nothing Then
            Dim imagePath As String = Path.Combine(Application.StartupPath, "Images", carID & ".jpg")

            If File.Exists(imagePath) Then
                Try
                    ' Load the image from the "Images" folder
                    image = Image.FromFile(imagePath)
                Catch ex As Exception
                    ' Handle any exceptions that occur while loading the image from the "Images" folder
                    MessageBox.Show("Error loading image from folder: " & ex.Message)
                End Try
            Else
                Try
                    ' Load the default image "Car_black" from resources
                    image = My.Resources.Car_blac
                Catch ex As Exception
                    ' Handle any exceptions that occur while loading the default image
                    MessageBox.Show("Error loading default image: " & ex.Message)
                End Try
            End If
        End If

        ' Set the image to the PictureBox
        CarImage.Image = image

        Try
            ' Create a SqlConnection using the connection string
            Using connectionCarDetails As New SqlConnection(connectionString)
                ' Open the connection
                connectionCarDetails.Open()

                ' Define a SQL query to retrieve car details based on CarID
                Dim queryCarDetails As String = "SELECT * FROM Cars WHERE CarId = @CarId"

                ' Create a SqlCommand with the query and connection
                Using commandCarDetails As New SqlCommand(queryCarDetails, connectionCarDetails)
                    ' Add a parameter for CarID to the SqlCommand
                    commandCarDetails.Parameters.AddWithValue("@CarId", carID)

                    ' Execute the SQL query and retrieve the results
                    Using readerCarDetails As SqlDataReader = commandCarDetails.ExecuteReader()
                        ' Check if there are any rows returned
                        If readerCarDetails.Read() Then
                            ' Populate labels with the retrieved data
                            CarMainTitle.Text = readerCarDetails("CarName").ToString()
                            CarTitle2.Text = readerCarDetails("CarName").ToString()
                            Specification.Text = readerCarDetails("CarName").ToString()
                            EngineLabel.Text = readerCarDetails("Engine").ToString()
                            MileageLabel.Text = readerCarDetails("Mileage").ToString()
                            TransmissionLabel.Text = readerCarDetails("Transmission").ToString()
                            FuelTypeLabel.Text = readerCarDetails("FuelType").ToString()
                            MaxPowerLabel.Text = readerCarDetails("MaxPower").ToString()
                            SeatingCapacityLabel.Text = readerCarDetails("SeatingCapacity").ToString()
                            DriverTypeLabel.Text = readerCarDetails("DriverType").ToString()
                            BodyTypeLabel.Text = readerCarDetails("BodyType").ToString()
                            DescriptionRichtext.Text = readerCarDetails("Description").ToString()
                            a = readerCarDetails("Price").ToString()
                            PriceLabel.Text = "₹ " & a & " /-"
                            CustReviewLabel.Text = readerCarDetails("CustReview").ToString() & "/5 Customer Rating"
                            CustReviewLink = readerCarDetails("CustReviewLink").ToString()
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
            Using connectionColor As New SqlConnection(connectionString)
                ' Open the connection
                connectionColor.Open()

                ' Define a SQL query to retrieve car details based on CarID
                Dim queryColor As String = "SELECT * FROM CarColors WHERE CarId = @CarId"

                ' Create a SqlCommand with the query and connection
                Using commandColor As New SqlCommand(queryColor, connectionColor)
                    ' Add a parameter for CarID to the SqlCommand
                    commandColor.Parameters.AddWithValue("@CarId", carID)

                    ' Execute the SQL query and retrieve the results
                    Using reader As SqlDataReader = commandColor.ExecuteReader()
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
        If CheckAvailability(carID) Then
            Add2cartBtn.Visible = True
            stockstatus.Visible = False
        Else
            Add2cartBtn.Visible = False
            stockstatus.Visible = True
        End If
    End Sub

    Public Function CheckAvailability(ByVal carID As String) As Boolean
        Dim query As String = "SELECT AvailableCount FROM InventoryStatus WHERE CarID = @CarID"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@CarID", carID)
                connection.Open()
                Dim AvailableCounts As Integer = Convert.ToInt32(command.ExecuteScalar())
                If AvailableCounts > 0 Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

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
        Console.WriteLine(CustID)

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
            User_Profile.CustID = CustID
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
    Private Sub Homebel_Click(sender As Object, e As EventArgs) Handles Homebel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Homebel)
        Me.Hide()
        HomeForm.Show()
        HomeForm.loggedIn = loggedIn ' Set loggedIn to True
        HomeForm.Profile.Text = "" & Profile.Text
        HomeForm.UpdateUI() ' Update the UI in HomeForm
        HomeForm.PopulateCarDisplayPanel(loggedIn)
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
        HomeForm.Show()
        HomeForm.loggedIn = loggedIn ' Set loggedIn to True
        HomeForm.Profile.Text = "" & Profile.Text
        HomeForm.UpdateUI() ' Update the UI in HomeForm
        HomeForm.PopulateCarDisplayPanel(loggedIn)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        HomeForm.Show()
        HomeForm.loggedIn = loggedIn ' Set loggedIn to True
        HomeForm.Profile.Text = "" & Profile.Text
        HomeForm.UpdateUI() ' Update the UI in HomeForm
        HomeForm.PopulateCarDisplayPanel(loggedIn)
    End Sub

    Private Sub back_icon_Click(sender As Object, e As EventArgs) Handles back_icon.Click
        Me.Hide()
        HomeForm.Show()
        HomeForm.loggedIn = loggedIn ' Set loggedIn to True
        HomeForm.Profile.Text = "" & Profile.Text
        HomeForm.UpdateUI() ' Update the UI in HomeForm
        HomeForm.PopulateCarDisplayPanel(loggedIn)

    End Sub

    Private Sub CustReviewLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CustReviewLabel.LinkClicked
        Process.Start(CustReviewLink)
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Color1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles Color1Pic.Click

    End Sub

    Private Sub Add2cart_Click(sender As Object, e As EventArgs) Handles Add2cartBtn.Click
        If loggedIn Then
            Console.WriteLine(CustID)
            ' Display a message box with Yes and No buttons
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to add this Car to Cart?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ' Check the user's response
            If result = DialogResult.Yes Then
                CheckOrderConditionsForCustomer(CustID, carID, a)
            End If
        Else
            MessageBox.Show("To add cars to your cart, please log in to your account.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub CheckOrderConditionsForCustomer(ByVal custID As Integer, ByVal carID As String, ByVal a As String)
        Try
            Dim querycheck As String = "SELECT * FROM Orders WHERE CustomerID = @CustID"

            ' Create a SqlConnection
            Using connectioncheck As New SqlConnection(connectionString)
                ' Create a SqlCommand
                Using commandcheck As New SqlCommand(querycheck, connectioncheck)
                    ' Add parameter for CustID
                    commandcheck.Parameters.AddWithValue("@CustID", custID)

                    ' Open the connection
                    connectioncheck.Open()

                    ' Execute the query and retrieve the result
                    Using readercheck As SqlDataReader = commandcheck.ExecuteReader()
                        ' Check if there are any rows returned
                        If readercheck.HasRows Then
                            ' Iterate through the result set
                            While readercheck.Read()
                                ' Retrieve the values of Cart, Ordered, and Delivered columns
                                Dim cart As Boolean = readercheck.GetBoolean(readercheck.GetOrdinal("Cart"))
                                Dim ordered As Boolean = readercheck.GetBoolean(readercheck.GetOrdinal("Ordered"))
                                Dim delivered As Boolean = readercheck.GetBoolean(readercheck.GetOrdinal("Delivered"))
                                ' Check the conditions using if-else statements
                                '********************************************************************************************************************************
                                If cart AndAlso Not ordered AndAlso Not delivered Then
                                    ' Condition 1: Cart = 1, Ordered = 0, Delivered = 0
                                    ' Perform actions for Condition 1
                                    Dim Cartresult As DialogResult = MessageBox.Show("There is already a Car existing in Your Cart! Do you want to replace it with the current car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                                    ' Check the user's response
                                    If Cartresult = DialogResult.Yes Then
                                        Try
                                            Using connectionUpdateCart As New SqlConnection(connectionString)
                                                connectionUpdateCart.Open()
                                                Dim queryUpdateCart As String = "UPDATE Orders SET CarID = @carID, Price = @price WHERE CustomerID = @CustID"
                                                Using commandUpdateCart As New SqlCommand(queryUpdateCart, connectionUpdateCart)
                                                    commandUpdateCart.Parameters.AddWithValue("@CustID", custID)
                                                    commandUpdateCart.Parameters.AddWithValue("@carID", carID)
                                                    commandUpdateCart.Parameters.AddWithValue("@price", a)
                                                    commandUpdateCart.ExecuteNonQuery()
                                                End Using
                                            End Using
                                        Catch ex As Exception
                                            MessageBox.Show("Error ordering now: " & ex.Message)
                                        End Try
                                    End If
                                    Console.WriteLine("Condition 1: Cart = 1, Ordered = 0, Delivered = 0")
                                    '********************************************************************************************************************************
                                ElseIf Not cart AndAlso ordered AndAlso Not delivered Then
                                    ' Condition 2: Cart = 0, Ordered = 1, Delivered = 0
                                    ' Perform actions for Condition 2
                                    MessageBox.Show("You are unable to add cars to your cart or place new orders while your current order is being processed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Try
                                        Using connection As New SqlConnection(connectionString)
                                            connection.Open()
                                            Dim query As String = "UPDATE Orders SET Cart = 0, Ordered = 0, Delivered = 1 WHERE CustomerID = @custID"
                                            Using command As New SqlCommand(query, connection)
                                                command.Parameters.AddWithValue("@custID", custID)
                                                command.ExecuteNonQuery()
                                            End Using
                                        End Using
                                    Catch ex As Exception
                                        MessageBox.Show("Error marking order as successful: " & ex.Message)
                                    End Try
                                    Console.WriteLine("Condition 2: Cart = 0, Ordered = 1, Delivered = 0")
                                    '********************************************************************************************************************************
                                ElseIf Not cart AndAlso Not ordered AndAlso delivered Then
                                    ' Condition 3: Cart = 0, Ordered = 0, Delivered = 1
                                    ' Perform actions for Condition 3
                                    MessageBox.Show("You are unable to add cars to your cart or place new orders while your current order is being processed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Console.WriteLine("Condition 3: Cart = 0, Ordered = 0, Delivered = 1")
                                    '********************************************************************************************************************************
                                ElseIf Not cart AndAlso Not ordered AndAlso Not delivered Then
                                    ' Condition 3: Cart = 0, Ordered = 0, Delivered = 0
                                    ' Perform actions for Condition 4
                                    Console.WriteLine("Condition 4: Cart = 0, Ordered = 0, Delivered = 0")
                                    '********************************************************************************************************************************
                                Else
                                    ' Other conditions
                                    ' Perform actions for other conditions or handle unknown conditions
                                    Console.WriteLine("Other conditions")
                                End If
                            End While
                        Else
                            'insert data into the Orders table
                            Dim cart As Boolean = True ' 1 for True (or 1), 0 for False (or 0)
                            Dim status As String = "Pending"

                            MessageBox.Show("Adding this Car to Your Cart", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' SQL query to insert data into the Orders table
                            Dim query As String = "INSERT INTO Orders (CarID, CustomerID, Username, Price, Cart, Status) VALUES (@CarID, @CustomerID, @Username, @Price, @Cart, @Status);"

                            ' Create a connection to the database
                            Using connection As New SqlConnection(connectionString)
                                ' Open the connection
                                connection.Open()

                                ' Create a SqlCommand object with the query and connection
                                Using command As New SqlCommand(query, connection)
                                    ' Add parameters to the command
                                    command.Parameters.AddWithValue("@CarID", carID)
                                    command.Parameters.AddWithValue("@CustomerID", custID)
                                    command.Parameters.AddWithValue("@Username", Profile.Text)
                                    command.Parameters.AddWithValue("@Price", a)
                                    command.Parameters.AddWithValue("@Cart", cart)
                                    command.Parameters.AddWithValue("@Status", status)

                                    ' Execute the command (perform the INSERT operation)
                                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                                    ' Check if the operation was successful
                                    If rowsAffected > 0 Then
                                        MessageBox.Show("Order placed successfully!")
                                    Else
                                        MessageBox.Show("Failed to place the order.")
                                    End If
                                End Using
                            End Using
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Redo the Order Error Message: " & ex.Message)
        End Try
    End Sub

    Private Sub Profile_Click(sender As Object, e As EventArgs) Handles Profile.Click
        Me.Hide()
        User_Profile.Show()
        User_Profile.loggedIn = loggedIn ' Set loggedIn to True
        User_Profile.Profile.Text = "" & Profile.Text
        User_Profile.UpdateUI()
        User_Profile.CheckOrderConditionsForCustomer(CustID)
        User_Profile.CustomerInfo(CustID)
    End Sub

    Private Sub CarImage_Click(sender As Object, e As EventArgs) Handles CarImage.Click

    End Sub
End Class