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
        Me.Categories.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Categories.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Categories.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Categories.Location = New System.Drawing.Point(54, 73)
        Me.Categories.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Categories.Name = "Categories"
        Me.Categories.Size = New System.Drawing.Size(183, 40)
        Me.Categories.TabIndex = 1
        Me.Categories.Text = "Gestionar Categories"
        Me.Categories.UseVisualStyleBackColor = False
        '
        'Ubicacions
        '
        Me.Ubicacions.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Ubicacions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Ubicacions.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ubicacions.Location = New System.Drawing.Point(54, 132)
        Me.Ubicacions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ubicacions.Name = "Ubicacions"
        Me.Ubicacions.Size = New System.Drawing.Size(183, 40)
        Me.Ubicacions.TabIndex = 2
        Me.Ubicacions.Text = "Gestionar Ubicacions"
        Me.Ubicacions.UseVisualStyleBackColor = False
        '
        'Departaments
        '
        Me.Departaments.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Departaments.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Departaments.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Departaments.Location = New System.Drawing.Point(54, 193)
        Me.Departaments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Departaments.Name = "Departaments"
        Me.Departaments.Size = New System.Drawing.Size(183, 40)
        Me.Departaments.TabIndex = 3
        Me.Departaments.Text = "Gestionar Departaments"
        Me.Departaments.UseVisualStyleBackColor = False
        '
        'Ponents
        '
        Me.Ponents.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Ponents.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Ponents.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ponents.Location = New System.Drawing.Point(54, 250)
        Me.Ponents.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ponents.Name = "Ponents"
        Me.Ponents.Size = New System.Drawing.Size(183, 40)
        Me.Ponents.TabIndex = 5
        Me.Ponents.Text = "Gestionar Ponents"
        Me.Ponents.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(73, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 38)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Administrar Activitats"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(264, 73)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(239, 239)
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
        Me.inici.Location = New System.Drawing.Point(605, 16)
        Me.inici.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(50, 50)
        Me.inici.TabIndex = 24
        Me.inici.UseVisualStyleBackColor = True
        '
        'administrar_activitats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(688, 382)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Ponents)
        Me.Controls.Add(Me.Departaments)
        Me.Controls.Add(Me.Ubicacions)
        Me.Controls.Add(Me.Categories)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
