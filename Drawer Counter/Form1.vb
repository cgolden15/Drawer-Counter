Public Class Form1

    Dim startBank As Integer = 0
    Dim sucess As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'coinP.Value = "0"
        startBank = InputBox("Enter your starting bank: ", "Starting Bank", "0")

        Try
            sucess = Int32.TryParse(startBank, 0)
        Catch ex As Exception
            MsgBox("Please enter a valid number")
            startBank = InputBox("Enter your starting bank: ", "Starting Bank", "0")
        End Try
        If sucess = True Then
            NumericUpDown1.Value = startBank
        Else
            MsgBox("Please enter a valid number")
            startBank = InputBox("Enter your starting bank: ", "Starting Bank", "0")
        End If
    End Sub

    ' -- Functions --

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

    ' -- I dont feel like categorizing --
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

    Private Sub coinP_ValueChanged(sender As Object, e As EventArgs) Handles coinP.ValueChanged
        pennies = coinP.Value * 0.01
        calcTotal()
    End Sub

    Private Sub coinN_ValueChanged(sender As Object, e As EventArgs) Handles coinN.ValueChanged
        nickles = coinN.Value * 0.05
        calcTotal()
    End Sub

    Private Sub coinD_ValueChanged(sender As Object, e As EventArgs) Handles coinD.ValueChanged
        dimes = coinD.Value * 0.1
        calcTotal()
    End Sub

    Private Sub coinQ_ValueChanged(sender As Object, e As EventArgs) Handles coinQ.ValueChanged
        quarters = coinQ.Value * 0.25
        calcTotal()
    End Sub

    ' -- Roll Counters --

    Dim rollPennies As Decimal = 0
    Dim rollNickles As Decimal = 0
    Dim rollDimes As Decimal = 0
    Dim rollQuarters As Decimal = 0

    Private Sub rollP_ValueChanged(sender As Object, e As EventArgs) Handles rollP.ValueChanged
        rollPennies = rollP.Value * 0.5
        calcTotal()
    End Sub

    Private Sub rollN_ValueChanged(sender As Object, e As EventArgs) Handles rollN.ValueChanged
        rollNickles = rollN.Value * 2
        calcTotal()
    End Sub
    Private Sub rollD_ValueChanged(sender As Object, e As EventArgs) Handles rollD.ValueChanged
        rollDimes = rollD.Value * 5
        calcTotal()
    End Sub
    Private Sub rollQ_ValueChanged(sender As Object, e As EventArgs) Handles rollQ.ValueChanged
        rollQuarters = rollQ.Value * 10
        calcTotal()
    End Sub

    ' -- Bill Counters --

    Dim ones As Decimal = 0
    Dim fives As Decimal = 0
    Dim tens As Decimal = 0
    Dim twenties As Decimal = 0
    Dim fifties As Decimal = 0
    Dim hundreds As Decimal = 0

    Private Sub bill1_ValueChanged(sender As Object, e As EventArgs) Handles bill1.ValueChanged
        ones = bill1.Value
        calcTotal()
    End Sub
    Private Sub bill5_ValueChanged(sender As Object, e As EventArgs) Handles bill5.ValueChanged
        fives = bill5.Value * 5
        calcTotal()
    End Sub
    Private Sub bill10_ValueChanged(sender As Object, e As EventArgs) Handles bill10.ValueChanged
        tens = bill10.Value * 10
        calcTotal()
    End Sub
    Private Sub bill20_ValueChanged(sender As Object, e As EventArgs) Handles bill20.ValueChanged
        twenties = bill20.Value * 20
        calcTotal()
    End Sub
    Private Sub bill50_ValueChanged(sender As Object, e As EventArgs) Handles bill50.ValueChanged
        fifties = bill50.Value * 50
        calcTotal()
    End Sub
    Private Sub bill100_ValueChanged(sender As Object, e As EventArgs) Handles bill100.ValueChanged
        hundreds = bill100.Value * 100
        calcTotal()
    End Sub

End Class
