Public Class Form1

    Public media As Decimal

    Public Sub Clean()
        Result1.Text = ""
        Result2.Text = ""
        Result3.Text = ""
        Result4.Text = ""
        Result5.Text = ""
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click



        If Result1.Text = "" Or Result2.Text = "" Or Result3.Text = "" Or Result4.Text = "" Or Result5.Text = "" Then

            MessageBox.Show("Preencha todos os campos")
            Clean()


        ElseIf Double.Parse(Result5.Text) = 0 Then
            MessageBox.Show("Você foi desclassificado pela nota da redação")
            Clean()


        ElseIf Double.Parse(Result5.Text) > 0 Then
            media = (Double.Parse(Result1.Text) + Double.Parse(Result4.Text) + Double.Parse(Result2.Text) + Double.Parse(Result3.Text) + Double.Parse(Result5.Text)) / 5

            MessageBox.Show("Sua média foi de: " & media & vbCrLf &
                             "-----------------------------" & vbCrLf &
                             " Média brasileira = 530")
            Clean()

            End If










    End Sub
End Class
