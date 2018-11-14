Imports System.IO

Public Class Incidencia
    Private cId As Integer
    Private cAmbito As Integer
    Private cDescripcion As String
    Private cResolucion As String
    Private cFechaRegistro As Date
    Private cFechaResolucion As Date
    Private cPlazoDias As Integer
    Private cSolicitado As Boolean
    Private cWiki As Boolean
    Private cCentro As Integer
    Private cUsuario As Integer
    Private cAdjuntos As Boolean

    Public Property Id()
        Get
            Return cId
        End Get
        Set(value)
            cId = value
        End Set
    End Property

    Public Property Ambito()
        Get
            Return cAmbito
        End Get
        Set(value)
            cAmbito = value
        End Set
    End Property

    Public Property Descripcion()
        Get
            Return cDescripcion
        End Get
        Set(value)
            cDescripcion = value
        End Set
    End Property

    Public Property Resolucion()
        Get
            Return cResolucion
        End Get
        Set(value)
            cResolucion = value
        End Set
    End Property

    Public Property FechaRegistro()
        Get
            Return cFechaRegistro
        End Get
        Set(value)
            cFechaRegistro = value
        End Set
    End Property

    Public Property FechaResolucion()
        Get
            Return cFechaResolucion
        End Get
        Set(value)
            cFechaResolucion = value
        End Set
    End Property

    Public Property PlazoDias()
        Get
            Return cPlazoDias
        End Get
        Set(value)
            cPlazoDias = value
        End Set
    End Property

    Public Property Solicitado()
        Get
            Return cSolicitado
        End Get
        Set(value)
            cSolicitado = value
        End Set
    End Property

    Public Property Wiki()
        Get
            Return cWiki
        End Get
        Set(value)
            cWiki = value
        End Set
    End Property

    Public Property Centro()
        Get
            Return cCentro
        End Get
        Set(value)
            cCentro = value
        End Set
    End Property

    Public Property Usuario()
        Get
            Return cUsuario
        End Get
        Set(value)
            cUsuario = value
        End Set
    End Property

    Public Property Adjuntos()
        Get
            Return cAdjuntos
        End Get
        Set(value)
            cAdjuntos = value
        End Set
    End Property

    'Constructor con parametros
    Public Sub New(ByVal id As Integer, ByVal amb As Integer, ByVal desc As String, ByVal res As String, ByVal freg As Date, ByVal fres As Date, ByVal plazo As Integer, ByVal solic As Boolean, ByVal wiki As Boolean, ByVal cent As Integer, ByVal usu As Integer, ByVal adj As Boolean)
        cId = id
        cAmbito = amb
        cDescripcion = desc
        cResolucion = res
        cFechaRegistro = freg
        cFechaResolucion = fres
        cPlazoDias = plazo
        cSolicitado = solic
        cWiki = wiki
        cCentro = cent
        cUsuario = usu
        cAdjuntos = adj
    End Sub

    Public Sub New(ByVal id As Integer)
        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand

            sqlconn.ConnectionString = connString
            sqlconn.Open()
            sqlquery.Connection = sqlconn
            sqlquery.CommandText = "SELECT IdAmbito, Descripcion, Resolucion, FechaRegistro, FechaResolucion, PlazoDias, Solicitado, Wiki, IdCentro, IdUsuario, Adjuntos FROM Incidencias WHERE Id=" & id & ""

            cId = id
            Dim oledbReader As OleDb.OleDbDataReader = sqlquery.ExecuteReader()

            While oledbReader.Read
                cAmbito = oledbReader.Item(0)
                cDescripcion = oledbReader.Item(1)
                If oledbReader.IsDBNull(2) Then
                    cResolucion = ""
                Else
                    cResolucion = oledbReader.Item(2)
                End If

                cFechaRegistro = oledbReader.Item(3)
                cFechaResolucion = oledbReader.Item(4)
                cPlazoDias = oledbReader.Item(5)
                cSolicitado = oledbReader.Item(6)
                cWiki = oledbReader.Item(7)
                cCentro = oledbReader.Item(8)
                cUsuario = oledbReader.Item(9)
                cAdjuntos = oledbReader.Item(10)
            End While

            oledbReader.Close()
            sqlquery.Dispose()
            sqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub Inserta(ByVal incidencia As Incidencia)

        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand

            sqlconn.ConnectionString = connString
            sqlconn.Open()
            sqlquery.Connection = sqlconn
            sqlquery.CommandText = "INSERT INTO Incidencias(Id, IdAmbito, [Descripcion], [Resolucion], FechaRegistro, FechaResolucion, PlazoDias, Solicitado, Wiki, IdCentro, IdUsuario) VALUES(" & idIncid & ",'" & incidencia.Ambito & "',@descripcion, @resolucion,'" & incidencia.FechaRegistro & "','" & incidencia.FechaResolucion & "'," & incidencia.PlazoDias & "," & incidencia.Solicitado & "," & incidencia.Wiki & "," & incidencia.Centro & "," & incidencia.Usuario & ")"
            sqlquery.Parameters.AddWithValue("@descripcion", incidencia.Descripcion)
            sqlquery.Parameters.AddWithValue("@resolucion", incidencia.Resolucion)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub Actualiza(ByVal ambito As Integer, ByVal texto As String, ByVal resolucion As String, ByVal fechaCierre As Date, ByVal id As Integer, ByVal solicitado As Boolean,
                         ByVal wiki As Boolean, ByVal centro As Integer, ByVal usuario As Integer, ByVal adjuntos As Boolean)

        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand

            sqlconn.ConnectionString = connString
            sqlconn.Open()
            sqlquery.Connection = sqlconn
            sqlquery.CommandText = "UPDATE Incidencias SET IdAmbito=" & ambito & ", [Descripcion] =?, [Resolucion] = ?, FechaResolucion=#" & fechaCierre & "#, 
                                    Solicitado =" & solicitado & ", Wiki =" & wiki & ",IdCentro =" & centro & ", IdUsuario =" & usuario & ", Adjuntos =" & adjuntos & " WHERE Id=" & id & "" ''" & texto & "','" & resolucion.ToString & "'
            sqlquery.Parameters.AddWithValue("@p1", texto)
            sqlquery.Parameters.AddWithValue("@p2", resolucion)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub Borra(ByVal incidencia As Integer)
        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand

            sqlconn.ConnectionString = connString
            sqlconn.Open()
            sqlquery.Connection = sqlconn
            sqlquery.CommandText = "DELETE FROM Incidencias WHERE Id=" & Id & ""
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()

            'Borra el adjunto si es que tiene
            If Directory.Exists("\\192.168.1.3\c$\Informatica\IncidenciasLE\Adjuntos\" & idIncid) Then
                Directory.Delete("\\192.168.1.3\c$\Informatica\IncidenciasLE\Adjuntos\" & idIncid, recursive:=True)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub ActualizaPlazo(ByVal id As Integer, ByVal dias As Integer)

        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand

            sqlconn.ConnectionString = connString
            sqlconn.Open()
            sqlquery.Connection = sqlconn
            sqlquery.CommandText = "UPDATE Incidencias SET PlazoDias=" & dias & " WHERE Id=" & id & ""
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub ObtenPlazo(ByVal id As Integer)

        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand

            sqlconn.ConnectionString = connString
            sqlconn.Open()
            sqlquery.Connection = sqlconn
            sqlquery.CommandText = "SELECT PlazoDias FROM Incidencias WHERE Id=" & id & ""
            cPlazoDias = sqlquery.ExecuteScalar()
            'sqlquery.ExecuteNonQuery()
            sqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
