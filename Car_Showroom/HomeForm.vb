Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class HomeForm

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public loggedIn As Boolean
    Private selectedButton As Button = Nothing
    Public VarID As String
    Public CustID As Integer


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
            loggedIn = True
            Individual_Car.CustID = CustID
            User_Profile.CustID = CustID
        Else
            Registerlink.Visible = True
            Logout.Text = ""
            Profile.Visible = False
            loggedIn = False
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
    Private Sub Allbel_Click(sender As Object, e As EventArgs) Handles Allbel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Allbel)
        HatchbackPanel.Visible = True
        SedanPanel.Visible = True
        SUVPanel.Visible = True
        MUVPanel.Visible = True
    End Sub

    Private Sub Hatchbackbel_Click(sender As Object, e As EventArgs) Handles Hatchbackbel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Hatchbackbel)
        HatchbackPanel.Visible = True
        SedanPanel.Visible = False
        SUVPanel.Visible = False
        MUVPanel.Visible = False
    End Sub

    Private Sub Sedanbel_Click(sender As Object, e As EventArgs) Handles Sedanbel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Sedanbel)
        HatchbackPanel.Visible = False
        SedanPanel.Visible = True
        SUVPanel.Visible = False
        MUVPanel.Visible = False
    End Sub

    Private Sub SUVbel_Click(sender As Object, e As EventArgs) Handles SUVbel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(SUVbel)
        HatchbackPanel.Visible = False
        SedanPanel.Visible = False
        SUVPanel.Visible = True
        MUVPanel.Visible = False
    End Sub

    Private Sub MUVbel_Click(sender As Object, e As EventArgs) Handles MUVbel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(MUVbel)
        HatchbackPanel.Visible = False
        SedanPanel.Visible = False
        SUVPanel.Visible = False
        MUVPanel.Visible = True
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
        For Each button As Button In {Allbel, Hatchbackbel, Sedanbel, SUVbel, MUVbel}
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

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label42_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub MainFormTST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateUI()
        ' Set the "Allbel" button as the initially selected button
        selectedButton = Allbel
        Allbel.BackColor = Color.FromArgb(0, 0, 64) ' Set dark blue color for selected button
        HatchbackPanel.Visible = True
        SedanPanel.Visible = True
        SUVPanel.Visible = True
        MUVPanel.Visible = True
        ' Enable MouseEnter and MouseLeave events for all buttons except the selected one
        For Each button As Button In {Allbel, Hatchbackbel, Sedanbel, SUVbel, MUVbel}
            If button IsNot selectedButton Then
                AddHandler button.MouseEnter, AddressOf Button_MouseEnter
                AddHandler button.MouseLeave, AddressOf Button_MouseLeave
            End If
        Next
        Console.WriteLine("af3e3SFS")
    End Sub

    Public Sub PopulateCarDisplayPanel(ByVal loggedIn As Boolean)
        ' Query the Cars table to get car information
        Dim cars As DataTable = GetDataFromCarsTable()
        Console.WriteLine("Before")
        Console.WriteLine(loggedIn)

        ' Iterate over the car data and categorize them by body type
        For Each row As DataRow In cars.Rows
            Dim carControl As New CarDisplayCard()
            carControl.CarName = row("CarName").ToString()
            carControl.Price = row("Price").ToString()
            carControl.CarImage = LoadCarImage(row("CarID").ToString())
            carControl.CarID = row("CarId").ToString()
            carControl.loggedIn = loggedIn
            carControl.Profile = Profile.Text

            ' Add event handler for View More button click
            AddHandler carControl.ViewMoreButtonClick, AddressOf ViewMoreButton_Click

            ' Determine the body type of the car
            Dim bodyType As String = row("BodyType").ToString()

            ' Add the car control to the appropriate panel based on the body type
            Select Case bodyType
                Case "Hatchback"
                    HatchbackPanel.Controls.Add(carControl)
                Case "Sedan"
                    SedanPanel.Controls.Add(carControl)
                Case "SUV"
                    SUVPanel.Controls.Add(carControl)
                Case "MUV"
                    MUVPanel.Controls.Add(carControl)
            End Select
        Next
    End Sub

    ' Event handler for View More button click
    Private Sub ViewMoreButton_Click(sender As Object, e As EventArgs)

    End Sub

    ' Function to load car image from file path
    Private Function LoadCarImage(CarID As String) As Image
        ' Load the image from the resources folder using the CarID as the resource name
        Dim image As Image = My.Resources.ResourceManager.GetObject(CarID)
        Return image
    End Function

    ' Function to retrieve car data from database
    Private Function GetDataFromCarsTable() As DataTable
        ' Define your SQL query to select data from the Cars table
        Dim query As String = "SELECT * FROM Cars"

        ' Create a new instance of the SqlConnection class to connect to your database
        Using connection As New SqlConnection("Data Source=DESKTOP-R8V9OD0;Initial Catalog=Car_ShowroomA;Integrated Security=True;Encrypt=True; Encrypt=False")
            ' Create a new instance of the SqlCommand class with your SQL query and the SqlConnection
            Using command As New SqlCommand(query, connection)
                ' Create a new instance of the SqlDataAdapter class to fetch the data from the database
                Using adapter As New SqlDataAdapter(command)
                    ' Create a new instance of the DataTable class to store the retrieved data
                    Dim dataTable As New DataTable()

                    ' Open the database connection
                    connection.Open()

                    ' Fill the DataTable with the data retrieved from the database using the SqlDataAdapter
                    adapter.Fill(dataTable)

                    ' Return the populated DataTable
                    Return dataTable
                End Using
            End Using
        End Using
    End Function

    Private Sub Profile_Click(sender As Object, e As EventArgs) Handles Profile.Click
        If loggedIn Then
            Me.Hide()
            User_Profile.Show()
            User_Profile.loggedIn = loggedIn ' Set loggedIn to True
            User_Profile.Profile.Text = "" & Profile.Text
            User_Profile.UpdateUI()
            User_Profile.CheckOrderConditionsForCustomer(CustID)
            User_Profile.CustomerInfo(CustID)
        Else
            loggedIn = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ReloadForm()
    End Sub
    Private Sub ReloadForm()
        ' Close the current instance of the form
        Me.Close()

        ' Open a new instance of the form
        Dim newForm As New HomeForm()
        newForm.Show()
        newForm.loggedIn = loggedIn ' Set loggedIn to loggedIn
        newForm.UpdateUI() ' Update the UI in MainForm
        newForm.PopulateCarDisplayPanel(loggedIn)
        newForm.Profile.Text = "" & Profile.Text
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ReloadForm()
    End Sub

    Private Sub HatchbackPanel_Paint(sender As Object, e As PaintEventArgs) Handles HatchbackPanel.Paint

    End Sub

    ' Function to navigate to next form with selected car's ID
End Class