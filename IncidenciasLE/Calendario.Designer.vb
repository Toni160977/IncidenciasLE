<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calendario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calendario))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CrossCalendar1 = New WindowsApplication1.CrossCalendar()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Button1.Location = New System.Drawing.Point(61, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 51)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CrossCalendar1
        '
        Me.CrossCalendar1.CrossColor = System.Drawing.Color.Red
        Me.CrossCalendar1.Location = New System.Drawing.Point(18, 18)
        Me.CrossCalendar1.MaximumSize = New System.Drawing.Size(227, 162)
        Me.CrossCalendar1.MaxSelectionCount = 1
        Me.CrossCalendar1.MinimumSize = New System.Drawing.Size(227, 162)
        Me.CrossCalendar1.Name = "CrossCalendar1"
        Me.CrossCalendar1.TabIndex = 6
        '
        'Calendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 253)
        Me.Controls.Add(Me.CrossCalendar1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(284, 291)
        Me.MinimumSize = New System.Drawing.Size(284, 291)
        Me.Name = "Calendario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendario"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents CrossCalendar1 As CrossCalendar
End Class
