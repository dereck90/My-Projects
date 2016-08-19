<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tbctrlTool = New System.Windows.Forms.TabControl()
        Me.tbpagAdd = New System.Windows.Forms.TabPage()
        Me.mtxtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.tbpagSearch = New System.Windows.Forms.TabPage()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClrFields = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.mtxtSPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtSEmail = New System.Windows.Forms.TextBox()
        Me.txtSCountry = New System.Windows.Forms.TextBox()
        Me.txtSName = New System.Windows.Forms.TextBox()
        Me.lblSEmail = New System.Windows.Forms.Label()
        Me.lblSPhone = New System.Windows.Forms.Label()
        Me.lblSCountry = New System.Windows.Forms.Label()
        Me.lblSName = New System.Windows.Forms.Label()
        Me.mtxtFindP = New System.Windows.Forms.MaskedTextBox()
        Me.rbtnFindPhone = New System.Windows.Forms.RadioButton()
        Me.txtFindI = New System.Windows.Forms.TextBox()
        Me.txtFindC = New System.Windows.Forms.TextBox()
        Me.rbtnFindC = New System.Windows.Forms.RadioButton()
        Me.rbtnFindI = New System.Windows.Forms.RadioButton()
        Me.DirectoryTableAdapter1 = New HealthCare_Doctor_Directory.HealthCare_Doctor_DirectoryDataSetTableAdapters.DirectoryTableAdapter()
        Me.HealthCare_Doctor_DirectoryDataSet1 = New HealthCare_Doctor_Directory.HealthCare_Doctor_DirectoryDataSet()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.tbctrlTool.SuspendLayout()
        Me.tbpagAdd.SuspendLayout()
        Me.tbpagSearch.SuspendLayout()
        CType(Me.HealthCare_Doctor_DirectoryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbctrlTool
        '
        Me.tbctrlTool.Controls.Add(Me.tbpagAdd)
        Me.tbctrlTool.Controls.Add(Me.tbpagSearch)
        Me.tbctrlTool.Location = New System.Drawing.Point(3, 4)
        Me.tbctrlTool.Name = "tbctrlTool"
        Me.tbctrlTool.SelectedIndex = 0
        Me.tbctrlTool.Size = New System.Drawing.Size(532, 329)
        Me.tbctrlTool.TabIndex = 0
        '
        'tbpagAdd
        '
        Me.tbpagAdd.Controls.Add(Me.mtxtPhone)
        Me.tbpagAdd.Controls.Add(Me.txtEmail)
        Me.tbpagAdd.Controls.Add(Me.txtCountry)
        Me.tbpagAdd.Controls.Add(Me.txtName)
        Me.tbpagAdd.Controls.Add(Me.btnClr)
        Me.tbpagAdd.Controls.Add(Me.btnSubmit)
        Me.tbpagAdd.Controls.Add(Me.lblEmail)
        Me.tbpagAdd.Controls.Add(Me.lblPhone)
        Me.tbpagAdd.Controls.Add(Me.lblCountry)
        Me.tbpagAdd.Controls.Add(Me.lblName)
        Me.tbpagAdd.Location = New System.Drawing.Point(4, 22)
        Me.tbpagAdd.Name = "tbpagAdd"
        Me.tbpagAdd.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpagAdd.Size = New System.Drawing.Size(524, 303)
        Me.tbpagAdd.TabIndex = 0
        Me.tbpagAdd.Text = "Add Info"
        Me.tbpagAdd.UseVisualStyleBackColor = True
        '
        'mtxtPhone
        '
        Me.mtxtPhone.Location = New System.Drawing.Point(145, 120)
        Me.mtxtPhone.Mask = "(999) 000-0000"
        Me.mtxtPhone.Name = "mtxtPhone"
        Me.mtxtPhone.Size = New System.Drawing.Size(80, 20)
        Me.mtxtPhone.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(145, 160)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(219, 20)
        Me.txtEmail.TabIndex = 9
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(145, 80)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(219, 20)
        Me.txtCountry.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(145, 40)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(219, 20)
        Me.txtName.TabIndex = 6
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(370, 228)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(75, 23)
        Me.btnClr.TabIndex = 5
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(64, 228)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(19, 160)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(74, 13)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Doctor's Email"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(19, 120)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(120, 13)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Doctor's Phone Number"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(19, 80)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(85, 13)
        Me.lblCountry.TabIndex = 1
        Me.lblCountry.Text = "Doctor's Country"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(19, 40)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(77, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Doctor's Name"
        '
        'tbpagSearch
        '
        Me.tbpagSearch.Controls.Add(Me.btnUpdate)
        Me.tbpagSearch.Controls.Add(Me.btnDelete)
        Me.tbpagSearch.Controls.Add(Me.btnClrFields)
        Me.tbpagSearch.Controls.Add(Me.btnSearch)
        Me.tbpagSearch.Controls.Add(Me.mtxtSPhone)
        Me.tbpagSearch.Controls.Add(Me.txtSEmail)
        Me.tbpagSearch.Controls.Add(Me.txtSCountry)
        Me.tbpagSearch.Controls.Add(Me.txtSName)
        Me.tbpagSearch.Controls.Add(Me.lblSEmail)
        Me.tbpagSearch.Controls.Add(Me.lblSPhone)
        Me.tbpagSearch.Controls.Add(Me.lblSCountry)
        Me.tbpagSearch.Controls.Add(Me.lblSName)
        Me.tbpagSearch.Controls.Add(Me.mtxtFindP)
        Me.tbpagSearch.Controls.Add(Me.rbtnFindPhone)
        Me.tbpagSearch.Controls.Add(Me.txtFindI)
        Me.tbpagSearch.Controls.Add(Me.txtFindC)
        Me.tbpagSearch.Controls.Add(Me.rbtnFindC)
        Me.tbpagSearch.Controls.Add(Me.rbtnFindI)
        Me.tbpagSearch.Location = New System.Drawing.Point(4, 22)
        Me.tbpagSearch.Name = "tbpagSearch"
        Me.tbpagSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpagSearch.Size = New System.Drawing.Size(524, 303)
        Me.tbpagSearch.TabIndex = 1
        Me.tbpagSearch.Text = "Search"
        Me.tbpagSearch.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(423, 236)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 23)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClrFields
        '
        Me.btnClrFields.Location = New System.Drawing.Point(342, 236)
        Me.btnClrFields.Name = "btnClrFields"
        Me.btnClrFields.Size = New System.Drawing.Size(75, 23)
        Me.btnClrFields.TabIndex = 20
        Me.btnClrFields.Text = "Clear"
        Me.btnClrFields.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(167, 236)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 19
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'mtxtSPhone
        '
        Me.mtxtSPhone.Location = New System.Drawing.Point(290, 129)
        Me.mtxtSPhone.Mask = "(999) 000-0000"
        Me.mtxtSPhone.Name = "mtxtSPhone"
        Me.mtxtSPhone.Size = New System.Drawing.Size(80, 20)
        Me.mtxtSPhone.TabIndex = 18
        '
        'txtSEmail
        '
        Me.txtSEmail.Location = New System.Drawing.Point(290, 169)
        Me.txtSEmail.Name = "txtSEmail"
        Me.txtSEmail.Size = New System.Drawing.Size(219, 20)
        Me.txtSEmail.TabIndex = 17
        '
        'txtSCountry
        '
        Me.txtSCountry.Location = New System.Drawing.Point(290, 89)
        Me.txtSCountry.Name = "txtSCountry"
        Me.txtSCountry.Size = New System.Drawing.Size(219, 20)
        Me.txtSCountry.TabIndex = 16
        '
        'txtSName
        '
        Me.txtSName.Location = New System.Drawing.Point(290, 49)
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(219, 20)
        Me.txtSName.TabIndex = 15
        '
        'lblSEmail
        '
        Me.lblSEmail.AutoSize = True
        Me.lblSEmail.Location = New System.Drawing.Point(164, 169)
        Me.lblSEmail.Name = "lblSEmail"
        Me.lblSEmail.Size = New System.Drawing.Size(74, 13)
        Me.lblSEmail.TabIndex = 14
        Me.lblSEmail.Text = "Doctor's Email"
        '
        'lblSPhone
        '
        Me.lblSPhone.AutoSize = True
        Me.lblSPhone.Location = New System.Drawing.Point(164, 129)
        Me.lblSPhone.Name = "lblSPhone"
        Me.lblSPhone.Size = New System.Drawing.Size(120, 13)
        Me.lblSPhone.TabIndex = 13
        Me.lblSPhone.Text = "Doctor's Phone Number"
        '
        'lblSCountry
        '
        Me.lblSCountry.AutoSize = True
        Me.lblSCountry.Location = New System.Drawing.Point(164, 89)
        Me.lblSCountry.Name = "lblSCountry"
        Me.lblSCountry.Size = New System.Drawing.Size(85, 13)
        Me.lblSCountry.TabIndex = 12
        Me.lblSCountry.Text = "Doctor's Country"
        '
        'lblSName
        '
        Me.lblSName.AutoSize = True
        Me.lblSName.Location = New System.Drawing.Point(164, 49)
        Me.lblSName.Name = "lblSName"
        Me.lblSName.Size = New System.Drawing.Size(77, 13)
        Me.lblSName.TabIndex = 11
        Me.lblSName.Text = "Doctor's Name"
        '
        'mtxtFindP
        '
        Me.mtxtFindP.Location = New System.Drawing.Point(6, 236)
        Me.mtxtFindP.Mask = "(999) 000-0000"
        Me.mtxtFindP.Name = "mtxtFindP"
        Me.mtxtFindP.Size = New System.Drawing.Size(133, 20)
        Me.mtxtFindP.TabIndex = 6
        '
        'rbtnFindPhone
        '
        Me.rbtnFindPhone.AutoSize = True
        Me.rbtnFindPhone.Location = New System.Drawing.Point(6, 204)
        Me.rbtnFindPhone.Name = "rbtnFindPhone"
        Me.rbtnFindPhone.Size = New System.Drawing.Size(134, 17)
        Me.rbtnFindPhone.TabIndex = 5
        Me.rbtnFindPhone.Text = "Find By Phone Number"
        Me.rbtnFindPhone.UseVisualStyleBackColor = True
        '
        'txtFindI
        '
        Me.txtFindI.Location = New System.Drawing.Point(6, 143)
        Me.txtFindI.Name = "txtFindI"
        Me.txtFindI.Size = New System.Drawing.Size(133, 20)
        Me.txtFindI.TabIndex = 4
        '
        'txtFindC
        '
        Me.txtFindC.Location = New System.Drawing.Point(6, 49)
        Me.txtFindC.Name = "txtFindC"
        Me.txtFindC.Size = New System.Drawing.Size(136, 20)
        Me.txtFindC.TabIndex = 3
        '
        'rbtnFindC
        '
        Me.rbtnFindC.AutoSize = True
        Me.rbtnFindC.Checked = True
        Me.rbtnFindC.Location = New System.Drawing.Point(6, 17)
        Me.rbtnFindC.Name = "rbtnFindC"
        Me.rbtnFindC.Size = New System.Drawing.Size(99, 17)
        Me.rbtnFindC.TabIndex = 1
        Me.rbtnFindC.TabStop = True
        Me.rbtnFindC.Text = "Find By Country"
        Me.rbtnFindC.UseVisualStyleBackColor = True
        '
        'rbtnFindI
        '
        Me.rbtnFindI.AutoSize = True
        Me.rbtnFindI.Location = New System.Drawing.Point(6, 109)
        Me.rbtnFindI.Name = "rbtnFindI"
        Me.rbtnFindI.Size = New System.Drawing.Size(74, 17)
        Me.rbtnFindI.TabIndex = 2
        Me.rbtnFindI.Text = "Find By ID"
        Me.rbtnFindI.UseVisualStyleBackColor = True
        '
        'DirectoryTableAdapter1
        '
        Me.DirectoryTableAdapter1.ClearBeforeFill = True
        '
        'HealthCare_Doctor_DirectoryDataSet1
        '
        Me.HealthCare_Doctor_DirectoryDataSet1.DataSetName = "HealthCare_Doctor_DirectoryDataSet"
        Me.HealthCare_Doctor_DirectoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(248, 236)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 22
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 336)
        Me.Controls.Add(Me.tbctrlTool)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HealthCare Doctor Directory"
        Me.tbctrlTool.ResumeLayout(False)
        Me.tbpagAdd.ResumeLayout(False)
        Me.tbpagAdd.PerformLayout()
        Me.tbpagSearch.ResumeLayout(False)
        Me.tbpagSearch.PerformLayout()
        CType(Me.HealthCare_Doctor_DirectoryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbctrlTool As System.Windows.Forms.TabControl
    Friend WithEvents tbpagAdd As System.Windows.Forms.TabPage
    Friend WithEvents tbpagSearch As System.Windows.Forms.TabPage
    Friend WithEvents mtxtPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnClr As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents DirectoryTableAdapter1 As HealthCare_Doctor_Directory.HealthCare_Doctor_DirectoryDataSetTableAdapters.DirectoryTableAdapter
    Friend WithEvents HealthCare_Doctor_DirectoryDataSet1 As HealthCare_Doctor_Directory.HealthCare_Doctor_DirectoryDataSet
    Friend WithEvents mtxtFindP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rbtnFindPhone As System.Windows.Forms.RadioButton
    Friend WithEvents txtFindI As System.Windows.Forms.TextBox
    Friend WithEvents txtFindC As System.Windows.Forms.TextBox
    Friend WithEvents rbtnFindC As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnFindI As System.Windows.Forms.RadioButton
    Friend WithEvents mtxtSPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtSCountry As System.Windows.Forms.TextBox
    Friend WithEvents txtSName As System.Windows.Forms.TextBox
    Friend WithEvents lblSEmail As System.Windows.Forms.Label
    Friend WithEvents lblSPhone As System.Windows.Forms.Label
    Friend WithEvents lblSCountry As System.Windows.Forms.Label
    Friend WithEvents lblSName As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClrFields As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button

End Class
