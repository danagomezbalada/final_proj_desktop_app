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
        Me.gestio_esdeveniments.ForeColor = System.Drawing.SystemColors.Control
        Me.gestio_esdeveniments.Location = New System.Drawing.Point(40, 16)
        Me.gestio_esdeveniments.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.gestio_esdeveniments.Name = "gestio_esdeveniments"
        Me.gestio_esdeveniments.Size = New System.Drawing.Size(334, 38)
        Me.gestio_esdeveniments.TabIndex = 0
        Me.gestio_esdeveniments.Text = "Gestió Esdeveniments"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(44, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom:"
        '
        'Nom
        '
        Me.Nom.CausesValidation = False
        Me.Nom.Location = New System.Drawing.Point(121, 76)
        Me.Nom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(132, 22)
        Me.Nom.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(293, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Any:"
        '
        'Any
        '
        Me.Any.CausesValidation = False
        Me.Any.Location = New System.Drawing.Point(368, 76)
        Me.Any.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Any.Name = "Any"
        Me.Any.Size = New System.Drawing.Size(132, 22)
        Me.Any.TabIndex = 4
        '
        'Cerca
        '
        Me.Cerca.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Cerca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cerca.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.Cerca.Location = New System.Drawing.Point(588, 72)
        Me.Cerca.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cerca.Name = "Cerca"
        Me.Cerca.Size = New System.Drawing.Size(97, 30)
        Me.Cerca.TabIndex = 16
        Me.Cerca.Text = "Cerca"
        Me.Cerca.UseVisualStyleBackColor = False
        '
        'taula_esdeveniment
        '
        Me.taula_esdeveniment.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.taula_esdeveniment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.taula_esdeveniment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.taula_esdeveniment.Location = New System.Drawing.Point(40, 123)
        Me.taula_esdeveniment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.taula_esdeveniment.Name = "taula_esdeveniment"
        Me.taula_esdeveniment.RowHeadersWidth = 51
        Me.taula_esdeveniment.Size = New System.Drawing.Size(800, 369)
        Me.taula_esdeveniment.TabIndex = 17
        '
        'afegir
        '
        Me.afegir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.afegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.afegir.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.afegir.Location = New System.Drawing.Point(181, 508)
        Me.afegir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.afegir.Name = "afegir"
        Me.afegir.Size = New System.Drawing.Size(111, 33)
        Me.afegir.TabIndex = 18
        Me.afegir.Text = "Afegir"
        Me.afegir.UseVisualStyleBackColor = False
        '
        'Editar
        '
        Me.Editar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Editar.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.Editar.Location = New System.Drawing.Point(393, 508)
        Me.Editar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(111, 33)
        Me.Editar.TabIndex = 19
        Me.Editar.Text = "Editar"
        Me.Editar.UseVisualStyleBackColor = False
        '
        'eliminar
        '
        Me.eliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.eliminar.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.eliminar.Location = New System.Drawing.Point(612, 508)
        Me.eliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(111, 33)
        Me.eliminar.TabIndex = 20
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.UseVisualStyleBackColor = False
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.inici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inici.Location = New System.Drawing.Point(803, 15)
        Me.inici.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(50, 50)
        Me.inici.TabIndex = 24
        Me.inici.UseVisualStyleBackColor = True
        '
        'gestio_esdeveniment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(887, 554)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
