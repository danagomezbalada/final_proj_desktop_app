<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editar_departaments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editar_departaments))
        Me.actualitzar = New System.Windows.Forms.Button()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inici = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.identificador = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'actualitzar
        '
        Me.actualitzar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.actualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.actualitzar.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.actualitzar.Location = New System.Drawing.Point(114, 136)
        Me.actualitzar.Name = "actualitzar"
        Me.actualitzar.Size = New System.Drawing.Size(86, 30)
        Me.actualitzar.TabIndex = 9
        Me.actualitzar.Text = "Actualitzar"
        Me.actualitzar.UseVisualStyleBackColor = False
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(99, 71)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(100, 20)
        Me.nom.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(43, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nom:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(11, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Editar Departaments"
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.inici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inici.Location = New System.Drawing.Point(323, 13)
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
        Me.back.Location = New System.Drawing.Point(283, 13)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(38, 41)
        Me.back.TabIndex = 29
        Me.back.UseVisualStyleBackColor = True
        '
        'identificador
        '
        Me.identificador.Location = New System.Drawing.Point(323, 160)
        Me.identificador.Name = "identificador"
        Me.identificador.Size = New System.Drawing.Size(30, 20)
        Me.identificador.TabIndex = 30
        Me.identificador.Visible = False
        '
        'editar_departaments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(365, 192)
        Me.Controls.Add(Me.identificador)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.actualitzar)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "editar_departaments"
        Me.Text = "Editar departaments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents actualitzar As Button
    Friend WithEvents nom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents inici As Button
    Friend WithEvents back As Button
    Friend WithEvents identificador As TextBox
End Class
