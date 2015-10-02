Public Class Form1
    Dim op1 As Integer
    Dim op2 As Integer
    Dim resultado As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Sumabtn_Click(sender As Object, e As EventArgs) Handles Sumabtn.Click

        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)

        resultado = op1 + op2
        Label1.Text = resultado.ToString()




    End Sub

    Private Sub Restabtn_Click(sender As Object, e As EventArgs) Handles Restabtn.Click

        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)

        resultado = op1 - op2
        Label1.Text = resultado.ToString()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
