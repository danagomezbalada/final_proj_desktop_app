<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestio_ponent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestio_ponent))
        Me.Gestio_ponents = New System.Windows.Forms.Label()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cerca = New System.Windows.Forms.Button()
        Me.Editar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cognoms = New System.Windows.Forms.TextBox()
        Me.inici = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.Afegir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gestio_ponents
        '
        Me.Gestio_ponents.AutoSize = True
        Me.Gestio_ponents.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gestio_ponents.Location = New System.Drawing.Point(30, 13)
        Me.Gestio_ponents.Name = "Gestio_ponents"
        Me.Gestio_ponents.Size = New System.Drawing.Size(189, 31)
        Me.Gestio_ponents.TabIndex = 0
        Me.Gestio_ponents.Text = "Gestió Ponents"
        '
        'Nom
        '
        Me.Nom.CausesValidation = False
        Me.Nom.Location = New System.Drawing.Point(91, 62)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(100, 20)
        Me.Nom.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(600, 300)
        Me.DataGridView1.TabIndex = 14
        '
        'Cerca
        '
        Me.Cerca.Location = New System.Drawing.Point(440, 62)
        Me.Cerca.Name = "Cerca"
        Me.Cerca.Size = New System.Drawing.Size(75, 23)
        Me.Cerca.TabIndex = 15
        Me.Cerca.Text = "Cerca"
        Me.Cerca.UseVisualStyleBackColor = True
        '
        'Editar
        '
        Me.Editar.Location = New System.Drawing.Point(295, 413)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(75, 23)
        Me.Editar.TabIndex = 17
        Me.Editar.Text = "Editar"
        Me.Editar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(459, 413)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 18
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nom: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 19)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Cognoms:"
        '
        'Cognoms
        '
        Me.Cognoms.CausesValidation = False
        Me.Cognoms.Location = New System.Drawing.Point(302, 62)
        Me.Cognoms.Name = "Cognoms"
        Me.Cognoms.Size = New System.Drawing.Size(100, 20)
        Me.Cognoms.TabIndex = 21
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.inici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inici.Location = New System.Drawing.Point(602, 12)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(40, 35)
        Me.inici.TabIndex = 22
        Me.inici.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Location = New System.Drawing.Point(556, 12)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(40, 35)
        Me.back.TabIndex = 29
        Me.back.UseVisualStyleBackColor = True
        '
        'Afegir
        '
        Me.Afegir.Location = New System.Drawing.Point(136, 413)
        Me.Afegir.Name = "Afegir"
        Me.Afegir.Size = New System.Drawing.Size(75, 23)
        Me.Afegir.TabIndex = 16
        Me.Afegir.Text = "Afegir"
        Me.Afegir.UseVisualStyleBackColor = True
        '
        'gestio_ponent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(665, 450)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.Cognoms)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Editar)
        Me.Controls.Add(Me.Afegir)
        Me.Controls.Add(Me.Cerca)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.Gestio_ponents)
        Me.Name = "gestio_ponent"
        Me.Text = "gestio ponents"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Gestio_ponents As Label
    Friend WithEvents Nom As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cerca As Button
    Friend WithEvents Editar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cognoms As TextBox
    Friend WithEvents inici As Button
    Friend WithEvents back As Button
    Friend WithEvents Afegir As Button
End Class
