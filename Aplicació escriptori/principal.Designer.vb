<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.Activitats = New System.Windows.Forms.Button()
        Me.Categories = New System.Windows.Forms.Button()
        Me.Ubicacions = New System.Windows.Forms.Button()
        Me.Departaments = New System.Windows.Forms.Button()
        Me.Esdeveniments = New System.Windows.Forms.Button()
        Me.Ponents = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Activitats
        '
        Me.Activitats.Location = New System.Drawing.Point(74, 22)
        Me.Activitats.Name = "Activitats"
        Me.Activitats.Size = New System.Drawing.Size(135, 23)
        Me.Activitats.TabIndex = 0
        Me.Activitats.Text = "Gestionar Activitats"
        Me.Activitats.UseVisualStyleBackColor = True
        '
        'Categories
        '
        Me.Categories.Location = New System.Drawing.Point(74, 70)
        Me.Categories.Name = "Categories"
        Me.Categories.Size = New System.Drawing.Size(135, 23)
        Me.Categories.TabIndex = 1
        Me.Categories.Text = "Gestionar Categories"
        Me.Categories.UseVisualStyleBackColor = True
        '
        'Ubicacions
        '
        Me.Ubicacions.Location = New System.Drawing.Point(74, 119)
        Me.Ubicacions.Name = "Ubicacions"
        Me.Ubicacions.Size = New System.Drawing.Size(135, 23)
        Me.Ubicacions.TabIndex = 2
        Me.Ubicacions.Text = "Gestionar Ubicacions"
        Me.Ubicacions.UseVisualStyleBackColor = True
        '
        'Departaments
        '
        Me.Departaments.Location = New System.Drawing.Point(74, 175)
        Me.Departaments.Name = "Departaments"
        Me.Departaments.Size = New System.Drawing.Size(135, 23)
        Me.Departaments.TabIndex = 3
        Me.Departaments.Text = "Gestionar Departaments"
        Me.Departaments.UseVisualStyleBackColor = True
        '
        'Esdeveniments
        '
        Me.Esdeveniments.Location = New System.Drawing.Point(74, 220)
        Me.Esdeveniments.Name = "Esdeveniments"
        Me.Esdeveniments.Size = New System.Drawing.Size(135, 23)
        Me.Esdeveniments.TabIndex = 4
        Me.Esdeveniments.Text = "Gestionar Esdeveniments"
        Me.Esdeveniments.UseVisualStyleBackColor = True
        '
        'Ponents
        '
        Me.Ponents.Location = New System.Drawing.Point(74, 268)
        Me.Ponents.Name = "Ponents"
        Me.Ponents.Size = New System.Drawing.Size(135, 23)
        Me.Ponents.TabIndex = 5
        Me.Ponents.Text = "Gestionar Ponents"
        Me.Ponents.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(292, 328)
        Me.Controls.Add(Me.Ponents)
        Me.Controls.Add(Me.Esdeveniments)
        Me.Controls.Add(Me.Departaments)
        Me.Controls.Add(Me.Ubicacions)
        Me.Controls.Add(Me.Categories)
        Me.Controls.Add(Me.Activitats)
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Activitats As Button
    Friend WithEvents Categories As Button
    Friend WithEvents Ubicacions As Button
    Friend WithEvents Departaments As Button
    Friend WithEvents Esdeveniments As Button
    Friend WithEvents Ponents As Button
End Class
