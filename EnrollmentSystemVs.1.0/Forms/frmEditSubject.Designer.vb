<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditSubject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditSubject))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSubjectID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsubjDesc = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsujCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbosy = New System.Windows.Forms.ComboBox()
        Me.btn_close = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_save = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Subject Id :"
        '
        'txtSubjectID
        '
        Me.txtSubjectID.Enabled = False
        Me.txtSubjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectID.Location = New System.Drawing.Point(168, 109)
        Me.txtSubjectID.Name = "txtSubjectID"
        Me.txtSubjectID.Size = New System.Drawing.Size(333, 26)
        Me.txtSubjectID.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Level :"
        '
        'cboYear
        '
        Me.cboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"Grade 7", "Gade 8", "3rd Year", "4th Year"})
        Me.cboYear.Location = New System.Drawing.Point(168, 270)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(333, 28)
        Me.cboYear.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Description :"
        '
        'txtsubjDesc
        '
        Me.txtsubjDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubjDesc.Location = New System.Drawing.Point(168, 173)
        Me.txtsubjDesc.Name = "txtsubjDesc"
        Me.txtsubjDesc.Size = New System.Drawing.Size(333, 91)
        Me.txtsubjDesc.TabIndex = 64
        Me.txtsubjDesc.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Subject :"
        '
        'txtsujCode
        '
        Me.txtsujCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsujCode.Location = New System.Drawing.Point(168, 141)
        Me.txtsujCode.Name = "txtsujCode"
        Me.txtsujCode.Size = New System.Drawing.Size(333, 26)
        Me.txtsujCode.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(579, 72)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Edit Subject"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(275, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 20)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "School Year :"
        '
        'cbosy
        '
        Me.cbosy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosy.FormattingEnabled = True
        Me.cbosy.Location = New System.Drawing.Point(250, 181)
        Me.cbosy.Name = "cbosy"
        Me.cbosy.Size = New System.Drawing.Size(155, 28)
        Me.cbosy.TabIndex = 66
        '
        'btn_close
        '
        Me.btn_close.ActiveBorderThickness = 1
        Me.btn_close.ActiveCornerRadius = 20
        Me.btn_close.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_close.ActiveForecolor = System.Drawing.Color.White
        Me.btn_close.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_close.BackColor = System.Drawing.SystemColors.Control
        Me.btn_close.BackgroundImage = CType(resources.GetObject("btn_close.BackgroundImage"), System.Drawing.Image)
        Me.btn_close.ButtonText = "Close"
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_close.IdleBorderThickness = 1
        Me.btn_close.IdleCornerRadius = 20
        Me.btn_close.IdleFillColor = System.Drawing.Color.White
        Me.btn_close.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_close.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_close.Location = New System.Drawing.Point(271, 306)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(93, 54)
        Me.btn_close.TabIndex = 76
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_save
        '
        Me.btn_save.ActiveBorderThickness = 1
        Me.btn_save.ActiveCornerRadius = 20
        Me.btn_save.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_save.ActiveForecolor = System.Drawing.Color.White
        Me.btn_save.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_save.BackColor = System.Drawing.SystemColors.Control
        Me.btn_save.BackgroundImage = CType(resources.GetObject("btn_save.BackgroundImage"), System.Drawing.Image)
        Me.btn_save.ButtonText = "Save"
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_save.IdleBorderThickness = 1
        Me.btn_save.IdleCornerRadius = 20
        Me.btn_save.IdleFillColor = System.Drawing.Color.White
        Me.btn_save.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btn_save.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btn_save.Location = New System.Drawing.Point(168, 306)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(93, 54)
        Me.btn_save.TabIndex = 75
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmEditSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 445)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSubjectID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtsubjDesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtsujCode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbosy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEditSubject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditSubject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSubjectID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtsubjDesc As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtsujCode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbosy As ComboBox
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_save As Bunifu.Framework.UI.BunifuThinButton2
End Class
