Imports System.Text.RegularExpressions

Public Class Form1

    Dim startBank As String = "0"
    Dim sucess As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'coinP.Value = "0"

        ' -- Set Starting Bank --
        While sucess = False
            startBank = InputBox("Enter your starting bank: ", "Starting Bank", "0")

            If validateInt(startBank, "Start Bank") Then
                NumericUpDown1.Value = Convert.ToDouble(startBank)
                sucess = True
            Else
                startBank = InputBox("Enter your starting bank: ", "Starting Bank", "0")
            End If
        End While
    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Console.WriteLine("key pressed")
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If

    End Sub

    ' -- Functions --

    ' add all values together to get deposit total
    Function calcTotal()
        total = pennies + nickles + dimes + quarters + rollPennies + rollNickles + rollDimes + rollQuarters + ones + fives + tens + twenties + fifties + hundreds
        fTotal.Text = total
        Dim deposit As Decimal = total - startBank
        If deposit > 0.00 Then
            dep.Text = deposit
        ElseIf deposit <= 0.00 Then
            dep.Text = "0"
        End If
        Return total
    End Function

    'validate input is an int
    Function validateInt(num, slot)
        Console.WriteLine("validating...")
        If Regex.IsMatch(num, "^[0-9 ]+$") Then
            Console.WriteLine("passed")
            Return True
        End If

        Console.WriteLine("failed")
        MessageBox.Show("Please enter a valid number for your " + slot)

        Return False
    End Function



    ' -- Define start Bank --
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        startBank = NumericUpDown1.Value
        calcTotal()
    End Sub


    ' -- Coin Counters --

    Dim pennies As Decimal = 0
    Dim nickles As Decimal = 0
    Dim dimes As Decimal = 0
    Dim quarters As Decimal = 0
    Dim total As Decimal = 0

    Private Sub coinP_TextChanged_1(sender As Object, e As EventArgs) Handles coinP.TextChanged
        If validateInt(coinP.Text, "pennies") Then
            pennies = Convert.ToDouble(coinP.Text) * 0.01
            calcTotal()
        End If
    End Sub

    Private Sub coinN_TextChanged_1(sender As Object, e As EventArgs) Handles coinN.TextChanged
        If validateInt(coinN.Text, "Nickles") Then
            nickles = Convert.ToDouble(coinN.Text) * 0.05
            calcTotal()
        End If
    End Sub

    Private Sub coinD_TextChanged_1(sender As Object, e As EventArgs) Handles coinD.TextChanged
        If validateInt(coinD.Text, "Dimes") Then
            dimes = Convert.ToDouble(coinD.Text) * 0.1
            calcTotal()
        End If
    End Sub

    Private Sub coinQ_TextChanged(sender As Object, e As EventArgs) Handles coinQ.TextChanged
        If validateInt(coinQ.Text, "Quarters") Then
            quarters = Convert.ToDouble(coinQ.Text) * 0.25
            calcTotal()
        End If
    End Sub

    ' -- Roll Counters --

    Dim rollPennies As Decimal = 0
    Dim rollNickles As Decimal = 0
    Dim rollDimes As Decimal = 0
    Dim rollQuarters As Decimal = 0

    Private Sub rollP_TextChanged(sender As Object, e As EventArgs) Handles rollP.TextChanged
        If validateInt(rollP.Text, "Penny Rolls") Then
            rollPennies = Convert.ToDouble(rollP.Text) * 0.5
            calcTotal()
        End If
    End Sub

    Private Sub rollN_TextChanged(sender As Object, e As EventArgs) Handles rollN.TextChanged
        If validateInt(rollN.Text, "Nickel Rolls") Then
            rollNickles = Convert.ToDouble(rollN.Text) * 2
            calcTotal()
        End If
    End Sub

    Private Sub rollD_TextChanged(sender As Object, e As EventArgs) Handles rollD.TextChanged
        If validateInt(rollD.Text, "Dime Rolls") Then
            rollDimes = Convert.ToDouble(rollD.Text) * 5
            calcTotal()
        End If
    End Sub

    Private Sub rollQ_TextChanged(sender As Object, e As EventArgs) Handles rollQ.TextChanged
        If validateInt(rollQ.Text, "Quarter Rolls") Then
            rollQuarters = Convert.ToDouble(rollQ.Text) * 10
            calcTotal()
        End If
    End Sub

    ' -- Bill Counters --

    Dim ones As Decimal = 0
    Dim fives As Decimal = 0
    Dim tens As Decimal = 0
    Dim twenties As Decimal = 0
    Dim fifties As Decimal = 0
    Dim hundreds As Decimal = 0

    Private Sub bill1_TextChanged(sender As Object, e As EventArgs)
        If validateInt(bill1.Text, "Ones") Then
            ones = Convert.ToDouble(bill1.Text)
            calcTotal()
        End If
    End Sub

    Private Sub bill5_TextChanged(sender As Object, e As EventArgs)
        If validateInt(bill5.Text, "Fives") Then
            fives = Convert.ToDouble(bill5.Text) * 5
            calcTotal()
        End If
    End Sub

    Private Sub bill10_TextChanged(sender As Object, e As EventArgs)
        If validateInt(bill10.Text, "Tens") Then
            tens = Convert.ToDouble(bill10.Text) * 10
            calcTotal()
        End If
    End Sub

    Private Sub bill20_TextChanged(sender As Object, e As EventArgs)
        If validateInt(bill20.Text, "Twenties") Then
            twenties = Convert.ToDouble(bill20.Text) * 20
            calcTotal()
        End If
    End Sub

    Private Sub bill50_TextChanged(sender As Object, e As EventArgs)
        If validateInt(bill50.Text, "Fifties") Then
            fifties = Convert.ToDouble(bill50.Text) * 50
            calcTotal()
        End If
    End Sub

    Private Sub bill100_TextChanged(sender As Object, e As EventArgs)
        If validateInt(bill100.Text, "Hundreds") Then
            hundreds = Convert.ToDouble(bill100.Text) * 100
            calcTotal()
        End If
    End Sub


End Class
