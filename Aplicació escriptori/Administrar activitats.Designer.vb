<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class administrar_activitats
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administrar_activitats))
        Me.Categories = New System.Windows.Forms.Button()
        Me.Ubicacions = New System.Windows.Forms.Button()
        Me.Departaments = New System.Windows.Forms.Button()
        Me.Ponents = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.inici = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Categories
        '
        Me.Categories.Location = New System.Drawing.Point(22, 59)
        Me.Categories.Name = "Categories"
        Me.Categories.Size = New System.Drawing.Size(135, 23)
        Me.Categories.TabIndex = 1
        Me.Categories.Text = "Gestionar Categories"
        Me.Categories.UseVisualStyleBackColor = True
        '
        'Ubicacions
        '
        Me.Ubicacions.Location = New System.Drawing.Point(22, 102)
        Me.Ubicacions.Name = "Ubicacions"
        Me.Ubicacions.Size = New System.Drawing.Size(135, 23)
        Me.Ubicacions.TabIndex = 2
        Me.Ubicacions.Text = "Gestionar Ubicacions"
        Me.Ubicacions.UseVisualStyleBackColor = True
        '
        'Departaments
        '
        Me.Departaments.Location = New System.Drawing.Point(22, 151)
        Me.Departaments.Name = "Departaments"
        Me.Departaments.Size = New System.Drawing.Size(135, 23)
        Me.Departaments.TabIndex = 3
        Me.Departaments.Text = "Gestionar Departaments"
        Me.Departaments.UseVisualStyleBackColor = True
        '
        'Ponents
        '
        Me.Ponents.Location = New System.Drawing.Point(22, 197)
        Me.Ponents.Name = "Ponents"
        Me.Ponents.Size = New System.Drawing.Size(135, 23)
        Me.Ponents.TabIndex = 5
        Me.Ponents.Text = "Gestionar Ponents"
        Me.Ponents.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Administrar Activitats"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(198, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.inici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inici.Location = New System.Drawing.Point(454, 13)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(40, 35)
        Me.inici.TabIndex = 24
        Me.inici.UseVisualStyleBackColor = True
        '
        'administrar_activitats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(516, 310)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Ponents)
        Me.Controls.Add(Me.Departaments)
        Me.Controls.Add(Me.Ubicacions)
        Me.Controls.Add(Me.Categories)
        Me.Name = "administrar_activitats"
        Me.Text = "Administrar Activitats"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Categories As Button
    Friend WithEvents Ubicacions As Button
    Friend WithEvents Departaments As Button
    Friend WithEvents Ponents As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents inici As Button
End Class
