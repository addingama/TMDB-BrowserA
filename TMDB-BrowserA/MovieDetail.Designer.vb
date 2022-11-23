<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieDetail
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_overview = New System.Windows.Forms.Label()
        Me.pb_poster = New System.Windows.Forms.PictureBox()
        Me.lbl_poster_path = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.pb_poster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(17, 29)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(39, 13)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Label1"
        '
        'lbl_overview
        '
        Me.lbl_overview.Location = New System.Drawing.Point(17, 59)
        Me.lbl_overview.Name = "lbl_overview"
        Me.lbl_overview.Size = New System.Drawing.Size(366, 107)
        Me.lbl_overview.TabIndex = 1
        Me.lbl_overview.Text = "Label2"
        '
        'pb_poster
        '
        Me.pb_poster.Location = New System.Drawing.Point(12, 12)
        Me.pb_poster.Name = "pb_poster"
        Me.pb_poster.Size = New System.Drawing.Size(181, 235)
        Me.pb_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_poster.TabIndex = 2
        Me.pb_poster.TabStop = False
        '
        'lbl_poster_path
        '
        Me.lbl_poster_path.AutoSize = True
        Me.lbl_poster_path.Location = New System.Drawing.Point(17, 193)
        Me.lbl_poster_path.Name = "lbl_poster_path"
        Me.lbl_poster_path.Size = New System.Drawing.Size(39, 13)
        Me.lbl_poster_path.TabIndex = 3
        Me.lbl_poster_path.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_poster_path)
        Me.GroupBox1.Controls.Add(Me.lbl_overview)
        Me.GroupBox1.Controls.Add(Me.lbl_title)
        Me.GroupBox1.Location = New System.Drawing.Point(199, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 226)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'MovieDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 259)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pb_poster)
        Me.Name = "MovieDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MovieDetail"
        CType(Me.pb_poster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_overview As Label
    Friend WithEvents pb_poster As PictureBox
    Friend WithEvents lbl_poster_path As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
