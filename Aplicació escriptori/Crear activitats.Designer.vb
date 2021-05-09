<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crear_activitat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(crear_activitat))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.titol = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.preu = New System.Windows.Forms.TextBox()
        Me.places_totals = New System.Windows.Forms.TextBox()
        Me.crear = New System.Windows.Forms.Button()
        Me.inici = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.data = New System.Windows.Forms.DateTimePicker()
        Me.data_inici_mostra = New System.Windows.Forms.DateTimePicker()
        Me.data_fi_mostra = New System.Windows.Forms.DateTimePicker()
        Me.back = New System.Windows.Forms.Button()
        Me.ubicacio = New System.Windows.Forms.ComboBox()
        Me.esdeveniment = New System.Windows.Forms.ComboBox()
        Me.departament = New System.Windows.Forms.ComboBox()
        Me.places_actuals = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.descripcio = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(249, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Crear Activitats"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(57, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Títol:"
        '
        'titol
        '
        Me.titol.Location = New System.Drawing.Point(159, 86)
        Me.titol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.titol.Name = "titol"
        Me.titol.Size = New System.Drawing.Size(225, 22)
        Me.titol.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(57, 185)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Preu:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(57, 284)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Descripció:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(57, 135)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Data:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(403, 183)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 23)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Data inici mostra:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(403, 233)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 23)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Data fi mostra:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(403, 86)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 23)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Places totals:"
        '
        'preu
        '
        Me.preu.Location = New System.Drawing.Point(159, 187)
        Me.preu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.preu.Name = "preu"
        Me.preu.Size = New System.Drawing.Size(225, 22)
        Me.preu.TabIndex = 13
        '
        'places_totals
        '
        Me.places_totals.Location = New System.Drawing.Point(571, 87)
        Me.places_totals.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.places_totals.Name = "places_totals"
        Me.places_totals.Size = New System.Drawing.Size(225, 22)
        Me.places_totals.TabIndex = 14
        '
        'crear
        '
        Me.crear.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.crear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.crear.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.crear.Location = New System.Drawing.Point(524, 411)
        Me.crear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.crear.Name = "crear"
        Me.crear.Size = New System.Drawing.Size(129, 38)
        Me.crear.TabIndex = 17
        Me.crear.Text = "Crear"
        Me.crear.UseVisualStyleBackColor = False
        '
        'inici
        '
        Me.inici.BackColor = System.Drawing.Color.SteelBlue
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.inici.FlatAppearance.BorderSize = 0
        Me.inici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inici.Location = New System.Drawing.Point(728, 15)
        Me.inici.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(50, 50)
        Me.inici.TabIndex = 18
        Me.inici.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(403, 282)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 23)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Esdeveniment:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(57, 233)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 23)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Ubicació:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(403, 331)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 23)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Department:"
        '
        'data
        '
        Me.data.CalendarFont = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data.Location = New System.Drawing.Point(159, 135)
        Me.data.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(225, 20)
        Me.data.TabIndex = 25
        '
        'data_inici_mostra
        '
        Me.data_inici_mostra.CalendarFont = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_inici_mostra.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_inici_mostra.Location = New System.Drawing.Point(571, 183)
        Me.data_inici_mostra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.data_inici_mostra.Name = "data_inici_mostra"
        Me.data_inici_mostra.Size = New System.Drawing.Size(225, 20)
        Me.data_inici_mostra.TabIndex = 26
        '
        'data_fi_mostra
        '
        Me.data_fi_mostra.CalendarFont = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_fi_mostra.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_fi_mostra.Location = New System.Drawing.Point(571, 233)
        Me.data_fi_mostra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.data_fi_mostra.Name = "data_fi_mostra"
        Me.data_fi_mostra.Size = New System.Drawing.Size(223, 20)
        Me.data_fi_mostra.TabIndex = 27
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.SteelBlue
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Location = New System.Drawing.Point(667, 15)
        Me.back.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(50, 50)
        Me.back.TabIndex = 28
        Me.back.UseVisualStyleBackColor = False
        '
        'ubicacio
        '
        Me.ubicacio.FormattingEnabled = True
        Me.ubicacio.Location = New System.Drawing.Point(159, 233)
        Me.ubicacio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ubicacio.Name = "ubicacio"
        Me.ubicacio.Size = New System.Drawing.Size(225, 24)
        Me.ubicacio.TabIndex = 46
        '
        'esdeveniment
        '
        Me.esdeveniment.FormattingEnabled = True
        Me.esdeveniment.Location = New System.Drawing.Point(571, 281)
        Me.esdeveniment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.esdeveniment.Name = "esdeveniment"
        Me.esdeveniment.Size = New System.Drawing.Size(223, 24)
        Me.esdeveniment.TabIndex = 47
        '
        'departament
        '
        Me.departament.FormattingEnabled = True
        Me.departament.Location = New System.Drawing.Point(571, 331)
        Me.departament.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.departament.Name = "departament"
        Me.departament.Size = New System.Drawing.Size(223, 24)
        Me.departament.TabIndex = 48
        '
        'places_actuals
        '
        Me.places_actuals.Location = New System.Drawing.Point(571, 134)
        Me.places_actuals.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.places_actuals.Name = "places_actuals"
        Me.places_actuals.Size = New System.Drawing.Size(223, 22)
        Me.places_actuals.TabIndex = 52
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(403, 134)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 23)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Places actuals:"
        '
        'descripcio
        '
        Me.descripcio.Location = New System.Drawing.Point(159, 281)
        Me.descripcio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.descripcio.Name = "descripcio"
        Me.descripcio.Size = New System.Drawing.Size(225, 117)
        Me.descripcio.TabIndex = 55
        Me.descripcio.Text = ""
        '
        'crear_activitat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(812, 476)
        Me.Controls.Add(Me.descripcio)
        Me.Controls.Add(Me.places_actuals)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.departament)
        Me.Controls.Add(Me.esdeveniment)
        Me.Controls.Add(Me.ubicacio)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.data_fi_mostra)
        Me.Controls.Add(Me.data_inici_mostra)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.crear)
        Me.Controls.Add(Me.places_totals)
        Me.Controls.Add(Me.preu)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.titol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "crear_activitat"
        Me.Text = "Crear Activitats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents titol As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents preu As TextBox
    Friend WithEvents places_totals As TextBox
    Friend WithEvents crear As Button
    Friend WithEvents inici As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents data As DateTimePicker
    Friend WithEvents data_inici_mostra As DateTimePicker
    Friend WithEvents data_fi_mostra As DateTimePicker
    Friend WithEvents back As Button
    Friend WithEvents ubicacio As ComboBox
    Friend WithEvents esdeveniment As ComboBox
    Friend WithEvents departament As ComboBox
    Friend WithEvents places_actuals As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents descripcio As RichTextBox
End Class
