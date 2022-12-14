<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mn_list = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn_report = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn_report_list = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn_report_companies = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn_report_movie_detail = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mn_list, Me.mn_report})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 42)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mn_list
        '
        Me.mn_list.Name = "mn_list"
        Me.mn_list.Size = New System.Drawing.Size(69, 38)
        Me.mn_list.Text = "List"
        '
        'mn_report
        '
        Me.mn_report.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mn_report_list, Me.mn_report_companies, Me.mn_report_movie_detail})
        Me.mn_report.Name = "mn_report"
        Me.mn_report.Size = New System.Drawing.Size(104, 38)
        Me.mn_report.Text = "Report"
        '
        'mn_report_list
        '
        Me.mn_report_list.Name = "mn_report_list"
        Me.mn_report_list.Size = New System.Drawing.Size(359, 44)
        Me.mn_report_list.Text = "Daftar Film"
        '
        'mn_report_companies
        '
        Me.mn_report_companies.Name = "mn_report_companies"
        Me.mn_report_companies.Size = New System.Drawing.Size(359, 44)
        Me.mn_report_companies.Text = "Daftar Perusahaan"
        '
        'mn_report_movie_detail
        '
        Me.mn_report_movie_detail.Name = "mn_report_movie_detail"
        Me.mn_report_movie_detail.Size = New System.Drawing.Size(359, 44)
        Me.mn_report_movie_detail.Text = "Detail Film"
        '
        'ParentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ParentForm"
        Me.Text = "Movie Browser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mn_list As ToolStripMenuItem
    Friend WithEvents mn_report As ToolStripMenuItem
    Friend WithEvents mn_report_list As ToolStripMenuItem
    Friend WithEvents mn_report_companies As ToolStripMenuItem
    Friend WithEvents mn_report_movie_detail As ToolStripMenuItem
End Class
