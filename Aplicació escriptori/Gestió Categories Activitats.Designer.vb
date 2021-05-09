<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestio_categories_activitat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestio_categories_activitat))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.taula_categoria_disponibles = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.afegir = New System.Windows.Forms.Button()
        Me.taula_categoria_actuals = New System.Windows.Forms.DataGridView()
        Me.Gestio_ponents = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Button()
        Me.inici = New System.Windows.Forms.Button()
        CType(Me.taula_categoria_disponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.taula_categoria_actuals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(627, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 38)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Disponibles"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(132, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 38)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Actuals"
        '
        'taula_categoria_disponibles
        '
        Me.taula_categoria_disponibles.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.taula_categoria_disponibles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.taula_categoria_disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.taula_categoria_disponibles.Location = New System.Drawing.Point(548, 124)
        Me.taula_categoria_disponibles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.taula_categoria_disponibles.Name = "taula_categoria_disponibles"
        Me.taula_categoria_disponibles.RowHeadersWidth = 51
        Me.taula_categoria_disponibles.Size = New System.Drawing.Size(352, 369)
        Me.taula_categoria_disponibles.TabIndex = 29
        '
        'eliminar
        '
        Me.eliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.eliminar.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.eliminar.Location = New System.Drawing.Point(140, 511)
        Me.eliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(111, 33)
        Me.eliminar.TabIndex = 28
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.UseVisualStyleBackColor = False
        '
        'afegir
        '
        Me.afegir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.afegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.afegir.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.afegir.Location = New System.Drawing.Point(687, 511)
        Me.afegir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.afegir.Name = "afegir"
        Me.afegir.Size = New System.Drawing.Size(111, 33)
        Me.afegir.TabIndex = 27
        Me.afegir.Text = "Afegir"
        Me.afegir.UseVisualStyleBackColor = False
        '
        'taula_categoria_actuals
        '
        Me.taula_categoria_actuals.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.taula_categoria_actuals.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.taula_categoria_actuals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.taula_categoria_actuals.Location = New System.Drawing.Point(29, 124)
        Me.taula_categoria_actuals.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.taula_categoria_actuals.Name = "taula_categoria_actuals"
        Me.taula_categoria_actuals.RowHeadersWidth = 51
        Me.taula_categoria_actuals.Size = New System.Drawing.Size(352, 369)
        Me.taula_categoria_actuals.TabIndex = 26
        '
        'Gestio_ponents
        '
        Me.Gestio_ponents.AutoSize = True
        Me.Gestio_ponents.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gestio_ponents.ForeColor = System.Drawing.SystemColors.Control
        Me.Gestio_ponents.Location = New System.Drawing.Point(40, 16)
        Me.Gestio_ponents.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Gestio_ponents.Name = "Gestio_ponents"
        Me.Gestio_ponents.Size = New System.Drawing.Size(465, 38)
        Me.Gestio_ponents.TabIndex = 32
        Me.Gestio_ponents.Text = "Gestió Categories de l'Activitat"
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
        Me.back.TabIndex = 45
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
        Me.inici.TabIndex = 44
        Me.inici.UseVisualStyleBackColor = True
        '
        'gestio_categories_activitat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(932, 554)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.Gestio_ponents)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.taula_categoria_disponibles)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.afegir)
        Me.Controls.Add(Me.taula_categoria_actuals)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "gestio_categories_activitat"
        Me.Text = "Gestió Categories de l'Activitat"
        CType(Me.taula_categoria_disponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.taula_categoria_actuals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents taula_categoria_disponibles As DataGridView
    Friend WithEvents eliminar As Button
    Friend WithEvents afegir As Button
    Friend WithEvents taula_categoria_actuals As DataGridView
    Friend WithEvents Gestio_ponents As Label
    Friend WithEvents back As Button
    Friend WithEvents inici As Button
End Class
