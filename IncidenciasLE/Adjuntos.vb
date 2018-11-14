Imports System.IO
Imports System.Runtime.InteropServices
Public Class Adjuntos

    Dim rutaAdjuntos As String = "\\192.168.1.3\c$\Informatica\IncidenciasLE\Adjuntos\" & idIncid

    Private Structure SHFILEINFO 'Contains information about a file object

        Public hIcon As IntPtr            'Icon
        Public iIcon As Integer           'Icondex
        Public dwAttributes As Integer    'SFGAO_ flags
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)>
        Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)>
        Public szTypeName As String

    End Structure

    Private Declare Auto Function SHGetFileInfo Lib "shell32.dll" _
            (ByVal pszPath As String,
             ByVal dwFileAttributes As Integer,
             ByRef psfi As SHFILEINFO,
             ByVal cbFileInfo As Integer,
             ByVal uFlags As Integer) As IntPtr 'Retrieves information about an object in the file system, such as a file, folder, directory, or drive root

    Private Const SHGFI_ICON = &H100 'Icon
    Private Const SHGFI_SMALLICON = &H1 'Small Icon
    Private Const SHGFI_LARGEICON = &H0    ' Large icon

    Private Const MAX_PATH = 260 'Path to Icon

    Private Sub AddImages(ByVal strFileName As String)

        Try

            Dim shInfo As SHFILEINFO 'Create File Info Object
            shInfo = New SHFILEINFO() 'Instantiate File Info Object
            shInfo.szDisplayName = New String(vbNullChar, MAX_PATH) 'Get Display Name
            shInfo.szTypeName = New String(vbNullChar, 80) 'Get File Type
            Dim hIcon As IntPtr 'Get File Type Icon Based On File Association
            hIcon = SHGetFileInfo(strFileName, 0, shInfo, Marshal.SizeOf(shInfo), SHGFI_ICON Or SHGFI_SMALLICON)
            Dim MyIcon As Drawing.Bitmap 'Create icon
            MyIcon = Drawing.Icon.FromHandle(shInfo.hIcon).ToBitmap 'Set Icon
            ImageList1.Images.Add(strFileName.ToString(), MyIcon) 'Add To ListView FileNames

        Catch ex As Exception

            MessageBox.Show(ex.Message & ex.Source)

        End Try

    End Sub
    Private Sub Adjuntos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeView1.Sort() 'Sort Alphabetically

        Dim Tnode As TreeNode = TreeView1.Nodes.Add(rutaAdjuntos) 'Add Main Node

        ListView1.View = View.Details 'Set View of ListView

        ' Add ListView Columns With Specified Width
        ListView1.Columns.Add("Nombre Archivo", 250, HorizontalAlignment.Left)
        ListView1.Columns.Add("Tipo Archivo", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Fecha Modificación", 125, HorizontalAlignment.Left)

        'CompruebaIdIncid()
        If nuevaIncid = True Then
            ObtenMaxIdIncidencia()
            rutaAdjuntos = "\\192.168.1.3\c$\Informatica\IncidenciasLE\Adjuntos\" & idIncid
        End If

        CargaAdjuntos()
    End Sub

    'Private Sub CompruebaIdIncid()

    '    If idIncid = 0 Then
    '        Dim idAdjunto As Integer = 99999
    '        Try
    '            Dim sqlconn As New OleDb.OleDbConnection
    '            Dim sqlquery As New OleDb.OleDbCommand

    '            sqlconn.ConnectionString = connString
    '            sqlconn.Open()
    '            sqlquery.Connection = sqlconn
    '            sqlquery.CommandText = "SELECT MAX(Id) FROM Incidencias"
    '            idAdjunto = sqlquery.ExecuteScalar() + 1
    '            rutaAdjuntos = "\\192.168.1.3\c$\Informatica\IncidenciasLE\Adjuntos\" & idAdjunto
    '            'sqlquery.ExecuteNonQuery()
    '            sqlconn.Close()

    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '        End Try
    '    End If

    'End Sub

    Private Sub CargaAdjuntos()
        Dim FileExtension As String 'Stores File Extension
        Dim SubItemIndex As Integer 'Sub Item Counter
        Dim DateMod As String 'Stores Date Modified Of File

        ListView1.Items.Clear() 'Clear Existing Items

        If Not rutaAdjuntos Is Nothing AndAlso Directory.Exists(rutaAdjuntos) Then

            Try

                For Each file As String In Directory.GetFiles(rutaAdjuntos) 'Get Files In Folder

                    FileExtension = Path.GetExtension(file) 'Get File Extension(s)

                    DateMod = IO.File.GetLastWriteTime(file).ToString() 'Get Date Modified For Each File

                    AddImages(file) 'Add Icons

                    ListView1.Items.Add(file.Substring(file.LastIndexOf("\"c) + 1), file.ToString()) 'Add Files & File Properties To ListView
                    ListView1.Items(SubItemIndex).SubItems.Add(FileExtension.ToString() & " File")
                    ListView1.Items(SubItemIndex).SubItems.Add(DateMod.ToString())

                    SubItemIndex += 1

                Next

            Catch ex As Exception 'Something Went Wrong

                MessageBox.Show(ex.Message)

            End Try

        End If
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarToolStripMenuItem.Click
        Using fold As New OpenFileDialog
            fold.Filter = "Archivos de Word (*.doc)|*.docx|Archivos PDF (*.pdf)|*.pdf|Archivos de Texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
            fold.Title = "Seleccione adjunto"
            If fold.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                'fold.FilterIndex = 2
                fold.RestoreDirectory = True
                'MessageBox.Show("Has seleccionado " & fold.FileName)
                If Not Directory.Exists(rutaAdjuntos) Then
                    System.IO.Directory.CreateDirectory(rutaAdjuntos)
                End If
                File.Copy(fold.FileName, rutaAdjuntos & "\" & fold.SafeFileName)
            End If
        End Using

        CargaAdjuntos()
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem.Click
        Dim resultado As Integer = MessageBox.Show("Quieres borar el adjunto " & Me.ListView1.SelectedItems(0).Text & "?", "Eliminar adjunto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.No Then
            Exit Sub
        Else
            File.Delete(rutaAdjuntos & "\" & Me.ListView1.SelectedItems(0).Text)
        End If

        CargaAdjuntos()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If Me.ListView1.SelectedItems.Count = 0 Then
            ContextMenuStrip1.Items(0).Visible = True
            ContextMenuStrip1.Items(1).Visible = False
            'e.Cancel = True
        Else
            ContextMenuStrip1.Items(0).Visible = False
            ContextMenuStrip1.Items(1).Visible = True
        End If
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        System.Diagnostics.Process.Start(rutaAdjuntos & "\" & Me.ListView1.SelectedItems(0).Text)
    End Sub
End Class