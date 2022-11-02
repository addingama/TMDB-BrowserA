Public Class Film
    Public id As String
    Public title As String
    Public release_date As String
    Public poster_path As String
    Public overview As String

    Public Sub Save()
        DBConnection.OpenConnection()

        ' insert into films values(id, title, release_year, poster, description)

    End Sub
End Class
