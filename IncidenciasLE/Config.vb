Public Class Config
    Private cDias1 As Integer
    Private cDias2 As Integer

    Public Property Dias1()
        Get
            Return cDias1
        End Get
        Set(value)
            cDias1 = value
        End Set
    End Property

    Public Property Dias2()
        Get
            Return cDias2
        End Get
        Set(value)
            cDias2 = value
        End Set
    End Property

    'Constructor con parametros
    Public Sub New()
        Try
            Dim sqlconn As New OleDb.OleDbConnection

            Dim da As OleDb.OleDbDataAdapter
            Dim ds As New DataSet
            Dim sql As String = Nothing

            sqlconn.ConnectionString = connString
            sqlconn.Open()

            sql = "SELECT Valor FROM Configuracion WHERE Parametro IN ('DiasAviso1', 'DiasAviso2')"

            da = New OleDb.OleDbDataAdapter(sql, sqlconn)
            da.Fill(ds, "Valor")

            cDias1 = ds.Tables(0).Rows(0).Item(0).ToString
            cDias2 = ds.Tables(0).Rows(1).Item(0).ToString

            sqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Public Sub ActualizaParametro(ByVal parametro As String, ByVal valor As Integer)

        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand

            sqlconn.ConnectionString = connString
            sqlconn.Open()
            sqlquery.Connection = sqlconn
            sqlquery.CommandText = "UPDATE Configuracion SET Valor=" & valor & " WHERE Parametro='" & parametro & "'"
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Function CargaParametro(ByVal parametro As String, ByVal valor As Integer)

        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand

            sqlconn.ConnectionString = connString
            sqlconn.Open()
            sqlquery.Connection = sqlconn
            sqlquery.CommandText = "SELECT Valor FROM Configuracion WHERE Parametro=" & parametro & ""
            'sqlquery.ExecuteNonQuery()
            Dim n As String
            n = CInt(sqlquery.ExecuteScalar())
            sqlconn.Close()
            Return (n)

        Catch ex As Exception
            Return 0
            MessageBox.Show(ex.Message)
        End Try

    End Function
End Class
