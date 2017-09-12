<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RadioDeposit = New System.Windows.Forms.RadioButton()
        Me.RadioCheck = New System.Windows.Forms.RadioButton()
        Me.RadioServiceCharge = New System.Windows.Forms.RadioButton()
        Me.LabelTransactionType = New System.Windows.Forms.Label()
        Me.LabelTransactionAmt = New System.Windows.Forms.Label()
        Me.TextBoxTransactionAmt = New System.Windows.Forms.TextBox()
        Me.LabelBalance = New System.Windows.Forms.Label()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.LabelRemainingBalance = New System.Windows.Forms.Label()
        Me.ButtonSummary = New System.Windows.Forms.Button()
        Me.ListBoxAccount = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'RadioDeposit
        '
        Me.RadioDeposit.AutoSize = True
        Me.RadioDeposit.Location = New System.Drawing.Point(28, 90)
        Me.RadioDeposit.Name = "RadioDeposit"
        Me.RadioDeposit.Size = New System.Drawing.Size(61, 17)
        Me.RadioDeposit.TabIndex = 0
        Me.RadioDeposit.TabStop = True
        Me.RadioDeposit.Text = "Deposit"
        Me.RadioDeposit.UseVisualStyleBackColor = True
        '
        'RadioCheck
        '
        Me.RadioCheck.AutoSize = True
        Me.RadioCheck.Location = New System.Drawing.Point(95, 90)
        Me.RadioCheck.Name = "RadioCheck"
        Me.RadioCheck.Size = New System.Drawing.Size(56, 17)
        Me.RadioCheck.TabIndex = 1
        Me.RadioCheck.TabStop = True
        Me.RadioCheck.Text = "Check"
        Me.RadioCheck.UseVisualStyleBackColor = True
        '
        'RadioServiceCharge
        '
        Me.RadioServiceCharge.AutoSize = True
        Me.RadioServiceCharge.Location = New System.Drawing.Point(157, 90)
        Me.RadioServiceCharge.Name = "RadioServiceCharge"
        Me.RadioServiceCharge.Size = New System.Drawing.Size(98, 17)
        Me.RadioServiceCharge.TabIndex = 2
        Me.RadioServiceCharge.TabStop = True
        Me.RadioServiceCharge.Text = "Service Charge"
        Me.RadioServiceCharge.UseVisualStyleBackColor = True
        '
        'LabelTransactionType
        '
        Me.LabelTransactionType.AutoSize = True
        Me.LabelTransactionType.Location = New System.Drawing.Point(92, 65)
        Me.LabelTransactionType.Name = "LabelTransactionType"
        Me.LabelTransactionType.Size = New System.Drawing.Size(90, 13)
        Me.LabelTransactionType.TabIndex = 3
        Me.LabelTransactionType.Text = "Transaction Type"
        '
        'LabelTransactionAmt
        '
        Me.LabelTransactionAmt.AutoSize = True
        Me.LabelTransactionAmt.Location = New System.Drawing.Point(28, 114)
        Me.LabelTransactionAmt.Name = "LabelTransactionAmt"
        Me.LabelTransactionAmt.Size = New System.Drawing.Size(102, 13)
        Me.LabelTransactionAmt.TabIndex = 4
        Me.LabelTransactionAmt.Text = "Transaction Amount"
        '
        'TextBoxTransactionAmt
        '
        Me.TextBoxTransactionAmt.Location = New System.Drawing.Point(136, 111)
        Me.TextBoxTransactionAmt.Name = "TextBoxTransactionAmt"
        Me.TextBoxTransactionAmt.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTransactionAmt.TabIndex = 3
        '
        'LabelBalance
        '
        Me.LabelBalance.AutoSize = True
        Me.LabelBalance.Location = New System.Drawing.Point(70, 143)
        Me.LabelBalance.Name = "LabelBalance"
        Me.LabelBalance.Size = New System.Drawing.Size(46, 13)
        Me.LabelBalance.TabIndex = 6
        Me.LabelBalance.Text = "Balance"
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Location = New System.Drawing.Point(31, 172)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalculate.TabIndex = 4
        Me.ButtonCalculate.Text = "Calculate"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(112, 172)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClear.TabIndex = 5
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(194, 172)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExit.TabIndex = 6
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'LabelRemainingBalance
        '
        Me.LabelRemainingBalance.AutoSize = True
        Me.LabelRemainingBalance.Location = New System.Drawing.Point(136, 143)
        Me.LabelRemainingBalance.Name = "LabelRemainingBalance"
        Me.LabelRemainingBalance.Size = New System.Drawing.Size(0, 13)
        Me.LabelRemainingBalance.TabIndex = 11
        '
        'ButtonSummary
        '
        Me.ButtonSummary.Location = New System.Drawing.Point(54, 224)
        Me.ButtonSummary.Name = "ButtonSummary"
        Me.ButtonSummary.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSummary.TabIndex = 7
        Me.ButtonSummary.Text = "Summary"
        Me.ButtonSummary.UseVisualStyleBackColor = True
        '
        'ListBoxAccount
        '
        Me.ListBoxAccount.FormattingEnabled = True
        Me.ListBoxAccount.Location = New System.Drawing.Point(323, 24)
        Me.ListBoxAccount.Name = "ListBoxAccount"
        Me.ListBoxAccount.Size = New System.Drawing.Size(416, 446)
        Me.ListBoxAccount.TabIndex = 8
        '
        'Form1
        '
        Me.AcceptButton = Me.ButtonCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonExit
        Me.ClientSize = New System.Drawing.Size(771, 501)
        Me.Controls.Add(Me.ListBoxAccount)
        Me.Controls.Add(Me.ButtonSummary)
        Me.Controls.Add(Me.LabelRemainingBalance)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.LabelBalance)
        Me.Controls.Add(Me.TextBoxTransactionAmt)
        Me.Controls.Add(Me.LabelTransactionAmt)
        Me.Controls.Add(Me.LabelTransactionType)
        Me.Controls.Add(Me.RadioServiceCharge)
        Me.Controls.Add(Me.RadioCheck)
        Me.Controls.Add(Me.RadioDeposit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadioDeposit As RadioButton
    Friend WithEvents RadioCheck As RadioButton
    Friend WithEvents RadioServiceCharge As RadioButton
    Friend WithEvents LabelTransactionType As Label
    Friend WithEvents LabelTransactionAmt As Label
    Friend WithEvents TextBoxTransactionAmt As TextBox
    Friend WithEvents LabelBalance As Label
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents LabelRemainingBalance As Label
    Friend WithEvents ButtonSummary As Button
    Friend WithEvents ListBoxAccount As ListBox
End Class
