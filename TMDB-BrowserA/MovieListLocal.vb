Imports System.Net.Http
Imports MySql.Data.MySqlClient


Public Class MovieListLocal
    Dim filmList As FilmList = New FilmList()
    Private Sub MovieListLocal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filmList.GetAllMovies()



    End Sub

    Private Async Sub btn_get_movies_Click(sender As Object, e As EventArgs) Handles btn_get_movies.Click
        'Membuat client untuk melakukan HTTP Request
        Dim client As HttpClient = New HttpClient()
        'API endpoint yang menyediakan data
        Dim url As String = "https://api.themoviedb.org/3/movie/now_playing?api_key=f71d911906b0a0157109443316cf77f8"
        'Await => tunggu sampai GetStringAsync selesai
        'Melakukan HTTP Get Request ke url
        Dim response = Await client.GetStringAsync(url)
        'Convert dari string menjadi Model GetMovieResponse
        Dim movieResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(Of GetMoviesResponse)(response)

        'Simpan movie ke sebuah variable
        Dim firstMovie = movieResponse.results(2)
        'Tampilkan info ke desktop app
        lbl_title.Text = firstMovie.title
        lbl_poster_path.Text = firstMovie.poster_path
        lbl_overview.Text = firstMovie.overview

        'Periksa apakah film dengan ID firstMove sudah ada di database atau tidak
        OpenConnection()
        Dim checkData As String = String.Format("Select * from films where id = {0}", firstMovie.id)
        CMD = New MySqlCommand(checkData, CONN)
        'Karena mau membaca ada berapa data, maka harus menggunakan ExecuteReader
        Dim result = CMD.ExecuteReader()
        'Selalu close connection sebelum menjalankan SQL command yang lain
        CloseConnection()

        'Periksa apakah result tidak memiliki data
        If (Not result.HasRows()) Then
            'Jika tidak memiliki data maka simpan ke DB
            OpenConnection()
            Dim simpanData As String = String.Format("Insert into films values (""{0}"", ""{1}"", ""{2}"", ""{3}"", ""{4}"")", firstMovie.id, firstMovie.title, firstMovie.release_date, firstMovie.poster_path, firstMovie.overview)
            CMD = New MySqlCommand(simpanData, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil disimpan")
            CloseConnection()
        Else
            'Jika duplikat, maka tampilkan pesan error
            MessageBox.Show("Data sudah ada")
        End If





    End Sub
End Class