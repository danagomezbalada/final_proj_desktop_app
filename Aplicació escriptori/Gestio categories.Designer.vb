<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gestio_categoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestio_categoria))
        Me.Categories = New System.Windows.Forms.Label()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.Cercar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Afegir = New System.Windows.Forms.Button()
        Me.Editar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inici = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Categories
        '
        Me.Categories.AutoSize = True
        Me.Categories.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Categories.ForeColor = System.Drawing.SystemColors.Control
        Me.Categories.Location = New System.Drawing.Point(40, 16)
        Me.Categories.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Categories.Name = "Categories"
        Me.Categories.Size = New System.Drawing.Size(271, 38)
        Me.Categories.TabIndex = 0
        Me.Categories.Text = "Gestió Categories"
        '
        'Nom
        '
        Me.Nom.Location = New System.Drawing.Point(121, 76)
        Me.Nom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(132, 22)
        Me.Nom.TabIndex = 1
        '
        'Cercar
        '
        Me.Cercar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Cercar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cercar.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Cercar.Location = New System.Drawing.Point(270, 72)
        Me.Cercar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cercar.Name = "Cercar"
        Me.Cercar.Size = New System.Drawing.Size(104, 31)
        Me.Cercar.TabIndex = 2
        Me.Cercar.Text = "Cercar"
        Me.Cercar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 123)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(800, 369)
        Me.DataGridView1.TabIndex = 13
        '
        'Afegir
        '
        Me.Afegir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Afegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Afegir.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Afegir.Location = New System.Drawing.Point(175, 500)
        Me.Afegir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Afegir.Name = "Afegir"
        Me.Afegir.Size = New System.Drawing.Size(104, 31)
        Me.Afegir.TabIndex = 14
        Me.Afegir.Text = "Afegir"
        Me.Afegir.UseVisualStyleBackColor = False
        '
        'Editar
        '
        Me.Editar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Editar.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Editar.Location = New System.Drawing.Point(387, 500)
        Me.Editar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(104, 31)
        Me.Editar.TabIndex = 15
        Me.Editar.Text = "Editar"
        Me.Editar.UseVisualStyleBackColor = False
        '
        'Eliminar
        '
        Me.Eliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Eliminar.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Eliminar.Location = New System.Drawing.Point(606, 500)
        Me.Eliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(104, 31)
        Me.Eliminar.TabIndex = 16
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(44, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nom:"
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.inici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inici.Location = New System.Drawing.Point(803, 15)
        Me.inici.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(50, 50)
        Me.inici.TabIndex = 18
        Me.inici.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Location = New System.Drawing.Point(741, 15)
        Me.back.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(50, 50)
        Me.back.TabIndex = 29
        Me.back.UseVisualStyleBackColor = True
        '
        'gestio_categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(887, 554)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Editar)
        Me.Controls.Add(Me.Afegir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Cercar)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.Categories)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "gestio_categoria"
        Me.Text = "gestio categories"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Categories As Label
    Friend WithEvents Nom As TextBox
    Friend WithEvents Cercar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Afegir As Button
    Friend WithEvents Editar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents inici As Button
    Friend WithEvents back As Button
End Class
