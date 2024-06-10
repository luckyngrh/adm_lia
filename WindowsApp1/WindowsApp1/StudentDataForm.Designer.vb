<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDataForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentDataForm))
        Me.dgvMurid = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GradeCBS = New System.Windows.Forms.ComboBox()
        Me.NameTBS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MainPictureBox = New System.Windows.Forms.PictureBox()
        Me.btnEditStudent = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvMurid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMurid
        '
        Me.dgvMurid.AllowUserToAddRows = False
        Me.dgvMurid.AllowUserToDeleteRows = False
        Me.dgvMurid.BackgroundColor = System.Drawing.SystemColors.Info
        Me.dgvMurid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMurid.Location = New System.Drawing.Point(4, 190)
        Me.dgvMurid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvMurid.Name = "dgvMurid"
        Me.dgvMurid.ReadOnly = True
        Me.dgvMurid.RowTemplate.Height = 28
        Me.dgvMurid.Size = New System.Drawing.Size(827, 299)
        Me.dgvMurid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search By Grade:"
        '
        'GradeCBS
        '
        Me.GradeCBS.FormattingEnabled = True
        Me.GradeCBS.Items.AddRange(New Object() {"Elementary", "Intermediate", "High Intermediate"})
        Me.GradeCBS.Location = New System.Drawing.Point(213, 78)
        Me.GradeCBS.Name = "GradeCBS"
        Me.GradeCBS.Size = New System.Drawing.Size(178, 40)
        Me.GradeCBS.TabIndex = 2
        '
        'NameTBS
        '
        Me.NameTBS.Location = New System.Drawing.Point(213, 143)
        Me.NameTBS.Name = "NameTBS"
        Me.NameTBS.Size = New System.Drawing.Size(178, 39)
        Me.NameTBS.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search By Name:"
        '
        'MainPictureBox
        '
        Me.MainPictureBox.Image = CType(resources.GetObject("MainPictureBox.Image"), System.Drawing.Image)
        Me.MainPictureBox.Location = New System.Drawing.Point(683, 78)
        Me.MainPictureBox.Name = "MainPictureBox"
        Me.MainPictureBox.Size = New System.Drawing.Size(122, 104)
        Me.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MainPictureBox.TabIndex = 7
        Me.MainPictureBox.TabStop = False
        '
        'btnEditStudent
        '
        Me.btnEditStudent.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditStudent.Location = New System.Drawing.Point(448, 72)
        Me.btnEditStudent.Name = "btnEditStudent"
        Me.btnEditStudent.Size = New System.Drawing.Size(125, 54)
        Me.btnEditStudent.TabIndex = 8
        Me.btnEditStudent.Text = "Update"
        Me.btnEditStudent.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(448, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 54)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(320, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 38)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Student Data"
        '
        'StudentDataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(833, 493)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEditStudent)
        Me.Controls.Add(Me.MainPictureBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NameTBS)
        Me.Controls.Add(Me.GradeCBS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvMurid)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "StudentDataForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Data"
        CType(Me.dgvMurid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMurid As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GradeCBS As ComboBox
    Friend WithEvents NameTBS As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MainPictureBox As PictureBox
    Friend WithEvents btnEditStudent As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
