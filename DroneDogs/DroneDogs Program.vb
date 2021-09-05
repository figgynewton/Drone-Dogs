Public Class DroneDogsOrder



Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

    'Declare constants
    Const DBL_SALES_TAX_RATE = 0.07
    Const DBL_PRICE_HOT_DOG As Double = 1.99


    Dim intNumBeefDogs As Integer
    Dim intNumPorkDogs As Integer
    Dim intNumTurkeyDogs As Integer
    Dim intTotalHotDogsOrdered As Integer

    Dim dblOrderSubtotal As Double
    Dim dblTaxAmtSales As Double
    Dim dblTotalOrderCost As Double


    'Declare variables 
    intNumBeefDogs = Convert.ToInt32(txtBeefDogs.Text)
    intNumPorkDogs = Convert.ToInt32(txtPorkDogs.Text)
    intNumTurkeyDogs = Convert.ToInt32(txtTurkeyDogs.Text)


    'Extract user typed quantities from text boxes and convert to integers

    'Calculate total number of hot dogs ordered
    intTotalHotDogsOrdered = (intNumBeefDogs + intNumPorkDogs + intNumTurkeyDogs)


    'Calculate subtotal, sales tax, and total amounts
    dblOrderSubtotal = (intTotalHotDogsOrdered * DBL_PRICE_HOT_DOG)
    dblTaxAmtSales = (dblOrderSubtotal * DBL_SALES_TAX_RATE)
    dblTotalOrderCost = (dblOrderSubtotal + dblTaxAmtSales)


    'Convert numbers back to text and display in text boxes
    txtTotalCost.Text = dblTotalOrderCost.ToString("c2")
    txtSalesTax.Text = dblTaxAmtSales.ToString("c2")
    txtSubtotal.Text = dblOrderSubtotal.ToString("c2")

End Sub

Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    Me.Close()
    'Close form

End Sub

Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MessageBox.Show("Thank you for ordering your meal from DroneDogs")
        'Display message box thanking the user

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblSubtotal.Click

    End Sub
End Class
