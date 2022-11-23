Imports MySql.Data.MySqlClient

Public Class FilmList

    Dim films As Film()



    ' Mengambil data dari database dan mengembalikan dalam bentuk array/list
    Function GetAllMovies() As List(Of Film)
        Dim movieList = New List(Of Film)
        DBConnection.OpenConnection()
        Dim query = "SELECT id, title, poster_path, release_date, overview FROM films order by release_date DESC"
        Dim command = New MySqlCommand(query, CONN)
        Dim reader = command.ExecuteReader()
        While reader.Read()
            Dim film = New Film()
            film.id = reader.GetValue(0)
            film.title = reader.GetValue(1)
            Dim posterPath = reader.GetValue(2)
            If (posterPath IsNot "") Then
                film.poster_path = "https://image.tmdb.org/t/p/original" & posterPath
            End If

            film.release_date = reader.GetValue(3)
            film.overview = reader.GetValue(4)
            movieList.Add(film)
        End While

        DBConnection.CloseConnection()
        Return movieList
    End Function
End Class
