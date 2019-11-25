Public Class frmEditAppetizerOptions
    Private Sub frmEditAppetizerOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add(New String() {"Stuffed Baked Jalapenos", "Cut in Half and Filled withCheddar Bacon Cream Cheese", "$125.00"})
        DataGridView1.Rows.Add(New String() {"Assorted Cucumber Bites", "Red Pepper Hummus,Smoked Salmon or Blackened Shrimp", "$110.00"})
        DataGridView1.Rows.Add(New String() {"Sushi", "A Variety of Freshly Prepared Rolls with Wasabi & Soy Pearls", "$250.00"})
    End Sub
End Class