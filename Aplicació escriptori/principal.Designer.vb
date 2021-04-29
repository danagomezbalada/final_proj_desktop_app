<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(principal))
        Me.administrar_esdeveniments = New System.Windows.Forms.Button()
        Me.activitats = New System.Windows.Forms.Button()
        Me.gestionar_activitats = New System.Windows.Forms.Button()
        Me.gestionar_reserves = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.generar_fitxer = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'administrar_esdeveniments
        '
        Me.administrar_esdeveniments.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.administrar_esdeveniments.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.administrar_esdeveniments.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.administrar_esdeveniments.Location = New System.Drawing.Point(98, 155)
        Me.administrar_esdeveniments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.administrar_esdeveniments.Name = "administrar_esdeveniments"
        Me.administrar_esdeveniments.Size = New System.Drawing.Size(165, 70)
        Me.administrar_esdeveniments.TabIndex = 0
        Me.administrar_esdeveniments.Text = "Administrar Esdeveniments"
        Me.administrar_esdeveniments.UseVisualStyleBackColor = False
        '
        'activitats
        '
        Me.activitats.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.activitats.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.activitats.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activitats.Location = New System.Drawing.Point(662, 155)
        Me.activitats.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.activitats.Name = "activitats"
        Me.activitats.Size = New System.Drawing.Size(165, 70)
        Me.activitats.TabIndex = 1
        Me.activitats.Text = "Administrar Activitats"
        Me.activitats.UseVisualStyleBackColor = False
        '
        'gestionar_activitats
        '
        Me.gestionar_activitats.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gestionar_activitats.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gestionar_activitats.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gestionar_activitats.Location = New System.Drawing.Point(98, 286)
        Me.gestionar_activitats.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gestionar_activitats.Name = "gestionar_activitats"
        Me.gestionar_activitats.Size = New System.Drawing.Size(165, 70)
        Me.gestionar_activitats.TabIndex = 2
        Me.gestionar_activitats.Text = "Gestionar Activitats"
        Me.gestionar_activitats.UseVisualStyleBackColor = False
        '
        'gestionar_reserves
        '
        Me.gestionar_reserves.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gestionar_reserves.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gestionar_reserves.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gestionar_reserves.Location = New System.Drawing.Point(662, 286)
        Me.gestionar_reserves.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gestionar_reserves.Name = "gestionar_reserves"
        Me.gestionar_reserves.Size = New System.Drawing.Size(165, 70)
        Me.gestionar_reserves.TabIndex = 3
        Me.gestionar_reserves.Text = "Gestionar Reserves"
        Me.gestionar_reserves.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(211, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(482, 38)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ajuntament de La Seu d'Urgell "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(349, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Agenda d'activitats"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(271, 96)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(383, 350)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'generar_fitxer
        '
        Me.generar_fitxer.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.generar_fitxer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.generar_fitxer.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.generar_fitxer.Location = New System.Drawing.Point(397, 453)
        Me.generar_fitxer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.generar_fitxer.Name = "generar_fitxer"
        Me.generar_fitxer.Size = New System.Drawing.Size(136, 43)
        Me.generar_fitxer.TabIndex = 7
        Me.generar_fitxer.Text = "Generar Fitxer"
        Me.generar_fitxer.UseVisualStyleBackColor = False
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(925, 554)
        Me.Controls.Add(Me.generar_fitxer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gestionar_reserves)
        Me.Controls.Add(Me.gestionar_activitats)
        Me.Controls.Add(Me.activitats)
        Me.Controls.Add(Me.administrar_esdeveniments)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "principal"
        Me.Text = "Principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents administrar_esdeveniments As Button
    Friend WithEvents activitats As Button
    Friend WithEvents gestionar_activitats As Button
    Friend WithEvents gestionar_reserves As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents generar_fitxer As Button
End Class
