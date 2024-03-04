Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class Admin_Mainform
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public loggedIn As Boolean = False
    Private selectedButton As Button = Nothing
    Public carID As String
    Private connectionString As String = "Data Source=DESKTOP-R8V9OD0;Initial Catalog=Car_ShowroomA;Integrated Security=True;Encrypt=True; Encrypt=False"

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
        'TODO: This line of code loads data into the 'Car_ShowroomADataSet.InventoryStatus' table. You can move, or remove it, as needed.
        Me.InventoryStatusTableAdapter.Fill(Me.Car_ShowroomADataSet.InventoryStatus)
        UpdateUI()
        ' Set the "Car_Inventory" button as the initially selected button
        selectedButton = Car_Inventory
        Car_Inventory.BackColor = Color.FromArgb(5, 82, 82) ' Set dark blue color for selected button
        ' Enable MouseEnter and MouseLeave events for all buttons except the selected one
        For Each button As Button In {Car_Inventory, Customer_Management, Sales_Reports, Employee_Management, Settings}
            If button IsNot selectedButton Then
                AddHandler button.MouseEnter, AddressOf Button_MouseEnter
                AddHandler button.MouseLeave, AddressOf Button_MouseLeave
            End If
        Next
        LoadCarIds()
    End Sub

    Private Sub LoadCarIds()
        ' Define the list of car IDs
        Dim carIds() As String = {
        "AmazeC1", "AuraC1", "BalenoC1", "BoleroC1", "BrezzaC1",
        "CarensC1", "CiazC1", "CretaC1", "DzireC1", "ErtigaC1",
        "i10_NiosC1", "InnovaC1", "KwidC1", "MagniteC1", "NexonC1",
        "PunchC1", "ScorpioC1", "SeltosC1", "SwiftC1", "Tata Tigor",
        "TriberC1", "VernaC1", "WagonRC1", "XUV300C1"
    }

        ' Add each car ID to the ComboBox
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
    End Sub

    Private Sub Customer_Management_Click(sender As Object, e As EventArgs) Handles Customer_Management.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Customer_Management)
    End Sub

    Private Sub Sales_Reports_Click(sender As Object, e As EventArgs) Handles Sales_Reports.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Sales_Reports)
    End Sub

    Private Sub Employee_Management_Click(sender As Object, e As EventArgs) Handles Employee_Management.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Employee_Management)
    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Settings)
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
        For Each button As Button In {Car_Inventory, Customer_Management, Sales_Reports, Employee_Management, Settings}
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
End Class