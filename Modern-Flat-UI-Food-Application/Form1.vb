Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection

    Private Sub btnFood_Click(sender As Object, e As EventArgs) Handles btnFood.Click
        pnlOnButtonPosition.Height = btnFood.Height
        pnlOnButtonPosition.Top = btnFood.Top

        pnlFoods.Visible = True
        pnlDrinks.Visible = False
        pnlDesserts.Visible = False
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = False
    End Sub

    Private Sub btnDrink_Click(sender As Object, e As EventArgs) Handles btnDrink.Click
        pnlOnButtonPosition.Height = btnDrink.Height
        pnlOnButtonPosition.Top = btnDrink.Top

        pnlFoods.Visible = False
        pnlDrinks.Visible = True
        pnlDesserts.Visible = False
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = False
    End Sub

    Private Sub btnDesserts_Click(sender As Object, e As EventArgs) Handles btnDesserts.Click
        pnlOnButtonPosition.Height = btnDesserts.Height
        pnlOnButtonPosition.Top = btnDesserts.Top

        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDesserts.Visible = True
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = False
    End Sub

    Private Sub btnMyCart_Click(sender As Object, e As EventArgs) Handles btnMyCart.Click
        pnlOnButtonPosition.Height = btnMyCart.Height
        pnlOnButtonPosition.Top = btnMyCart.Top

        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDesserts.Visible = False
        pnlMyCart.Visible = True
        pnlAboutUs.Visible = False
    End Sub

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        pnlOnButtonPosition.Height = btnAboutUs.Height
        pnlOnButtonPosition.Top = btnAboutUs.Top

        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDesserts.Visible = False
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = True
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub picMaximize_Click(sender As Object, e As EventArgs) Handles picMaximize.Click
        If WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        conn.ConnectionString = "server=localhost;userid=root;password='';database=food_app"

        Try
            conn.Open()
            MessageBox.Show("Connection to MySQL test database was successful!!!", "TESTING
            CONNECTION TO MySQL DATABASE")

            Dim InsertCommand = "INSERT INTO sell(produkId, produk_name, produk_price) 
                                VALUES (@produkId, @produk_name, @produk_price)"

            Dim COMMAND = New MySqlCommand(InsertCommand, conn)

            COMMAND.Parameters.AddWithValue("@produkId", 1)
            COMMAND.Parameters.AddWithValue("@produk_name", "nasi")
            COMMAND.Parameters.AddWithValue("@produk_price", 5000)
            COMMAND.Prepare()

            COMMAND.ExecuteNonQuery()
            Console.WriteLine("Record inserted successfully")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub
End Class
