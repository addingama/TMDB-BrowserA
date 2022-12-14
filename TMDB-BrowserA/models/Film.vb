Imports System.Net.Http
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto

Public Class Film
    Public id As String
    Public title As String
    Public release_date As String
    Public poster_path As String
    Public overview As String
    Public poster() As Byte

    Public Function IsExistInDB() As Boolean
        'Periksa apakah film dengan ID yg ada pada model sudah ada di database atau tidak
        OpenConnection()
        Dim checkData As String = String.Format("Select * from films where id = ""{0}""", id)
        CMD = New MySqlCommand(checkData, CONN)
        'Karena mau membaca ada berapa data, maka harus menggunakan ExecuteReader
        Dim result = CMD.ExecuteReader()
        'Selalu close connection sebelum menjalankan SQL command yang lain
        Dim isExist = result.HasRows()
        CloseConnection()

        Return isExist
    End Function
    Public Sub Save()
        'Jika tidak memiliki data maka simpan ke DB
        OpenConnection()
        'Mengkonversi tanda ' menjadi \' agar SQL valid
        Dim escapedOverview = overview.Replace("'", "\'")
        Dim escapedTitle = title.Replace("'", "\'")
        Dim simpanData As String = String.Format("Insert into films values ('{0}', '{1}', '{2}', '{3}', '{4}', null)", id, escapedTitle, release_date, poster_path, escapedOverview)
        CMD = New MySqlCommand(simpanData, CONN)
        CMD.ExecuteNonQuery()
        'MessageBox.Show("Data film " & title & " berhasil disimpan")
        CloseConnection()
    End Sub

    Public Function GetFilmDetail(ByVal id As String) As Film
        'Periksa apakah film dengan ID yg ada pada model sudah ada di database atau tidak
        OpenConnection()
        Dim checkData As String = String.Format("Select * from films where id = ""{0}""", id)
        CMD = New MySqlCommand(checkData, CONN)
        'Karena mau membaca ada berapa data, maka harus menggunakan ExecuteReader
        Dim result = CMD.ExecuteReader()
        Dim film = New Film()
        If (result.HasRows()) Then
            film.title = result.GetValue(1)
        End If

        CloseConnection()
        Return film
    End Function

    Public Sub SavePosterToDb(ByVal photo() As Byte)
        OpenConnection()
        Try

            'Sql command dengan menggunakan nama alias/parameter, nanti datanya di addWithValue di bawah
            Dim sql = "UPDATE films SET poster = @Poster where id = @FilmId"
            CMD = New MySqlCommand
            With CMD
                .Connection = CONN
                .CommandText = sql
                .Parameters.AddWithValue("@Poster", photo)
                .Parameters.AddWithValue("@FilmId", Me.id)
                .ExecuteNonQuery()
            End With


        Catch ex As Exception
            MessageBox.Show("Maaf error")
        End Try
        CloseConnection()
    End Sub

    Public Async Sub GetMovieDetail()
        'Membuat client untuk melakukan HTTP Request
        Dim client As HttpClient = New HttpClient()
        'API endpoint yang menyediakan data dan akan mengambil data pada halaman tertentu sesuai nilai dari variable page
        Dim url As String = "https://api.themoviedb.org/3/movie/" & id & "?region=US&api_key=f71d911906b0a0157109443316cf77f8"
        'Await => tunggu sampai GetStringAsync selesai
        'Melakukan HTTP Get Request ke url
        Dim response = Await client.GetStringAsync(url)
        'Convert dari string menjadi Model GetMovieResponse
        Dim movieResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(Of FilmDetail)(response)

        If (movieResponse.production_companies.Length > 0) Then
            For Each company As Company In movieResponse.production_companies
                If Not company.IsExistInDB() Then
                    company.Save()
                End If

                Dim pr As New ProductionCompany
                pr.film_id = movieResponse.id
                pr.company_id = company.id
                If Not pr.IsExistInDB() Then
                    pr.Save()
                End If

            Next

        Else
            MessageBox.Show("Tidak ada perusahaannya")
        End If
    End Sub
End Class
