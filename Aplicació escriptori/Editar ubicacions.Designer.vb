﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editar_ubicacions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editar_ubicacions))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.actualitzar = New System.Windows.Forms.Button()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.inici = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.identificador = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(23, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 38)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Editar Ubicacions"
        '
        'actualitzar
        '
        Me.actualitzar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.actualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.actualitzar.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.actualitzar.Location = New System.Drawing.Point(181, 159)
        Me.actualitzar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.actualitzar.Name = "actualitzar"
        Me.actualitzar.Size = New System.Drawing.Size(115, 37)
        Me.actualitzar.TabIndex = 7
        Me.actualitzar.Text = "Actualitzar"
        Me.actualitzar.UseVisualStyleBackColor = False
        '
        'Nom
        '
        Me.Nom.Location = New System.Drawing.Point(211, 87)
        Me.Nom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(132, 22)
        Me.Nom.TabIndex = 6
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.Control
        Me.label1.Location = New System.Drawing.Point(136, 87)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(61, 23)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Nom: "
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
        'identificador
        '
        Me.identificador.Location = New System.Drawing.Point(451, 197)
        Me.identificador.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.identificador.Name = "identificador"
        Me.identificador.Size = New System.Drawing.Size(32, 22)
        Me.identificador.TabIndex = 22
        Me.identificador.Visible = False
        '
        'editar_ubicacions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(489, 236)
        Me.Controls.Add(Me.identificador)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.actualitzar)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "editar_ubicacions"
        Me.Text = "Editar ubicacions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents actualitzar As Button
    Friend WithEvents Nom As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents inici As Button
    Friend WithEvents back As Button
    Friend WithEvents identificador As TextBox
End Class
