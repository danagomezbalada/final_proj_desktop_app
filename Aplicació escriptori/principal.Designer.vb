<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.administrar_esdeveniments = New System.Windows.Forms.Button()
        Me.administrar_activitats = New System.Windows.Forms.Button()
        Me.gestionar_activitats = New System.Windows.Forms.Button()
        Me.gestionar_reserves = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'administrar_esdeveniments
        '
        Me.administrar_esdeveniments.Location = New System.Drawing.Point(37, 126)
        Me.administrar_esdeveniments.Name = "administrar_esdeveniments"
        Me.administrar_esdeveniments.Size = New System.Drawing.Size(160, 23)
        Me.administrar_esdeveniments.TabIndex = 0
        Me.administrar_esdeveniments.Text = "Administrar Esdeveniments"
        Me.administrar_esdeveniments.UseVisualStyleBackColor = True
        '
        'administrar_activitats
        '
        Me.administrar_activitats.Location = New System.Drawing.Point(496, 126)
        Me.administrar_activitats.Name = "administrar_activitats"
        Me.administrar_activitats.Size = New System.Drawing.Size(133, 23)
        Me.administrar_activitats.TabIndex = 1
        Me.administrar_activitats.Text = "Administrar Activitats"
        Me.administrar_activitats.UseVisualStyleBackColor = True
        '
        'gestionar_activitats
        '
        Me.gestionar_activitats.Location = New System.Drawing.Point(37, 304)
        Me.gestionar_activitats.Name = "gestionar_activitats"
        Me.gestionar_activitats.Size = New System.Drawing.Size(160, 38)
        Me.gestionar_activitats.TabIndex = 2
        Me.gestionar_activitats.Text = "Gestionar Activitats"
        Me.gestionar_activitats.UseVisualStyleBackColor = True
        '
        'gestionar_reserves
        '
        Me.gestionar_reserves.Location = New System.Drawing.Point(496, 304)
        Me.gestionar_reserves.Name = "gestionar_reserves"
        Me.gestionar_reserves.Size = New System.Drawing.Size(160, 38)
        Me.gestionar_reserves.TabIndex = 3
        Me.gestionar_reserves.Text = "Gestionar Reserves"
        Me.gestionar_reserves.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ajuntament de La Seu d'Urgell "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(262, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Agenda d'activitats"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(203, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(287, 284)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(694, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gestionar_reserves)
        Me.Controls.Add(Me.gestionar_activitats)
        Me.Controls.Add(Me.administrar_activitats)
        Me.Controls.Add(Me.administrar_esdeveniments)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents administrar_esdeveniments As Button
    Friend WithEvents administrar_activitats As Button
    Friend WithEvents gestionar_activitats As Button
    Friend WithEvents gestionar_reserves As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
