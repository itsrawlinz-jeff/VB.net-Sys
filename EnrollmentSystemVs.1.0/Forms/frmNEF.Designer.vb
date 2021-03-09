<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNEF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNEF))
        Me.dtgList = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboLevel = New System.Windows.Forms.ComboBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_clear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_delete = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_save = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgList
        '
        Me.dtgList.AllowUserToAddRows = False
        Me.dtgList.AllowUserToDeleteRows = False
        Me.dtgList.AllowUserToResizeColumns = False
        Me.dtgList.AllowUserToResizeRows = False
        Me.dtgList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column2, Me.Column3})
        Me.dtgList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgList.Location = New System.Drawing.Point(13, 167)
        Me.dtgList.Name = "dtgList"
        Me.dtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgList.Size = New System.Drawing.Size(789, 301)
        Me.dtgList.TabIndex = 38
        '
        'Column4
        '
        Me.Column4.HeaderText = "ID"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 80
        '
        'Column1
        '
        Me.Column1.HeaderText = "Description"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 330
        '
        'Column2
        '
        Me.Column2.HeaderText = "Amount"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Level"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'txtDesc
        '
        Me.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDesc.Location = New System.Drawing.Point(228, 28)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(395, 20)
        Me.txtDesc.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Description :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(156, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Level :"
        '
        'cboLevel
        '
        Me.cboLevel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Location = New System.Drawing.Point(228, 80)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(237, 21)
        Me.cboLevel.TabIndex = 42
        '
        'txtAmount
        '
        Me.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAmount.Location = New System.Drawing.Point(228, 54)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(109, 20)
        Me.txtAmount.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Amount :"
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
        Me.btn_clear.Location = New System.Drawing.Point(434, 105)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(94, 54)
        Me.btn_clear.TabIndex = 86
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_delete.Location = New System.Drawing.Point(331, 105)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(94, 54)
        Me.btn_delete.TabIndex = 85
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_save.Location = New System.Drawing.Point(228, 105)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(94, 54)
        Me.btn_save.TabIndex = 84
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmNEF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.dtgList)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboLevel)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmNEF"
        Me.Size = New System.Drawing.Size(818, 505)
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgList As DataGridView
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboLevel As ComboBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_clear As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_delete As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_save As Bunifu.Framework.UI.BunifuThinButton2
End Class
