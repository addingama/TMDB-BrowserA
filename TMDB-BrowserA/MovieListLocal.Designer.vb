<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MovieListLocal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_sync_10_pages_movies = New System.Windows.Forms.Button()
        Me.dgv_movie_list = New System.Windows.Forms.DataGridView()
        Me.btn_sync = New System.Windows.Forms.Button()
        Me.tb_search = New System.Windows.Forms.TextBox()
        CType(Me.dgv_movie_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_sync_10_pages_movies
        '
        Me.btn_sync_10_pages_movies.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sync_10_pages_movies.Location = New System.Drawing.Point(1788, 21)
        Me.btn_sync_10_pages_movies.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_sync_10_pages_movies.Name = "btn_sync_10_pages_movies"
        Me.btn_sync_10_pages_movies.Size = New System.Drawing.Size(200, 67)
        Me.btn_sync_10_pages_movies.TabIndex = 9
        Me.btn_sync_10_pages_movies.Text = "Sync 10 pages movies"
        Me.btn_sync_10_pages_movies.UseVisualStyleBackColor = True
        '
        'dgv_movie_list
        '
        Me.dgv_movie_list.AllowUserToAddRows = False
        Me.dgv_movie_list.AllowUserToDeleteRows = False
        Me.dgv_movie_list.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_movie_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_movie_list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgv_movie_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_movie_list.Location = New System.Drawing.Point(24, 83)
        Me.dgv_movie_list.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dgv_movie_list.Name = "dgv_movie_list"
        Me.dgv_movie_list.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgv_movie_list.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_movie_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.dgv_movie_list.Size = New System.Drawing.Size(1362, 638)
        Me.dgv_movie_list.TabIndex = 10
        '
        'btn_sync
        '
        Me.btn_sync.Location = New System.Drawing.Point(24, 23)
        Me.btn_sync.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_sync.Name = "btn_sync"
        Me.btn_sync.Size = New System.Drawing.Size(150, 44)
        Me.btn_sync.TabIndex = 11
        Me.btn_sync.Text = "Sync Movie"
        Me.btn_sync.UseVisualStyleBackColor = True
        '
        'tb_search
        '
        Me.tb_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_search.Location = New System.Drawing.Point(946, 36)
        Me.tb_search.Name = "tb_search"
        Me.tb_search.Size = New System.Drawing.Size(440, 31)
        Me.tb_search.TabIndex = 12
        '
        'MovieListLocal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1410, 744)
        Me.Controls.Add(Me.tb_search)
        Me.Controls.Add(Me.btn_sync)
        Me.Controls.Add(Me.dgv_movie_list)
        Me.Controls.Add(Me.btn_sync_10_pages_movies)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "MovieListLocal"
        Me.Text = "The Movie Database Browser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_movie_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_sync_10_pages_movies As Button
    Friend WithEvents dgv_movie_list As DataGridView
    Friend WithEvents btn_sync As Button
    Friend WithEvents tb_search As TextBox
End Class
