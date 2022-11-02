Imports MySql.Data.MySqlClient

Public Class FilmList

    Dim films As Film()



    Sub GetAllMovies()
        Dim dataAdapter As MySqlDataAdapter
        DBConnection.OpenConnection()
        dataAdapter = New MySqlDataAdapter("select * from films", DBConnection.CONN)
        DBConnection.CloseConnection()

    End Sub
End Class
