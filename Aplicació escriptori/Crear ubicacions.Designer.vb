﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crear_ubicacio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(crear_ubicacio))
        Me.label1 = New System.Windows.Forms.Label()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.Crear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inici = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.Control
        Me.label1.Location = New System.Drawing.Point(135, 95)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(61, 23)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Nom: "
        '
        'Nom
        '
        Me.Nom.Location = New System.Drawing.Point(210, 95)
        Me.Nom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(132, 22)
        Me.Nom.TabIndex = 2
        '
        'Crear
        '
        Me.Crear.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Crear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Crear.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Crear.Location = New System.Drawing.Point(175, 151)
        Me.Crear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Crear.Name = "Crear"
        Me.Crear.Size = New System.Drawing.Size(117, 54)
        Me.Crear.TabIndex = 3
        Me.Crear.Text = "Crear"
        Me.Crear.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(23, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 38)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Crear Ubicacions"
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.inici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inici.Location = New System.Drawing.Point(421, 20)
        Me.inici.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(50, 50)
        Me.inici.TabIndex = 19
        Me.inici.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Location = New System.Drawing.Point(360, 20)
        Me.back.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(50, 50)
        Me.back.TabIndex = 21
        Me.back.UseVisualStyleBackColor = True
        '
        'crear_ubicacio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(489, 236)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Crear)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "crear_ubicacio"
        Me.Text = "Crear Ubicació"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents Nom As TextBox
    Friend WithEvents Crear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents inici As Button
    Friend WithEvents back As Button
End Class
