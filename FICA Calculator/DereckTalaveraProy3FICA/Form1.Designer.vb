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
        Me.gbPreviousData = New System.Windows.Forms.GroupBox()
        Me.lblPrevWith = New System.Windows.Forms.Label()
        Me.lblPrevIn = New System.Windows.Forms.Label()
        Me.tbPrevWith = New System.Windows.Forms.TextBox()
        Me.tbPrevIn = New System.Windows.Forms.TextBox()
        Me.gbCurrentData = New System.Windows.Forms.GroupBox()
        Me.lblCurrIn = New System.Windows.Forms.Label()
        Me.lblCurrWith = New System.Windows.Forms.Label()
        Me.tbCurrWith = New System.Windows.Forms.TextBox()
        Me.tbCurrIn = New System.Windows.Forms.TextBox()
        Me.gbTotalAmount = New System.Windows.Forms.GroupBox()
        Me.lblTotalIn = New System.Windows.Forms.Label()
        Me.lblTotalWith = New System.Windows.Forms.Label()
        Me.tbTotalIn = New System.Windows.Forms.TextBox()
        Me.tbTotalWith = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.gbPreviousData.SuspendLayout()
        Me.gbCurrentData.SuspendLayout()
        Me.gbTotalAmount.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPreviousData
        '
        Me.gbPreviousData.Controls.Add(Me.lblPrevWith)
        Me.gbPreviousData.Controls.Add(Me.lblPrevIn)
        Me.gbPreviousData.Controls.Add(Me.tbPrevWith)
        Me.gbPreviousData.Controls.Add(Me.tbPrevIn)
        Me.gbPreviousData.Location = New System.Drawing.Point(12, 12)
        Me.gbPreviousData.Name = "gbPreviousData"
        Me.gbPreviousData.Size = New System.Drawing.Size(186, 158)
        Me.gbPreviousData.TabIndex = 0
        Me.gbPreviousData.TabStop = False
        Me.gbPreviousData.Text = "Previous Data"
        '
        'lblPrevWith
        '
        Me.lblPrevWith.AutoSize = True
        Me.lblPrevWith.Location = New System.Drawing.Point(34, 88)
        Me.lblPrevWith.Name = "lblPrevWith"
        Me.lblPrevWith.Size = New System.Drawing.Size(107, 13)
        Me.lblPrevWith.TabIndex = 8
        Me.lblPrevWith.Text = "Previous Withholding"
        '
        'lblPrevIn
        '
        Me.lblPrevIn.AutoSize = True
        Me.lblPrevIn.Location = New System.Drawing.Point(34, 25)
        Me.lblPrevIn.Name = "lblPrevIn"
        Me.lblPrevIn.Size = New System.Drawing.Size(86, 13)
        Me.lblPrevIn.TabIndex = 7
        Me.lblPrevIn.Text = "Previous Income"
        '
        'tbPrevWith
        '
        Me.tbPrevWith.Location = New System.Drawing.Point(37, 104)
        Me.tbPrevWith.Name = "tbPrevWith"
        Me.tbPrevWith.ReadOnly = True
        Me.tbPrevWith.Size = New System.Drawing.Size(100, 20)
        Me.tbPrevWith.TabIndex = 5
        '
        'tbPrevIn
        '
        Me.tbPrevIn.Location = New System.Drawing.Point(37, 41)
        Me.tbPrevIn.Name = "tbPrevIn"
        Me.tbPrevIn.Size = New System.Drawing.Size(100, 20)
        Me.tbPrevIn.TabIndex = 6
        '
        'gbCurrentData
        '
        Me.gbCurrentData.Controls.Add(Me.lblCurrIn)
        Me.gbCurrentData.Controls.Add(Me.lblCurrWith)
        Me.gbCurrentData.Controls.Add(Me.tbCurrWith)
        Me.gbCurrentData.Controls.Add(Me.tbCurrIn)
        Me.gbCurrentData.Location = New System.Drawing.Point(204, 12)
        Me.gbCurrentData.Name = "gbCurrentData"
        Me.gbCurrentData.Size = New System.Drawing.Size(175, 158)
        Me.gbCurrentData.TabIndex = 0
        Me.gbCurrentData.TabStop = False
        Me.gbCurrentData.Text = "Current Data"
        '
        'lblCurrIn
        '
        Me.lblCurrIn.AutoSize = True
        Me.lblCurrIn.Location = New System.Drawing.Point(34, 25)
        Me.lblCurrIn.Name = "lblCurrIn"
        Me.lblCurrIn.Size = New System.Drawing.Size(82, 13)
        Me.lblCurrIn.TabIndex = 9
        Me.lblCurrIn.Text = " Current Income"
        '
        'lblCurrWith
        '
        Me.lblCurrWith.AutoSize = True
        Me.lblCurrWith.Location = New System.Drawing.Point(34, 88)
        Me.lblCurrWith.Name = "lblCurrWith"
        Me.lblCurrWith.Size = New System.Drawing.Size(100, 13)
        Me.lblCurrWith.TabIndex = 10
        Me.lblCurrWith.Text = "Current Withholding"
        '
        'tbCurrWith
        '
        Me.tbCurrWith.Location = New System.Drawing.Point(37, 104)
        Me.tbCurrWith.Name = "tbCurrWith"
        Me.tbCurrWith.ReadOnly = True
        Me.tbCurrWith.Size = New System.Drawing.Size(100, 20)
        Me.tbCurrWith.TabIndex = 3
        '
        'tbCurrIn
        '
        Me.tbCurrIn.Location = New System.Drawing.Point(37, 41)
        Me.tbCurrIn.Name = "tbCurrIn"
        Me.tbCurrIn.Size = New System.Drawing.Size(100, 20)
        Me.tbCurrIn.TabIndex = 4
        '
        'gbTotalAmount
        '
        Me.gbTotalAmount.Controls.Add(Me.lblTotalIn)
        Me.gbTotalAmount.Controls.Add(Me.lblTotalWith)
        Me.gbTotalAmount.Controls.Add(Me.tbTotalIn)
        Me.gbTotalAmount.Controls.Add(Me.tbTotalWith)
        Me.gbTotalAmount.Location = New System.Drawing.Point(385, 12)
        Me.gbTotalAmount.Name = "gbTotalAmount"
        Me.gbTotalAmount.Size = New System.Drawing.Size(195, 158)
        Me.gbTotalAmount.TabIndex = 0
        Me.gbTotalAmount.TabStop = False
        Me.gbTotalAmount.Text = "Total Amounts"
        '
        'lblTotalIn
        '
        Me.lblTotalIn.AutoSize = True
        Me.lblTotalIn.Location = New System.Drawing.Point(44, 25)
        Me.lblTotalIn.Name = "lblTotalIn"
        Me.lblTotalIn.Size = New System.Drawing.Size(69, 13)
        Me.lblTotalIn.TabIndex = 11
        Me.lblTotalIn.Text = "Total Income"
        '
        'lblTotalWith
        '
        Me.lblTotalWith.AutoSize = True
        Me.lblTotalWith.Location = New System.Drawing.Point(44, 88)
        Me.lblTotalWith.Name = "lblTotalWith"
        Me.lblTotalWith.Size = New System.Drawing.Size(90, 13)
        Me.lblTotalWith.TabIndex = 12
        Me.lblTotalWith.Text = "Total Withholding"
        '
        'tbTotalIn
        '
        Me.tbTotalIn.Location = New System.Drawing.Point(47, 41)
        Me.tbTotalIn.Name = "tbTotalIn"
        Me.tbTotalIn.ReadOnly = True
        Me.tbTotalIn.Size = New System.Drawing.Size(100, 20)
        Me.tbTotalIn.TabIndex = 5
        '
        'tbTotalWith
        '
        Me.tbTotalWith.Location = New System.Drawing.Point(47, 104)
        Me.tbTotalWith.Name = "tbTotalWith"
        Me.tbTotalWith.ReadOnly = True
        Me.tbTotalWith.Size = New System.Drawing.Size(100, 20)
        Me.tbTotalWith.TabIndex = 6
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(159, 212)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 23)
        Me.btnCompute.TabIndex = 1
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(341, 212)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 262)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.gbCurrentData)
        Me.Controls.Add(Me.gbTotalAmount)
        Me.Controls.Add(Me.gbPreviousData)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbPreviousData.ResumeLayout(False)
        Me.gbPreviousData.PerformLayout()
        Me.gbCurrentData.ResumeLayout(False)
        Me.gbCurrentData.PerformLayout()
        Me.gbTotalAmount.ResumeLayout(False)
        Me.gbTotalAmount.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbPreviousData As System.Windows.Forms.GroupBox
    Friend WithEvents gbCurrentData As System.Windows.Forms.GroupBox
    Friend WithEvents gbTotalAmount As System.Windows.Forms.GroupBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents tbPrevWith As System.Windows.Forms.TextBox
    Friend WithEvents tbPrevIn As System.Windows.Forms.TextBox
    Friend WithEvents tbCurrWith As System.Windows.Forms.TextBox
    Friend WithEvents tbCurrIn As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalIn As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalWith As System.Windows.Forms.TextBox
    Friend WithEvents lblPrevWith As System.Windows.Forms.Label
    Friend WithEvents lblPrevIn As System.Windows.Forms.Label
    Friend WithEvents lblCurrIn As System.Windows.Forms.Label
    Friend WithEvents lblCurrWith As System.Windows.Forms.Label
    Friend WithEvents lblTotalIn As System.Windows.Forms.Label
    Friend WithEvents lblTotalWith As System.Windows.Forms.Label

End Class
