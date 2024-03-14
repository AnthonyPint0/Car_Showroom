Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Resources
Imports System.Runtime.InteropServices.ComTypes

Public Class Admin_Mainform
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public loggedIn As Boolean = False
    Private selectedButton As Button = Nothing
    Public carID As String
    Private connectionString As String = Form1.conectionString


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

    Private Sub Admin_Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Car_InventoryGB.Visible = True
        Add_carGB.Visible = False
        CustomerGB.Visible = False
        SalesRepertGB.Visible = False
        'TODO: This line of code loads data into the 'Car_ShowroomADataSet.OrderHistory' table. You can move, or remove it, as needed.
        Me.OrderHistoryTableAdapter.Fill(Me.Car_ShowroomADataSet.OrderHistory)
        'TODO: This line of code loads data into the 'Car_ShowroomADataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Car_ShowroomADataSet.Customer)
        BodyTypeCB.Items.Add("Hatchback")
        BodyTypeCB.Items.Add("Sedan")
        BodyTypeCB.Items.Add("SUV")
        BodyTypeCB.Items.Add("MUV")
        'TODO: This line of code loads data into the 'Car_ShowroomADataSet.InventoryStatus' table. You can move, or remove it, as needed.
        Me.InventoryStatusTableAdapter.Fill(Me.Car_ShowroomADataSet.InventoryStatus)
        UpdateUI()
        ' Set the "Car_Inventory" button as the initially selected button
        selectedButton = Car_Inventory
        Car_Inventory.BackColor = Color.FromArgb(5, 82, 82) ' Set dark blue color for selected button
        ' Enable MouseEnter and MouseLeave events for all buttons except the selected one
        For Each button As Button In {Car_Inventory, Customer_Management, Sales_Reports, Add_carBtn}
            If button IsNot selectedButton Then
                AddHandler button.MouseEnter, AddressOf Button_MouseEnter
                AddHandler button.MouseLeave, AddressOf Button_MouseLeave
            End If
        Next
        LoadCarIds()
    End Sub

    Private Sub LoadCarIds()
        ' Clear existing items from the ComboBox
        CarIDCB.Items.Clear()

        ' Query the Cars table to retrieve all car IDs
        Dim query As String = "SELECT CarId FROM Cars"
        Dim carIds As New List(Of String)()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                ' Read each car ID and add it to the list
                While reader.Read()
                    carIds.Add(reader("CarId").ToString())
                End While

                ' Close the reader
                reader.Close()
            End Using
        End Using

        ' Add retrieved car IDs to the ComboBox
        For Each carId As String In carIds
            CarIDCB.Items.Add(carId)
        Next
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
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        ' Display a message box with Yes and No buttons
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        ' Check the user's response
        If result = DialogResult.Yes Then
            ' If the user clicks Yes, close the application
            Me.Hide()
            Admin_Login.Show()
            loggedIn = False
            Admin_Login.loggedIn = False
            Admin_Login.username_txt.Text = ""
            Admin_Login.Password_txt.Text = ""
        End If
    End Sub
    Private Sub Car_Inventory_Click(sender As Object, e As EventArgs) Handles Car_Inventory.Click, MyBase.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Car_Inventory)
        Car_InventoryGB.Visible = True
        Add_carGB.Visible = False
        CustomerGB.Visible = False
        SalesRepertGB.Visible = False
    End Sub

    Private Sub Customer_Management_Click(sender As Object, e As EventArgs) Handles Customer_Management.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Customer_Management)
        Car_InventoryGB.Visible = False
        Add_carGB.Visible = False
        CustomerGB.Visible = True
        SalesRepertGB.Visible = False
    End Sub

    Private Sub Sales_Reports_Click(sender As Object, e As EventArgs) Handles Sales_Reports.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Sales_Reports)
        Car_InventoryGB.Visible = False
        Add_carGB.Visible = False
        CustomerGB.Visible = False
        SalesRepertGB.Visible = True
    End Sub

    Private Sub Add_car_Click(sender As Object, e As EventArgs) Handles Add_carBtn.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Add_carBtn)
        Car_InventoryGB.Visible = False
        Add_carGB.Visible = True
        CustomerGB.Visible = False
        SalesRepertGB.Visible = False
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
        clickedButton.BackColor = Color.FromArgb(9, 81, 81)

        ' Disable MouseEnter and MouseLeave events for the clicked button
        RemoveHandler clickedButton.MouseEnter, AddressOf Button_MouseEnter
        RemoveHandler clickedButton.MouseLeave, AddressOf Button_MouseLeave

        ' Enable MouseEnter and MouseLeave events for all other buttons
        For Each button As Button In {Car_Inventory, Customer_Management, Sales_Reports, Add_carBtn}
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
            button.BackColor = Color.FromArgb(6, 163, 163)
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

    Private Sub NumericTextBox_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles noofcars.KeyPress
        ' Check if the entered character is a digit or a control character
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If not a digit or control character, ignore the key press event
            e.Handled = True
        End If
    End Sub

    Private Sub UpdateAvailableCount(ByVal carID As String, ByVal countToAdd As Integer)
        Try
            ' Get the current AvailableCount for the specified carID
            Dim currentCount As Integer = GetCurrentAvailableCount(carID)
            Console.WriteLine(currentCount)
            Console.WriteLine("Good7")
            ' Calculate the new count after adding the specified number of cars
            Dim newCount As Integer = currentCount + countToAdd
            Console.WriteLine(newCount)
            ' Limit the new count to a maximum of 7
            If newCount > 7 Then
                newCount = 7
                Console.WriteLine("Good8")
            End If
            Console.WriteLine(newCount)

            ' Define the SQL query to update the AvailableCount
            Dim query As String = "UPDATE InventoryStatus SET AvailableCount = @newCount WHERE CarID = @carID"

            ' Create a SqlConnection using the connection string
            Using connection As New SqlConnection(connectionString)
                ' Create a SqlCommand with the query and connection
                Using command As New SqlCommand(query, connection)
                    ' Add parameters for CarID and newCount to the SqlCommand
                    Console.WriteLine(newCount)
                    command.Parameters.AddWithValue("@carID", carID)
                    command.Parameters.AddWithValue("@newCount", newCount)
                    Console.WriteLine(newCount)
                    ' Open the connection
                    connection.Open()

                    ' Execute the SQL query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Console.WriteLine("Good10")
                    ' Check if any rows were affected by the update
                    If rowsAffected > 0 Then
                        MessageBox.Show("AvailableCount updated successfully.")
                        Console.WriteLine("Good11")
                    Else
                        MessageBox.Show("No rows updated. CarID not found.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions that may occur
            MessageBox.Show("Error updating AvailableCount: " & ex.Message)
        End Try
    End Sub

    Private Function GetCurrentAvailableCount(ByVal carID As String) As Integer
        ' Define the SQL query to retrieve the current AvailableCount
        Dim query As String = "SELECT AvailableCount FROM InventoryStatus WHERE CarID = @carID"

        ' Create a variable to store the AvailableCount
        Dim currentCount As Integer = 0
        Console.WriteLine("Good1")
        Try
            ' Create a SqlConnection using the connection string
            Using connection As New SqlConnection(connectionString)
                ' Create a SqlCommand with the query and connection
                Using command As New SqlCommand(query, connection)
                    ' Add a parameter for CarID to the SqlCommand
                    command.Parameters.AddWithValue("@carID", carID)

                    ' Open the connection
                    connection.Open()

                    ' Execute the SQL query and retrieve the AvailableCount
                    Dim result As Object = command.ExecuteScalar()

                    ' Check if the result is not null and convert it to an integer
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        currentCount = Convert.ToInt32(result)
                    End If
                    Console.WriteLine("Good2")
                End Using
                Console.WriteLine("Good3")
            End Using
        Catch ex As Exception
            ' Handle any exceptions that may occur
            MessageBox.Show("Error retrieving AvailableCount: " & ex.Message)
            Console.WriteLine("Bad")
        End Try
        Console.WriteLine("Good5")
        ' Return the current AvailableCount
        Return currentCount
        Console.WriteLine("Good6")
    End Function

    Private Sub AddCarBtn_Click(sender As Object, e As EventArgs) Handles AddCarBtn.Click
        ' Validate the input value in the textbox
        Dim numberOfCars As Integer
        If Integer.TryParse(noofcars.Text, numberOfCars) AndAlso numberOfCars > 0 AndAlso numberOfCars < 8 Then
            ' Get the selected CarID from the combobox
            Dim selectedCarID As String = CarIDCB.SelectedItem.ToString()
            ' Call the function to update the AvailableCount in InventoryStatus
            UpdateAvailableCount(selectedCarID, numberOfCars)
        Else
            MessageBox.Show("Please enter a valid number between 1 and 7.")
        End If
        ReloadForm()
    End Sub
    Private Sub ReloadForm()
        ' Close the current instance of the form
        Me.Close()

        ' Open a new instance of the form
        Dim newForm As New Admin_Mainform()
        newForm.Show()
        newForm.loggedIn = True ' Set loggedIn to True
        loggedIn = True ' Set loggedIn to True
        newForm.Profile.Text = "" & Profile.Text
        newForm.UpdateUI() ' Update the UI in MainForm
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        ' Specify the directory path for the Images folder
        Dim imagesFolderPath As String = Path.Combine(Application.StartupPath, "Images")

        ' Create the Images folder if it doesn't exist
        If Not Directory.Exists(imagesFolderPath) Then
            Directory.CreateDirectory(imagesFolderPath)
        End If

        ' Generate a unique file name for the uploaded image
        Dim imageName As String = CarIdTextBox.Text & ".jpg" ' You can use a unique identifier here
        Dim imagePath As String = Path.Combine(imagesFolderPath, imageName)

        ' Check if an image is selected in the PictureBox
        If CarPictureBox.Image IsNot Nothing Then
            Try
                ' Save the image to the specified file path
                CarPictureBox.Image.Save(imagePath)

                ' Provide feedback to the user
                MessageBox.Show("Image saved to Images folder successfully!")
            Catch ex As Exception
                MessageBox.Show("Error saving image: " & ex.Message)
            End Try
        Else
            MessageBox.Show("No image to save!")
        End If

        ' Insert car information into the database
        Dim carId As String = CarIdTextBox.Text
        Dim carName As String = CarNameTextBox.Text
        Dim Engine As String = EngineTB.Text
        Dim Mileage As String = MileageTB.Text
        Dim Price As String = PriceTB.Text
        Dim Descrpition As String = DescriptionTB.Text
        Dim CustReview As String = CustReviewTB.Text
        Dim CustReviewlink As String = CustReviewlinkTB.Text
        Dim FuelType As String = FuelTypeTB.Text
        Dim Transmission As String = TransmissionTB.Text
        Dim MaxPower As String = MaxPowerTB.Text
        Dim SeatingCapacity As String = SeatingCapacityTB.Text
        Dim DriveType As String = DriverTypeTB.Text
        Dim BodyType As String = BodyTypeCB.SelectedItem.ToString()

        ' Retrieve other car information from respective controls

        ' Example SQL query to insert data into the Cars table
        Dim query As String = $"INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink) VALUES ('{carId}', '{carName}', '{Engine}', '{Mileage}', '{Transmission}', '{FuelType}', '{MaxPower}', '{SeatingCapacity}', '{DriveType}', '{BodyType}', '{Descrpition}', {Price}, {CustReview}, '{CustReviewlink}')"

        ' Execute the query to insert data into the database
        ' Ensure to handle exceptions and provide appropriate feedback to the user
        Try
            ' Create a new instance of SqlConnection with your connection string
            Using connection As New SqlConnection(connectionString)
                ' Create a new instance of SqlCommand with the query and the SqlConnection
                Using command As New SqlCommand(query, connection)
                    ' Open the connection
                    connection.Open()
                    ' Execute the SQL query
                    command.ExecuteNonQuery()
                End Using
            End Using
            ' Provide feedback to the user indicating successful insertion
            MessageBox.Show("Data inserted successfully!")

            ' Define your SQL query to insert data into the InventoryStatus table
            Dim insertquery As String = "INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity) VALUES (@CarId, 7, 7)"

            ' Create a new SqlConnection using the connection string
            Using insertconnection As New SqlConnection(connectionString)
                ' Create a new SqlCommand with your SQL query and the SqlConnection
                Using command As New SqlCommand(insertquery, insertconnection)
                    ' Add parameters to the SqlCommand to prevent SQL injection
                    command.Parameters.AddWithValue("@CarId", carId)

                    Try
                        ' Open the database connection
                        insertconnection.Open()

                        ' Execute the SQL query
                        command.ExecuteNonQuery()

                        ' Optionally, provide feedback to the user indicating successful insertion
                        MessageBox.Show("Data inserted into InventoryStatus table successfully!")
                    Catch ex As Exception
                        ' Handle any exceptions that occur during database interaction
                        MessageBox.Show("Error inserting data into InventoryStatus table: " & ex.Message)
                    End Try
                End Using
            End Using

            ' Define your SQL query to insert data into the CarColors table
            Dim colorquery As String = "INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES (@CarId, 'Red', 'Blue', 'Black')"

            ' Create a new SqlConnection using the connection string
            Using colorConnection As New SqlConnection(connectionString)
                ' Create a new SqlCommand with your SQL query and the SqlConnection
                Using command As New SqlCommand(colorquery, colorConnection)
                    ' Add parameters to the SqlCommand to prevent SQL injection
                    command.Parameters.AddWithValue("@CarId", carId)

                    Try
                        ' Open the database connection
                        colorConnection.Open()

                        ' Execute the SQL query
                        command.ExecuteNonQuery()

                        ' Optionally, provide feedback to the user indicating successful insertion
                        MessageBox.Show("Data inserted into CarColors table successfully!")
                        ReloadForm()
                    Catch ex As Exception
                        ' Handle any exceptions that occur during database interaction
                        MessageBox.Show("Error inserting data into CarColors table: " & ex.Message)
                    End Try
                End Using
            End Using

        Catch ex As Exception
            ' Handle any exceptions that occur during database interaction
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub UploadImageButton_Click(sender As Object, e As EventArgs) Handles UploadImageButton.Click
        ' Open a file dialog to allow the user to select an image
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Display the selected image in the PictureBox control
                CarPictureBox.Image = Image.FromFile(openFileDialog.FileName)
            End If
        End Using
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

End Class