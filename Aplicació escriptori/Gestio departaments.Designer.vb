<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestio_departament
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestio_departament))
        Me.Gestio_departaments = New System.Windows.Forms.Label()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.Cerca = New System.Windows.Forms.Button()
        Me.taula_departament = New System.Windows.Forms.DataGridView()
        Me.Afegir = New System.Windows.Forms.Button()
        Me.Editar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inici = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        CType(Me.taula_departament, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gestio_departaments
        '
        Me.Gestio_departaments.AutoSize = True
        Me.Gestio_departaments.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gestio_departaments.ForeColor = System.Drawing.SystemColors.Control
        Me.Gestio_departaments.Location = New System.Drawing.Point(30, 13)
        Me.Gestio_departaments.Name = "Gestio_departaments"
        Me.Gestio_departaments.Size = New System.Drawing.Size(261, 31)
        Me.Gestio_departaments.TabIndex = 0
        Me.Gestio_departaments.Text = "Gestió Departaments"
        '
        'Nom
        '
        Me.Nom.Location = New System.Drawing.Point(91, 62)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(100, 20)
        Me.Nom.TabIndex = 1
        '
        'Cerca
        '
        Me.Cerca.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Cerca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cerca.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.Cerca.Location = New System.Drawing.Point(208, 58)
        Me.Cerca.Name = "Cerca"
        Me.Cerca.Size = New System.Drawing.Size(73, 24)
        Me.Cerca.TabIndex = 2
        Me.Cerca.Text = "Cerca"
        Me.Cerca.UseVisualStyleBackColor = False
        '
        'taula_departament
        '
        Me.taula_departament.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.taula_departament.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.taula_departament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.taula_departament.Location = New System.Drawing.Point(30, 100)
        Me.taula_departament.Name = "taula_departament"
        Me.taula_departament.RowHeadersWidth = 51
        Me.taula_departament.Size = New System.Drawing.Size(600, 300)
        Me.taula_departament.TabIndex = 13
        '
        'Afegir
        '
        Me.Afegir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Afegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Afegir.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.Afegir.Location = New System.Drawing.Point(136, 413)
        Me.Afegir.Name = "Afegir"
        Me.Afegir.Size = New System.Drawing.Size(83, 27)
        Me.Afegir.TabIndex = 14
        Me.Afegir.Text = "Afegir"
        Me.Afegir.UseVisualStyleBackColor = False
        '
        'Editar
        '
        Me.Editar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Editar.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.Editar.Location = New System.Drawing.Point(295, 413)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(83, 27)
        Me.Editar.TabIndex = 15
        Me.Editar.Text = "Editar"
        Me.Editar.UseVisualStyleBackColor = False
        '
        'Eliminar
        '
        Me.Eliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Eliminar.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.Eliminar.Location = New System.Drawing.Point(459, 413)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(83, 27)
        Me.Eliminar.TabIndex = 16
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(33, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nom:"
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.inici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inici.Location = New System.Drawing.Point(602, 12)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(38, 41)
        Me.inici.TabIndex = 19
        Me.inici.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Location = New System.Drawing.Point(556, 12)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(38, 41)
        Me.back.TabIndex = 29
        Me.back.UseVisualStyleBackColor = True
        '
        'gestio_departament
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(665, 450)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Editar)
        Me.Controls.Add(Me.Afegir)
        Me.Controls.Add(Me.taula_departament)
        Me.Controls.Add(Me.Cerca)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.Gestio_departaments)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gestio_departament"
        Me.Text = "Gestió departaments"
        CType(Me.taula_departament, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Gestio_departaments As Label
    Friend WithEvents Nom As TextBox
    Friend WithEvents Cerca As Button
    Friend WithEvents taula_departament As DataGridView
    Friend WithEvents Afegir As Button
    Friend WithEvents Editar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents inici As Button
    Friend WithEvents back As Button
End Class
