Imports System.Drawing.Drawing2D

Public Class Mainform
    Public loggedIn As Boolean = False
    Private selectedButton As Button = Nothing
    Public carID As String
    Public CustID As Integer

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        ' Display a message box with Yes and No buttons
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit this application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            ' If the user clicks Yes, close the application
            Application.Exit()
        End If
    End Sub
    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateUI()
        ' Set the "Allbel" button as the initially selected button
        selectedButton = Allbel
        Allbel.BackColor = Color.FromArgb(0, 0, 64) ' Set dark blue color for selected button
        HatchbackGB.Visible = True
        SedanGB.Visible = True
        SUVGB.Visible = True
        MUVGB.Visible = True
        ' Enable MouseEnter and MouseLeave events for all buttons except the selected one
        For Each button As Button In {Allbel, Hatchbackbel, Sedanbel, SUVbel, MUVbel}
            If button IsNot selectedButton Then
                AddHandler button.MouseEnter, AddressOf Button_MouseEnter
                AddHandler button.MouseLeave, AddressOf Button_MouseLeave
            End If
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
            Individual_Car.CustID = CustID
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
    Private Sub Allbel_Click(sender As Object, e As EventArgs) Handles Allbel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Allbel)
        HatchbackGB.Visible = True
        SedanGB.Visible = True
        SUVGB.Visible = True
        MUVGB.Visible = True
    End Sub

    Private Sub Hatchbackbel_Click(sender As Object, e As EventArgs) Handles Hatchbackbel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Hatchbackbel)
        HatchbackGB.Visible = True
        SedanGB.Visible = False
        SUVGB.Visible = False
        MUVGB.Visible = False
    End Sub

    Private Sub Sedanbel_Click(sender As Object, e As EventArgs) Handles Sedanbel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Sedanbel)
        HatchbackGB.Visible = False
        SedanGB.Visible = True
        SUVGB.Visible = False
        MUVGB.Visible = False
    End Sub

    Private Sub SUVbel_Click(sender As Object, e As EventArgs) Handles SUVbel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(SUVbel)
        HatchbackGB.Visible = False
        SedanGB.Visible = False
        SUVGB.Visible = True
        MUVGB.Visible = False
    End Sub

    Private Sub MUVbel_Click(sender As Object, e As EventArgs) Handles MUVbel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(MUVbel)
        HatchbackGB.Visible = False
        SedanGB.Visible = False
        SUVGB.Visible = False
        MUVGB.Visible = True
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

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label42_Click(sender As Object, e As EventArgs) Handles Label42.Click

    End Sub

    Public Sub NextForm(carID)
        Individual_Car.Show() ' To show the main form
        Individual_Car.loggedIn = loggedIn ' Set loggedIn to True
        Individual_Car.Profile.Text = "" & Profile.Text
        Individual_Car.UpdateUI() ' Update the UI in Individual_Car
        Individual_Car.DisplayCarDetails(carID)
        Individual_Car.ColorsDisplay(carID)
    End Sub

    Private Sub BalenoBtn_Click(sender As Object, e As EventArgs) Handles BalenoBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "BalenoC1"
        carID = "BalenoC1"
        NextForm(carID)
    End Sub

    Private Sub PunchBtn_Click(sender As Object, e As EventArgs) Handles PunchBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "PunchC1"
        carID = "PunchC1"
        NextForm(carID)

    End Sub

    Private Sub WagonRBtn_Click(sender As Object, e As EventArgs) Handles WagonRBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "WagonRC1"
        carID = "WagonRC1"
        NextForm(carID)
    End Sub

    Private Sub SeltosBtn_Click(sender As Object, e As EventArgs) Handles SeltosBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "SeltosC1"
        carID = "SeltosC1"
        NextForm(carID)
    End Sub

    Private Sub SwiftBtn_Click(sender As Object, e As EventArgs) Handles SwiftBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "SwiftC1"
        carID = "SwiftC1"
        NextForm(carID)
    End Sub

    Private Sub i10_NiosBtn_Click(sender As Object, e As EventArgs) Handles i10_NiosBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "i10_NiosC1"
        carID = "i10_NiosC1"
        NextForm(carID)
    End Sub

    Private Sub KwidBtn_Click(sender As Object, e As EventArgs) Handles KwidBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "KwidC1"
        carID = "KwidC1"
        NextForm(carID)
    End Sub

    Private Sub DzireBtn_Click(sender As Object, e As EventArgs) Handles DzireBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "DzireC1"
        carID = "DzireC1"
        NextForm(carID)
    End Sub

    Private Sub AmazeBtn_Click(sender As Object, e As EventArgs) Handles AmazeBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "AmazeC1"
        carID = "AmazeC1"
        NextForm(carID)
    End Sub

    Private Sub AuraBtn_Click(sender As Object, e As EventArgs) Handles AuraBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "AuraC1"
        carID = "AuraC1"
        NextForm(carID)
    End Sub

    Private Sub CiazBtn_Click(sender As Object, e As EventArgs) Handles CiazBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "CiazC1"
        carID = "CiazC1"
        NextForm(carID)
    End Sub

    Private Sub TigoBtn_Click(sender As Object, e As EventArgs) Handles TigoBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "Tata Tigor"
        carID = "Tata Tigor"
        NextForm(carID)
    End Sub

    Private Sub VernaBtn_Click(sender As Object, e As EventArgs) Handles VernaBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "VernaC1"
        carID = "VernaC1"
        NextForm(carID)
    End Sub

    Private Sub BrezzaBtn_Click(sender As Object, e As EventArgs) Handles BrezzaBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "BrezzaC1"
        carID = "BrezzaC1"
        NextForm(carID)
    End Sub

    Private Sub NexonBtn_Click(sender As Object, e As EventArgs) Handles NexonBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "NexonC1"
        carID = "NexonC1"
        NextForm(carID)
    End Sub

    Private Sub CretaBtn_Click(sender As Object, e As EventArgs) Handles CretaBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "CretaC1"
        carID = "CretaC1"
        NextForm(carID)
    End Sub

    Private Sub XUV300Btn_Click(sender As Object, e As EventArgs) Handles XUV300Btn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "XUV300C1"
        carID = "XUV300C1"
        NextForm(carID)
    End Sub

    Private Sub MagniteBtn_Click(sender As Object, e As EventArgs) Handles MagniteBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "MagniteC1"
        carID = "MagniteC1"
        NextForm(carID)
    End Sub

    Private Sub BoleroBtn_Click(sender As Object, e As EventArgs) Handles BoleroBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "BoleroC1"
        carID = "BoleroC1"
        NextForm(carID)
    End Sub

    Private Sub CrystaBtn_Click(sender As Object, e As EventArgs) Handles CrystaBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "InnovaC1"
        carID = "InnovaC1"
        NextForm(carID)
    End Sub

    Private Sub ErtigaBtn_Click(sender As Object, e As EventArgs) Handles ErtigaBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "ErtigaC1"
        carID = "ErtigaC1"
        NextForm(carID)
    End Sub

    Private Sub CarensBtn_Click(sender As Object, e As EventArgs) Handles CarensBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "CarensC1"
        carID = "CarensC1"
        NextForm(carID)
    End Sub

    Private Sub ScorpioBtn_Click(sender As Object, e As EventArgs) Handles ScorpioBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "ScorpioC1"
        carID = "ScorpioC1"
        NextForm(carID)
    End Sub

    Private Sub TriberBtn_Click(sender As Object, e As EventArgs) Handles TriberBtn.Click
        Me.Hide() ' To hide the login form
        Individual_Car.carID = "TriberC1"
        carID = "TriberC1"
        NextForm(carID)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click

    End Sub

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

    Private Sub Sidebar_Paint(sender As Object, e As PaintEventArgs) Handles Sidebar.Paint

    End Sub
End Class