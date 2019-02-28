Public Class Form1
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles numero3.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ponto.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles subtracao.Click


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles numero0.Click

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles numero2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles adi.Click
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles iqual.Click
    End Sub


    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles div.Click
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles numero6.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles back.Click
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles numero1.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles numero0.Click, numero1.Click, numero2.Click, numero3.Click, numero4.Click, numero5.Click, numero6.Click, numero7.Click, numero8.Click, numero9.Click, ponto.Click, back.Click, div.Click, iqual.Click, multi.Click, adi.Click, subtracao.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "numero1" Then

            TextBox1_Text.Text = TextBox1_Text.Text + "1"
        End If

        If button.Name = "numero2" Then

            TextBox1_Text.Text = TextBox1_Text.Text + "2"
        End If

        If button.Name = "numero3" Then

            TextBox1_Text.Text = TextBox1_Text.Text + "3"
        End If

        If button.Name = "numero4" Then

            TextBox1_Text.Text = TextBox1_Text.Text + "4"
        End If

        If button.Name = "numero5" Then

            TextBox1_Text.Text = TextBox1_Text.Text + "5"
        End If

        If button.Name = "numero6" Then

            TextBox1_Text.Text = TextBox1_Text.Text + "6"
        End If

        If button.Name = "numero7" Then

            TextBox1_Text.Text = TextBox1_Text.Text + "7"
        End If

        If button.Name = "numero8" Then

            TextBox1_Text.Text = TextBox1_Text.Text + "8"
        End If

        If button.Name = "numero9" Then

            TextBox1_Text.Text = TextBox1_Text.Text + "9"
        End If

        If button.Name = "numero0" Then

            TextBox1_Text.Text = TextBox1_Text.Text + "0"
        End If

        If button.Name = "ponto" Then

            TextBox1_Text.Text = TextBox1_Text.Text + "."
        End If

        If button.Name = "iqual" Then
            Dim equation As String = TextBox1_Text.Text
            Dim result = New DataTable().Compute(equation, Nothing)
            TextBox1_Text.Text = result
        End If

        If button.Name = "multi" Then

            TextBox1_Text.Text = TextBox1_Text.Text + "*"
        End If

        If button.Name = "div" Then

            TextBox1_Text.Text = TextBox1_Text.Text + "/"
        End If

        If button.Name = "adi" Then

            TextBox1_Text.Text = TextBox1_Text.Text + "+"
        End If

        If button.Name = "subtracao" Then

            TextBox1_Text.Text = TextBox1_Text.Text + "-"
        End If

        If button.Name = "back" Then

            TextBox1_Text.Text = ""
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles numero4.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles numero9.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles numero7.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles numero8.Click

    End Sub

    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1_Text.TextChanged

    End Sub
End Class
