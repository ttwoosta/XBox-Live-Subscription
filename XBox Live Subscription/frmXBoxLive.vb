' Program:      XBox Live Subscription
' Author:       Tu Tong
' Date:         October 29, 2017
' Purpose:      This Windows Desktop application calculates the payment 
'               amount for a monthly XBox Subscription

' Prevent automatic conversion of values
Option Strict On

Public Class frmXBoxLive

    ' Declare 

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This event handler is executed when user taps or click on Calculate button,
        ' it will calculate subscription cost based on subscription type
        ' selection.

        ' Declare subscription price constants
        Const cdecSingleSubscription As Decimal = 7D
        Const cdecFamilySubscription As Decimal = 12D
        Const cdecDeveloperSubscription As Decimal = 3D

        ' Declare variables
        Dim intNumberOfMonths As Integer
        Dim decSubscriptionPrice As Decimal
        Dim decSubscriptionCost As Decimal

        ' set subscription Cost label to $0
        ' to clear previous calculation
        lblSubscriptionCost.Text = 0.ToString("C")

        ' This satisfy the restriction #3
        ' Did user enter a name?
        If txtName.Text.Length = 0 Then
            ' Display an error message box because user did not enter a name
            ' set focus on Full Name textbox, and exit the function execution

            MsgBox("Please enter a name", MsgBoxStyle.Information, "Input error")
            txtName.Focus()
            Return
        End If

        ' This satisfy the restriction #1
        ' Did user enter a non-numeric value?
        If Not IsNumeric(txtNumberOfMonths.Text) Then
            ' Display an error message box because user did not enter a number
            ' set focus on Number of Month textbox, and exit the function execution

            MsgBox("Enter the Number of Month", MsgBoxStyle.Critical, "Input Error")
            txtNumberOfMonths.Clear()
            txtNumberOfMonths.Focus()
            Return
        End If

        ' convert entered Number of Months to Integer
        intNumberOfMonths = Convert.ToInt32(txtNumberOfMonths.Text)

        ' This satisfy the restriction #2
        ' Is the Number of month less than or equal to zero?
        If intNumberOfMonths <= 0 Then
            ' Display error message because user entered a negative number of months
            ' set focus on number of month textbox, and exit the function execution
            MsgBox("You entered " & intNumberOfMonths.ToString() & ". Please enter a valid number.",
                   MsgBoxStyle.Exclamation, "Input Error")
            txtNumberOfMonths.Clear()
            txtNumberOfMonths.Focus()
            Return
        End If

        ' Determine subscription cost
        If radSingleSubcription.Checked Then
            decSubscriptionPrice = cdecSingleSubscription
            Console.WriteLine("Debug Info: Single subscription type is selected, the price is: " &
                              decSubscriptionPrice.ToString("C"))
        ElseIf radFamilySubscription.Checked Then
            decSubscriptionPrice = cdecFamilySubscription
            Console.WriteLine("Debug Info: Family subscription type is selected, the price is: " &
                              decSubscriptionPrice.ToString("C"))
        ElseIf radDeveloperSubscription.Checked Then
            decSubscriptionPrice = cdecDeveloperSubscription
            Console.WriteLine("Debug Info: Developer subscription type is selected, the price is: " &
                              decSubscriptionPrice.ToString("C"))
        End If

        ' calculate and display the cost of subscription
        decSubscriptionCost = intNumberOfMonths * decSubscriptionPrice
        lblSubscriptionCost.Text = decSubscriptionCost.ToString("C")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when user click on Clear button
        ' It clear Name and Number of Month textboxes, set Subscription
        ' Cost label to $0, set the Single subscription radio button to checked
        ' clear others radio buttons, and set focus on the Full Name textbox

        txtName.Clear()
        txtNumberOfMonths.Clear()
        lblSubscriptionCost.Text = 0.ToString("C")
        radSingleSubcription.Checked = True
        radFamilySubscription.Checked = False
        radDeveloperSubscription.Checked = False
        txtName.Focus()

    End Sub

    Private Sub frmXBoxLive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the Form is loading.
        ' It set the text of Subcription Cost label to $0,
        ' set focus on the Full name text box.

        lblSubscriptionCost.Text = 0.ToString("C")
        txtName.Focus()

    End Sub
End Class
