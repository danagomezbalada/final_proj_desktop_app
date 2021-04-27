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
        Me.descripcio = New System.Windows.Forms.TextBox()
        Me.preu = New System.Windows.Forms.TextBox()
        Me.places_totals = New System.Windows.Forms.TextBox()
        Me.crear = New System.Windows.Forms.Button()
        Me.inici = New System.Windows.Forms.Button()
        Me.id_esdeveniment = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.id_ubicacio = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.id_departament = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.data = New System.Windows.Forms.DateTimePicker()
        Me.data_fi_mostra = New System.Windows.Forms.DateTimePicker()
        Me.data_inici_mostra = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Crear Activitats"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Títol:"
        '
        'titol
        '
        Me.titol.Location = New System.Drawing.Point(99, 70)
        Me.titol.Name = "titol"
        Me.titol.Size = New System.Drawing.Size(100, 20)
        Me.titol.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Preu:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Descripció:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Data:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(302, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Data fi mostra:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(302, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 19)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Data inici mostra:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(302, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 19)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Places totals:"
        '
        'descripcio
        '
        Me.descripcio.Location = New System.Drawing.Point(140, 190)
        Me.descripcio.Name = "descripcio"
        Me.descripcio.Size = New System.Drawing.Size(100, 20)
        Me.descripcio.TabIndex = 12
        '
        'preu
        '
        Me.preu.Location = New System.Drawing.Point(99, 150)
        Me.preu.Name = "preu"
        Me.preu.Size = New System.Drawing.Size(100, 20)
        Me.preu.TabIndex = 13
        '
        'places_totals
        '
        Me.places_totals.Location = New System.Drawing.Point(417, 70)
        Me.places_totals.Name = "places_totals"
        Me.places_totals.Size = New System.Drawing.Size(100, 20)
        Me.places_totals.TabIndex = 14
        '
        'crear
        '
        Me.crear.Location = New System.Drawing.Point(232, 299)
        Me.crear.Name = "crear"
        Me.crear.Size = New System.Drawing.Size(97, 31)
        Me.crear.TabIndex = 17
        Me.crear.Text = "Crear"
        Me.crear.UseVisualStyleBackColor = True
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.Location = New System.Drawing.Point(546, 12)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(40, 35)
        Me.inici.TabIndex = 18
        Me.inici.UseVisualStyleBackColor = True
        '
        'id_esdeveniment
        '
        Me.id_esdeveniment.Location = New System.Drawing.Point(437, 190)
        Me.id_esdeveniment.Name = "id_esdeveniment"
        Me.id_esdeveniment.Size = New System.Drawing.Size(100, 20)
        Me.id_esdeveniment.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(302, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 19)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Id Esdeveniment:"
        '
        'id_ubicacio
        '
        Me.id_ubicacio.Location = New System.Drawing.Point(140, 230)
        Me.id_ubicacio.Name = "id_ubicacio"
        Me.id_ubicacio.Size = New System.Drawing.Size(100, 20)
        Me.id_ubicacio.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(43, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 19)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Id Ubicacio:"
        '
        'id_departament
        '
        Me.id_departament.Location = New System.Drawing.Point(437, 230)
        Me.id_departament.Name = "id_departament"
        Me.id_departament.Size = New System.Drawing.Size(100, 20)
        Me.id_departament.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(302, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 19)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Id Department:"
        '
        'data
        '
        Me.data.CalendarFont = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data.Location = New System.Drawing.Point(99, 110)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(170, 18)
        Me.data.TabIndex = 25
        '
        'data_fi_mostra
        '
        Me.data_fi_mostra.CalendarFont = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_fi_mostra.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_fi_mostra.Location = New System.Drawing.Point(417, 110)
        Me.data_fi_mostra.Name = "data_fi_mostra"
        Me.data_fi_mostra.Size = New System.Drawing.Size(170, 18)
        Me.data_fi_mostra.TabIndex = 26
        '
        'data_inici_mostra
        '
        Me.data_inici_mostra.CalendarFont = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_inici_mostra.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_inici_mostra.Location = New System.Drawing.Point(428, 150)
        Me.data_inici_mostra.Name = "data_inici_mostra"
        Me.data_inici_mostra.Size = New System.Drawing.Size(168, 18)
        Me.data_inici_mostra.TabIndex = 27
        '
        'crear_activitat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(609, 387)
        Me.Controls.Add(Me.data_inici_mostra)
        Me.Controls.Add(Me.data_fi_mostra)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.id_departament)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.id_ubicacio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.id_esdeveniment)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.crear)
        Me.Controls.Add(Me.places_totals)
        Me.Controls.Add(Me.preu)
        Me.Controls.Add(Me.descripcio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.titol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents descripcio As TextBox
    Friend WithEvents preu As TextBox
    Friend WithEvents places_totals As TextBox
    Friend WithEvents crear As Button
    Friend WithEvents inici As Button
    Friend WithEvents id_esdeveniment As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents id_ubicacio As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents id_departament As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents data As DateTimePicker
    Friend WithEvents data_fi_mostra As DateTimePicker
    Friend WithEvents data_inici_mostra As DateTimePicker
End Class
