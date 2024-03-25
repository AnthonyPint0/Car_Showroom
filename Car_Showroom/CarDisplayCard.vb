Imports System.Runtime.InteropServices.ComTypes

Public Class CarDisplayCard
    Public Property CarID As String
    Public Property CarName As String
    Public Property Price As String
    Public Property Profile As String
    Public Property loggedIn As Boolean
    Public Property CarImage As Image
    Public Event ViewMoreButtonClick As EventHandler

    Private Sub ViewMoreButton_Click(sender As Object, e As EventArgs) Handles ViewMoreBtn.Click
        NextForm(CarID)
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub CarDisplayControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarNameLB.Text = CarName
        PriceLB.Text = "Starting from ₹ " & Price
        CarImagePB.Image = CarImage
    End Sub

    Private Sub NextForm(carID As String)
        HomeForm.Hide()
        Me.Hide() ' To hide the login form
        Individual_Car.carID = carID
        IndiForm(carID)
    End Sub

    Private Sub IndiForm(carID As String)
        Individual_Car.Show() ' To show the main form
        Individual_Car.loggedIn = loggedIn ' Set loggedIn to True
        Individual_Car.Profile.Text = "" & Profile
        Individual_Car.UpdateUI() ' Update the UI in Individual_Car
        Individual_Car.DisplayCarDetails(carID)
        Individual_Car.ColorsDisplay(carID)
    End Sub
End Class
