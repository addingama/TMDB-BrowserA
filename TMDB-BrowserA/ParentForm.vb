Public Class ParentForm
    Private Sub mn_list_Click(sender As Object, e As EventArgs) Handles mn_list.Click
        MovieListLocal.MdiParent = Me
        MovieListLocal.Show()
    End Sub
End Class