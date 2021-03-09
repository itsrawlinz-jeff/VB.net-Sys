<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudents
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudents))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_clear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_save = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnGenerateIDNO = New System.Windows.Forms.Button()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkReportCard = New System.Windows.Forms.CheckBox()
        Me.chkCertification = New System.Windows.Forms.CheckBox()
        Me.chkBirthCert = New System.Windows.Forms.CheckBox()
        Me.chkPic = New System.Windows.Forms.CheckBox()
        Me.txtguardianadd = New System.Windows.Forms.RichTextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txtguardiantel = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txtguardian = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.cboAddSy = New System.Windows.Forms.ComboBox()
        Me.txtLastSchoolAttend = New System.Windows.Forms.RichTextBox()
        Me.txtPBirth = New System.Windows.Forms.RichTextBox()
        Me.txtAddress = New System.Windows.Forms.RichTextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.rdoFemale = New System.Windows.Forms.RadioButton()
        Me.rdoMale = New System.Windows.Forms.RadioButton()
        Me.dtpDbirth = New System.Windows.Forms.DateTimePicker()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtWeigth = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_delete = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_edit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.tsSearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtgList = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(818, 505)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_clear)
        Me.TabPage1.Controls.Add(Me.btn_save)
        Me.TabPage1.Controls.Add(Me.btnGenerateIDNO)
        Me.TabPage1.Controls.Add(Me.txtStudentId)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(810, 479)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Student"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.ActiveBorderThickness = 1
        Me.btn_clear.ActiveCornerRadius = 20
        Me.btn_clear.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_clear.ActiveForecolor = System.Drawing.Color.White
        Me.btn_clear.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_clear.BackColor = System.Drawing.Color.Transparent
        Me.btn_clear.BackgroundImage = CType(resources.GetObject("btn_clear.BackgroundImage"), System.Drawing.Image)
        Me.btn_clear.ButtonText = "Clear"
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_clear.IdleBorderThickness = 1
        Me.btn_clear.IdleCornerRadius = 20
        Me.btn_clear.IdleFillColor = System.Drawing.Color.White
        Me.btn_clear.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_clear.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_clear.Location = New System.Drawing.Point(113, 384)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(94, 54)
        Me.btn_clear.TabIndex = 86
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_save
        '
        Me.btn_save.ActiveBorderThickness = 1
        Me.btn_save.ActiveCornerRadius = 20
        Me.btn_save.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_save.ActiveForecolor = System.Drawing.Color.White
        Me.btn_save.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.BackgroundImage = CType(resources.GetObject("btn_save.BackgroundImage"), System.Drawing.Image)
        Me.btn_save.ButtonText = "Save"
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_save.IdleBorderThickness = 1
        Me.btn_save.IdleCornerRadius = 20
        Me.btn_save.IdleFillColor = System.Drawing.Color.White
        Me.btn_save.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_save.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_save.Location = New System.Drawing.Point(10, 384)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(94, 54)
        Me.btn_save.TabIndex = 84
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerateIDNO
        '
        Me.btnGenerateIDNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateIDNO.Location = New System.Drawing.Point(438, 18)
        Me.btnGenerateIDNO.Name = "btnGenerateIDNO"
        Me.btnGenerateIDNO.Size = New System.Drawing.Size(114, 26)
        Me.btnGenerateIDNO.TabIndex = 49
        Me.btnGenerateIDNO.Text = "Genarate ID No."
        Me.btnGenerateIDNO.UseVisualStyleBackColor = True
        '
        'txtStudentId
        '
        Me.txtStudentId.Enabled = False
        Me.txtStudentId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentId.Location = New System.Drawing.Point(102, 18)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(328, 26)
        Me.txtStudentId.TabIndex = 46
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtguardianadd)
        Me.GroupBox1.Controls.Add(Me.Label61)
        Me.GroupBox1.Controls.Add(Me.txtguardiantel)
        Me.GroupBox1.Controls.Add(Me.Label60)
        Me.GroupBox1.Controls.Add(Me.txtguardian)
        Me.GroupBox1.Controls.Add(Me.Label59)
        Me.GroupBox1.Controls.Add(Me.cboAddSy)
        Me.GroupBox1.Controls.Add(Me.txtLastSchoolAttend)
        Me.GroupBox1.Controls.Add(Me.txtPBirth)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label51)
        Me.GroupBox1.Controls.Add(Me.rdoFemale)
        Me.GroupBox1.Controls.Add(Me.rdoMale)
        Me.GroupBox1.Controls.Add(Me.dtpDbirth)
        Me.GroupBox1.Controls.Add(Me.txtHeight)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtWeigth)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtMName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(796, 321)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkReportCard)
        Me.GroupBox2.Controls.Add(Me.chkCertification)
        Me.GroupBox2.Controls.Add(Me.chkBirthCert)
        Me.GroupBox2.Controls.Add(Me.chkPic)
        Me.GroupBox2.Location = New System.Drawing.Point(647, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(138, 265)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Requirements"
        '
        'chkReportCard
        '
        Me.chkReportCard.AutoSize = True
        Me.chkReportCard.Location = New System.Drawing.Point(26, 41)
        Me.chkReportCard.Name = "chkReportCard"
        Me.chkReportCard.Size = New System.Drawing.Size(83, 17)
        Me.chkReportCard.TabIndex = 16
        Me.chkReportCard.Text = "Report Card"
        Me.chkReportCard.UseVisualStyleBackColor = True
        '
        'chkCertification
        '
        Me.chkCertification.AutoSize = True
        Me.chkCertification.Location = New System.Drawing.Point(28, 203)
        Me.chkCertification.Name = "chkCertification"
        Me.chkCertification.Size = New System.Drawing.Size(81, 17)
        Me.chkCertification.TabIndex = 19
        Me.chkCertification.Text = "Certification"
        Me.chkCertification.UseVisualStyleBackColor = True
        '
        'chkBirthCert
        '
        Me.chkBirthCert.AutoSize = True
        Me.chkBirthCert.Location = New System.Drawing.Point(26, 99)
        Me.chkBirthCert.Name = "chkBirthCert"
        Me.chkBirthCert.Size = New System.Drawing.Size(97, 17)
        Me.chkBirthCert.TabIndex = 17
        Me.chkBirthCert.Text = "Birth Certificate"
        Me.chkBirthCert.UseVisualStyleBackColor = True
        '
        'chkPic
        '
        Me.chkPic.AutoSize = True
        Me.chkPic.Location = New System.Drawing.Point(26, 156)
        Me.chkPic.Name = "chkPic"
        Me.chkPic.Size = New System.Drawing.Size(93, 17)
        Me.chkPic.TabIndex = 18
        Me.chkPic.Text = "1x1 ID Picture"
        Me.chkPic.UseVisualStyleBackColor = True
        '
        'txtguardianadd
        '
        Me.txtguardianadd.Location = New System.Drawing.Point(382, 180)
        Me.txtguardianadd.Name = "txtguardianadd"
        Me.txtguardianadd.Size = New System.Drawing.Size(259, 60)
        Me.txtguardianadd.TabIndex = 13
        Me.txtguardianadd.Text = ""
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(379, 164)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(51, 13)
        Me.Label61.TabIndex = 34
        Me.Label61.Text = "Address :"
        '
        'txtguardiantel
        '
        Me.txtguardiantel.Location = New System.Drawing.Point(9, 220)
        Me.txtguardiantel.Name = "txtguardiantel"
        Me.txtguardiantel.Size = New System.Drawing.Size(367, 20)
        Me.txtguardiantel.TabIndex = 12
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(6, 207)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(28, 13)
        Me.Label60.TabIndex = 32
        Me.Label60.Text = "Tel :"
        '
        'txtguardian
        '
        Me.txtguardian.Location = New System.Drawing.Point(9, 184)
        Me.txtguardian.Name = "txtguardian"
        Me.txtguardian.Size = New System.Drawing.Size(367, 20)
        Me.txtguardian.TabIndex = 11
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(6, 171)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(56, 13)
        Me.Label59.TabIndex = 30
        Me.Label59.Text = "Guardian :"
        '
        'cboAddSy
        '
        Me.cboAddSy.FormattingEnabled = True
        Me.cboAddSy.Location = New System.Drawing.Point(382, 263)
        Me.cboAddSy.Name = "cboAddSy"
        Me.cboAddSy.Size = New System.Drawing.Size(259, 21)
        Me.cboAddSy.TabIndex = 15
        '
        'txtLastSchoolAttend
        '
        Me.txtLastSchoolAttend.Location = New System.Drawing.Point(9, 263)
        Me.txtLastSchoolAttend.Name = "txtLastSchoolAttend"
        Me.txtLastSchoolAttend.Size = New System.Drawing.Size(367, 52)
        Me.txtLastSchoolAttend.TabIndex = 14
        Me.txtLastSchoolAttend.Text = ""
        '
        'txtPBirth
        '
        Me.txtPBirth.Location = New System.Drawing.Point(382, 86)
        Me.txtPBirth.Name = "txtPBirth"
        Me.txtPBirth.Size = New System.Drawing.Size(259, 37)
        Me.txtPBirth.TabIndex = 5
        Me.txtPBirth.Text = ""
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(9, 86)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(367, 37)
        Me.txtAddress.TabIndex = 4
        Me.txtAddress.Text = ""
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(379, 243)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(71, 13)
        Me.Label29.TabIndex = 23
        Me.Label29.Text = "School Year :"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(6, 243)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(115, 13)
        Me.Label51.TabIndex = 23
        Me.Label51.Text = "Last School Attended :"
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Location = New System.Drawing.Point(393, 144)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(59, 17)
        Me.rdoFemale.TabIndex = 8
        Me.rdoFemale.TabStop = True
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Location = New System.Drawing.Point(339, 144)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(48, 17)
        Me.rdoMale.TabIndex = 7
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "Male"
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'dtpDbirth
        '
        Me.dtpDbirth.CustomFormat = "yyyy-MM-dd"
        Me.dtpDbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDbirth.Location = New System.Drawing.Point(9, 143)
        Me.dtpDbirth.Name = "dtpDbirth"
        Me.dtpDbirth.Size = New System.Drawing.Size(158, 20)
        Me.dtpDbirth.TabIndex = 6
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(537, 143)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(86, 20)
        Me.txtHeight.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(534, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Height :"
        '
        'txtWeigth
        '
        Me.txtWeigth.Location = New System.Drawing.Point(459, 144)
        Me.txtWeigth.Name = "txtWeigth"
        Me.txtWeigth.Size = New System.Drawing.Size(72, 20)
        Me.txtWeigth.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(457, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Weight :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(336, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Sex :"
        '
        'txtAge
        '
        Me.txtAge.Enabled = False
        Me.txtAge.Location = New System.Drawing.Point(173, 142)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(143, 20)
        Me.txtAge.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(170, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Age :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date Of Birth :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(379, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Place Of Birth :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Address :"
        '
        'txtMName
        '
        Me.txtMName.Location = New System.Drawing.Point(460, 38)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(181, 20)
        Me.txtMName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(516, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Middle Name :"
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(287, 38)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(165, 20)
        Me.txtFName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Given Name :"
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(9, 38)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(272, 20)
        Me.txtLName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Family Name :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 21)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(95, 20)
        Me.Label27.TabIndex = 48
        Me.Label27.Text = "Student ID :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_delete)
        Me.TabPage2.Controls.Add(Me.btn_edit)
        Me.TabPage2.Controls.Add(Me.tsSearch)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.dtgList)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(810, 479)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "List of Students"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.ActiveBorderThickness = 1
        Me.btn_delete.ActiveCornerRadius = 20
        Me.btn_delete.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_delete.ActiveForecolor = System.Drawing.Color.White
        Me.btn_delete.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.BackgroundImage = CType(resources.GetObject("btn_delete.BackgroundImage"), System.Drawing.Image)
        Me.btn_delete.ButtonText = "Delete"
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_delete.IdleBorderThickness = 1
        Me.btn_delete.IdleCornerRadius = 20
        Me.btn_delete.IdleFillColor = System.Drawing.Color.White
        Me.btn_delete.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_delete.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_delete.Location = New System.Drawing.Point(115, 409)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(94, 54)
        Me.btn_delete.TabIndex = 85
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_edit
        '
        Me.btn_edit.ActiveBorderThickness = 1
        Me.btn_edit.ActiveCornerRadius = 20
        Me.btn_edit.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_edit.ActiveForecolor = System.Drawing.Color.White
        Me.btn_edit.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_edit.BackColor = System.Drawing.Color.Transparent
        Me.btn_edit.BackgroundImage = CType(resources.GetObject("btn_edit.BackgroundImage"), System.Drawing.Image)
        Me.btn_edit.ButtonText = "Edit"
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_edit.IdleBorderThickness = 1
        Me.btn_edit.IdleCornerRadius = 20
        Me.btn_edit.IdleFillColor = System.Drawing.Color.White
        Me.btn_edit.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_edit.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_edit.Location = New System.Drawing.Point(12, 409)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(94, 54)
        Me.btn_edit.TabIndex = 84
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tsSearch
        '
        Me.tsSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSearch.Location = New System.Drawing.Point(400, 415)
        Me.tsSearch.Name = "tsSearch"
        Me.tsSearch.Size = New System.Drawing.Size(404, 30)
        Me.tsSearch.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(271, 418)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 25)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Find Student"
        '
        'dtgList
        '
        Me.dtgList.AllowUserToAddRows = False
        Me.dtgList.AllowUserToDeleteRows = False
        Me.dtgList.AllowUserToResizeColumns = False
        Me.dtgList.AllowUserToResizeRows = False
        Me.dtgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgList.Location = New System.Drawing.Point(6, 6)
        Me.dtgList.Name = "dtgList"
        Me.dtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgList.Size = New System.Drawing.Size(801, 395)
        Me.dtgList.TabIndex = 8
        '
        'frmStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmStudents"
        Me.Size = New System.Drawing.Size(818, 505)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnGenerateIDNO As Button
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkReportCard As CheckBox
    Friend WithEvents chkCertification As CheckBox
    Friend WithEvents chkBirthCert As CheckBox
    Friend WithEvents chkPic As CheckBox
    Friend WithEvents txtguardianadd As RichTextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents txtguardiantel As TextBox
    Friend WithEvents Label60 As Label
    Friend WithEvents txtguardian As TextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents cboAddSy As ComboBox
    Friend WithEvents txtLastSchoolAttend As RichTextBox
    Friend WithEvents txtPBirth As RichTextBox
    Friend WithEvents txtAddress As RichTextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents rdoFemale As RadioButton
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents dtpDbirth As DateTimePicker
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtWeigth As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tsSearch As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dtgList As DataGridView
    Friend WithEvents btn_clear As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_save As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_delete As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_edit As Bunifu.Framework.UI.BunifuThinButton2
End Class
