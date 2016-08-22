<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContactInf
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
        Me.gbContactInfo = New System.Windows.Forms.GroupBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.mtbPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnErase = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.cdlOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.cdlSaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.gbContactInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbContactInfo
        '
        Me.gbContactInfo.Controls.Add(Me.lblName)
        Me.gbContactInfo.Controls.Add(Me.lblPhoneNumber)
        Me.gbContactInfo.Controls.Add(Me.tbName)
        Me.gbContactInfo.Controls.Add(Me.mtbPhoneNumber)
        Me.gbContactInfo.Location = New System.Drawing.Point(12, 12)
        Me.gbContactInfo.Name = "gbContactInfo"
        Me.gbContactInfo.Size = New System.Drawing.Size(304, 166)
        Me.gbContactInfo.TabIndex = 0
        Me.gbContactInfo.TabStop = False
        Me.gbContactInfo.Text = "Contact Information"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(15, 109)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(89, 13)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name (Last, First)"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(15, 45)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(78, 13)
        Me.lblPhoneNumber.TabIndex = 3
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(110, 106)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(166, 20)
        Me.tbName.TabIndex = 1
        '
        'mtbPhoneNumber
        '
        Me.mtbPhoneNumber.Location = New System.Drawing.Point(110, 42)
        Me.mtbPhoneNumber.Mask = "(999) 000-0000"
        Me.mtbPhoneNumber.Name = "mtbPhoneNumber"
        Me.mtbPhoneNumber.Size = New System.Drawing.Size(166, 20)
        Me.mtbPhoneNumber.TabIndex = 2
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(12, 206)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(66, 23)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(84, 206)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(66, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnErase
        '
        Me.btnErase.Location = New System.Drawing.Point(178, 206)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(66, 23)
        Me.btnErase.TabIndex = 3
        Me.btnErase.Text = "Erase"
        Me.btnErase.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(250, 206)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(66, 23)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'cdlOpenFile
        '
        Me.cdlOpenFile.FileName = "ContactInfo"
        Me.cdlOpenFile.Filter = "Text Files (*.txt)|*.txt"
        Me.cdlOpenFile.Title = "Where is the archive?"
        '
        'cdlSaveFile
        '
        Me.cdlSaveFile.FileName = "ContactInfo"
        Me.cdlSaveFile.Filter = "Text Files (*.txt)|*.txt"
        Me.cdlSaveFile.Title = "Where do you want to save?"
        '
        'frmContactInf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 241)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnErase)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.gbContactInfo)
        Me.Name = "frmContactInf"
        Me.Text = "Contact Information Update"
        Me.gbContactInfo.ResumeLayout(False)
        Me.gbContactInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbContactInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents mtbPhoneNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnErase As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents cdlOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cdlSaveFile As System.Windows.Forms.SaveFileDialog

End Class
