Public Class Form1
    Private Sub btnCifrar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtTexto.Text = ""
        txtCifrado.Text = ""
        txtimprimir.Text = ""
        Txt8.Text = ""
        Timer1.Stop()
        ProgressBar1.Value = 0
        Label4.Visible = False
        Label5.Text = " o%"
    End Sub


    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click

        txt10.Text = ("5632")
        txt10.Text = ("4567")


        txtimprimir.Text = ("0" & txtCifrado.Text)
    End Sub

    Private Sub txtTexto_TextChanged(sender As Object, e As EventArgs) Handles txtTexto.TextChanged

        Dim text1 = txtTexto.Text
        Dim md5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim bytes() As Byte = md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(text1))
        Dim s As String
        For Each i As Byte In bytes
            'controla la velocidad y capacidad del hash'
            s &= i.ToString("x2")
            Timer1.Start()
            Label4.Visible = False
            Dim size As Integer
            Dim nonce1 As New Nonce(size)


        Next
        txtCifrado.Text = s
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Label4.Visible = True
            Label5.Visible = True


        End If
        Label5.Text = ProgressBar1.Value & (" %")
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txt10_TextChanged(sender As Object, e As EventArgs) Handles txt10.TextChanged


    End Sub
End Class
