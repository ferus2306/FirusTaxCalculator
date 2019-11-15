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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.socialSecurityLabel = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.hourlyPaylLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.hourlyPayListBox2 = New System.Windows.Forms.ListBox()
        Me.stateListBox2 = New System.Windows.Forms.ListBox()
        Me.ficaListBox2 = New System.Windows.Forms.ListBox()
        Me.socialSecurityListBox2 = New System.Windows.Forms.ListBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.totalPayAfterTaxLabel = New System.Windows.Forms.Label()
        Me.ficaLabel = New System.Windows.Forms.Label()
        Me.stateLabel = New System.Windows.Forms.Label()
        Me.checkBeforeTaxLabel = New System.Windows.Forms.Label()
        Me.loadButton2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totalHoursTextBox = New System.Windows.Forms.TextBox()
        Me.employeeListBox2 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.modifyButton = New System.Windows.Forms.Button()
        Me.stateTextBox = New System.Windows.Forms.TextBox()
        Me.ficaTextBox = New System.Windows.Forms.TextBox()
        Me.socialSecurityTextBox = New System.Windows.Forms.TextBox()
        Me.hourlyPayTextBox = New System.Windows.Forms.TextBox()
        Me.stateListBox = New System.Windows.Forms.ListBox()
        Me.ficaListBox = New System.Windows.Forms.ListBox()
        Me.socialSecurityListBox = New System.Windows.Forms.ListBox()
        Me.hourlyPayListBox = New System.Windows.Forms.ListBox()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.loadButton = New System.Windows.Forms.Button()
        Me.employeeListBox = New System.Windows.Forms.ListBox()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.employeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(2, 3)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(797, 448)
        Me.TabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightGray
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.socialSecurityLabel)
        Me.TabPage1.Controls.Add(Me.Label)
        Me.TabPage1.Controls.Add(Me.hourlyPaylLabel)
        Me.TabPage1.Controls.Add(Me.nameLabel)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.hourlyPayListBox2)
        Me.TabPage1.Controls.Add(Me.stateListBox2)
        Me.TabPage1.Controls.Add(Me.ficaListBox2)
        Me.TabPage1.Controls.Add(Me.socialSecurityListBox2)
        Me.TabPage1.Controls.Add(Me.DateTimePicker2)
        Me.TabPage1.Controls.Add(Me.totalPayAfterTaxLabel)
        Me.TabPage1.Controls.Add(Me.ficaLabel)
        Me.TabPage1.Controls.Add(Me.stateLabel)
        Me.TabPage1.Controls.Add(Me.checkBeforeTaxLabel)
        Me.TabPage1.Controls.Add(Me.loadButton2)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.totalHoursTextBox)
        Me.TabPage1.Controls.Add(Me.employeeListBox2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(789, 419)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tax Calculator"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(295, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 16)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "LiveToInspire production 2019"
        '
        'socialSecurityLabel
        '
        Me.socialSecurityLabel.AutoSize = True
        Me.socialSecurityLabel.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.socialSecurityLabel.Location = New System.Drawing.Point(636, 255)
        Me.socialSecurityLabel.Name = "socialSecurityLabel"
        Me.socialSecurityLabel.Size = New System.Drawing.Size(28, 21)
        Me.socialSecurityLabel.TabIndex = 29
        Me.socialSecurityLabel.Text = "..."
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(428, 250)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(126, 21)
        Me.Label.TabIndex = 28
        Me.Label.Text = "Social Security:"
        '
        'hourlyPaylLabel
        '
        Me.hourlyPaylLabel.AutoSize = True
        Me.hourlyPaylLabel.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hourlyPaylLabel.Location = New System.Drawing.Point(294, 208)
        Me.hourlyPaylLabel.Name = "hourlyPaylLabel"
        Me.hourlyPaylLabel.Size = New System.Drawing.Size(28, 21)
        Me.hourlyPaylLabel.TabIndex = 27
        Me.hourlyPaylLabel.Text = "..."
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(294, 187)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(28, 21)
        Me.nameLabel.TabIndex = 26
        Me.nameLabel.Text = "..."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(184, 210)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 21)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Hourly pay"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(184, 189)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 21)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Name"
        '
        'hourlyPayListBox2
        '
        Me.hourlyPayListBox2.FormattingEnabled = True
        Me.hourlyPayListBox2.ItemHeight = 16
        Me.hourlyPayListBox2.Location = New System.Drawing.Point(270, 321)
        Me.hourlyPayListBox2.Name = "hourlyPayListBox2"
        Me.hourlyPayListBox2.Size = New System.Drawing.Size(105, 84)
        Me.hourlyPayListBox2.TabIndex = 23
        Me.hourlyPayListBox2.Visible = False
        '
        'stateListBox2
        '
        Me.stateListBox2.FormattingEnabled = True
        Me.stateListBox2.ItemHeight = 16
        Me.stateListBox2.Location = New System.Drawing.Point(603, 321)
        Me.stateListBox2.Name = "stateListBox2"
        Me.stateListBox2.Size = New System.Drawing.Size(105, 84)
        Me.stateListBox2.TabIndex = 22
        Me.stateListBox2.Visible = False
        '
        'ficaListBox2
        '
        Me.ficaListBox2.FormattingEnabled = True
        Me.ficaListBox2.ItemHeight = 16
        Me.ficaListBox2.Location = New System.Drawing.Point(492, 321)
        Me.ficaListBox2.Name = "ficaListBox2"
        Me.ficaListBox2.Size = New System.Drawing.Size(105, 84)
        Me.ficaListBox2.TabIndex = 21
        Me.ficaListBox2.Visible = False
        '
        'socialSecurityListBox2
        '
        Me.socialSecurityListBox2.FormattingEnabled = True
        Me.socialSecurityListBox2.ItemHeight = 16
        Me.socialSecurityListBox2.Location = New System.Drawing.Point(381, 321)
        Me.socialSecurityListBox2.Name = "socialSecurityListBox2"
        Me.socialSecurityListBox2.Size = New System.Drawing.Size(105, 84)
        Me.socialSecurityListBox2.TabIndex = 20
        Me.socialSecurityListBox2.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(446, 127)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 25)
        Me.DateTimePicker2.TabIndex = 19
        '
        'totalPayAfterTaxLabel
        '
        Me.totalPayAfterTaxLabel.AutoSize = True
        Me.totalPayAfterTaxLabel.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPayAfterTaxLabel.Location = New System.Drawing.Point(636, 276)
        Me.totalPayAfterTaxLabel.Name = "totalPayAfterTaxLabel"
        Me.totalPayAfterTaxLabel.Size = New System.Drawing.Size(28, 21)
        Me.totalPayAfterTaxLabel.TabIndex = 18
        Me.totalPayAfterTaxLabel.Text = "..."
        '
        'ficaLabel
        '
        Me.ficaLabel.AutoSize = True
        Me.ficaLabel.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficaLabel.Location = New System.Drawing.Point(636, 231)
        Me.ficaLabel.Name = "ficaLabel"
        Me.ficaLabel.Size = New System.Drawing.Size(28, 21)
        Me.ficaLabel.TabIndex = 17
        Me.ficaLabel.Text = "..."
        '
        'stateLabel
        '
        Me.stateLabel.AutoSize = True
        Me.stateLabel.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stateLabel.Location = New System.Drawing.Point(636, 208)
        Me.stateLabel.Name = "stateLabel"
        Me.stateLabel.Size = New System.Drawing.Size(28, 21)
        Me.stateLabel.TabIndex = 16
        Me.stateLabel.Text = "..."
        '
        'checkBeforeTaxLabel
        '
        Me.checkBeforeTaxLabel.AutoSize = True
        Me.checkBeforeTaxLabel.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBeforeTaxLabel.Location = New System.Drawing.Point(636, 180)
        Me.checkBeforeTaxLabel.Name = "checkBeforeTaxLabel"
        Me.checkBeforeTaxLabel.Size = New System.Drawing.Size(28, 21)
        Me.checkBeforeTaxLabel.TabIndex = 15
        Me.checkBeforeTaxLabel.Text = "..."
        '
        'loadButton2
        '
        Me.loadButton2.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadButton2.Location = New System.Drawing.Point(24, 345)
        Me.loadButton2.Name = "loadButton2"
        Me.loadButton2.Size = New System.Drawing.Size(131, 32)
        Me.loadButton2.TabIndex = 14
        Me.loadButton2.Text = "Load Employee Database"
        Me.loadButton2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(428, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 21)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Total pay after tax:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(428, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "FICA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(428, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "State:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(428, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Gross Pay:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(184, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total Hours"
        '
        'totalHoursTextBox
        '
        Me.totalHoursTextBox.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalHoursTextBox.Location = New System.Drawing.Point(298, 232)
        Me.totalHoursTextBox.Name = "totalHoursTextBox"
        Me.totalHoursTextBox.Size = New System.Drawing.Size(40, 25)
        Me.totalHoursTextBox.TabIndex = 3
        '
        'employeeListBox2
        '
        Me.employeeListBox2.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeListBox2.FormattingEnabled = True
        Me.employeeListBox2.ItemHeight = 20
        Me.employeeListBox2.Location = New System.Drawing.Point(23, 107)
        Me.employeeListBox2.Name = "employeeListBox2"
        Me.employeeListBox2.Size = New System.Drawing.Size(130, 224)
        Me.employeeListBox2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(19, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Employee List"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(268, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tax Calculator"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightGray
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.modifyButton)
        Me.TabPage2.Controls.Add(Me.stateTextBox)
        Me.TabPage2.Controls.Add(Me.ficaTextBox)
        Me.TabPage2.Controls.Add(Me.socialSecurityTextBox)
        Me.TabPage2.Controls.Add(Me.hourlyPayTextBox)
        Me.TabPage2.Controls.Add(Me.stateListBox)
        Me.TabPage2.Controls.Add(Me.ficaListBox)
        Me.TabPage2.Controls.Add(Me.socialSecurityListBox)
        Me.TabPage2.Controls.Add(Me.hourlyPayListBox)
        Me.TabPage2.Controls.Add(Me.deleteButton)
        Me.TabPage2.Controls.Add(Me.loadButton)
        Me.TabPage2.Controls.Add(Me.employeeListBox)
        Me.TabPage2.Controls.Add(Me.saveButton)
        Me.TabPage2.Controls.Add(Me.employeeNameTextBox)
        Me.TabPage2.Controls.Add(Me.addButton)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(789, 419)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(576, 237)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 16)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "State rate %"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(460, 237)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 16)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Fica rate %"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(332, 237)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 16)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "ssn rate %"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(205, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Hourly pay"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(84, 237)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Name"
        '
        'modifyButton
        '
        Me.modifyButton.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifyButton.Location = New System.Drawing.Point(289, 293)
        Me.modifyButton.Name = "modifyButton"
        Me.modifyButton.Size = New System.Drawing.Size(150, 32)
        Me.modifyButton.TabIndex = 25
        Me.modifyButton.Text = "Modify Employees"
        Me.modifyButton.UseVisualStyleBackColor = True
        '
        'stateTextBox
        '
        Me.stateTextBox.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stateTextBox.Location = New System.Drawing.Point(554, 259)
        Me.stateTextBox.Name = "stateTextBox"
        Me.stateTextBox.Size = New System.Drawing.Size(120, 28)
        Me.stateTextBox.TabIndex = 24
        '
        'ficaTextBox
        '
        Me.ficaTextBox.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficaTextBox.Location = New System.Drawing.Point(428, 259)
        Me.ficaTextBox.Name = "ficaTextBox"
        Me.ficaTextBox.Size = New System.Drawing.Size(120, 28)
        Me.ficaTextBox.TabIndex = 23
        '
        'socialSecurityTextBox
        '
        Me.socialSecurityTextBox.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.socialSecurityTextBox.Location = New System.Drawing.Point(302, 259)
        Me.socialSecurityTextBox.Name = "socialSecurityTextBox"
        Me.socialSecurityTextBox.Size = New System.Drawing.Size(120, 28)
        Me.socialSecurityTextBox.TabIndex = 22
        '
        'hourlyPayTextBox
        '
        Me.hourlyPayTextBox.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hourlyPayTextBox.Location = New System.Drawing.Point(176, 259)
        Me.hourlyPayTextBox.Name = "hourlyPayTextBox"
        Me.hourlyPayTextBox.Size = New System.Drawing.Size(120, 28)
        Me.hourlyPayTextBox.TabIndex = 21
        '
        'stateListBox
        '
        Me.stateListBox.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stateListBox.FormattingEnabled = True
        Me.stateListBox.ItemHeight = 17
        Me.stateListBox.Location = New System.Drawing.Point(554, 77)
        Me.stateListBox.Name = "stateListBox"
        Me.stateListBox.Size = New System.Drawing.Size(120, 157)
        Me.stateListBox.TabIndex = 20
        '
        'ficaListBox
        '
        Me.ficaListBox.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficaListBox.FormattingEnabled = True
        Me.ficaListBox.ItemHeight = 17
        Me.ficaListBox.Location = New System.Drawing.Point(428, 77)
        Me.ficaListBox.Name = "ficaListBox"
        Me.ficaListBox.Size = New System.Drawing.Size(120, 157)
        Me.ficaListBox.TabIndex = 19
        '
        'socialSecurityListBox
        '
        Me.socialSecurityListBox.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.socialSecurityListBox.FormattingEnabled = True
        Me.socialSecurityListBox.ItemHeight = 17
        Me.socialSecurityListBox.Location = New System.Drawing.Point(302, 77)
        Me.socialSecurityListBox.Name = "socialSecurityListBox"
        Me.socialSecurityListBox.Size = New System.Drawing.Size(120, 157)
        Me.socialSecurityListBox.TabIndex = 18
        '
        'hourlyPayListBox
        '
        Me.hourlyPayListBox.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hourlyPayListBox.FormattingEnabled = True
        Me.hourlyPayListBox.ItemHeight = 17
        Me.hourlyPayListBox.Location = New System.Drawing.Point(176, 77)
        Me.hourlyPayListBox.Name = "hourlyPayListBox"
        Me.hourlyPayListBox.Size = New System.Drawing.Size(120, 157)
        Me.hourlyPayListBox.TabIndex = 17
        '
        'deleteButton
        '
        Me.deleteButton.Enabled = False
        Me.deleteButton.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Location = New System.Drawing.Point(502, 293)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(150, 32)
        Me.deleteButton.TabIndex = 14
        Me.deleteButton.Text = "Delete Employee"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'loadButton
        '
        Me.loadButton.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadButton.Location = New System.Drawing.Point(412, 359)
        Me.loadButton.Name = "loadButton"
        Me.loadButton.Size = New System.Drawing.Size(136, 36)
        Me.loadButton.TabIndex = 13
        Me.loadButton.Text = "Load database"
        Me.loadButton.UseVisualStyleBackColor = True
        '
        'employeeListBox
        '
        Me.employeeListBox.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeListBox.FormattingEnabled = True
        Me.employeeListBox.ItemHeight = 17
        Me.employeeListBox.Location = New System.Drawing.Point(50, 77)
        Me.employeeListBox.Name = "employeeListBox"
        Me.employeeListBox.Size = New System.Drawing.Size(120, 157)
        Me.employeeListBox.TabIndex = 12
        '
        'saveButton
        '
        Me.saveButton.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.Location = New System.Drawing.Point(186, 359)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(136, 36)
        Me.saveButton.TabIndex = 11
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'employeeNameTextBox
        '
        Me.employeeNameTextBox.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeNameTextBox.Location = New System.Drawing.Point(50, 259)
        Me.employeeNameTextBox.Name = "employeeNameTextBox"
        Me.employeeNameTextBox.Size = New System.Drawing.Size(120, 28)
        Me.employeeNameTextBox.TabIndex = 10
        '
        'addButton
        '
        Me.addButton.Enabled = False
        Me.addButton.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addButton.Location = New System.Drawing.Point(87, 293)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(150, 32)
        Me.addButton.TabIndex = 9
        Me.addButton.Text = "Add Employee"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(300, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Settings"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "Form1"
        Me.Text = "Firus's Tax Calculator"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents totalHoursTextBox As TextBox
    Friend WithEvents employeeListBox2 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents employeeListBox As ListBox
    Friend WithEvents saveButton As Button
    Friend WithEvents employeeNameTextBox As TextBox
    Friend WithEvents addButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents loadButton As Button
    Friend WithEvents loadButton2 As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents totalPayAfterTaxLabel As Label
    Friend WithEvents ficaLabel As Label
    Friend WithEvents stateLabel As Label
    Friend WithEvents checkBeforeTaxLabel As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents hourlyPayListBox2 As ListBox
    Friend WithEvents stateListBox2 As ListBox
    Friend WithEvents ficaListBox2 As ListBox
    Friend WithEvents socialSecurityListBox2 As ListBox
    Friend WithEvents hourlyPaylLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents stateListBox As ListBox
    Friend WithEvents ficaListBox As ListBox
    Friend WithEvents socialSecurityListBox As ListBox
    Friend WithEvents hourlyPayListBox As ListBox
    Friend WithEvents stateTextBox As TextBox
    Friend WithEvents ficaTextBox As TextBox
    Friend WithEvents socialSecurityTextBox As TextBox
    Friend WithEvents hourlyPayTextBox As TextBox
    Friend WithEvents modifyButton As Button
    Friend WithEvents socialSecurityLabel As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
End Class
