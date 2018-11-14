Public Class Calendario
    Private Sub Calendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim i As New Incidencia(idIncid)
        'i.ObtenPlazo(idIncid)
        'Me.MonthCalendar1.AddBoldedDate(System.DateTime.Today.Add(i.PlazoDias))
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.CrossCalendar1.SelectionRange.Start <> System.DateTime.Today Then
            'MsgBox(DateDiff(DateInterval.Day, System.DateTime.Today, Me.CrossCalendar1.SelectionRange.Start).ToString)

            Dim i As New Incidencia(idIncid)
            i.ActualizaPlazo(idIncid, DateDiff(DateInterval.Day, System.DateTime.Today, Me.CrossCalendar1.SelectionRange.Start))

        Else
            Dim i As New Incidencia(idIncid)
            i.ActualizaPlazo(idIncid, 0)
        End If

        Me.Close()

    End Sub


End Class