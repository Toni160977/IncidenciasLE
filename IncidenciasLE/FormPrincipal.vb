Public Class Form1
    Dim diasAviso1, diasAviso2 As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        diasAviso1 = CargaConfiguracion("DiasAviso1")
        diasAviso2 = CargaConfiguracion("DiasAviso2")

        CargaDatosGrid("TabAbiertas", Me.ComboBox1.SelectedValue + 1, Me.CheckBox1.Checked, Me.ComboBox2.SelectedIndex, usuario, "") 'Me.CheckBox3.Checked, 

        Dim dsDatos As New DataSet

        dsDatos = CargaDatosCombo("Ambito")
        ComboBox1.DataSource = dsDatos.Tables(0)
        ComboBox1.ValueMember = "Id"
        ComboBox1.DisplayMember = "Descripcion"

        dsDatos = CargaDatosCombo("Centros")
        ComboBox2.DataSource = dsDatos.Tables(0)
        ComboBox2.ValueMember = "IdCentro"
        ComboBox2.DisplayMember = "Descripcion"

        Dim timer As New Timer()
        timer.Interval = 30000
        '30 segundos
        AddHandler timer.Tick, AddressOf timer_Tick
        timer.Start()
    End Sub
    Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        Me.dgAbiertas.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnRegistra.Click
        Dim formIncidencia As New FormIncidencia()
        activeTab = Me.TabControl1.SelectedTab.Name.ToString
        nuevaIncid = True
        'idIncid = 0
        formIncidencia.Show()
        CargaDatosGrid("TabAbiertas", Me.ComboBox1.SelectedIndex + 1, Me.CheckBox1.Checked, Me.ComboBox2.SelectedIndex, usuario, "")
    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        Configuracion.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Acerca.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        CargaDatosGrid(Me.TabControl1.SelectedTab.Name.ToString, Me.ComboBox1.SelectedIndex + 1, Me.CheckBox1.Checked, Me.ComboBox2.SelectedIndex, usuario, "")
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If Me.TabControl1.SelectedIndex = 0 Then
            CargaDatosGrid("TabAbiertas", Me.ComboBox1.SelectedIndex + 1, Me.CheckBox1.Checked, Me.ComboBox2.SelectedIndex, usuario, "")
        ElseIf Me.TabControl1.SelectedIndex = 1 Then
            CargaDatosGrid("TabCerradas", Me.ComboBox1.SelectedIndex + 1, Me.CheckBox1.Checked, Me.ComboBox2.SelectedIndex, usuario, "")
        Else
            CargaDatosGrid("TabWiki", Me.ComboBox1.SelectedIndex + 1, Me.CheckBox1.Checked, Me.ComboBox2.SelectedIndex, usuario, "")
        End If
    End Sub

    Private Sub dgAbiertas_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgAbiertas.RowPostPaint
        If e.RowIndex < Me.dgAbiertas.RowCount Then
            Dim dgvRow As DataGridViewRow = Me.dgAbiertas.Rows(e.RowIndex)
            Dim diferenciaDias As Integer = 0
            diferenciaDias = DateDiff(DateInterval.Day, (dgvRow.Cells("FechaRegistro").Value), Date.Now)

            If diferenciaDias >= diasAviso1 AndAlso diferenciaDias < diasAviso2 Then

                dgvRow.DefaultCellStyle.BackColor = Color.Orange 'Color.FromArgb(255, 165, 0)

            ElseIf diferenciaDias >= diasAviso2 Then
                dgvRow.DefaultCellStyle.BackColor = Color.Red

            End If

        End If
    End Sub

    Private Sub dgCerradas_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgCerradas.RowPostPaint
        If e.RowIndex < Me.dgCerradas.RowCount Then
            Dim dgvRow As DataGridViewRow = Me.dgCerradas.Rows(e.RowIndex)
            dgvRow.DefaultCellStyle.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub dgAbiertas_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgAbiertas.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim idIncidencia As Integer = dgAbiertas.Item(0, e.RowIndex).Value
            Dim formIncidencia As New FormIncidencia()
            nuevaIncid = False
            idIncid = idIncidencia
            activeTab = "TabAbiertas"
            Dim i As New Incidencia(idIncid)
            formIncidencia.Show()

            formIncidencia.ComboBox1.SelectedIndex = i.Ambito - 1
            formIncidencia.ComboBox2.SelectedIndex = i.Centro
            formIncidencia.ComboBox3.SelectedIndex = i.Usuario - 1
            formIncidencia.CheckBox1.Checked = i.Solicitado
            formIncidencia.TextBox1.Text = i.Descripcion
            formIncidencia.TextBox2.Text = i.Resolucion
            formIncidencia.CheckBox3.Checked = i.Wiki

        End If
    End Sub

    Private Sub dgCerradas_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgCerradas.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim idIncidencia As Integer = dgCerradas.Item(0, e.RowIndex).Value
            Dim formIncidencia As New FormIncidencia()
            nuevaIncid = False
            idIncid = idIncidencia
            activeTab = "TabCerradas"
            Dim i As New Incidencia(idIncid)
            formIncidencia.Show()
            formIncidencia.ComboBox1.SelectedIndex = i.Ambito - 1
            formIncidencia.ComboBox2.SelectedIndex = i.Centro
            formIncidencia.ComboBox3.SelectedIndex = i.Usuario - 1
            formIncidencia.CheckBox1.Checked = i.Solicitado
            formIncidencia.TextBox1.Text = i.Descripcion
            formIncidencia.TextBox2.Text = i.Resolucion
            formIncidencia.CheckBox2.Checked = True
            formIncidencia.CheckBox3.Checked = i.Wiki

        End If
    End Sub

    Private Sub dgWiki_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgWiki.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim idIncidencia As Integer = dgWiki.Item(0, e.RowIndex).Value
            Dim formIncidencia As New FormIncidencia()
            nuevaIncid = False
            idIncid = idIncidencia
            activeTab = "TabWiki"
            Dim i As New Incidencia(idIncid)
            formIncidencia.Show()
            formIncidencia.ComboBox1.SelectedIndex = i.Ambito - 1
            formIncidencia.ComboBox2.SelectedIndex = i.Centro
            formIncidencia.ComboBox3.SelectedIndex = i.Usuario - 1
            formIncidencia.CheckBox1.Checked = i.Solicitado
            formIncidencia.TextBox1.Text = i.Descripcion
            formIncidencia.TextBox2.Text = i.Resolucion
            If i.FechaResolucion <> "#01/01/1900#" Then
                formIncidencia.CheckBox2.Checked = True
            Else
                formIncidencia.CheckBox2.Checked = False
            End If
            formIncidencia.CheckBox3.Checked = i.Wiki
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CargaDatosGrid("TabAbiertas", Me.ComboBox1.SelectedIndex + 1, Me.CheckBox1.Checked, Me.ComboBox2.SelectedIndex, usuario, "")
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        CargaDatosGrid("TabCerradas", Me.ComboBox1.SelectedIndex + 1, Me.CheckBox2.Checked, Me.ComboBox2.SelectedIndex, usuario, "")
    End Sub


    Private Sub ServidoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServidoresToolStripMenuItem.Click
        System.Diagnostics.Process.Start("\\192.168.1.3\c$\informatica\Servidores.docx")
    End Sub

    Private Sub DatosDeEmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDeEmpresaToolStripMenuItem.Click
        System.Diagnostics.Process.Start("\\192.168.1.3\c$\informatica\Datos empresa.xlsx")
    End Sub

    Private Sub PCsDeOficinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PCsDeOficinaToolStripMenuItem.Click
        System.Diagnostics.Process.Start("\\192.168.1.3\c$\informatica\PCs de oficina.xlsx")
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        System.Diagnostics.Process.Start("\\192.168.1.3\c$\informatica\Usuarios.xlsx")
    End Sub

    Private Sub ConexionesVNCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConexionesVNCToolStripMenuItem.Click
        System.Diagnostics.Process.Start("\\192.168.1.3\c$\informatica\Conexiones VNC")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub dgAbiertas_KeyDown(sender As Object, e As KeyEventArgs) Handles dgAbiertas.KeyDown
        If e.KeyCode = Keys.Delete AndAlso dgAbiertas.CurrentRow.Selected Then
            'delete selected rows
            Dim resultado As Integer = MessageBox.Show("Borrar la incidendia seleccionada?", "Borrar incidencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resultado = DialogResult.No Then
                Exit Sub
            Else
                Dim idIncidencia As Integer = CInt(dgAbiertas.SelectedRows.Item(0).Cells(0).Value.ToString)
                Dim i As New Incidencia(idIncidencia)
                i.Borra(idIncidencia)
                CargaDatosGrid("TabAbiertas", Me.ComboBox1.SelectedIndex + 1, Me.CheckBox1.Checked, Me.ComboBox2.SelectedIndex, usuario, "")
            End If

        End If

    End Sub

    Private Sub dgCerradas_KeyDown(sender As Object, e As KeyEventArgs) Handles dgCerradas.KeyDown
        If e.KeyCode = Keys.Delete AndAlso dgCerradas.CurrentRow.Selected Then
            'delete selected rows
            Dim resultado As Integer = MessageBox.Show("Borrar la incidendia seleccionada?", "Borrar incidencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resultado = DialogResult.No Then
                Exit Sub
            Else
                Dim idIncidencia As Integer = CInt(dgCerradas.SelectedRows.Item(0).Cells(0).Value.ToString)
                Dim i As New Incidencia(idIncidencia)
                i.Borra(idIncidencia)
                CargaDatosGrid("TabCerradas", Me.ComboBox1.SelectedIndex + 1, Me.CheckBox1.Checked, Me.ComboBox2.SelectedIndex, usuario, "")
            End If

        End If
    End Sub

    Private Sub dgWiki_KeyDown(sender As Object, e As KeyEventArgs) Handles dgWiki.KeyDown
        If e.KeyCode = Keys.Delete AndAlso dgWiki.CurrentRow.Selected Then
            'delete selected rows
            Dim resultado As Integer = MessageBox.Show("Borrar la incidendia seleccionada?", "Borrar incidencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resultado = DialogResult.No Then
                Exit Sub
            Else
                Dim idIncidencia As Integer = CInt(dgWiki.SelectedRows.Item(0).Cells(0).Value.ToString)
                Dim i As New Incidencia(idIncidencia)
                i.Borra(idIncidencia)
                CargaDatosGrid("TabWiki", Me.ComboBox1.SelectedIndex + 1, Me.CheckBox1.Checked, Me.ComboBox2.SelectedIndex, usuario, "")
            End If

        End If
    End Sub

    Private Sub SanAdriánToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SanAdrianToolStripMenuItem.Click
        System.Diagnostics.Process.Start("\\192.168.1.3\c$\informatica\ExtensionesSA.pdf")
    End Sub

    Private Sub PamplonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PamplonaToolStripMenuItem.Click
        System.Diagnostics.Process.Start("\\192.168.1.3\c$\informatica\ExtensionesPA.pdf")
    End Sub

    Private Sub ZaragozaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZaragozaToolStripMenuItem.Click
        System.Diagnostics.Process.Start("\\192.168.1.3\c$\informatica\ExtensionesZA.pdf")
    End Sub

    Private Sub ValladolidToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValladolidToolStripMenuItem.Click
        System.Diagnostics.Process.Start("\\192.168.1.3\c$\informatica\ExtensionesVA.pdf")
    End Sub

    Private Sub LaserKenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaserKenToolStripMenuItem.Click
        System.Diagnostics.Process.Start("\\192.168.1.3\c$\informatica\Ext Publicas LaserKen.pdf")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        CargaDatosGrid(Me.TabControl1.SelectedTab.Name.ToString, Me.ComboBox1.SelectedIndex + 1, Me.CheckBox1.Checked, Me.ComboBox2.SelectedIndex, usuario, "")
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        usuario = FiltroUsuario()
        CargaDatosGrid(Me.TabControl1.SelectedTab.Name.ToString, Me.ComboBox1.SelectedIndex + 1, Me.CheckBox1.Checked, Me.ComboBox2.SelectedIndex, usuario, "")
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        usuario = FiltroUsuario()
        CargaDatosGrid(Me.TabControl1.SelectedTab.Name.ToString, Me.ComboBox1.SelectedIndex + 1, Me.CheckBox1.Checked, Me.ComboBox2.SelectedIndex, usuario, "")
    End Sub

    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles TextBox1.Validated
        Dim filtroContiene As String = ""
        If Trim(Me.TextBox1.Text) <> "" Then
            filtroContiene = " AND (Descripcion LIKE '%" & Me.TextBox1.Text & "%' OR Resolucion LIKE '%" & Me.TextBox1.Text & "%')"
        End If

        CargaDatosGrid(Me.TabControl1.SelectedTab.Name.ToString, Me.ComboBox1.SelectedIndex + 1, Me.CheckBox1.Checked, Me.ComboBox2.SelectedIndex, usuario, filtroContiene)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Dim filtroContiene As String = ""
        If Trim(Me.TextBox1.Text) <> "" Then
            filtroContiene = " AND (Descripcion LIKE '%" & Me.TextBox1.Text & "%' OR Resolucion LIKE '%" & Me.TextBox1.Text & "%')"
        End If
        If e.KeyCode = Keys.Enter Then
            CargaDatosGrid(Me.TabControl1.SelectedTab.Name.ToString, Me.ComboBox1.SelectedIndex + 1, Me.CheckBox1.Checked, Me.ComboBox2.SelectedIndex, usuario, filtroContiene)
        End If
    End Sub

    Private Sub PowerShellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PowerShellToolStripMenuItem.Click
        Dim formScripts As New Scripts_Powershell()
        formScripts.Show()
    End Sub

    Private Function FiltroUsuario()
        If CheckBox3.Checked AndAlso CheckBox4.Equals(True) Then
            Return 0
        ElseIf CheckBox3.Checked AndAlso Not CheckBox4.Checked Then
            Return 1
        ElseIf Not CheckBox3.Checked AndAlso CheckBox4.Checked Then
            Return 2
        Else
            Return 0
        End If
    End Function
End Class
