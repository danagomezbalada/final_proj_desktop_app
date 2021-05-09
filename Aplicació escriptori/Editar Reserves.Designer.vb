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
        Me.prova = New System.Windows.Forms.TextBox()
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
        Me.back.Location = New System.Drawing.Point(523, 15)
        Me.back.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(50, 50)
        Me.back.TabIndex = 38
        Me.back.UseVisualStyleBackColor = True
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.inici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inici.Location = New System.Drawing.Point(584, 15)
        Me.inici.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(50, 50)
        Me.inici.TabIndex = 37
        Me.inici.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(331, 135)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 23)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Estat:"
        '
        'activitat
        '
        Me.activitat.Enabled = False
        Me.activitat.Location = New System.Drawing.Point(191, 135)
        Me.activitat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.activitat.Name = "activitat"
        Me.activitat.Size = New System.Drawing.Size(132, 22)
        Me.activitat.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(57, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 23)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Activitat:"
        '
        'actualitzar
        '
        Me.actualitzar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.actualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.actualitzar.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.actualitzar.Location = New System.Drawing.Point(261, 244)
        Me.actualitzar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.actualitzar.Name = "actualitzar"
        Me.actualitzar.Size = New System.Drawing.Size(115, 37)
        Me.actualitzar.TabIndex = 30
        Me.actualitzar.Text = "Actualitzar"
        Me.actualitzar.UseVisualStyleBackColor = False
        '
        'usuari
        '
        Me.usuari.Enabled = False
        Me.usuari.Location = New System.Drawing.Point(191, 86)
        Me.usuari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.usuari.Name = "usuari"
        Me.usuari.Size = New System.Drawing.Size(132, 22)
        Me.usuari.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(57, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 23)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(201, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 38)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Editar Reserves"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(331, 85)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 23)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Data:"
        '
        'data
        '
        Me.data.Enabled = False
        Me.data.Location = New System.Drawing.Point(396, 82)
        Me.data.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(265, 22)
        Me.data.TabIndex = 40
        '
        'identificador
        '
        Me.identificador.Location = New System.Drawing.Point(615, 250)
        Me.identificador.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.identificador.Name = "identificador"
        Me.identificador.Size = New System.Drawing.Size(33, 22)
        Me.identificador.TabIndex = 42
        Me.identificador.Visible = False
        '
        'codi_transaccio
        '
        Me.codi_transaccio.Enabled = False
        Me.codi_transaccio.Location = New System.Drawing.Point(208, 187)
        Me.codi_transaccio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.codi_transaccio.Name = "codi_transaccio"
        Me.codi_transaccio.Size = New System.Drawing.Size(115, 22)
        Me.codi_transaccio.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(57, 187)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 23)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Codi Transacció:"
        '
        'prova
        '
        Me.prova.Location = New System.Drawing.Point(500, 246)
        Me.prova.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.prova.Name = "prova"
        Me.prova.Size = New System.Drawing.Size(33, 22)
        Me.prova.TabIndex = 46
        '
        'confirmada
        '
        Me.confirmada.AutoSize = True
        Me.confirmada.ForeColor = System.Drawing.SystemColors.Control
        Me.confirmada.Location = New System.Drawing.Point(8, 20)
        Me.confirmada.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.confirmada.Name = "confirmada"
        Me.confirmada.Size = New System.Drawing.Size(101, 21)
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
        Me.estat.Location = New System.Drawing.Point(395, 114)
        Me.estat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.estat.Name = "estat"
        Me.estat.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.estat.Size = New System.Drawing.Size(159, 103)
        Me.estat.TabIndex = 48
        Me.estat.TabStop = False
        '
        'rebutjada
        '
        Me.rebutjada.AutoSize = True
        Me.rebutjada.ForeColor = System.Drawing.SystemColors.Control
        Me.rebutjada.Location = New System.Drawing.Point(8, 71)
        Me.rebutjada.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rebutjada.Name = "rebutjada"
        Me.rebutjada.Size = New System.Drawing.Size(94, 21)
        Me.rebutjada.TabIndex = 49
        Me.rebutjada.TabStop = True
        Me.rebutjada.Text = "Rebutjada"
        Me.rebutjada.UseVisualStyleBackColor = True
        '
        'pendent
        '
        Me.pendent.AutoSize = True
        Me.pendent.ForeColor = System.Drawing.SystemColors.Control
        Me.pendent.Location = New System.Drawing.Point(8, 46)
        Me.pendent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pendent.Name = "pendent"
        Me.pendent.Size = New System.Drawing.Size(82, 21)
        Me.pendent.TabIndex = 48
        Me.pendent.TabStop = True
        Me.pendent.Text = "Pendent"
        Me.pendent.UseVisualStyleBackColor = True
        '
        'editar_reserves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(677, 289)
        Me.Controls.Add(Me.estat)
        Me.Controls.Add(Me.prova)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents prova As TextBox
    Friend WithEvents confirmada As RadioButton
    Friend WithEvents estat As GroupBox
    Friend WithEvents rebutjada As RadioButton
    Friend WithEvents pendent As RadioButton
End Class
