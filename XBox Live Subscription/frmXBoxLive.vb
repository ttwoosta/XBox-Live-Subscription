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
        ' The code execute when user taps or click on Calculate button,
        ' it will calculate subscription cost based on subscription type
        ' selection.

        ' Declare subscription price constants
        Const cdecSingleSubscription As Decimal = 7D
        Const cdecFamilySubscription As Decimal = 12D
        Const cdecDeveloperSubscription As Decimal = 3D



    End Sub
End Class
