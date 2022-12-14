Imports MySql.Data.MySqlClient

Public Class Company
    Public id As Integer
    Public name As String
    Public logo_path As String
    Public origin_country As String

    Public Sub Save()
        'Jika tidak memiliki data maka simpan ke DB
        OpenConnection()
        'Mengkonversi tanda ' menjadi \' agar SQL valid
        Dim nama = name.Replace("'", "\'")
        Dim simpanData As String = String.Format("Insert into companies values ({0}, '{1}', '{2}', '{3}')", id, nama, logo_path, origin_country)
        CMD = New MySqlCommand(simpanData, CONN)
        CMD.ExecuteNonQuery()
        CloseConnection()
    End Sub

    Public Function IsExistInDB() As Boolean
        'Periksa apakah company dengan ID yg ada pada model sudah ada di database atau tidak
        OpenConnection()
        Dim checkData As String = String.Format("Select * from companies where id = ""{0}""", id)
        CMD = New MySqlCommand(checkData, CONN)
        'Karena mau membaca ada berapa data, maka harus menggunakan ExecuteReader
        Dim result = CMD.ExecuteReader()
        'Selalu close connection sebelum menjalankan SQL command yang lain
        Dim isExist = result.HasRows()
        CloseConnection()

        Return isExist
    End Function
End Class
