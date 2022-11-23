Imports System.IO
Imports System.Net
Imports Google.Protobuf.WellKnownTypes

Public Class MovieDetail
    Private Sub MovieDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            ' Ganti nilai URL dengan url default
            url = "https://pandagila.com/wp-content/uploads/2020/08/error-404-not-found-288x180.jpg"
        End If
        ' Download data gambar dari url ke memory stream dan simpan sebagai bitmap
        Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(url)))
        ' Set picture box Image dengan bitmap yang telah terdownload
        pb_poster.Image = tImage
    End Sub
End Class