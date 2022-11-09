Imports System.Net.Http
Imports MySql.Data.MySqlClient


Public Class MovieListLocal
    Dim filmList As FilmList = New FilmList()
    'Variable untuk menampung halaman yang akan di tarik datanya.
    'Halaman selalu mulai dari halaman 1
    Dim page As Integer = 1
    Private Sub MovieListLocal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filmList.GetAllMovies()
        Dim testFilm As Film = New Film()
        testFilm.title = "test film"
        testFilm.id = "randomid"
        testFilm.overview = "pokoknya overview ada petik 1 ' dan ada petik """
        testFilm.Save()
    End Sub

    Private Async Sub btn_sync_10_pages_movies_Click(sender As Object, e As EventArgs) Handles btn_sync_10_pages_movies.Click
        ' Lakukan sinkronisasi untuk halaman 1 sampai 10
        For pageIndex = 21 To 30
            page = pageIndex
            'Membuat client untuk melakukan HTTP Request
            Dim client As HttpClient = New HttpClient()
            'API endpoint yang menyediakan data dan akan mengambil data pada halaman tertentu sesuai nilai dari variable page
            Dim url As String = "https://api.themoviedb.org/3/movie/now_playing?api_key=f71d911906b0a0157109443316cf77f8&page=" & page
            'Await => tunggu sampai GetStringAsync selesai
            'Melakukan HTTP Get Request ke url
            Dim response = Await client.GetStringAsync(url)
            'Convert dari string menjadi Model GetMovieResponse
            Dim movieResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(Of GetMoviesResponse)(response)

            'Lakukan perulangan untuk setiap film
            For index = 0 To movieResponse.results.Length - 1
                'Simpan movie ke sebuah variable
                Dim firstMovie = movieResponse.results(index)
                'Tampilkan info ke desktop app
                lbl_title.Text = firstMovie.title
                lbl_poster_path.Text = firstMovie.poster_path
                lbl_overview.Text = firstMovie.overview

                'Periksa apakah result tidak memiliki data
                If (Not firstMovie.IsExistInDB()) Then
                    'Simpan data ke database
                    firstMovie.Save()
                Else
                    'Jika duplikat, maka tampilkan pesan error
                    'MessageBox.Show("Data ke " & index + 1 & " sudah ada")
                End If
            Next

        Next
    End Sub
End Class