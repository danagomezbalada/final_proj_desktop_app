<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editar_esdeveniments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editar_esdeveniments))
        Me.descripcio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.any = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.actualitzar = New System.Windows.Forms.Button()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inici = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.actiu = New System.Windows.Forms.CheckBox()
        Me.identificador = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'descripcio
        '
        Me.descripcio.Location = New System.Drawing.Point(349, 110)
        Me.descripcio.Name = "descripcio"
        Me.descripcio.Size = New System.Drawing.Size(101, 20)
        Me.descripcio.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(263, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Descripció:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(263, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Actiu:"
        '
        'any
        '
        Me.any.Location = New System.Drawing.Point(108, 110)
        Me.any.Name = "any"
        Me.any.Size = New System.Drawing.Size(100, 20)
        Me.any.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(43, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 19)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Any:"
        '
        'actualitzar
        '
        Me.actualitzar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.actualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.actualitzar.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.actualitzar.Location = New System.Drawing.Point(201, 175)
        Me.actualitzar.Name = "actualitzar"
        Me.actualitzar.Size = New System.Drawing.Size(86, 30)
        Me.actualitzar.TabIndex = 26
        Me.actualitzar.Text = "Actualitzar"
        Me.actualitzar.UseVisualStyleBackColor = False
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(108, 70)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(100, 20)
        Me.nom.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(43, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nom:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(123, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 31)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Editar Esdeveniments"
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.inici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inici.Location = New System.Drawing.Point(456, 12)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(38, 41)
        Me.inici.TabIndex = 33
        Me.inici.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Location = New System.Drawing.Point(410, 12)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(38, 41)
        Me.back.TabIndex = 34
        Me.back.UseVisualStyleBackColor = True
        '
        'actiu
        '
        Me.actiu.AutoSize = True
        Me.actiu.Location = New System.Drawing.Point(349, 70)
        Me.actiu.Name = "actiu"
        Me.actiu.Size = New System.Drawing.Size(15, 14)
        Me.actiu.TabIndex = 35
        Me.actiu.UseVisualStyleBackColor = True
        '
        'identificador
        '
        Me.identificador.Location = New System.Drawing.Point(456, 203)
        Me.identificador.Name = "identificador"
        Me.identificador.Size = New System.Drawing.Size(31, 20)
        Me.identificador.TabIndex = 36
        Me.identificador.Visible = False
        '
        'editar_esdeveniments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(499, 235)
        Me.Controls.Add(Me.identificador)
        Me.Controls.Add(Me.actiu)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.descripcio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.any)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.actualitzar)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "editar_esdeveniments"
        Me.Text = "Editar Esdeveniments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents any As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents actualitzar As Button
    Friend WithEvents nom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents inici As Button
    Friend WithEvents back As Button
    Friend WithEvents actiu As CheckBox
    Friend WithEvents descripcio As TextBox
    Friend WithEvents identificador As TextBox
End Class
