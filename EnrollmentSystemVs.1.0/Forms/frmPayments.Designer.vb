<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayments
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayments))
        Me.cboSearchBy = New System.Windows.Forms.ComboBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTransDate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTransNo = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txtCurrentBalance = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.txtSy = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBackAccount = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCurrentAccount = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dtgNonEssential = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotNonEssential = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtgEssential = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotEssential = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_clear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_save = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_search = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dtgNonEssential, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dtgEssential, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboSearchBy
        '
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Items.AddRange(New Object() {"Id Number", "Name"})
        Me.cboSearchBy.Location = New System.Drawing.Point(61, 45)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(308, 21)
        Me.cboSearchBy.TabIndex = 1
        Me.cboSearchBy.Text = "Select"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.txtTransDate)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.txtTransNo)
        Me.GroupBox7.Location = New System.Drawing.Point(489, 73)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(321, 78)
        Me.GroupBox7.TabIndex = 30
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Transaction Details"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Transaction Date :"
        '
        'txtTransDate
        '
        Me.txtTransDate.BackColor = System.Drawing.Color.White
        Me.txtTransDate.Enabled = False
        Me.txtTransDate.Location = New System.Drawing.Point(112, 41)
        Me.txtTransDate.Name = "txtTransDate"
        Me.txtTransDate.Size = New System.Drawing.Size(202, 20)
        Me.txtTransDate.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Transaction # :"
        '
        'txtTransNo
        '
        Me.txtTransNo.BackColor = System.Drawing.Color.White
        Me.txtTransNo.Enabled = False
        Me.txtTransNo.Location = New System.Drawing.Point(112, 15)
        Me.txtTransNo.Name = "txtTransNo"
        Me.txtTransNo.Size = New System.Drawing.Size(202, 20)
        Me.txtTransNo.TabIndex = 14
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(61, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(308, 20)
        Me.txtSearch.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txtCurrentBalance)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(561, 386)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(249, 80)
        Me.GroupBox9.TabIndex = 32
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Current Balance"
        '
        'txtCurrentBalance
        '
        Me.txtCurrentBalance.BackColor = System.Drawing.Color.White
        Me.txtCurrentBalance.Enabled = False
        Me.txtCurrentBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentBalance.Location = New System.Drawing.Point(14, 19)
        Me.txtCurrentBalance.Name = "txtCurrentBalance"
        Me.txtCurrentBalance.Size = New System.Drawing.Size(226, 53)
        Me.txtCurrentBalance.TabIndex = 11
        Me.txtCurrentBalance.Text = "0.00"
        Me.txtCurrentBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(244, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Academic Year :"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtPayment)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(563, 300)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(249, 80)
        Me.GroupBox8.TabIndex = 31
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Payment"
        '
        'txtPayment
        '
        Me.txtPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.Location = New System.Drawing.Point(14, 19)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(226, 53)
        Me.txtPayment.TabIndex = 10
        Me.txtPayment.Text = "0.00"
        Me.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSy
        '
        Me.txtSy.BackColor = System.Drawing.Color.White
        Me.txtSy.Enabled = False
        Me.txtSy.Location = New System.Drawing.Point(335, 45)
        Me.txtSy.Name = "txtSy"
        Me.txtSy.Size = New System.Drawing.Size(80, 20)
        Me.txtSy.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(130, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Section :"
        '
        'txtSection
        '
        Me.txtSection.BackColor = System.Drawing.Color.White
        Me.txtSection.Enabled = False
        Me.txtSection.Location = New System.Drawing.Point(183, 45)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(58, 20)
        Me.txtSection.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "By :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Level :"
        '
        'txtLevel
        '
        Me.txtLevel.BackColor = System.Drawing.Color.White
        Me.txtLevel.Enabled = False
        Me.txtLevel.Location = New System.Drawing.Point(61, 45)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(65, 20)
        Me.txtLevel.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Name :"
        '
        'txtStudentName
        '
        Me.txtStudentName.BackColor = System.Drawing.Color.White
        Me.txtStudentName.Enabled = False
        Me.txtStudentName.Location = New System.Drawing.Point(61, 19)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(354, 20)
        Me.txtStudentName.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Total Amount :"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.BackColor = System.Drawing.Color.White
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(101, 94)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(139, 30)
        Me.txtTotalAmount.TabIndex = 10
        Me.txtTotalAmount.Text = "0.00"
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Back Account :"
        '
        'txtBackAccount
        '
        Me.txtBackAccount.BackColor = System.Drawing.Color.White
        Me.txtBackAccount.Enabled = False
        Me.txtBackAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBackAccount.Location = New System.Drawing.Point(101, 56)
        Me.txtBackAccount.Name = "txtBackAccount"
        Me.txtBackAccount.Size = New System.Drawing.Size(139, 30)
        Me.txtBackAccount.TabIndex = 8
        Me.txtBackAccount.Text = "0.00"
        Me.txtBackAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Current Account :"
        '
        'txtCurrentAccount
        '
        Me.txtCurrentAccount.BackColor = System.Drawing.Color.White
        Me.txtCurrentAccount.Enabled = False
        Me.txtCurrentAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentAccount.Location = New System.Drawing.Point(101, 19)
        Me.txtCurrentAccount.Name = "txtCurrentAccount"
        Me.txtCurrentAccount.Size = New System.Drawing.Size(139, 30)
        Me.txtCurrentAccount.TabIndex = 6
        Me.txtCurrentAccount.Text = "0.00"
        Me.txtCurrentAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_search)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboSearchBy)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 76)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search for Student"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Search :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 178)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(554, 291)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fee's"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dtgNonEssential)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.txtTotNonEssential)
        Me.GroupBox6.Location = New System.Drawing.Point(277, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(270, 269)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Non-Essential"
        '
        'dtgNonEssential
        '
        Me.dtgNonEssential.AllowUserToAddRows = False
        Me.dtgNonEssential.AllowUserToDeleteRows = False
        Me.dtgNonEssential.AllowUserToResizeColumns = False
        Me.dtgNonEssential.AllowUserToResizeRows = False
        Me.dtgNonEssential.BackgroundColor = System.Drawing.Color.White
        Me.dtgNonEssential.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgNonEssential.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dtgNonEssential.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgNonEssential.Location = New System.Drawing.Point(6, 19)
        Me.dtgNonEssential.Name = "dtgNonEssential"
        Me.dtgNonEssential.RowHeadersVisible = False
        Me.dtgNonEssential.Size = New System.Drawing.Size(258, 218)
        Me.dtgNonEssential.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle1.Format = "#.##"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 94
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(96, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Total :"
        '
        'txtTotNonEssential
        '
        Me.txtTotNonEssential.BackColor = System.Drawing.Color.White
        Me.txtTotNonEssential.Enabled = False
        Me.txtTotNonEssential.Location = New System.Drawing.Point(141, 243)
        Me.txtTotNonEssential.Name = "txtTotNonEssential"
        Me.txtTotNonEssential.Size = New System.Drawing.Size(123, 20)
        Me.txtTotNonEssential.TabIndex = 16
        Me.txtTotNonEssential.Text = "0.00"
        Me.txtTotNonEssential.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dtgEssential)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.txtTotEssential)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(265, 269)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Essential"
        '
        'dtgEssential
        '
        Me.dtgEssential.AllowUserToAddRows = False
        Me.dtgEssential.AllowUserToDeleteRows = False
        Me.dtgEssential.AllowUserToResizeColumns = False
        Me.dtgEssential.AllowUserToResizeRows = False
        Me.dtgEssential.BackgroundColor = System.Drawing.Color.White
        Me.dtgEssential.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgEssential.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dtgEssential.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgEssential.Location = New System.Drawing.Point(6, 19)
        Me.dtgEssential.Name = "dtgEssential"
        Me.dtgEssential.RowHeadersVisible = False
        Me.dtgEssential.Size = New System.Drawing.Size(259, 218)
        Me.dtgEssential.TabIndex = 18
        '
        'Column1
        '
        Me.Column1.HeaderText = "Description"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Column2
        '
        DataGridViewCellStyle2.Format = "#.##"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "Amount"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 94
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(93, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Total :"
        '
        'txtTotEssential
        '
        Me.txtTotEssential.BackColor = System.Drawing.Color.White
        Me.txtTotEssential.Enabled = False
        Me.txtTotEssential.Location = New System.Drawing.Point(136, 243)
        Me.txtTotEssential.Name = "txtTotEssential"
        Me.txtTotEssential.Size = New System.Drawing.Size(123, 20)
        Me.txtTotEssential.TabIndex = 14
        Me.txtTotEssential.Text = "0.00"
        Me.txtTotEssential.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtTotalAmount)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtBackAccount)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtCurrentAccount)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(563, 156)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(247, 138)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Summary"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtSy)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtSection)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtLevel)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtStudentName)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(457, 78)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Details"
        '
        'btn_clear
        '
        Me.btn_clear.ActiveBorderThickness = 1
        Me.btn_clear.ActiveCornerRadius = 20
        Me.btn_clear.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_clear.ActiveForecolor = System.Drawing.Color.White
        Me.btn_clear.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_clear.BackColor = System.Drawing.SystemColors.Control
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
        Me.btn_clear.Location = New System.Drawing.Point(696, 5)
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
        Me.btn_save.BackColor = System.Drawing.SystemColors.Control
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
        Me.btn_save.Location = New System.Drawing.Point(597, 5)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(94, 54)
        Me.btn_save.TabIndex = 84
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_search
        '
        Me.btn_search.ActiveBorderThickness = 1
        Me.btn_search.ActiveCornerRadius = 20
        Me.btn_search.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_search.ActiveForecolor = System.Drawing.Color.White
        Me.btn_search.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_search.BackColor = System.Drawing.SystemColors.Control
        Me.btn_search.BackgroundImage = CType(resources.GetObject("btn_search.BackgroundImage"), System.Drawing.Image)
        Me.btn_search.ButtonText = "Search"
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_search.IdleBorderThickness = 1
        Me.btn_search.IdleCornerRadius = 20
        Me.btn_search.IdleFillColor = System.Drawing.Color.White
        Me.btn_search.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btn_search.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btn_search.Location = New System.Drawing.Point(377, 9)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(72, 62)
        Me.btn_search.TabIndex = 87
        Me.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmPayments"
        Me.Size = New System.Drawing.Size(818, 505)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dtgNonEssential, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dtgEssential, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboSearchBy As ComboBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTransDate As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTransNo As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents txtCurrentBalance As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents txtSy As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSection As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBackAccount As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCurrentAccount As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dtgNonEssential As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTotNonEssential As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents dtgEssential As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotEssential As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_clear As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_save As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_search As Bunifu.Framework.UI.BunifuThinButton2
End Class
