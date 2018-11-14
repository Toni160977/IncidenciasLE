Imports System.IO
Public Class FormIncidencia
    Dim tieneAdjunto As Boolean = False

    Private Sub FormIncidencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dsDatos As New DataSet

        dsDatos = CargaDatosCombo("Ambito")
        ComboBox1.DataSource = dsDatos.Tables(0)
        ComboBox1.ValueMember = "Id"
        ComboBox1.DisplayMember = "Descripcion"

        dsDatos = CargaDatosCombo("Centros")
        ComboBox2.DataSource = dsDatos.Tables(0)
        ComboBox2.ValueMember = "IdCentro"
        ComboBox2.DisplayMember = "Descripcion"

        dsDatos = CargaDatosCombo("Usuarios")
        ComboBox3.DataSource = dsDatos.Tables(0)
        ComboBox3.ValueMember = "IdUsuario"
        ComboBox3.DisplayMember = "Descripcion"

        If CompruebaAdjuntos(idIncid) = True Then
            Me.Button3.BackColor = Color.Cyan
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim adjuntos As Boolean = False
        If Me.Button3.BackColor = Color.Cyan Then
            adjuntos = True
        End If

        If nuevaIncid = True Then '  idIncid = 0 Then
            ObtenMaxIdIncidencia()
            If Me.CheckBox2.Checked = True Then
                Dim incidencia As New Incidencia(idIncid, Me.ComboBox1.SelectedIndex + 1, Me.TextBox1.Text, Me.TextBox2.Text, System.DateTime.Today, System.DateTime.Today, Nothing, Me.CheckBox1.Checked, Me.CheckBox3.Checked, Me.ComboBox2.SelectedIndex, Me.ComboBox3.SelectedIndex + 1, adjuntos)
                incidencia.Inserta(incidencia)
            Else
                Dim incidencia As New Incidencia(idIncid, Me.ComboBox1.SelectedIndex + 1, Me.TextBox1.Text, Me.TextBox2.Text, System.DateTime.Today, CDate("01/01/1900"), Nothing, Me.CheckBox1.Checked, Me.CheckBox3.Checked, Me.ComboBox2.SelectedIndex, Me.ComboBox3.SelectedIndex + 1, adjuntos)
                incidencia.Inserta(incidencia)
            End If

            Me.Close()

        Else
            If Me.CheckBox2.Checked = True Then
                Dim incidencia As New Incidencia(idIncid, Me.ComboBox1.SelectedIndex + 1, Me.TextBox1.Text, Me.TextBox2.Text, System.DateTime.Today, System.DateTime.Today, Nothing, Me.CheckBox1.Checked, Me.CheckBox3.Checked, Me.ComboBox2.SelectedIndex, Me.ComboBox3.SelectedIndex + 1, adjuntos)
                incidencia.Actualiza(Me.ComboBox1.SelectedIndex + 1, Me.TextBox1.Text, Me.TextBox2.Text, System.DateTime.Today, idIncid, Me.CheckBox1.Checked, Me.CheckBox3.Checked, Me.ComboBox2.SelectedIndex, Me.ComboBox3.SelectedIndex + 1, adjuntos)
            Else
                Dim incidencia As New Incidencia(idIncid, Me.ComboBox1.SelectedIndex + 1, Me.TextBox1.Text, Me.TextBox2.Text, System.DateTime.Today, CDate("01/01/1900"), Nothing, Me.CheckBox1.Checked, Me.CheckBox3.Checked, Me.ComboBox2.SelectedIndex, Me.ComboBox3.SelectedIndex + 1, adjuntos)
                incidencia.Actualiza(Me.ComboBox1.SelectedIndex + 1, Me.TextBox1.Text, Me.TextBox2.Text, CDate("01/01/1900"), idIncid, Me.CheckBox1.Checked, Me.CheckBox3.Checked, Me.ComboBox2.SelectedIndex, Me.ComboBox3.SelectedIndex + 1, adjuntos)
            End If

            Me.Close()
        End If
        CargaDatosGrid(activeTab, Form1.ComboBox1.SelectedIndex + 1, Form1.CheckBox1.Checked, Form1.ComboBox2.SelectedIndex, usuario, "") 'Form1.CheckBox3.Checked,
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cal As New Calendario()
        cal.Show()
        Dim i As New Incidencia(idIncid)
        i.ObtenPlazo(idIncid)
        Dim ArrayFechas() As Date = New Date() {"#" & System.DateTime.Today.AddDays(i.PlazoDias) & "#"}
        'Dim fechaplazo As Date = System.DateTime.Today.AddDays(i.PlazoDias)
        cal.CrossCalendar1.AddDate(System.DateTime.Today.AddDays(i.PlazoDias))
        ' cal.MonthCalendar1.BoldedDates = ArrayFechas

    End Sub

    Private Function CompruebaAdjuntos(ByVal incidencia As Integer)
        If Directory.Exists("\\192.168.1.3\c$\Informatica\IncidenciasLE\Adjuntos\" & incidencia) Then
            tieneAdjunto = True
        End If
        Return tieneAdjunto
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'If tieneAdjunto = True Then
        'Process.Start("\\192.168.1.2\Informatica\IncidenciasLE\Adjuntos\" & idIncid)
        'Else
        'End If
        Dim i As New Adjuntos()
        i.Show()

    End Sub


    'Private Sub HighlightDates()  'Draw Borders Around Dates
    '    Dim gMonthCalendar As Graphics = MonthCalendar1.CreateGraphics()   'Enable Drawing Capabilities
    '    Dim oHTIMonths As MonthCalendar.HitTestInfo   'Get HitTestInfo
    '    Dim arrDates As New ArrayList()   'ArrayList For Dates
    '    For intRows As Integer = 1 To MonthCalendar1.Size.Width - 1   'Loop Through Width ( Rows )
    '        For intCols As Integer = 1 To MonthCalendar1.Size.Height - 1   'Loop Through Columns
    '            oHTIMonths = MonthCalendar1.HitTest(intRows, intCols)   'Get Hit Info
    '            If oHTIMonths.HitArea = MonthCalendar.HitArea.Date Then   'Is It A Date That Was Clicked On?
    '                If Not arrDates.Contains(oHTIMonths.Time) Then
    '                    arrDates.Add(oHTIMonths.Time)
    '                    gMonthCalendar.DrawRectangle(New Pen(Brushes.Blue, 2), intRows, intCols, 24, 15)   'Draw Rectangle Around
    '                End If
    '            End If
    '        Next intCols
    '    Next intRows
    'End Sub

End Class