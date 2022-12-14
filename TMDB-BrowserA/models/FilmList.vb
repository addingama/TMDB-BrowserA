Imports MySql.Data.MySqlClient

Public Class FilmList

    Dim films As Film()



    ' Mengambil data dari database dan mengembalikan dalam bentuk array/list
    Function GetAllMovies() As List(Of Film)
        Dim movieList = New List(Of Film)
        DBConnection.OpenConnection()
        Dim query = "SELECT id, title, poster_path, release_date, overview, poster FROM films order by release_date DESC"
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
            Dim poster = reader.GetValue(5)
            'Karena data NULL dari db, jadi cek nya agak berbeda
            If Not DBNull.Value.Equals(poster) Then
                film.poster = poster
            End If

            movieList.Add(film)
        End While

        DBConnection.CloseConnection()
        Return movieList
    End Function

    Function SearchMovie(keyword As String) As List(Of Film)
        Dim movieList = New List(Of Film)
        DBConnection.OpenConnection()
        Dim sql = "select * from films where title like '%" & keyword & "%'"
        CMD = New MySqlCommand
        With CMD
            .Connection = CONN
            .CommandText = sql
            .ExecuteNonQuery()
        End With
        Dim reader = CMD.ExecuteReader()
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
            Dim poster = reader.GetValue(5)
            'Karena data NULL dari db, jadi cek nya agak berbeda
            If Not DBNull.Value.Equals(poster) Then
                film.poster = poster
            End If

            movieList.Add(film)
        End While

        DBConnection.CloseConnection()
        Return movieList
    End Function
End Class
