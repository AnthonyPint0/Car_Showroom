Imports System.Drawing.Drawing2D
Imports System.Data.SqlClient

Public Class Individual_Car
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public loggedIn As Boolean = False
    Private selectedButton As Button = Nothing

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
    Private Sub Individual_Car_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateUI()
        ' Set the "Allbel" button as the initially selected button
        selectedButton = Allbel
        Allbel.BackColor = Color.FromArgb(0, 0, 64) ' Set dark blue color for selected button

        ' Enable MouseEnter and MouseLeave events for all buttons except the selected one
        For Each button As Button In {Allbel, Hatchbackbel, Sedanbel, SUVbel, MUVbel, MPVbel}
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
        Login_info1.Visible = False
        Login_info1.Visible = False
        Logout.Visible = False
        Form_Login.loggedIn = False
    End Sub

    Private Sub Login_info1_Paint(sender As Object, e As PaintEventArgs)
        ' Define the region for rounded edges
        Dim panelRegion As New Region(New Rectangle(0, 0, Login_info1.Width, Login_info1.Height))
        Dim panelPath As New GraphicsPath()
        Dim radius As Integer = 10 ' Adjust the radius to control the roundness of edges

        ' Draw rounded rectangle
        panelPath.AddArc(New Rectangle(0, 0, 2 * radius, 2 * radius), 180, 90)
        panelPath.AddArc(New Rectangle(Login_info1.Width - 2 * radius, 0, 2 * radius, 2 * radius), 270, 90)
        panelPath.AddArc(New Rectangle(Login_info1.Width - 2 * radius, Login_info1.Height - 2 * radius, 2 * radius, 2 * radius), 0, 90)
        panelPath.AddArc(New Rectangle(0, Login_info1.Height - 2 * radius, 2 * radius, 2 * radius), 90, 90)
        panelPath.CloseAllFigures()

        ' Apply the rounded rectangle region to the panel
        panelRegion = New Region(panelPath)
        Login_info1.Region = panelRegion

        ' Optionally, you can set a background color or image for the panel
        ' Login_info1.BackColor = Color.White
        ' Login_info1.BackgroundImage = YourImage
    End Sub

    Public Sub UpdateUI()
        If loggedIn Then
            Registerlink.Visible = False
            Login_info1.Visible = True
            Logout.Text = "Log out"
            Logout.Visible = True
        Else
            Registerlink.Visible = True
            Logout.Text = ""
            Login_info1.Visible = False
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
        End If
    End Sub
    Private Sub Allbel_Click(sender As Object, e As EventArgs) Handles Allbel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Allbel)
    End Sub

    Private Sub Hatchbackbel_Click(sender As Object, e As EventArgs) Handles Hatchbackbel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Hatchbackbel)
    End Sub

    Private Sub Sedanbel_Click(sender As Object, e As EventArgs) Handles Sedanbel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(Sedanbel)
    End Sub

    Private Sub SUVbel_Click(sender As Object, e As EventArgs) Handles SUVbel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(SUVbel)
    End Sub

    Private Sub MUVbel_Click(sender As Object, e As EventArgs) Handles MUVbel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(MUVbel)
    End Sub

    Private Sub MPVbel_Click(sender As Object, e As EventArgs) Handles MPVbel.Click
        ' Call the function to handle button clicks
        HandleButtonClick(MPVbel)
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
        For Each button As Button In {Allbel, Hatchbackbel, Sedanbel, SUVbel, MUVbel, MPVbel}
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
End Class