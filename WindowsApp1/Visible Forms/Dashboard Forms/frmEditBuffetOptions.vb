Public Class frmEditBuffetOptions
    Private Sub frmEditBuffetOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add(New String() {"Entree", "Glazed Carribean JerkPork Loin", "Jerk Brined and Served withTropical Mango & Pineapple Salsa", "$5.00"})
        DataGridView1.Rows.Add(New String() {"Side Dish", "Herbed Stuffing with Gravy", "Savory Bread Stuffing with SpicyPork Sausage", ""})
        DataGridView1.Rows.Add(New String() {"Salads", "Mixed Garden Greens", "Tomatoes, Cucumbers, ShreddedCheese, Blue Cheese Crumbles", ""})
    End Sub



End Class