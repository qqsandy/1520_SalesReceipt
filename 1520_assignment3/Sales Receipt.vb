Public Class Receipt
    ' Created by:           Sandy Le
    ' Course:               COIS-1520 WINTER2019
    ' Assignemnt:           Assignment #3 - Sales Receipt
    ' Due Date:             March 8, 2019 @ 12:00
    ' -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    ' 
    ' [Program Description]
    ' This program Is a sales receipt generator based off Of an imaginary store I've made up named "Friendly's". This receipt generator produces a sales receipt based off the
    ' item(s) in your cart. Using a textbox to take user input for the item name & price, the program will add the item&price using the 'AddItemBtn' and has the capabilites to keep updating
    ' your cart until you want to check out using the check out button that will prompt the subtotal, hst, and total into our listbox. I've added a feature for Friendly's exclusive $1.99
    ' sale that includes a combo box with predefined items & prices (1.99 for selected items) that will be added to your cart and displayed on the listbox (receipt) as well.
    ' -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '
    ' [Instructions]
    ' 1. Enter an item name & price to the correct text boxes
    ' 2. You may also add featured hot sale items from friendly's selected $1.99 sale to the cart as well using the combobox.
    ' 3. Add the standard item to your cart with the 'Add item to cart' button and/or 'Add sale item to cart' for the featured sale items.
    ' 4. Repeat steps 1-3 however many times you have to in order to buy everything you desire.
    ' 5. Use the 'check-out' button to checkout and print the subtotal, hst, and total amount.
    ' 6. Use the 'Close transaction' button to clear the previous transacations. (this will clear the listbox and all textbox)
    ' 7. When you've grown bored of the program use the exit button to close the program.
    ' -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    ' [Other Stuff]
    ' 1. Labels:
    '   a. 'ReceiptLbl'     - This label is used to represent the receipt, it says "Friendly's Sales Receipt:"
    '   b. 'ItemLbl'        - This label is used to highlight and locate the item text box, displaying "Item:"
    '   c. 'PriceLbl'       - This label is used to highlight and locate the price text box, displaying "Price:"
    '   d. 'saleLbl'        - This label is used to highlight the sale items below of it (combobox), displaying "$1.99 Sale Items:"
    '
    ' 2. TextBoxs:
    '   a. 'ItemTxtBox'     - This textbox is for the user to input the item name they desire to purchase.
    '   b. 'PriceTxtBox'    - This textbox is for the user to input the price of the item they desire to purchase.
    ' 
    ' 3. Buttons:
    '   a. 'AddItemBtn'     - Button used to add the credentials in itemtxtbox and pricetxtbox to the cart/receipt/listbox.
    '   b. 'saleButton'     - Button used to add the Friendly's $1.99 sale from the combobox.
    '   c. 'CheckOutBtn'    - Button used to compute and display the subtotal, tax and total amount on the receipt/listbox.
    '   d. 'CloseTransBtn'  - Button used to clear all the fields in the textboxes, listbox, and variable value. Resetting everything.
    '   e. 'ExitBtn'        - Button used to exit the program.
    '
    ' 4. ListBox:
    '   a. 'ReceiptListBox' - This listbox acts as the receipt/cart. It takes userinputted formatted values of items and prices. Prints everything on your order onto this listbox.
    '
    ' 5. PicBox:
    '   a. 'LogoPicBox'     - A picbox used to import the logo of "Friendly's".
    '
    ' 6. ComboBox:
    '   a. 'saleCmbBox'     - A combo box that displays predefined items and prices for the "$1.99 sale", it can be used paired with the add sale button to add these sale items to the cart.
    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '
    ' Declaration of variables used throughout the program
    Dim subTotal As Double                   ' This variable is used to store and represent the value of the cost of all items in cart before taxes.
    Dim totalCost As Double                  ' This variable is used to store and represent the value of the cost of the total amount after taxes.
    Dim tax As Double                        ' This variable is to represent the tax amount, which is 13% of the subtotal.
    Dim counter As Integer                   ' This variable is represents the amount of items the user has in his cart.
    Dim coloumn As String = "{0,-20}{1,20}"  ' This variable is a format.string type variable used to organize a column's in our listbox output. First cololumn aligns to the  right for 20 chars (item), and the secound coloumn aligns left for the next 20 characters (price).
    Dim center As String = "{0,27}"          ' This variable is used to center to print out the storename on our receipt. when center is used in format it will center the output, in this case the store name
    Dim timeCenter As String = "{0,31}"      ' This variable is used to center when formated the time on the receipt, no other usage than that.
    Dim price As Double                      ' This variable is used to store & represent the price of the item in the price text box. (Although I could of used itemtxtbox.text, it seems less tedious to instatiate a much shorter length variable)
    Dim item As String                       ' This variable is used to store and represent the string/item name in the item text box. (Although I could of used pricetxtbox.text, it seems less tedious to instatiate a much shorter length variable)

    Private Sub AddItemBtn_Click(sender As Object, e As EventArgs) Handles AddItemBtn.Click
        ' In this subroutine, I've used an elseif statement with multiple outcomes per situations, such as empty fields in textboxs, invalid amounts, character limit, etc.
        ' I've added a 20 character limit for the item as it kind of messes up with coloumn alighment if you spam the character count, and in most real receipts the item name is shorten.
        ' I've added an else if situation if the price is equal to or exceeding the value of 100,000 as Friendly's is a department store with nothing more than that amount, and to not mess with
        ' alignment issues with a gazillion amount. These situations will prompt a message box to display the error that the user had occured.
        ' If all else works then it goes to one last elseif situation where it's basically the else statement where it will take the item and price and add it to the cart when clicked, but
        ' this time the condition is if the counter = 0 to allow for the storename and date to be printed off once and only once per transaction.
        ' When the button is clicked or hotkeyed the item will be added and the prices will be added accordingly to the user input, this will count the sum of the subtotal
        ' and counter as well but will not be dispalyed but rather stored until further usage in the checkout button.
        If String.IsNullOrEmpty(ItemTxtBox.Text) Or String.IsNullOrEmpty(PriceTxtBox.Text) Then
            MsgBox("***ERROR***: TEXT AND/OR PRICE IS EMPTY")
        ElseIf Val(PriceTxtBox.Text = 0) Then
            MsgBox("***ERROR***: PRICE CANNOT BE ZERO!")
        ElseIf Val(PriceTxtBox.Text >= 100000) Then
            MsgBox("***ERROR***: NOTHING COST THIS MUCH AT FRIENDLY'S!")
        ElseIf (ItemTxtBox.Text.Length > 20) Then
            MsgBox("***ERROR***: ITEM CANNOT BE LONGER THAN 15 CHARACTERS!")
        ElseIf (counter = 0) Then
            ReceiptListBox.Items.Add(String.Format(center, "[Friendly's]"))
            ReceiptListBox.Items.Add(String.Format(timeCenter, Now()))
            ReceiptListBox.Items.Add("--------------------------------------------")
            price = PriceTxtBox.Text
            item = ItemTxtBox.Text
            ReceiptListBox.Items.Add(String.Format(coloumn, item, FormatCurrency(price)))
            'cost += PriceTxtBox.Text
            subTotal += price
            ReceiptListBox.TopIndex = ReceiptListBox.Items.Count - 1
            counter += 1
        Else
            'PriceTxtBox.Text = FormatCurrency(PriceTxtBox.Text)
            price = PriceTxtBox.Text
            item = ItemTxtBox.Text
            ReceiptListBox.Items.Add(String.Format(coloumn, item, FormatCurrency(price)))
            'cost += PriceTxtBox.Text
            subTotal += price
            ReceiptListBox.TopIndex = ReceiptListBox.Items.Count - 1
            counter += 1
        End If
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        ' The code below Ensures that the sales receipt program (form) is closed when button is clicked or activated.
        Me.Close()
    End Sub

    Private Sub PriceTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PriceTxtBox.KeyPress
        ' In this subroutine, the code below acts as a restriction. Similar to older assignments, the code below will not allow any key press that is not numbers or decimals.
        ' Any price should be in this format with only numbers, decimals, and backspace (8) for correction purposes.
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub CheckOutBtn_Click(sender As Object, e As EventArgs) Handles CheckOutBtn.Click
        ' This subroutine is coded to work for the checkout button, whenever clicked or hotkeyed the following code uses a if elseif statement to compute the checkout prompt message, and
        ' the values of the variables such as subtotal, tax, and total amount. There are if else if statements to prevent any errors that may occur such as checking out on empty entries
        ' such as there being no items added, and if the counter is 0, means there aren't any items.
        ' The secound if statement is to prompt the ending receipt message along with the item counter amount, depending on if you had checked out with 1 or more items, the scenario will trigger
        ' one of the if else statement for the situation. The only real difference was a grammartic error if this if statement was not present in the word 'item or items'. 
        ' If you bought 1 item, it says item, 2 or more = items.
        ' When clicked it will prompt the messages with the subtotal, tax, and total amount along with the item amount.
        If (subTotal >= 0.01 Or counter >= 1) Then
            ReceiptListBox.Items.Add("--------------------------------------------")
            ReceiptListBox.Items.Add((String.Format(coloumn, "Subtotal:", FormatCurrency(subTotal))))
            tax = (subTotal * 0.13)
            ReceiptListBox.Items.Add((String.Format(coloumn, "HST Tax (13%):", FormatCurrency(tax))))
            totalCost = (subTotal + tax)
            ReceiptListBox.Items.Add((String.Format(coloumn, "Total amount:", FormatCurrency(totalCost))))
            ReceiptListBox.Items.Add("--------------------------------------------")
        ElseIf (subTotal <= 0.00 Or counter = 0) Then
            MsgBox("***ERROR***: There is an error with the price or item.")
        End If

        If (counter = 1) Then
            ReceiptListBox.Items.Add(("Thank you for buying " & counter & " item."))
            ReceiptListBox.Items.Add("Thanks for shopping at Friendly's")
        ElseIf (counter >= 2) Then
            ReceiptListBox.Items.Add("Thank you for buying " & counter & " items.")
            ReceiptListBox.Items.Add("Thanks for shopping at Friendly's")
        End If
        ReceiptListBox.TopIndex = ReceiptListBox.Items.Count - 1
    End Sub

    Private Sub CloseTransBtn_Click(sender As Object, e As EventArgs) Handles CloseTransBtn.Click
        ' This subroutine will give the button function to clear everything within the listbox and all of the variables will be resetted to their default values of zero.
        ReceiptListBox.Items.Clear()
        subTotal = 0
        counter = 0
        totalCost = 0
        ItemTxtBox.Clear()
        PriceTxtBox.Clear()
    End Sub

    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This subroutine is addtional work that I did to add a bit of originality to my sales receipt generator by adding predefined items that can be added by selecting the item and
        ' using the 'Add sale item to cart' button. The following are the item names in the combo box, all these items have the default value of $1.99, hence the "1.99 sale".
        saleCmbBox.Items.Add("Friendly's Hotdogs")
        saleCmbBox.Items.Add("Friendly's Eggs")
        saleCmbBox.Items.Add("Friendly's Bread")
        saleCmbBox.Items.Add("Friendly's Soap")
        saleCmbBox.Items.Add("Friendly's Butter")
    End Sub

    Private Sub saleButton_Click(sender As Object, e As EventArgs) Handles saleButton.Click
        ' Additional subroutine for the sale I've added.
        ' This will give the salebutton function to add the sale item to the cart, depending on the item selected, I was not sure how to make sure that if user edited the predefined combobox
        ' items that it will still add regardless, so I made sure that the length had to be atleast 10 characters long (because all my predefined items are) and use that as a condition in my
        ' if else statement. When clicked the item will be added and the counter will increment by 1 as well, along with the subtotal. (also note it had auto scrolling with itesm.count-1)
        If (saleCmbBox.Text.Length > 10) Then
            ReceiptListBox.Items.Add(String.Format(coloumn, saleCmbBox.Text, FormatCurrency(1.99)))
            subTotal += 1.99
            counter += 1
            ReceiptListBox.TopIndex = ReceiptListBox.Items.Count - 1
        Else
            MsgBox("***ERROR***: ITEM NOT ON FRIENDLY'S $1.99 SALE!")
        End If
    End Sub
End Class