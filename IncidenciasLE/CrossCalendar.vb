
Option Strict On
    Option Explicit On
Public Class CrossCalendar
    Inherits MonthCalendar

#Region "Variables"
    Private dayBoxWidth As Integer = 0
    Private dayBoxHeight As Integer = Me.FontHeight + 5
    Private xList As New List(Of Date)
    Private cross As String = "X"
    Private xFont As Font = New Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold, Me.Font.Unit)
#End Region

#Region "Custom Property"
    Private xColor As Color = Color.Red
    Public Property CrossColor As Color
        Get
            Return xColor
        End Get
        Set(ByVal value As Color)
            xColor = value
        End Set
    End Property

#End Region

#Region "Painting"
    '
    'Read this and you'll see why I used WndProc http://nickeandersson.blogs.com/blog/2006/05/_modifying_the_.html
    'Also, I couldn't have done most of this without the help of this thread: http://social.msdn.microsoft.com/Forums/en/winforms/thread/80dcfb01-fcba-461c-8532-3e2b713c1be4
    '

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)



        Dim g As Graphics = e.Graphics
        Dim dayBoxWidth As Integer = 0
        Dim dayBoxHeight As Integer = 0
        Dim firstWeekPosition As Integer = 0
        Dim lastWeekPosition As Integer = Height

        If xList.Count > 0 Then
            Dim calendarRange As SelectionRange = GetDisplayRange(False)
            Dim visibleXList As New List(Of Date)

            For Each dates As Date In xList
                If dates >= calendarRange.Start AndAlso dates <= calendarRange.[End] Then
                    visibleXList.Add(dates)
                End If
            Next

            If visibleXList.Count > 0 Then
                While (HitTest(25, firstWeekPosition).HitArea <> HitArea.PrevMonthDate AndAlso HitTest(25, firstWeekPosition).HitArea <> HitArea.[Date]) AndAlso firstWeekPosition < Height
                    firstWeekPosition += 1
                End While

                While (HitTest(25, lastWeekPosition).HitArea <> HitArea.NextMonthDate AndAlso HitTest(25, lastWeekPosition).HitArea <> HitArea.[Date]) AndAlso lastWeekPosition >= 0
                    lastWeekPosition -= 1
                End While

                If firstWeekPosition > 0 AndAlso lastWeekPosition > 0 Then
                    dayBoxWidth = CInt(Width / (If(ShowWeekNumbers, 8, 7)))
                    dayBoxHeight = CInt(CSng(lastWeekPosition - firstWeekPosition) / 6.0F)

                    Using warningBrush As Brush = New SolidBrush(xColor)

                        For Each visDate As DateTime In visibleXList
                            Dim row As Integer = 0
                            Dim col As Integer = 0

                            Dim span As New TimeSpan()
                            span = visDate.Subtract(calendarRange.Start)
                            row = CInt(span.Days \ 7)
                            col = span.Days Mod 7

                            Dim rect As New Rectangle((col + (If(ShowWeekNumbers, 1, 0))) * dayBoxWidth + 2, firstWeekPosition + row * dayBoxHeight + 1, dayBoxWidth - 2, dayBoxHeight - 2)
                            TextRenderer.DrawText(g, cross, xFont, rect, xColor)
                        Next

                    End Using
                End If
            End If
        End If

    End Sub

    Protected Shared WM_PAINT As Integer = &HF
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        If m.Msg = WM_PAINT Then
            Dim graphics__1 As Graphics = Graphics.FromHwnd(Me.Handle)
            Dim pe As New PaintEventArgs(graphics__1, New Rectangle(0, 0, Me.Width, Me.Height))
            OnPaint(pe)
        End If
    End Sub

#End Region

#Region "Adding and Removing Dates"

    Public Sub AddDate(ByVal dates As Date)
        If xList.Contains(dates) = False Then
            xList.Add(dates)
        End If
    End Sub

    Public Sub AddDateRange(ByVal dates() As Date)
        For Each dt As Date In dates
            If xList.Contains(dt) = False Then
                xList.Add(dt)
            End If
        Next
    End Sub

    Public Sub RemoveDate(ByVal dates As Date)
        If xList.Contains(dates) Then
            xList.Remove(dates)
        End If
    End Sub

#End Region
End Class

