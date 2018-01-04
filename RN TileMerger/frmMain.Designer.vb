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
        Me.cmdSource = New System.Windows.Forms.Button()
        Me.cmdTarget = New System.Windows.Forms.Button()
        Me.lblBron = New System.Windows.Forms.Label()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.cmdProcess = New System.Windows.Forms.Button()
        Me.updownColumns = New System.Windows.Forms.NumericUpDown()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblImgCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pgbVoortgang = New System.Windows.Forms.ToolStripProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdLocatie = New System.Windows.Forms.ComboBox()
        Me.chkPDOK = New System.Windows.Forms.CheckBox()
        CType(Me.updownColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSource
        '
        Me.cmdSource.Location = New System.Drawing.Point(4, 8)
        Me.cmdSource.Name = "cmdSource"
        Me.cmdSource.Size = New System.Drawing.Size(75, 23)
        Me.cmdSource.TabIndex = 0
        Me.cmdSource.Text = "Bron"
        Me.cmdSource.UseVisualStyleBackColor = True
        '
        'cmdTarget
        '
        Me.cmdTarget.Location = New System.Drawing.Point(4, 37)
        Me.cmdTarget.Name = "cmdTarget"
        Me.cmdTarget.Size = New System.Drawing.Size(75, 23)
        Me.cmdTarget.TabIndex = 1
        Me.cmdTarget.Text = "Doel"
        Me.cmdTarget.UseVisualStyleBackColor = True
        '
        'lblBron
        '
        Me.lblBron.AutoSize = True
        Me.lblBron.Location = New System.Drawing.Point(85, 13)
        Me.lblBron.Name = "lblBron"
        Me.lblBron.Size = New System.Drawing.Size(38, 13)
        Me.lblBron.TabIndex = 2
        Me.lblBron.Text = "BRON"
        '
        'lblTarget
        '
        Me.lblTarget.AutoSize = True
        Me.lblTarget.Location = New System.Drawing.Point(85, 42)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(36, 13)
        Me.lblTarget.TabIndex = 3
        Me.lblTarget.Text = "DOEL"
        '
        'cmdProcess
        '
        Me.cmdProcess.Enabled = False
        Me.cmdProcess.Location = New System.Drawing.Point(4, 122)
        Me.cmdProcess.Name = "cmdProcess"
        Me.cmdProcess.Size = New System.Drawing.Size(75, 23)
        Me.cmdProcess.TabIndex = 5
        Me.cmdProcess.Text = "Verwerk"
        Me.cmdProcess.UseVisualStyleBackColor = True
        '
        'updownColumns
        '
        Me.updownColumns.Location = New System.Drawing.Point(88, 69)
        Me.updownColumns.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updownColumns.Name = "updownColumns"
        Me.updownColumns.Size = New System.Drawing.Size(68, 20)
        Me.updownColumns.TabIndex = 6
        Me.updownColumns.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblImgCount, Me.pgbVoortgang})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 272)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(805, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblImgCount
        '
        Me.lblImgCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblImgCount.Name = "lblImgCount"
        Me.lblImgCount.Size = New System.Drawing.Size(20, 17)
        Me.lblImgCount.Text = "#0"
        '
        'pgbVoortgang
        '
        Me.pgbVoortgang.Name = "pgbVoortgang"
        Me.pgbVoortgang.Size = New System.Drawing.Size(100, 16)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Kolommen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Locatie eerste afbeelding"
        '
        'cmdLocatie
        '
        Me.cmdLocatie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdLocatie.FormattingEnabled = True
        Me.cmdLocatie.Items.AddRange(New Object() {"Links Boven", "Links Onder", "Rechts Boven", "Rechts Onder"})
        Me.cmdLocatie.Location = New System.Drawing.Point(306, 68)
        Me.cmdLocatie.Name = "cmdLocatie"
        Me.cmdLocatie.Size = New System.Drawing.Size(121, 21)
        Me.cmdLocatie.TabIndex = 10
        '
        'chkPDOK
        '
        Me.chkPDOK.AutoSize = True
        Me.chkPDOK.Location = New System.Drawing.Point(91, 99)
        Me.chkPDOK.Name = "chkPDOK"
        Me.chkPDOK.Size = New System.Drawing.Size(127, 17)
        Me.chkPDOK.TabIndex = 13
        Me.chkPDOK.Text = "PDOK Afbeeldingen?"
        Me.chkPDOK.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 294)
        Me.Controls.Add(Me.chkPDOK)
        Me.Controls.Add(Me.cmdLocatie)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.updownColumns)
        Me.Controls.Add(Me.cmdProcess)
        Me.Controls.Add(Me.lblTarget)
        Me.Controls.Add(Me.lblBron)
        Me.Controls.Add(Me.cmdTarget)
        Me.Controls.Add(Me.cmdSource)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(821, 333)
        Me.MinimumSize = New System.Drawing.Size(821, 333)
        Me.Name = "frmMain"
        Me.Text = "RN Tile Merger"
        CType(Me.updownColumns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSource As Button
    Friend WithEvents cmdTarget As Button
    Friend WithEvents lblBron As Label
    Friend WithEvents lblTarget As Label
    Friend WithEvents cmdProcess As Button
    Friend WithEvents updownColumns As NumericUpDown
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblImgCount As ToolStripStatusLabel
    Friend WithEvents pgbVoortgang As ToolStripProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdLocatie As ComboBox
    Friend WithEvents chkPDOK As CheckBox
End Class
