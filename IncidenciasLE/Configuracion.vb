Public Class Configuracion
    Private Sub Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conf As New Config()
        Me.TextBox1.Text = conf.Dias1
        Me.TextBox2.Text = conf.Dias2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conf As New Config()
        conf.ActualizaParametro("DiasAviso1", CInt(Me.TextBox1.Text))
        conf.ActualizaParametro("DiasAviso2", CInt(Me.TextBox2.Text))
        Me.Close()
    End Sub
End Class