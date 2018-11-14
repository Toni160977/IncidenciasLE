<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dgAbiertas = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SolicAbiertas = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IncidenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InidenciasDataSet = New WindowsApplication1.InidenciasDataSet()
        Me.BtnRegistra = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabAbiertas = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TabCerradas = New System.Windows.Forms.TabPage()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.dgCerradas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaResolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SolicCerradas = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabWiki = New System.Windows.Forms.TabPage()
        Me.dgWiki = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServidoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosDeEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PCsDeOficinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConexionesVNCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TelefoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SanAdrianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PamplonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZaragozaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValladolidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaserKenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowerShellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncidenciasTableAdapter = New WindowsApplication1.InidenciasDataSetTableAdapters.IncidenciasTableAdapter()
        Me.InidenciasDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgAbiertas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncidenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InidenciasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabAbiertas.SuspendLayout()
        Me.TabCerradas.SuspendLayout()
        CType(Me.dgCerradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabWiki.SuspendLayout()
        CType(Me.dgWiki, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.InidenciasDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgAbiertas
        '
        Me.dgAbiertas.AllowUserToAddRows = False
        Me.dgAbiertas.AllowUserToDeleteRows = False
        Me.dgAbiertas.AutoGenerateColumns = False
        Me.dgAbiertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAbiertas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.FechaRegistro, Me.SolicAbiertas})
        Me.dgAbiertas.DataSource = Me.IncidenciasBindingSource
        Me.dgAbiertas.Location = New System.Drawing.Point(0, 1)
        Me.dgAbiertas.Name = "dgAbiertas"
        Me.dgAbiertas.ReadOnly = True
        Me.dgAbiertas.Size = New System.Drawing.Size(890, 419)
        Me.dgAbiertas.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.MaxInputLength = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdDataGridViewTextBoxColumn.Width = 50
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DescripcionDataGridViewTextBoxColumn.Width = 605
        '
        'FechaRegistro
        '
        Me.FechaRegistro.DataPropertyName = "FechaRegistro"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaRegistro.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaRegistro.HeaderText = "FechaRegistro"
        Me.FechaRegistro.Name = "FechaRegistro"
        Me.FechaRegistro.ReadOnly = True
        Me.FechaRegistro.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'SolicAbiertas
        '
        Me.SolicAbiertas.DataPropertyName = "Solicitado"
        Me.SolicAbiertas.HeaderText = "Solic."
        Me.SolicAbiertas.Name = "SolicAbiertas"
        Me.SolicAbiertas.ReadOnly = True
        Me.SolicAbiertas.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SolicAbiertas.Width = 75
        '
        'IncidenciasBindingSource
        '
        Me.IncidenciasBindingSource.DataMember = "Incidencias"
        Me.IncidenciasBindingSource.DataSource = Me.InidenciasDataSet
        '
        'InidenciasDataSet
        '
        Me.InidenciasDataSet.DataSetName = "InidenciasDataSet"
        Me.InidenciasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnRegistra
        '
        Me.BtnRegistra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistra.Location = New System.Drawing.Point(629, 39)
        Me.BtnRegistra.Name = "BtnRegistra"
        Me.BtnRegistra.Size = New System.Drawing.Size(273, 47)
        Me.BtnRegistra.TabIndex = 2
        Me.BtnRegistra.Text = "Registrar incidencia"
        Me.BtnRegistra.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabAbiertas)
        Me.TabControl1.Controls.Add(Me.TabCerradas)
        Me.TabControl1.Controls.Add(Me.TabWiki)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.TabControl1.Location = New System.Drawing.Point(12, 85)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(894, 444)
        Me.TabControl1.TabIndex = 4
        '
        'TabAbiertas
        '
        Me.TabAbiertas.Controls.Add(Me.CheckBox1)
        Me.TabAbiertas.Controls.Add(Me.dgAbiertas)
        Me.TabAbiertas.Location = New System.Drawing.Point(4, 24)
        Me.TabAbiertas.Name = "TabAbiertas"
        Me.TabAbiertas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAbiertas.Size = New System.Drawing.Size(886, 416)
        Me.TabAbiertas.TabIndex = 0
        Me.TabAbiertas.Text = "Incidencias Abiertas"
        Me.TabAbiertas.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(857, 7)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TabCerradas
        '
        Me.TabCerradas.Controls.Add(Me.CheckBox2)
        Me.TabCerradas.Controls.Add(Me.dgCerradas)
        Me.TabCerradas.Location = New System.Drawing.Point(4, 24)
        Me.TabCerradas.Name = "TabCerradas"
        Me.TabCerradas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCerradas.Size = New System.Drawing.Size(886, 416)
        Me.TabCerradas.TabIndex = 1
        Me.TabCerradas.Text = "Incidencias Cerradas"
        Me.TabCerradas.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(857, 7)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 11
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'dgCerradas
        '
        Me.dgCerradas.AllowUserToAddRows = False
        Me.dgCerradas.AutoGenerateColumns = False
        Me.dgCerradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCerradas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.FechaResolucion, Me.SolicCerradas})
        Me.dgCerradas.DataSource = Me.IncidenciasBindingSource
        Me.dgCerradas.Location = New System.Drawing.Point(0, 0)
        Me.dgCerradas.Name = "dgCerradas"
        Me.dgCerradas.ReadOnly = True
        Me.dgCerradas.Size = New System.Drawing.Size(890, 419)
        Me.dgCerradas.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.Width = 500
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FechaRegistro"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.HeaderText = "FechaRegistro"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'FechaResolucion
        '
        Me.FechaResolucion.DataPropertyName = "FechaResolucion"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaResolucion.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaResolucion.HeaderText = "FechaResolucion"
        Me.FechaResolucion.Name = "FechaResolucion"
        Me.FechaResolucion.ReadOnly = True
        Me.FechaResolucion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FechaResolucion.Width = 120
        '
        'SolicCerradas
        '
        Me.SolicCerradas.DataPropertyName = "Solicitado"
        Me.SolicCerradas.HeaderText = "Solic."
        Me.SolicCerradas.Name = "SolicCerradas"
        Me.SolicCerradas.ReadOnly = True
        Me.SolicCerradas.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SolicCerradas.Width = 75
        '
        'TabWiki
        '
        Me.TabWiki.Controls.Add(Me.dgWiki)
        Me.TabWiki.Location = New System.Drawing.Point(4, 24)
        Me.TabWiki.Name = "TabWiki"
        Me.TabWiki.Padding = New System.Windows.Forms.Padding(3)
        Me.TabWiki.Size = New System.Drawing.Size(886, 416)
        Me.TabWiki.TabIndex = 2
        Me.TabWiki.Text = "WIKI"
        Me.TabWiki.UseVisualStyleBackColor = True
        '
        'dgWiki
        '
        Me.dgWiki.AllowUserToAddRows = False
        Me.dgWiki.AllowUserToDeleteRows = False
        Me.dgWiki.AutoGenerateColumns = False
        Me.dgWiki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgWiki.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgWiki.DataSource = Me.IncidenciasBindingSource
        Me.dgWiki.Location = New System.Drawing.Point(-2, -1)
        Me.dgWiki.Name = "dgWiki"
        Me.dgWiki.ReadOnly = True
        Me.dgWiki.Size = New System.Drawing.Size(890, 419)
        Me.dgWiki.TabIndex = 1
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn4.MaxInputLength = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn5.Width = 675
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FechaRegistro"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn6.HeaderText = "FechaRegistro"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn6.Width = 120
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(216, 24)
        Me.ComboBox1.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 52)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ámbito"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem, Me.UtilidadesToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(922, 27)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(67, 23)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(107, 24)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(106, 23)
        Me.ConfiguraciónToolStripMenuItem.Text = "&Configuración"
        '
        'UtilidadesToolStripMenuItem
        '
        Me.UtilidadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentosToolStripMenuItem, Me.ConexionesVNCToolStripMenuItem, Me.TelefoToolStripMenuItem, Me.PowerShellToolStripMenuItem})
        Me.UtilidadesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.UtilidadesToolStripMenuItem.Name = "UtilidadesToolStripMenuItem"
        Me.UtilidadesToolStripMenuItem.Size = New System.Drawing.Size(81, 23)
        Me.UtilidadesToolStripMenuItem.Text = "&Utilidades"
        '
        'DocumentosToolStripMenuItem
        '
        Me.DocumentosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServidoresToolStripMenuItem, Me.DatosDeEmpresaToolStripMenuItem, Me.PCsDeOficinaToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.DocumentosToolStripMenuItem.Name = "DocumentosToolStripMenuItem"
        Me.DocumentosToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.DocumentosToolStripMenuItem.Text = "&Documentos"
        '
        'ServidoresToolStripMenuItem
        '
        Me.ServidoresToolStripMenuItem.Name = "ServidoresToolStripMenuItem"
        Me.ServidoresToolStripMenuItem.Size = New System.Drawing.Size(189, 24)
        Me.ServidoresToolStripMenuItem.Text = "&Servidores"
        '
        'DatosDeEmpresaToolStripMenuItem
        '
        Me.DatosDeEmpresaToolStripMenuItem.Name = "DatosDeEmpresaToolStripMenuItem"
        Me.DatosDeEmpresaToolStripMenuItem.Size = New System.Drawing.Size(189, 24)
        Me.DatosDeEmpresaToolStripMenuItem.Text = "Datos de &Empresa"
        '
        'PCsDeOficinaToolStripMenuItem
        '
        Me.PCsDeOficinaToolStripMenuItem.Name = "PCsDeOficinaToolStripMenuItem"
        Me.PCsDeOficinaToolStripMenuItem.Size = New System.Drawing.Size(189, 24)
        Me.PCsDeOficinaToolStripMenuItem.Text = "&PCs de Oficina"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(189, 24)
        Me.UsuariosToolStripMenuItem.Text = "&Usuarios"
        '
        'ConexionesVNCToolStripMenuItem
        '
        Me.ConexionesVNCToolStripMenuItem.Name = "ConexionesVNCToolStripMenuItem"
        Me.ConexionesVNCToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.ConexionesVNCToolStripMenuItem.Text = "&Conexiones VNC"
        '
        'TelefoToolStripMenuItem
        '
        Me.TelefoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SanAdrianToolStripMenuItem, Me.PamplonaToolStripMenuItem, Me.ZaragozaToolStripMenuItem, Me.ValladolidToolStripMenuItem, Me.LaserKenToolStripMenuItem})
        Me.TelefoToolStripMenuItem.Name = "TelefoToolStripMenuItem"
        Me.TelefoToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.TelefoToolStripMenuItem.Text = "&Teléfonos"
        '
        'SanAdrianToolStripMenuItem
        '
        Me.SanAdrianToolStripMenuItem.Name = "SanAdrianToolStripMenuItem"
        Me.SanAdrianToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.SanAdrianToolStripMenuItem.Text = "&San Adrián"
        '
        'PamplonaToolStripMenuItem
        '
        Me.PamplonaToolStripMenuItem.Name = "PamplonaToolStripMenuItem"
        Me.PamplonaToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.PamplonaToolStripMenuItem.Text = "&Pamplona"
        '
        'ZaragozaToolStripMenuItem
        '
        Me.ZaragozaToolStripMenuItem.Name = "ZaragozaToolStripMenuItem"
        Me.ZaragozaToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ZaragozaToolStripMenuItem.Text = "&Zaragoza"
        '
        'ValladolidToolStripMenuItem
        '
        Me.ValladolidToolStripMenuItem.Name = "ValladolidToolStripMenuItem"
        Me.ValladolidToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ValladolidToolStripMenuItem.Text = "&Valladolid"
        '
        'LaserKenToolStripMenuItem
        '
        Me.LaserKenToolStripMenuItem.Name = "LaserKenToolStripMenuItem"
        Me.LaserKenToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.LaserKenToolStripMenuItem.Text = "LaserKen"
        '
        'PowerShellToolStripMenuItem
        '
        Me.PowerShellToolStripMenuItem.Name = "PowerShellToolStripMenuItem"
        Me.PowerShellToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.PowerShellToolStripMenuItem.Text = "&PowerShell"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(80, 23)
        Me.AcercaDeToolStripMenuItem.Text = "&Acerca de"
        '
        'IncidenciasTableAdapter
        '
        Me.IncidenciasTableAdapter.ClearBeforeFill = True
        '
        'InidenciasDataSetBindingSource
        '
        Me.InidenciasDataSetBindingSource.DataSource = Me.InidenciasDataSet
        Me.InidenciasDataSetBindingSource.Position = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBox2)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.GroupBox4.Location = New System.Drawing.Point(273, 27)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(181, 52)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Centro"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(6, 17)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(161, 24)
        Me.ComboBox2.TabIndex = 5
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(480, 50)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox3.TabIndex = 10
        Me.CheckBox3.Text = "Jordi"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(548, 50)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox4.TabIndex = 12
        Me.CheckBox4.Text = "Toni"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.TextBox1.Location = New System.Drawing.Point(567, 541)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(335, 21)
        Me.TextBox1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label1.Location = New System.Drawing.Point(19, 546)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(505, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Buscar incidencias que en su descripción o resolución contengan el siguiente text" &
    "o :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 574)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnRegistra)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(938, 612)
        Me.MinimumSize = New System.Drawing.Size(938, 612)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IncidenciasLE"
        CType(Me.dgAbiertas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncidenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InidenciasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabAbiertas.ResumeLayout(False)
        Me.TabAbiertas.PerformLayout()
        Me.TabCerradas.ResumeLayout(False)
        Me.TabCerradas.PerformLayout()
        CType(Me.dgCerradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabWiki.ResumeLayout(False)
        CType(Me.dgWiki, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.InidenciasDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgAbiertas As DataGridView
    Friend WithEvents BtnRegistra As Button
    Friend WithEvents InidenciasDataSet As InidenciasDataSet
    Friend WithEvents IncidenciasBindingSource As BindingSource
    Friend WithEvents IncidenciasTableAdapter As InidenciasDataSetTableAdapters.IncidenciasTableAdapter
    Friend WithEvents InidenciasDataSetBindingSource As BindingSource
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabAbiertas As TabPage
    Friend WithEvents TabCerradas As TabPage
    Friend WithEvents dgCerradas As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents UtilidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServidoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosDeEmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PCsDeOficinaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConexionesVNCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents FechaResolucion As DataGridViewTextBoxColumn
    Friend WithEvents SolicCerradas As DataGridViewCheckBoxColumn
    Friend WithEvents TelefoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SanAdrianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PamplonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZaragozaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValladolidToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaserKenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaRegistro As DataGridViewTextBoxColumn
    Friend WithEvents SolicAbiertas As DataGridViewCheckBoxColumn
    Friend WithEvents PowerShellToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabWiki As TabPage
    Friend WithEvents dgWiki As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
