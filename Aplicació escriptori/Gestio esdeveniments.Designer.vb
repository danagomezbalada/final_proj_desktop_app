<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestio_esdeveniment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestio_esdeveniment))
        Me.gestio_esdeveniments = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Any = New System.Windows.Forms.TextBox()
        Me.Cerca = New System.Windows.Forms.Button()
        Me.taula_esdeveniment = New System.Windows.Forms.DataGridView()
        Me.afegir = New System.Windows.Forms.Button()
        Me.Editar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.inici = New System.Windows.Forms.Button()
        CType(Me.taula_esdeveniment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gestio_esdeveniments
        '
        Me.gestio_esdeveniments.AutoSize = True
        Me.gestio_esdeveniments.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gestio_esdeveniments.Location = New System.Drawing.Point(30, 13)
        Me.gestio_esdeveniments.Name = "gestio_esdeveniments"
        Me.gestio_esdeveniments.Size = New System.Drawing.Size(270, 31)
        Me.gestio_esdeveniments.TabIndex = 0
        Me.gestio_esdeveniments.Text = "Gestió Esdeveniments"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom:"
        '
        'Nom
        '
        Me.Nom.CausesValidation = False
        Me.Nom.Location = New System.Drawing.Point(91, 62)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(100, 20)
        Me.Nom.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Any:"
        '
        'Any
        '
        Me.Any.CausesValidation = False
        Me.Any.Location = New System.Drawing.Point(276, 62)
        Me.Any.Name = "Any"
        Me.Any.Size = New System.Drawing.Size(100, 20)
        Me.Any.TabIndex = 4
        '
        'Cerca
        '
        Me.Cerca.Location = New System.Drawing.Point(440, 62)
        Me.Cerca.Name = "Cerca"
        Me.Cerca.Size = New System.Drawing.Size(75, 23)
        Me.Cerca.TabIndex = 16
        Me.Cerca.Text = "Cerca"
        Me.Cerca.UseVisualStyleBackColor = True
        '
        'taula_esdeveniment
        '
        Me.taula_esdeveniment.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.taula_esdeveniment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.taula_esdeveniment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.taula_esdeveniment.Location = New System.Drawing.Point(30, 100)
        Me.taula_esdeveniment.Name = "taula_esdeveniment"
        Me.taula_esdeveniment.Size = New System.Drawing.Size(600, 300)
        Me.taula_esdeveniment.TabIndex = 17
        '
        'afegir
        '
        Me.afegir.Location = New System.Drawing.Point(136, 413)
        Me.afegir.Name = "afegir"
        Me.afegir.Size = New System.Drawing.Size(75, 23)
        Me.afegir.TabIndex = 18
        Me.afegir.Text = "Afegir"
        Me.afegir.UseVisualStyleBackColor = True
        '
        'Editar
        '
        Me.Editar.Location = New System.Drawing.Point(295, 413)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(75, 23)
        Me.Editar.TabIndex = 19
        Me.Editar.Text = "Editar"
        Me.Editar.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(459, 413)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(75, 23)
        Me.eliminar.TabIndex = 20
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.inici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inici.Location = New System.Drawing.Point(602, 12)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(40, 35)
        Me.inici.TabIndex = 24
        Me.inici.UseVisualStyleBackColor = True
        '
        'gestio_esdeveniment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(665, 450)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.Editar)
        Me.Controls.Add(Me.afegir)
        Me.Controls.Add(Me.taula_esdeveniment)
        Me.Controls.Add(Me.Cerca)
        Me.Controls.Add(Me.Any)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gestio_esdeveniments)
        Me.Name = "gestio_esdeveniment"
        Me.Text = "gestio esdeveniments"
        CType(Me.taula_esdeveniment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gestio_esdeveniments As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Nom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Any As TextBox
    Friend WithEvents Cerca As Button
    Friend WithEvents taula_esdeveniment As DataGridView
    Friend WithEvents afegir As Button
    Friend WithEvents Editar As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents inici As Button
End Class
