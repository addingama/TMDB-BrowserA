﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_get_movies = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_poster_path = New System.Windows.Forms.Label()
        Me.lbl_overview = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Judul"
        '
        'btn_get_movies
        '
        Me.btn_get_movies.Location = New System.Drawing.Point(34, 12)
        Me.btn_get_movies.Name = "btn_get_movies"
        Me.btn_get_movies.Size = New System.Drawing.Size(75, 23)
        Me.btn_get_movies.TabIndex = 2
        Me.btn_get_movies.Text = "Get Movies"
        Me.btn_get_movies.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Poster Path"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Overview"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(109, 62)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(32, 13)
        Me.lbl_title.TabIndex = 5
        Me.lbl_title.Text = "Judul"
        '
        'lbl_poster_path
        '
        Me.lbl_poster_path.AutoSize = True
        Me.lbl_poster_path.Location = New System.Drawing.Point(109, 90)
        Me.lbl_poster_path.Name = "lbl_poster_path"
        Me.lbl_poster_path.Size = New System.Drawing.Size(32, 13)
        Me.lbl_poster_path.TabIndex = 6
        Me.lbl_poster_path.Text = "Judul"
        '
        'lbl_overview
        '
        Me.lbl_overview.AutoSize = True
        Me.lbl_overview.Location = New System.Drawing.Point(109, 120)
        Me.lbl_overview.Name = "lbl_overview"
        Me.lbl_overview.Size = New System.Drawing.Size(32, 13)
        Me.lbl_overview.TabIndex = 7
        Me.lbl_overview.Text = "Judul"
        '
        'MovieListLocal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_overview)
        Me.Controls.Add(Me.lbl_poster_path)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_get_movies)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MovieListLocal"
        Me.Text = "The Movie Database Browser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_get_movies As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_poster_path As Label
    Friend WithEvents lbl_overview As Label
End Class
