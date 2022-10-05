Public Class SplashScreen
    'Variable global untuk progress yang akan di update setiap interval
    Dim progress As Integer = 0

    'Fungsi yang dieksekusi setiap interval
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Dapatkan nilai progress yang baru
        Dim newProgress = progress + 1

        'Periksa apakah progress kurang dari atau sama dengan 100
        If (newProgress <= 100) Then
            ' update tulisan pada label
            lbl_percentage.Text = newProgress & "%"
            ' update progress bar value
            pb_loading.Value = newProgress
            ' update global variable progress supaya angkanya tidak 0 terus
            progress = newProgress
        Else
            ' kalau newProgress sudah lebih dari 100 maka timer stop
            Timer1.Stop()

            MovieListLocal.Show()
            Me.Hide()

        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set timer interval biar cepet
        Timer1.Interval = 100
        ' Jalankan timer saat form di load
        Timer1.Start()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
