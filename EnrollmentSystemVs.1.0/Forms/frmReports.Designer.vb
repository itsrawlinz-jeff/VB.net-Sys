<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbosy = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboLevel = New System.Windows.Forms.ComboBox()
        Me.txtsearchid = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_studentscopy = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_enrollstudent = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_masterlist = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(157, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(661, 505)
        Me.CrystalReportViewer1.TabIndex = 5
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SY"
        '
        'cbosy
        '
        Me.cbosy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosy.FormattingEnabled = True
        Me.cbosy.Location = New System.Drawing.Point(9, 72)
        Me.cbosy.Name = "cbosy"
        Me.cbosy.Size = New System.Drawing.Size(129, 21)
        Me.cbosy.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbosy)
        Me.GroupBox1.Controls.Add(Me.btn_masterlist)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboLevel)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 162)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Grade/Year"
        '
        'cboLevel
        '
        Me.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Location = New System.Drawing.Point(9, 32)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(129, 21)
        Me.cboLevel.TabIndex = 2
        '
        'txtsearchid
        '
        Me.txtsearchid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtsearchid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtsearchid.Location = New System.Drawing.Point(3, 247)
        Me.txtsearchid.Name = "txtsearchid"
        Me.txtsearchid.Size = New System.Drawing.Size(147, 20)
        Me.txtsearchid.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_studentscopy)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btn_enrollstudent)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtsearchid)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(157, 505)
        Me.Panel1.TabIndex = 4
        '
        'btn_studentscopy
        '
        Me.btn_studentscopy.ActiveBorderThickness = 1
        Me.btn_studentscopy.ActiveCornerRadius = 20
        Me.btn_studentscopy.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_studentscopy.ActiveForecolor = System.Drawing.Color.White
        Me.btn_studentscopy.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_studentscopy.BackColor = System.Drawing.Color.Transparent
        Me.btn_studentscopy.BackgroundImage = CType(resources.GetObject("btn_studentscopy.BackgroundImage"), System.Drawing.Image)
        Me.btn_studentscopy.ButtonText = "Student's Copy"
        Me.btn_studentscopy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_studentscopy.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_studentscopy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_studentscopy.IdleBorderThickness = 1
        Me.btn_studentscopy.IdleCornerRadius = 20
        Me.btn_studentscopy.IdleFillColor = System.Drawing.Color.White
        Me.btn_studentscopy.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_studentscopy.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_studentscopy.Location = New System.Drawing.Point(5, 275)
        Me.btn_studentscopy.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_studentscopy.Name = "btn_studentscopy"
        Me.btn_studentscopy.Size = New System.Drawing.Size(143, 54)
        Me.btn_studentscopy.TabIndex = 86
        Me.btn_studentscopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_enrollstudent
        '
        Me.btn_enrollstudent.ActiveBorderThickness = 1
        Me.btn_enrollstudent.ActiveCornerRadius = 20
        Me.btn_enrollstudent.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_enrollstudent.ActiveForecolor = System.Drawing.Color.White
        Me.btn_enrollstudent.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_enrollstudent.BackColor = System.Drawing.SystemColors.Control
        Me.btn_enrollstudent.BackgroundImage = CType(resources.GetObject("btn_enrollstudent.BackgroundImage"), System.Drawing.Image)
        Me.btn_enrollstudent.ButtonText = "Enrolled Student"
        Me.btn_enrollstudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_enrollstudent.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enrollstudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_enrollstudent.IdleBorderThickness = 1
        Me.btn_enrollstudent.IdleCornerRadius = 20
        Me.btn_enrollstudent.IdleFillColor = System.Drawing.Color.White
        Me.btn_enrollstudent.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_enrollstudent.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_enrollstudent.Location = New System.Drawing.Point(5, 175)
        Me.btn_enrollstudent.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_enrollstudent.Name = "btn_enrollstudent"
        Me.btn_enrollstudent.Size = New System.Drawing.Size(145, 54)
        Me.btn_enrollstudent.TabIndex = 85
        Me.btn_enrollstudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_masterlist
        '
        Me.btn_masterlist.ActiveBorderThickness = 1
        Me.btn_masterlist.ActiveCornerRadius = 20
        Me.btn_masterlist.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_masterlist.ActiveForecolor = System.Drawing.Color.White
        Me.btn_masterlist.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_masterlist.BackColor = System.Drawing.SystemColors.Control
        Me.btn_masterlist.BackgroundImage = CType(resources.GetObject("btn_masterlist.BackgroundImage"), System.Drawing.Image)
        Me.btn_masterlist.ButtonText = "Master List"
        Me.btn_masterlist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_masterlist.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_masterlist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_masterlist.IdleBorderThickness = 1
        Me.btn_masterlist.IdleCornerRadius = 20
        Me.btn_masterlist.IdleFillColor = System.Drawing.Color.White
        Me.btn_masterlist.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_masterlist.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_masterlist.Location = New System.Drawing.Point(9, 100)
        Me.btn_masterlist.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_masterlist.Name = "btn_masterlist"
        Me.btn_masterlist.Size = New System.Drawing.Size(129, 54)
        Me.btn_masterlist.TabIndex = 84
        Me.btn_masterlist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmReports"
        Me.Size = New System.Drawing.Size(818, 505)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbosy As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboLevel As ComboBox
    Friend WithEvents txtsearchid As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_studentscopy As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_enrollstudent As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_masterlist As Bunifu.Framework.UI.BunifuThinButton2
End Class
