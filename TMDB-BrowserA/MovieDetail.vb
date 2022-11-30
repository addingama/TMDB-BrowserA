Imports System.IO
Imports System.Net
Imports Google.Protobuf.WellKnownTypes

Public Class MovieDetail
    Private Sub MovieDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Flag untuk mengetahui apakah harus di simpan atau tidak
        'Default nya semua gambar di simpan
        Dim savePosterToDb = True

        'Membaca global variable selectedMovie dari form MovieListLocal
        Dim selectedFilm As Film = MovieListLocal.selectedMovie

        'Update tulisan
        lbl_title.Text = selectedFilm.title
        lbl_overview.Text = selectedFilm.overview
        lbl_poster_path.Text = selectedFilm.poster_path

        ' Update judul form
        Me.Text = "Detail Film: " & selectedFilm.title

        ' Buat client untuk download gambar dari URL
        Dim tClient As WebClient = New WebClient
        ' Default url adalah nilai dari poster_path
        Dim url = selectedFilm.poster_path
        ' Jika poster_path kosong
        If url Is Nothing Then
            ' Tidak perlu simpan gambar 404
            savePosterToDb = False
            ' Ganti nilai URL dengan url default
            url = "https://pandagila.com/wp-content/uploads/2020/08/error-404-not-found-288x180.jpg"
        End If

        ' Jika poster kosong
        If (selectedFilm.poster Is Nothing) Then
            ' Download data gambar dari url ke memory stream dan simpan sebagai bitmap
            Dim memoryStream = New MemoryStream(tClient.DownloadData(url))
            Dim tImage As Bitmap = Bitmap.FromStream(memoryStream)
            ' Simpan data array poster ke db
            selectedFilm.SavePosterToDb(memoryStream.ToArray)
            'Update daftar movies yang ada di MovieListLocal agar tidak perlu download poster lagi
            MovieListLocal.movies = MovieListLocal.filmList.GetAllMovies()
            ' Set picture box Image dengan bitmap yang telah terdownload
            pb_poster.Image = tImage

            'komentar
        Else
            'Jika ada data poster di db, load datanya ke memory stream
            Dim memoryStream = New MemoryStream(selectedFilm.poster)
            'Ubah memory stream menjadi bitmat
            Dim tImage As Bitmap = Bitmap.FromStream(memoryStream)
            'Set picturebox image menggunakan image tersebut
            pb_poster.Image = tImage
        End If

    End Sub
End Class