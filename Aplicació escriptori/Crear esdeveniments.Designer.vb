<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crear_esdeveniments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(crear_esdeveniments))
        Me.descripcio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.any = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Crear = New System.Windows.Forms.Button()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inici = New System.Windows.Forms.Button()
        Me.actiu = New System.Windows.Forms.CheckBox()
        Me.back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'descripcio
        '
        Me.descripcio.Location = New System.Drawing.Point(349, 110)
        Me.descripcio.Name = "descripcio"
        Me.descripcio.Size = New System.Drawing.Size(100, 20)
        Me.descripcio.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(263, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Descripció:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(263, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Actiu:"
        '
        'any
        '
        Me.any.Location = New System.Drawing.Point(108, 110)
        Me.any.Name = "any"
        Me.any.Size = New System.Drawing.Size(100, 20)
        Me.any.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 19)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Any:"
        '
        'Crear
        '
        Me.Crear.Location = New System.Drawing.Point(201, 175)
        Me.Crear.Name = "Crear"
        Me.Crear.Size = New System.Drawing.Size(75, 23)
        Me.Crear.TabIndex = 16
        Me.Crear.Text = "Crear"
        Me.Crear.UseVisualStyleBackColor = True
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(108, 70)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(100, 20)
        Me.nom.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nom:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Crear Esdeveniments"
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.inici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inici.Location = New System.Drawing.Point(454, 12)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(40, 35)
        Me.inici.TabIndex = 23
        Me.inici.UseVisualStyleBackColor = True
        '
        'actiu
        '
        Me.actiu.AutoSize = True
        Me.actiu.Location = New System.Drawing.Point(349, 70)
        Me.actiu.Name = "actiu"
        Me.actiu.Size = New System.Drawing.Size(15, 14)
        Me.actiu.TabIndex = 24
        Me.actiu.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Location = New System.Drawing.Point(413, 12)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(40, 35)
        Me.back.TabIndex = 25
        Me.back.UseVisualStyleBackColor = True
        '
        'crear_esdeveniments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(499, 235)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.actiu)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.descripcio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.any)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Crear)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "crear_esdeveniments"
        Me.Text = "Crear Esdeveniments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents descripcio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents any As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Crear As Button
    Friend WithEvents nom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents inici As Button
    Friend WithEvents actiu As CheckBox
    Friend WithEvents back As Button
End Class
