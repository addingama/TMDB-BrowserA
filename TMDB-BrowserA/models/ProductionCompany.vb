Imports MySql.Data.MySqlClient

Public Class ProductionCompany
    Public id As Integer
    Public film_id As String
    Public company_id As Integer

    Public Sub Save()
        'Jika tidak memiliki data maka simpan ke DB
        OpenConnection()
        Dim simpanData As String = String.Format("Insert into production_companies values ({0}, '{1}', {2})", id, film_id, company_id)
        CMD = New MySqlCommand(simpanData, CONN)
        CMD.ExecuteNonQuery()
        'MessageBox.Show("Data film " & title & " berhasil disimpan")
        CloseConnection()
    End Sub

    Public Function IsExistInDB() As Boolean
        'Periksa apakah film dengan ID yg ada pada model sudah ada di database atau tidak
        OpenConnection()
        Dim checkData As String = String.Format("Select * from production_companies where film_id = ""{0}"" and company_id = {1}", film_id, company_id)
        CMD = New MySqlCommand(checkData, CONN)
        'Karena mau membaca ada berapa data, maka harus menggunakan ExecuteReader
        Dim result = CMD.ExecuteReader()
        'Selalu close connection sebelum menjalankan SQL command yang lain
        Dim isExist = result.HasRows()
        CloseConnection()

        Return isExist
    End Function
End Class
