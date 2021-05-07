<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editar_reserves
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editar_reserves))
        Me.back = New System.Windows.Forms.Button()
        Me.inici = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.codi_transaccio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.activitat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.actualitzar = New System.Windows.Forms.Button()
        Me.usuari = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.data = New System.Windows.Forms.DateTimePicker()
        Me.estat = New System.Windows.Forms.ComboBox()
        Me.identificador = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Location = New System.Drawing.Point(392, 12)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(40, 35)
        Me.back.TabIndex = 38
        Me.back.UseVisualStyleBackColor = True
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.inici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inici.Location = New System.Drawing.Point(438, 12)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(40, 35)
        Me.inici.TabIndex = 37
        Me.inici.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(245, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 19)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Estat:"
        '
        'codi_transaccio
        '
        Me.codi_transaccio.Location = New System.Drawing.Point(370, 70)
        Me.codi_transaccio.Name = "codi_transaccio"
        Me.codi_transaccio.Size = New System.Drawing.Size(100, 20)
        Me.codi_transaccio.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(245, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Codi Transacció:"
        '
        'activitat
        '
        Me.activitat.Location = New System.Drawing.Point(120, 110)
        Me.activitat.Name = "activitat"
        Me.activitat.Size = New System.Drawing.Size(100, 20)
        Me.activitat.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Activitat:"
        '
        'actualitzar
        '
        Me.actualitzar.Location = New System.Drawing.Point(196, 198)
        Me.actualitzar.Name = "actualitzar"
        Me.actualitzar.Size = New System.Drawing.Size(75, 23)
        Me.actualitzar.TabIndex = 30
        Me.actualitzar.Text = "Actualitzar"
        Me.actualitzar.UseVisualStyleBackColor = True
        '
        'usuari
        '
        Me.usuari.Location = New System.Drawing.Point(120, 70)
        Me.usuari.Name = "usuari"
        Me.usuari.Size = New System.Drawing.Size(100, 20)
        Me.usuari.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 31)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Editar Reserves"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Data:"
        '
        'data
        '
        Me.data.Location = New System.Drawing.Point(96, 147)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(200, 20)
        Me.data.TabIndex = 40
        '
        'estat
        '
        Me.estat.FormattingEnabled = True
        Me.estat.Location = New System.Drawing.Point(300, 110)
        Me.estat.Name = "estat"
        Me.estat.Size = New System.Drawing.Size(121, 21)
        Me.estat.TabIndex = 41
        '
        'identificador
        '
        Me.identificador.Location = New System.Drawing.Point(461, 203)
        Me.identificador.Name = "identificador"
        Me.identificador.Size = New System.Drawing.Size(26, 20)
        Me.identificador.TabIndex = 42
        Me.identificador.Visible = False
        '
        'editar_reserves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(499, 235)
        Me.Controls.Add(Me.identificador)
        Me.Controls.Add(Me.estat)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.codi_transaccio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.activitat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.actualitzar)
        Me.Controls.Add(Me.usuari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "editar_reserves"
        Me.Text = "Editar Reserves"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents back As Button
    Friend WithEvents inici As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents codi_transaccio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents activitat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents actualitzar As Button
    Friend WithEvents usuari As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents data As DateTimePicker
    Friend WithEvents estat As ComboBox
    Friend WithEvents identificador As TextBox
End Class
