
Module Module1
    Public idIncid As Integer
    Public nuevaIncid = True
    Public activeTab As String
    Public usuario As Integer = 0
    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\192.168.1.3\c$\Informatica\IncidenciasLE\Incidencias - copia.accdb"
    '"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Inidencias.accdb"

    Public Function CargaConfiguracion(ByVal parametro As String)
        Dim connection As New OleDb.OleDbConnection
        Dim cmd As OleDb.OleDbCommand = Nothing
        Dim sql As String = Nothing

        sql = "SELECT Valor FROM Configuracion WHERE Parametro ='" & parametro & "'"
        Try
            cmd = New OleDb.OleDbCommand(sql, connection)
            connection.ConnectionString = connString
            connection.Open()
            Dim n As Integer
            n = CInt(cmd.ExecuteScalar())
            connection.Close()
            Return (n)
        Catch ex As Exception
            MessageBox.Show("No se puede abrir la conexión!")
            Return 0
        Finally
            If connection IsNot Nothing AndAlso connection.State <> ConnectionState.Closed Then
                connection.Close()
            End If
        End Try


    End Function

    Public Function CargaDatosCombo(ByVal combo As String)
        If combo <> "" Then
            Dim connection As New OleDb.OleDbConnection
            Dim da As OleDb.OleDbDataAdapter
            Dim ds As New DataSet
            Dim i As Integer = 0
            Dim sql As String = Nothing

            sql = "Select * from " & combo

            Try
                connection.ConnectionString = connString
                connection.Open()
                da = New OleDb.OleDbDataAdapter(sql, connection)
                da.Fill(ds, "Ambito")
                connection.Close()
                Return (ds)
            Catch ex As Exception
                MessageBox.Show("No se puede abrir la conexión!")
                Return 0
            End Try
        Else
            Return ""
        End If
    End Function

    Public Sub CargaDatosGrid(ByVal grid As String, ByVal ambito As Integer, ByVal solicitado As Boolean, ByVal centro As Integer, ByVal usuario As Integer, ByVal contiene As String) 'ByVal wiki As Boolean,
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connString

        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String
        Dim textofiltro As String = ""
        Dim textofiltro2 As String = contiene

        If solicitado.Equals(True) Then
            textofiltro = " AND Solicitado = " & solicitado & ""
        Else
            textofiltro = ""
        End If

        'If wiki.Equals(True) Then
        'textofiltro = " AND Wiki = " & wiki & ""
        'Else
        'textofiltro = ""
        'End If

        If centro > 0 Then
            textofiltro = textofiltro & " AND IdCentro = " & centro & ""
        Else
            textofiltro = textofiltro & ""
        End If

        If usuario <> 0 Then
            textofiltro = textofiltro & " AND IdUsuario = " & usuario & ""
        Else
            textofiltro = textofiltro & ""
        End If


        If grid = "TabAbiertas" Then
            Try
                con.Open()
                Select Case ambito
                    Case <= 1
                        sql = "SELECT * FROM Incidencias WHERE FechaResolucion = #01/01/1900 0:00:00# " & textofiltro & textofiltro2 & " ORDER BY Id ASC" 'and (Descripcion LIKE '%ex%' or Resolucion LIKE '%ex%')
                    Case Else
                        sql = "SELECT * FROM Incidencias WHERE IdAmbito = " & ambito & " and FechaResolucion=#01/01/1900#" & textofiltro & textofiltro2 & " ORDER BY Id ASC"
                End Select

                adapter.SelectCommand = New OleDb.OleDbCommand(sql, con)
                adapter.Fill(ds, "Abiertas")
                Form1.dgAbiertas.DataSource = ds.Tables(0)
                con.Close()

            Catch
                MessageBox.Show("No se puede abrir la conexión!")
            End Try

        ElseIf grid = "TabCerradas" Then
            Try
                con.Open()
                Select Case ambito
                    Case <= 1
                        sql = "SELECT * FROM Incidencias WHERE FechaResolucion <> #01/01/1900 0:00:00#" & textofiltro & textofiltro2 & " ORDER BY Id ASC"
                    Case Else
                        sql = "SELECT * FROM Incidencias WHERE IdAmbito = " & ambito & " and FechaResolucion<>#01/01/1900#" & textofiltro & textofiltro2 & " ORDER BY Id ASC"
                End Select

                adapter.SelectCommand = New OleDb.OleDbCommand(sql, con)
                adapter.Fill(ds, "Cerradas")
                Form1.dgCerradas.DataSource = ds.Tables(0)
                con.Close()

            Catch
                MessageBox.Show("No se puede abrir la conexión!")
            End Try

        Else
            Try
                con.Open()
                Select Case ambito
                    Case <= 1
                        sql = "SELECT * FROM Incidencias WHERE FechaResolucion >= #01/01/1900 0:00:00# and Wiki=True" & textofiltro & textofiltro2 & " ORDER BY Id ASC" 'La fecha da igual pero no se puede quitar de la query por los filtros
                    Case Else
                        sql = "SELECT * FROM Incidencias WHERE IdAmbito = " & ambito & " and FechaResolucion>=#01/01/1900 0:00:00# and Wiki=True" & textofiltro & textofiltro2 & " ORDER BY Id ASC" 'La fecha da igual pero no se puede quitar de la query por los filtros
                End Select

                adapter.SelectCommand = New OleDb.OleDbCommand(sql, con)
                adapter.Fill(ds, "Wiki")
                Form1.dgWiki.DataSource = ds.Tables(0)
                con.Close()

            Catch
                MessageBox.Show("No se puede abrir la conexión!")
            End Try
        End If

    End Sub

    Public Sub ObtenMaxIdIncidencia()
        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand

            sqlconn.ConnectionString = connString
            sqlconn.Open()
            sqlquery.Connection = sqlconn
            sqlquery.CommandText = "SELECT MAX(Id) FROM Incidencias"
            idIncid = sqlquery.ExecuteScalar() + 1

            'sqlquery.ExecuteNonQuery()
            sqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Module
