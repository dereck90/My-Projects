<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTuitionCalc
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
        Me.gbResidence = New System.Windows.Forms.GroupBox()
        Me.rbInState = New System.Windows.Forms.RadioButton()
        Me.rbOutState = New System.Windows.Forms.RadioButton()
        Me.rbInternational = New System.Windows.Forms.RadioButton()
        Me.lblHoursTaken = New System.Windows.Forms.Label()
        Me.lblYourTuition = New System.Windows.Forms.Label()
        Me.tbHoursTaken = New System.Windows.Forms.TextBox()
        Me.tbYourTuition = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.gbResidence.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbResidence
        '
        Me.gbResidence.Controls.Add(Me.rbInState)
        Me.gbResidence.Controls.Add(Me.rbOutState)
        Me.gbResidence.Controls.Add(Me.rbInternational)
        Me.gbResidence.Location = New System.Drawing.Point(12, 30)
        Me.gbResidence.Name = "gbResidence"
        Me.gbResidence.Size = New System.Drawing.Size(180, 129)
        Me.gbResidence.TabIndex = 0
        Me.gbResidence.TabStop = False
        Me.gbResidence.Text = "Residence Status"
        '
        'rbInState
        '
        Me.rbInState.AutoSize = True
        Me.rbInState.Location = New System.Drawing.Point(38, 24)
        Me.rbInState.Name = "rbInState"
        Me.rbInState.Size = New System.Drawing.Size(62, 17)
        Me.rbInState.TabIndex = 1
        Me.rbInState.TabStop = True
        Me.rbInState.Text = "In State"
        Me.rbInState.UseVisualStyleBackColor = True
        '
        'rbOutState
        '
        Me.rbOutState.AutoSize = True
        Me.rbOutState.Location = New System.Drawing.Point(38, 58)
        Me.rbOutState.Name = "rbOutState"
        Me.rbOutState.Size = New System.Drawing.Size(82, 17)
        Me.rbOutState.TabIndex = 2
        Me.rbOutState.TabStop = True
        Me.rbOutState.Text = "Out of State"
        Me.rbOutState.UseVisualStyleBackColor = True
        '
        'rbInternational
        '
        Me.rbInternational.AutoSize = True
        Me.rbInternational.Location = New System.Drawing.Point(38, 93)
        Me.rbInternational.Name = "rbInternational"
        Me.rbInternational.Size = New System.Drawing.Size(83, 17)
        Me.rbInternational.TabIndex = 3
        Me.rbInternational.TabStop = True
        Me.rbInternational.Text = "International"
        Me.rbInternational.UseVisualStyleBackColor = True
        '
        'lblHoursTaken
        '
        Me.lblHoursTaken.AutoSize = True
        Me.lblHoursTaken.Location = New System.Drawing.Point(206, 49)
        Me.lblHoursTaken.Name = "lblHoursTaken"
        Me.lblHoursTaken.Size = New System.Drawing.Size(69, 13)
        Me.lblHoursTaken.TabIndex = 1
        Me.lblHoursTaken.Text = "Hours Taken"
        '
        'lblYourTuition
        '
        Me.lblYourTuition.AutoSize = True
        Me.lblYourTuition.Location = New System.Drawing.Point(211, 83)
        Me.lblYourTuition.Name = "lblYourTuition"
        Me.lblYourTuition.Size = New System.Drawing.Size(64, 13)
        Me.lblYourTuition.TabIndex = 2
        Me.lblYourTuition.Text = "Your Tuition"
        '
        'tbHoursTaken
        '
        Me.tbHoursTaken.Location = New System.Drawing.Point(281, 46)
        Me.tbHoursTaken.Name = "tbHoursTaken"
        Me.tbHoursTaken.Size = New System.Drawing.Size(100, 20)
        Me.tbHoursTaken.TabIndex = 3
        '
        'tbYourTuition
        '
        Me.tbYourTuition.Location = New System.Drawing.Point(281, 80)
        Me.tbYourTuition.Name = "tbYourTuition"
        Me.tbYourTuition.Size = New System.Drawing.Size(100, 20)
        Me.tbYourTuition.TabIndex = 4
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(281, 136)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(100, 23)
        Me.btnCompute.TabIndex = 5
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'frmTuitionCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 197)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.tbYourTuition)
        Me.Controls.Add(Me.tbHoursTaken)
        Me.Controls.Add(Me.lblYourTuition)
        Me.Controls.Add(Me.lblHoursTaken)
        Me.Controls.Add(Me.gbResidence)
        Me.Name = "frmTuitionCalc"
        Me.Text = "Tuition Calculation"
        Me.gbResidence.ResumeLayout(False)
        Me.gbResidence.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbResidence As System.Windows.Forms.GroupBox
    Friend WithEvents rbInState As System.Windows.Forms.RadioButton
    Friend WithEvents rbOutState As System.Windows.Forms.RadioButton
    Friend WithEvents rbInternational As System.Windows.Forms.RadioButton
    Friend WithEvents lblHoursTaken As System.Windows.Forms.Label
    Friend WithEvents lblYourTuition As System.Windows.Forms.Label
    Friend WithEvents tbHoursTaken As System.Windows.Forms.TextBox
    Friend WithEvents tbYourTuition As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button

End Class
