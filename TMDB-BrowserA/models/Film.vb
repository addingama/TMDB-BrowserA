Imports MySql.Data.MySqlClient

Public Class Film
    Public id As String
    Public title As String
    Public release_date As String
    Public poster_path As String
    Public overview As String

    Public Function IsExistInDB()
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
        Dim simpanData As String = String.Format("Insert into films values ('{0}', '{1}', '{2}', '{3}', '{4}')", id, escapedTitle, release_date, poster_path, escapedOverview)
        CMD = New MySqlCommand(simpanData, CONN)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Data film " & title & " berhasil disimpan")
        CloseConnection()
    End Sub
End Class
