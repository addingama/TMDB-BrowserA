Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Policy
Imports MySql.Data.MySqlClient


Public Class MovieListLocal
    Public filmList As FilmList = New FilmList()

    ' Global variable untuk menampung daftar film
    Public movies As List(Of Film)
    ' Global variable untuk menampung data film yang di double click di DataGridView
    Public selectedMovie As Film

    Public Sub UpdateDataGrid()
        dgv_movie_list.Rows.Clear()

        For Each movie As Film In movies
            'Buat array dari string sebanyak kolom yang ada dan beri nilai yang sesuai
            Dim row() As String = {movie.title, movie.overview}
            'Tambahkan baris tersebut ke DataGridView
            dgv_movie_list.Rows.Add(row)
        Next
    End Sub

    Private Sub MovieListLocal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Konfigurasi DataGridView
        With dgv_movie_list
            .ColumnCount = 2
            .RowTemplate.Height = 44 'Setting tinggi baris
            .Columns(0).Name = "Title"
            .Columns(0).Width = 120 'Setting lebar kolom tertentu
            .Columns(1).Name = "Overview"
        End With
        'Ambil semua film yang ada di database local
        movies = filmList.GetAllMovies()
        UpdateDataGrid()




        'Dim imageUrl = "https://plus.unsplash.com/premium_photo-1669018128972-d43d65810fa4?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&h=150&q=80"

        'Dim tClient As WebClient = New WebClient
        'Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(imageUrl)))


        'dgv_movie_list.RowTemplate.Height = 150
        'dgv_movie_list.Rows.Add(tImage)

        'With dgv_movie_list
        '    .ColumnCount = 2
        '    .Columns(0).Name = "Poster"
        '    .Columns(0).DataPropertyName = "Film.poster_path"
        '    .Columns(1).Name = "Title"
        '    .Columns(1).DataPropertyName = "Film.title"
        'End With

        'Dim films = filmList.GetAllMovies()

        'For Each item As Film In films
        '    dgv_movie_list.Rows.Add(item)

        'Next

    End Sub

    Private Async Sub btn_sync_Click(sender As Object, e As EventArgs) Handles btn_sync.Click
        ' Lakukan sinkronisasi untuk halaman 1 sampai 10
        For pageIndex = 1 To 10
            'Membuat client untuk melakukan HTTP Request
            Dim client As HttpClient = New HttpClient()
            'API endpoint yang menyediakan data dan akan mengambil data pada halaman tertentu sesuai nilai dari variable page
            Dim url As String = "https://api.themoviedb.org/3/movie/now_playing?region=ID&api_key=f71d911906b0a0157109443316cf77f8&page=" & pageIndex
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
                'lbl_title.Text = firstMovie.title
                'lbl_poster_path.Text = firstMovie.poster_path
                'lbl_overview.Text = firstMovie.overview

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

    Private Sub dgv_movie_list_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_movie_list.CellContentClick

    End Sub

    Private Sub dgv_movie_list_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_movie_list.CellContentDoubleClick
        ' Update global variable dengan data film yang terpilih agar bisa di akses oleh Fom lain
        selectedMovie = movies(e.RowIndex)
        ' Tutup form dulu jika terbuka
        MovieDetail.Close()
        MovieDetail.MdiParent = ParentForm
        ' Buka form MovieDetail
        MovieDetail.Show()

    End Sub

    Private Sub tb_search_TextChanged(sender As Object, e As EventArgs) Handles tb_search.TextChanged
        movies = filmList.SearchMovie(tb_search.Text)
        UpdateDataGrid()
    End Sub
End Class