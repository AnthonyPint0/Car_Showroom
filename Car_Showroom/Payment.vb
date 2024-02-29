Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.Devices

Public Class Payment
    Private connectionString As String = "Data Source=DESKTOP-R8V9OD0;Initial Catalog=Car_ShowroomA;Integrated Security=True;Encrypt=True; Encrypt=False"
    Public CustID As Integer
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

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

    Private Sub OrderBtn_Click(sender As Object, e As EventArgs) Handles OrderBtn.Click
        Ordering()
    End Sub

    Private Sub Ordering()
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Pay Now?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        ' Check the user's response
        If Result = DialogResult.Yes Then
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "UPDATE Orders SET Cart = 0, Ordered = 1, Delivered = 0 WHERE CustomerID = @custID"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@custID", CustID)
                        command.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Payment Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Mainform.Show()
                User_Profile.Close()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error marking order as successful: " & ex.Message)
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
End Class