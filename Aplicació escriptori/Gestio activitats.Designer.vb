<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gestio_activitats
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestio_activitats))
        Me.nom = New System.Windows.Forms.TextBox()
        Me.Cercar = New System.Windows.Forms.Button()
        Me.Afegir = New System.Windows.Forms.Button()
        Me.Editar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.taula_activitats = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inici = New System.Windows.Forms.Button()
        CType(Me.taula_activitats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(91, 62)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(100, 20)
        Me.nom.TabIndex = 0
        '
        'Cercar
        '
        Me.Cercar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Cercar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cercar.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.Cercar.Location = New System.Drawing.Point(207, 58)
        Me.Cercar.Name = "Cercar"
        Me.Cercar.Size = New System.Drawing.Size(73, 24)
        Me.Cercar.TabIndex = 5
        Me.Cercar.Text = "Cercar"
        Me.Cercar.UseVisualStyleBackColor = False
        '
        'Afegir
        '
        Me.Afegir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Afegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Afegir.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.Afegir.Location = New System.Drawing.Point(136, 413)
        Me.Afegir.Name = "Afegir"
        Me.Afegir.Size = New System.Drawing.Size(83, 27)
        Me.Afegir.TabIndex = 9
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
        Me.Editar.TabIndex = 10
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
        Me.Eliminar.TabIndex = 11
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = False
        '
        'taula_activitats
        '
        Me.taula_activitats.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.taula_activitats.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.taula_activitats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.taula_activitats.Location = New System.Drawing.Point(30, 100)
        Me.taula_activitats.Name = "taula_activitats"
        Me.taula_activitats.RowHeadersWidth = 51
        Me.taula_activitats.Size = New System.Drawing.Size(600, 300)
        Me.taula_activitats.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(30, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Gestió Activitats"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(33, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nom:"
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.inici.FlatAppearance.BorderSize = 0
        Me.inici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inici.Location = New System.Drawing.Point(602, 12)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(38, 41)
        Me.inici.TabIndex = 15
        Me.inici.UseVisualStyleBackColor = True
        '
        'gestio_activitats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(665, 450)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.taula_activitats)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Editar)
        Me.Controls.Add(Me.Afegir)
        Me.Controls.Add(Me.Cercar)
        Me.Controls.Add(Me.nom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gestio_activitats"
        Me.Text = "Gestió Activitats"
        CType(Me.taula_activitats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nom As TextBox
    Friend WithEvents Cercar As Button
    Friend WithEvents Afegir As Button
    Friend WithEvents Editar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents taula_activitats As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents inici As Button
End Class
