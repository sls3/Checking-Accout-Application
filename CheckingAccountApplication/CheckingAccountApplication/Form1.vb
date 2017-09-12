'Sameer Shrestha
'Description: Checking Account Application
'9/11/2017

Public Class Form1

    Private dBalance As Double
    Private iNumberOfDeposits As Integer
    Private dTotalDeposit As Double
    Private iNumberOfChecks As Integer
    Private dTotalChecks As Double
    Private iNumberOfServiceCharges As Integer
    Private dTotalServiceCharges As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' e.DrawBackground()
        RadioDeposit.Select()
        TextBoxTransactionAmt.Select()
        ListBoxAccount.Items.Add("Transaction type                 Amount")
        dBalance = 0
        iNumberOfDeposits = 0
        dTotalDeposit = 0
        iNumberOfChecks = 0
        dTotalChecks = 0
        iNumberOfServiceCharges = 0
        dTotalServiceCharges = 0

    End Sub


    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        'If RadioDeposit.Checked = False And RadioCheck.Checked = False And RadioServiceCharge.Checked = False Then
        'MsgBox("Transaction type missing", "Tranaction Error")
        'End If


        If RadioDeposit.Checked = True Then
            dBalance = dBalance + Val(TextBoxTransactionAmt.Text)
            iNumberOfDeposits = iNumberOfDeposits + 1
            dTotalDeposit = dTotalDeposit + Val(TextBoxTransactionAmt.Text)
            ListBoxAccount.Items.Add("Deposit                               " + TextBoxTransactionAmt.Text)
            LabelRemainingBalance.Text = dBalance
        End If

        If RadioCheck.Checked = True Then

            If dBalance < Val(TextBoxTransactionAmt.Text) Then
                ListBoxAccount.ForeColor = Color.Red
                ListBoxAccount.Items.Add("Check Bounced                                " + TextBoxTransactionAmt.Text)
                'Dim intListCount = ListBoxAccount.Items.Count
                ' ListBoxAccount.
                MsgBox("You don't have sufficient funds to cover the check amount", vbExclamation, "Insufficient Funds")
                dBalance = dBalance - 10
                iNumberOfServiceCharges = iNumberOfServiceCharges + 1
                dTotalServiceCharges = dTotalServiceCharges + 10
                ListBoxAccount.Items.Add("Service Charge                   10")
                If dBalance < 0 Then
                    MsgBox("You have an overdraft", vbExclamation, "Overdraft Alert")
                End If
            End If

            If dBalance >= Val(TextBoxTransactionAmt.Text) Then
                dBalance = dBalance - Val(TextBoxTransactionAmt.Text)
                iNumberOfChecks = iNumberOfChecks + 1
                dTotalChecks = dTotalChecks + Val(TextBoxTransactionAmt.Text)
                ListBoxAccount.Items.Add("Check                                 " + TextBoxTransactionAmt.Text)
            End If

            LabelRemainingBalance.Text = dBalance
        End If

        If RadioServiceCharge.Checked = True Then
            dBalance = dBalance - Val(TextBoxTransactionAmt.Text)
            iNumberOfServiceCharges = iNumberOfServiceCharges + 1
            dTotalServiceCharges = dTotalServiceCharges + Val(TextBoxTransactionAmt.Text)
            ListBoxAccount.Items.Add("Service Charge                   " + TextBoxTransactionAmt.Text)
            If dBalance < 0 Then
                MsgBox("You have an overdraft", vbExclamation, "Overdraft Alert")
            End If
            LabelRemainingBalance.Text = dBalance
        End If


    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxTransactionAmt.Clear()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Application.Exit()
    End Sub

    Private Sub ButtonSummary_Click(sender As Object, e As EventArgs) Handles ButtonSummary.Click
        MsgBox("Total Number of Deposits: " & iNumberOfDeposits & Environment.NewLine &
               "Total Dollar Amount of Deposits: $" & dTotalDeposit & Environment.NewLine &
               "Total Number of Checks: " & iNumberOfChecks & Environment.NewLine &
               "Total Dollar Amount of Checks: $" & dTotalChecks & Environment.NewLine &
               "Total Number of Service Charges: " & iNumberOfServiceCharges & Environment.NewLine &
               "Total Dollar Amount of Service Charges: $" & dTotalServiceCharges & Environment.NewLine)
    End Sub

    Private Sub ListBoxAccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxAccount.SelectedIndexChanged
        'ListBoxAccount.Items.Add()

    End Sub
End Class
