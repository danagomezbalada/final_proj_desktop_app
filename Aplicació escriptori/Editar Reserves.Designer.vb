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
        Me.activitat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.actualitzar = New System.Windows.Forms.Button()
        Me.usuari = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.data = New System.Windows.Forms.DateTimePicker()
        Me.identificador = New System.Windows.Forms.TextBox()
        Me.codi_transaccio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.estat_text = New System.Windows.Forms.TextBox()
        Me.confirmada = New System.Windows.Forms.RadioButton()
        Me.estat = New System.Windows.Forms.GroupBox()
        Me.rebutjada = New System.Windows.Forms.RadioButton()
        Me.pendent = New System.Windows.Forms.RadioButton()
        Me.estat.SuspendLayout()
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
        Me.back.Size = New System.Drawing.Size(38, 41)
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
        Me.inici.Size = New System.Drawing.Size(38, 41)
        Me.inici.TabIndex = 37
        Me.inici.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(248, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 19)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Estat:"
        '
        'activitat
        '
        Me.activitat.Enabled = False
        Me.activitat.Location = New System.Drawing.Point(143, 110)
        Me.activitat.Name = "activitat"
        Me.activitat.Size = New System.Drawing.Size(100, 20)
        Me.activitat.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(43, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Activitat:"
        '
        'actualitzar
        '
        Me.actualitzar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.actualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.actualitzar.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.actualitzar.Location = New System.Drawing.Point(196, 198)
        Me.actualitzar.Name = "actualitzar"
        Me.actualitzar.Size = New System.Drawing.Size(86, 30)
        Me.actualitzar.TabIndex = 30
        Me.actualitzar.Text = "Actualitzar"
        Me.actualitzar.UseVisualStyleBackColor = False
        '
        'usuari
        '
        Me.usuari.Enabled = False
        Me.usuari.Location = New System.Drawing.Point(143, 70)
        Me.usuari.Name = "usuari"
        Me.usuari.Size = New System.Drawing.Size(100, 20)
        Me.usuari.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
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
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
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
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(248, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Data:"
        '
        'data
        '
        Me.data.Enabled = False
        Me.data.Location = New System.Drawing.Point(297, 67)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(200, 20)
        Me.data.TabIndex = 40
        '
        'identificador
        '
        Me.identificador.Location = New System.Drawing.Point(461, 203)
        Me.identificador.Name = "identificador"
        Me.identificador.Size = New System.Drawing.Size(26, 20)
        Me.identificador.TabIndex = 42
        Me.identificador.Visible = False
        '
        'codi_transaccio
        '
        Me.codi_transaccio.Enabled = False
        Me.codi_transaccio.Location = New System.Drawing.Point(156, 152)
        Me.codi_transaccio.Name = "codi_transaccio"
        Me.codi_transaccio.Size = New System.Drawing.Size(87, 20)
        Me.codi_transaccio.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(43, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 19)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Codi Transacció:"
        '
        'estat_text
        '
        Me.estat_text.Location = New System.Drawing.Point(429, 203)
        Me.estat_text.Name = "estat_text"
        Me.estat_text.Size = New System.Drawing.Size(26, 20)
        Me.estat_text.TabIndex = 46
        Me.estat_text.Visible = False
        '
        'confirmada
        '
        Me.confirmada.AutoSize = True
        Me.confirmada.ForeColor = System.Drawing.SystemColors.Control
        Me.confirmada.Location = New System.Drawing.Point(6, 16)
        Me.confirmada.Name = "confirmada"
        Me.confirmada.Size = New System.Drawing.Size(78, 17)
        Me.confirmada.TabIndex = 47
        Me.confirmada.TabStop = True
        Me.confirmada.Text = "Confirmada"
        Me.confirmada.UseVisualStyleBackColor = True
        '
        'estat
        '
        Me.estat.Controls.Add(Me.rebutjada)
        Me.estat.Controls.Add(Me.pendent)
        Me.estat.Controls.Add(Me.confirmada)
        Me.estat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.estat.Location = New System.Drawing.Point(296, 93)
        Me.estat.Name = "estat"
        Me.estat.Size = New System.Drawing.Size(119, 84)
        Me.estat.TabIndex = 48
        Me.estat.TabStop = False
        '
        'rebutjada
        '
        Me.rebutjada.AutoSize = True
        Me.rebutjada.ForeColor = System.Drawing.SystemColors.Control
        Me.rebutjada.Location = New System.Drawing.Point(6, 58)
        Me.rebutjada.Name = "rebutjada"
        Me.rebutjada.Size = New System.Drawing.Size(74, 17)
        Me.rebutjada.TabIndex = 49
        Me.rebutjada.TabStop = True
        Me.rebutjada.Text = "Rebutjada"
        Me.rebutjada.UseVisualStyleBackColor = True
        '
        'pendent
        '
        Me.pendent.AutoSize = True
        Me.pendent.ForeColor = System.Drawing.SystemColors.Control
        Me.pendent.Location = New System.Drawing.Point(6, 37)
        Me.pendent.Name = "pendent"
        Me.pendent.Size = New System.Drawing.Size(65, 17)
        Me.pendent.TabIndex = 48
        Me.pendent.TabStop = True
        Me.pendent.Text = "Pendent"
        Me.pendent.UseVisualStyleBackColor = True
        '
        'editar_reserves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(508, 235)
        Me.Controls.Add(Me.estat)
        Me.Controls.Add(Me.estat_text)
        Me.Controls.Add(Me.codi_transaccio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.identificador)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.activitat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.actualitzar)
        Me.Controls.Add(Me.usuari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "editar_reserves"
        Me.Text = "Editar Reserves"
        Me.estat.ResumeLayout(False)
        Me.estat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents back As Button
    Friend WithEvents inici As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents activitat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents actualitzar As Button
    Friend WithEvents usuari As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents data As DateTimePicker
    Friend WithEvents identificador As TextBox
    Friend WithEvents codi_transaccio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents estat_text As TextBox
    Friend WithEvents confirmada As RadioButton
    Friend WithEvents estat As GroupBox
    Friend WithEvents rebutjada As RadioButton
    Friend WithEvents pendent As RadioButton
End Class
