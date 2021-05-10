<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editar_activitats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editar_activitats))
        Me.actualitzar = New System.Windows.Forms.Button()
        Me.places_totals = New System.Windows.Forms.TextBox()
        Me.preu = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.titol = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inici = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Button()
        Me.data = New System.Windows.Forms.DateTimePicker()
        Me.data_inici_mostra = New System.Windows.Forms.DateTimePicker()
        Me.esdeveniment = New System.Windows.Forms.ComboBox()
        Me.departament = New System.Windows.Forms.ComboBox()
        Me.egstionar_categories_activitat = New System.Windows.Forms.Button()
        Me.gestionar_ponents_activitat = New System.Windows.Forms.Button()
        Me.identificador = New System.Windows.Forms.TextBox()
        Me.descripcio = New System.Windows.Forms.RichTextBox()
        Me.ubicacio = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.places_actuals = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.data_fi_mostra = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.test = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'actualitzar
        '
        Me.actualitzar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.actualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.actualitzar.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.actualitzar.Location = New System.Drawing.Point(400, 338)
        Me.actualitzar.Name = "actualitzar"
        Me.actualitzar.Size = New System.Drawing.Size(115, 38)
        Me.actualitzar.TabIndex = 33
        Me.actualitzar.Text = "Actualitzar"
        Me.actualitzar.UseVisualStyleBackColor = False
        '
        'places_totals
        '
        Me.places_totals.Location = New System.Drawing.Point(430, 72)
        Me.places_totals.Name = "places_totals"
        Me.places_totals.Size = New System.Drawing.Size(170, 20)
        Me.places_totals.TabIndex = 30
        '
        'preu
        '
        Me.preu.Location = New System.Drawing.Point(119, 151)
        Me.preu.Name = "preu"
        Me.preu.Size = New System.Drawing.Size(170, 20)
        Me.preu.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(306, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 19)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Places totals:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(306, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 19)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Data inici mostra:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(43, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Data:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(43, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 19)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Descripció:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(43, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Preu:"
        '
        'titol
        '
        Me.titol.Location = New System.Drawing.Point(119, 72)
        Me.titol.Name = "titol"
        Me.titol.Size = New System.Drawing.Size(173, 20)
        Me.titol.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(43, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Títol:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(187, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 31)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Editar Activitats"
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.inici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inici.Location = New System.Drawing.Point(566, 12)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(38, 41)
        Me.inici.TabIndex = 34
        Me.inici.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(306, 265)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 19)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Department:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(306, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 19)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Esdeveniment:"
        '
        'back
        '
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Location = New System.Drawing.Point(521, 12)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(38, 41)
        Me.back.TabIndex = 41
        Me.back.UseVisualStyleBackColor = True
        '
        'data
        '
        Me.data.CalendarFont = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data.Location = New System.Drawing.Point(119, 110)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(170, 18)
        Me.data.TabIndex = 42
        '
        'data_inici_mostra
        '
        Me.data_inici_mostra.CalendarFont = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_inici_mostra.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_inici_mostra.Location = New System.Drawing.Point(430, 145)
        Me.data_inici_mostra.Name = "data_inici_mostra"
        Me.data_inici_mostra.Size = New System.Drawing.Size(170, 18)
        Me.data_inici_mostra.TabIndex = 44
        '
        'esdeveniment
        '
        Me.esdeveniment.FormattingEnabled = True
        Me.esdeveniment.Location = New System.Drawing.Point(430, 224)
        Me.esdeveniment.Name = "esdeveniment"
        Me.esdeveniment.Size = New System.Drawing.Size(170, 21)
        Me.esdeveniment.TabIndex = 46
        '
        'departament
        '
        Me.departament.FormattingEnabled = True
        Me.departament.Location = New System.Drawing.Point(430, 265)
        Me.departament.Name = "departament"
        Me.departament.Size = New System.Drawing.Size(170, 21)
        Me.departament.TabIndex = 47
        '
        'egstionar_categories_activitat
        '
        Me.egstionar_categories_activitat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.egstionar_categories_activitat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.egstionar_categories_activitat.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.egstionar_categories_activitat.Location = New System.Drawing.Point(233, 338)
        Me.egstionar_categories_activitat.Name = "egstionar_categories_activitat"
        Me.egstionar_categories_activitat.Size = New System.Drawing.Size(115, 38)
        Me.egstionar_categories_activitat.TabIndex = 52
        Me.egstionar_categories_activitat.Text = "Gestionar Categories"
        Me.egstionar_categories_activitat.UseVisualStyleBackColor = False
        '
        'gestionar_ponents_activitat
        '
        Me.gestionar_ponents_activitat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gestionar_ponents_activitat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gestionar_ponents_activitat.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.gestionar_ponents_activitat.Location = New System.Drawing.Point(72, 338)
        Me.gestionar_ponents_activitat.Name = "gestionar_ponents_activitat"
        Me.gestionar_ponents_activitat.Size = New System.Drawing.Size(115, 38)
        Me.gestionar_ponents_activitat.TabIndex = 51
        Me.gestionar_ponents_activitat.Text = "Gestionar Ponents"
        Me.gestionar_ponents_activitat.UseVisualStyleBackColor = False
        '
        'identificador
        '
        Me.identificador.Location = New System.Drawing.Point(574, 364)
        Me.identificador.Name = "identificador"
        Me.identificador.Size = New System.Drawing.Size(31, 20)
        Me.identificador.TabIndex = 53
        Me.identificador.Visible = False
        '
        'descripcio
        '
        Me.descripcio.Location = New System.Drawing.Point(119, 230)
        Me.descripcio.Name = "descripcio"
        Me.descripcio.Size = New System.Drawing.Size(170, 96)
        Me.descripcio.TabIndex = 54
        Me.descripcio.Text = ""
        '
        'ubicacio
        '
        Me.ubicacio.FormattingEnabled = True
        Me.ubicacio.Location = New System.Drawing.Point(119, 191)
        Me.ubicacio.Name = "ubicacio"
        Me.ubicacio.Size = New System.Drawing.Size(170, 21)
        Me.ubicacio.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(43, 189)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 19)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Ubicació:"
        '
        'places_actuals
        '
        Me.places_actuals.Location = New System.Drawing.Point(430, 110)
        Me.places_actuals.Name = "places_actuals"
        Me.places_actuals.Size = New System.Drawing.Size(170, 20)
        Me.places_actuals.TabIndex = 60
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(306, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 19)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Places actuals:"
        '
        'data_fi_mostra
        '
        Me.data_fi_mostra.CalendarFont = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_fi_mostra.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_fi_mostra.Location = New System.Drawing.Point(430, 186)
        Me.data_fi_mostra.Name = "data_fi_mostra"
        Me.data_fi_mostra.Size = New System.Drawing.Size(170, 18)
        Me.data_fi_mostra.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(306, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 19)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Data fi mostra:"
        '
        'test
        '
        Me.test.Location = New System.Drawing.Point(574, 338)
        Me.test.Name = "test"
        Me.test.Size = New System.Drawing.Size(31, 20)
        Me.test.TabIndex = 63
        Me.test.Visible = False
        '
        'editar_activitats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(609, 387)
        Me.Controls.Add(Me.test)
        Me.Controls.Add(Me.data_fi_mostra)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.places_actuals)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ubicacio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.descripcio)
        Me.Controls.Add(Me.identificador)
        Me.Controls.Add(Me.egstionar_categories_activitat)
        Me.Controls.Add(Me.gestionar_ponents_activitat)
        Me.Controls.Add(Me.departament)
        Me.Controls.Add(Me.esdeveniment)
        Me.Controls.Add(Me.data_inici_mostra)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.actualitzar)
        Me.Controls.Add(Me.places_totals)
        Me.Controls.Add(Me.preu)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.titol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "editar_activitats"
        Me.Text = "editar_activitats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents actualitzar As Button
    Friend WithEvents places_totals As TextBox
    Friend WithEvents preu As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents titol As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents inici As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents back As Button
    Friend WithEvents data As DateTimePicker
    Friend WithEvents data_inici_mostra As DateTimePicker
    Friend WithEvents esdeveniment As ComboBox
    Friend WithEvents departament As ComboBox
    Friend WithEvents egstionar_categories_activitat As Button
    Friend WithEvents gestionar_ponents_activitat As Button
    Friend WithEvents identificador As TextBox
    Friend WithEvents descripcio As RichTextBox
    Friend WithEvents ubicacio As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents places_actuals As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents data_fi_mostra As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents test As TextBox
End Class
