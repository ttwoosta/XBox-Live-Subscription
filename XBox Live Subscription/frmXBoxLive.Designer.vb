<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXBoxLive
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
        Me.picXBoxLive = New System.Windows.Forms.PictureBox()
        Me.lblNameLabel = New System.Windows.Forms.Label()
        Me.lblNumberOfMonthsLabel = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtNumberOfMonths = New System.Windows.Forms.TextBox()
        Me.rdaSingleSubcription = New System.Windows.Forms.RadioButton()
        Me.grpMembershipTypes = New System.Windows.Forms.GroupBox()
        Me.rdaFamilySubscription = New System.Windows.Forms.RadioButton()
        Me.rdaDeveloperSubscription = New System.Windows.Forms.RadioButton()
        Me.lblSubscriptionCostLabel = New System.Windows.Forms.Label()
        Me.lblSubscriptionCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picXBoxLive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMembershipTypes.SuspendLayout()
        Me.SuspendLayout()
        '
        'picXBoxLive
        '
        Me.picXBoxLive.Image = Global.XBox_Live_Subscription.My.Resources.Resources.Xbox_live_logo
        Me.picXBoxLive.Location = New System.Drawing.Point(1, 20)
        Me.picXBoxLive.Name = "picXBoxLive"
        Me.picXBoxLive.Size = New System.Drawing.Size(431, 212)
        Me.picXBoxLive.TabIndex = 0
        Me.picXBoxLive.TabStop = False
        '
        'lblNameLabel
        '
        Me.lblNameLabel.AutoSize = True
        Me.lblNameLabel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameLabel.Location = New System.Drawing.Point(63, 271)
        Me.lblNameLabel.Name = "lblNameLabel"
        Me.lblNameLabel.Size = New System.Drawing.Size(95, 18)
        Me.lblNameLabel.TabIndex = 1
        Me.lblNameLabel.Text = "Full name:"
        '
        'lblNumberOfMonthsLabel
        '
        Me.lblNumberOfMonthsLabel.AutoSize = True
        Me.lblNumberOfMonthsLabel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfMonthsLabel.Location = New System.Drawing.Point(63, 315)
        Me.lblNumberOfMonthsLabel.Name = "lblNumberOfMonthsLabel"
        Me.lblNumberOfMonthsLabel.Size = New System.Drawing.Size(167, 18)
        Me.lblNumberOfMonthsLabel.TabIndex = 2
        Me.lblNumberOfMonthsLabel.Text = "Number of months:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(164, 268)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(206, 27)
        Me.txtName.TabIndex = 3
        '
        'txtNumberOfMonths
        '
        Me.txtNumberOfMonths.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfMonths.Location = New System.Drawing.Point(236, 312)
        Me.txtNumberOfMonths.Name = "txtNumberOfMonths"
        Me.txtNumberOfMonths.Size = New System.Drawing.Size(134, 27)
        Me.txtNumberOfMonths.TabIndex = 4
        '
        'rdaSingleSubcription
        '
        Me.rdaSingleSubcription.AutoSize = True
        Me.rdaSingleSubcription.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdaSingleSubcription.Location = New System.Drawing.Point(19, 36)
        Me.rdaSingleSubcription.Name = "rdaSingleSubcription"
        Me.rdaSingleSubcription.Size = New System.Drawing.Size(182, 22)
        Me.rdaSingleSubcription.TabIndex = 5
        Me.rdaSingleSubcription.TabStop = True
        Me.rdaSingleSubcription.Text = "Single Subscription"
        Me.rdaSingleSubcription.UseVisualStyleBackColor = True
        '
        'grpMembershipTypes
        '
        Me.grpMembershipTypes.BackColor = System.Drawing.Color.White
        Me.grpMembershipTypes.Controls.Add(Me.rdaDeveloperSubscription)
        Me.grpMembershipTypes.Controls.Add(Me.rdaFamilySubscription)
        Me.grpMembershipTypes.Controls.Add(Me.rdaSingleSubcription)
        Me.grpMembershipTypes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMembershipTypes.Location = New System.Drawing.Point(24, 385)
        Me.grpMembershipTypes.Name = "grpMembershipTypes"
        Me.grpMembershipTypes.Size = New System.Drawing.Size(385, 155)
        Me.grpMembershipTypes.TabIndex = 6
        Me.grpMembershipTypes.TabStop = False
        Me.grpMembershipTypes.Text = "Select membership types:"
        '
        'rdaFamilySubscription
        '
        Me.rdaFamilySubscription.AutoSize = True
        Me.rdaFamilySubscription.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdaFamilySubscription.Location = New System.Drawing.Point(17, 75)
        Me.rdaFamilySubscription.Name = "rdaFamilySubscription"
        Me.rdaFamilySubscription.Size = New System.Drawing.Size(344, 22)
        Me.rdaFamilySubscription.TabIndex = 6
        Me.rdaFamilySubscription.TabStop = True
        Me.rdaFamilySubscription.Text = "Family Subscription (up to 4 members)"
        Me.rdaFamilySubscription.UseVisualStyleBackColor = True
        '
        'rdaDeveloperSubscription
        '
        Me.rdaDeveloperSubscription.AutoSize = True
        Me.rdaDeveloperSubscription.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdaDeveloperSubscription.Location = New System.Drawing.Point(17, 114)
        Me.rdaDeveloperSubscription.Name = "rdaDeveloperSubscription"
        Me.rdaDeveloperSubscription.Size = New System.Drawing.Size(261, 22)
        Me.rdaDeveloperSubscription.TabIndex = 7
        Me.rdaDeveloperSubscription.TabStop = True
        Me.rdaDeveloperSubscription.Text = "XBox Developer Subscription"
        Me.rdaDeveloperSubscription.UseVisualStyleBackColor = True
        '
        'lblSubscriptionCostLabel
        '
        Me.lblSubscriptionCostLabel.AutoSize = True
        Me.lblSubscriptionCostLabel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubscriptionCostLabel.Location = New System.Drawing.Point(87, 579)
        Me.lblSubscriptionCostLabel.Name = "lblSubscriptionCostLabel"
        Me.lblSubscriptionCostLabel.Size = New System.Drawing.Size(155, 18)
        Me.lblSubscriptionCostLabel.TabIndex = 7
        Me.lblSubscriptionCostLabel.Text = "Subscription cost:"
        '
        'lblSubscriptionCost
        '
        Me.lblSubscriptionCost.AutoSize = True
        Me.lblSubscriptionCost.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubscriptionCost.Location = New System.Drawing.Point(272, 579)
        Me.lblSubscriptionCost.Name = "lblSubscriptionCost"
        Me.lblSubscriptionCost.Size = New System.Drawing.Size(73, 18)
        Me.lblSubscriptionCost.TabIndex = 8
        Me.lblSubscriptionCost.Text = "$X,XXX"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Orange
        Me.btnCalculate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(82, 630)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(113, 26)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Orange
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(238, 630)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 26)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmXBoxLive
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(432, 680)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblSubscriptionCost)
        Me.Controls.Add(Me.lblSubscriptionCostLabel)
        Me.Controls.Add(Me.txtNumberOfMonths)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblNumberOfMonthsLabel)
        Me.Controls.Add(Me.lblNameLabel)
        Me.Controls.Add(Me.picXBoxLive)
        Me.Controls.Add(Me.grpMembershipTypes)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(448, 719)
        Me.MinimumSize = New System.Drawing.Size(448, 719)
        Me.Name = "frmXBoxLive"
        Me.Text = "XBox Live Subscription"
        CType(Me.picXBoxLive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMembershipTypes.ResumeLayout(False)
        Me.grpMembershipTypes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picXBoxLive As PictureBox
    Friend WithEvents lblNameLabel As Label
    Friend WithEvents lblNumberOfMonthsLabel As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNumberOfMonths As TextBox
    Friend WithEvents rdaSingleSubcription As RadioButton
    Friend WithEvents grpMembershipTypes As GroupBox
    Friend WithEvents rdaDeveloperSubscription As RadioButton
    Friend WithEvents rdaFamilySubscription As RadioButton
    Friend WithEvents lblSubscriptionCostLabel As Label
    Friend WithEvents lblSubscriptionCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
