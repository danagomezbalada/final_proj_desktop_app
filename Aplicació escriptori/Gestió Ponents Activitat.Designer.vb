<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gestio_ponents_activitat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestio_ponents_activitat))
        Me.taula_ponents_actuals = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Afegir = New System.Windows.Forms.Button()
        Me.Gestio_ponents = New System.Windows.Forms.Label()
        Me.taula_ponents_disponibles = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Button()
        Me.inici = New System.Windows.Forms.Button()
        CType(Me.taula_ponents_actuals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.taula_ponents_disponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'taula_ponents_actuals
        '
        Me.taula_ponents_actuals.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.taula_ponents_actuals.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.taula_ponents_actuals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.taula_ponents_actuals.Location = New System.Drawing.Point(15, 124)
        Me.taula_ponents_actuals.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.taula_ponents_actuals.Name = "taula_ponents_actuals"
        Me.taula_ponents_actuals.RowHeadersWidth = 51
        Me.taula_ponents_actuals.Size = New System.Drawing.Size(443, 369)
        Me.taula_ponents_actuals.TabIndex = 15
        '
        'Eliminar
        '
        Me.Eliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Eliminar.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.Eliminar.Location = New System.Drawing.Point(165, 511)
        Me.Eliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(111, 33)
        Me.Eliminar.TabIndex = 21
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = False
        '
        'Afegir
        '
        Me.Afegir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Afegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Afegir.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.Afegir.Location = New System.Drawing.Point(661, 511)
        Me.Afegir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Afegir.Name = "Afegir"
        Me.Afegir.Size = New System.Drawing.Size(111, 33)
        Me.Afegir.TabIndex = 19
        Me.Afegir.Text = "Afegir"
        Me.Afegir.UseVisualStyleBackColor = False
        '
        'Gestio_ponents
        '
        Me.Gestio_ponents.AutoSize = True
        Me.Gestio_ponents.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gestio_ponents.ForeColor = System.Drawing.SystemColors.Control
        Me.Gestio_ponents.Location = New System.Drawing.Point(40, 16)
        Me.Gestio_ponents.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Gestio_ponents.Name = "Gestio_ponents"
        Me.Gestio_ponents.Size = New System.Drawing.Size(426, 38)
        Me.Gestio_ponents.TabIndex = 22
        Me.Gestio_ponents.Text = "Gestió Ponents de l'Activitat"
        '
        'taula_ponents_disponibles
        '
        Me.taula_ponents_disponibles.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.taula_ponents_disponibles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.taula_ponents_disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.taula_ponents_disponibles.Location = New System.Drawing.Point(491, 124)
        Me.taula_ponents_disponibles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.taula_ponents_disponibles.Name = "taula_ponents_disponibles"
        Me.taula_ponents_disponibles.RowHeadersWidth = 51
        Me.taula_ponents_disponibles.Size = New System.Drawing.Size(428, 369)
        Me.taula_ponents_disponibles.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(155, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 38)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Actuals"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(611, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 38)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Disponibles"
        '
        'back
        '
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Location = New System.Drawing.Point(787, 16)
        Me.back.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(50, 50)
        Me.back.TabIndex = 43
        Me.back.UseVisualStyleBackColor = True
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.inici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inici.Location = New System.Drawing.Point(847, 16)
        Me.inici.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(50, 50)
        Me.inici.TabIndex = 42
        Me.inici.UseVisualStyleBackColor = True
        '
        'gestio_ponents_activitat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(932, 554)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.taula_ponents_disponibles)
        Me.Controls.Add(Me.Gestio_ponents)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Afegir)
        Me.Controls.Add(Me.taula_ponents_actuals)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "gestio_ponents_activitat"
        Me.Text = "Gestió Ponents Activitat"
        CType(Me.taula_ponents_actuals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.taula_ponents_disponibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents taula_ponents_actuals As DataGridView
    Friend WithEvents Eliminar As Button
    Friend WithEvents Afegir As Button
    Friend WithEvents Gestio_ponents As Label
    Friend WithEvents taula_ponents_disponibles As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents back As Button
    Friend WithEvents inici As Button
End Class
