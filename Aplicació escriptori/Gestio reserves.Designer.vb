<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gestio_reserves
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestio_reserves))
        Me.inici = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.taula_reserves = New System.Windows.Forms.DataGridView()
        Me.Editar = New System.Windows.Forms.Button()
        Me.Cercar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.estat = New System.Windows.Forms.TextBox()
        Me.data = New System.Windows.Forms.DateTimePicker()
        Me.cercar_per_data = New System.Windows.Forms.CheckBox()
        CType(Me.taula_reserves, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.inici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inici.Location = New System.Drawing.Point(602, 12)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(38, 41)
        Me.inici.TabIndex = 24
        Me.inici.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(33, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Data:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(30, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 31)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Gestió Reserves"
        '
        'taula_reserves
        '
        Me.taula_reserves.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.taula_reserves.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.taula_reserves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.taula_reserves.Location = New System.Drawing.Point(30, 100)
        Me.taula_reserves.Name = "taula_reserves"
        Me.taula_reserves.RowHeadersWidth = 51
        Me.taula_reserves.Size = New System.Drawing.Size(600, 300)
        Me.taula_reserves.TabIndex = 21
        '
        'Editar
        '
        Me.Editar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Editar.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.Editar.Location = New System.Drawing.Point(291, 415)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(83, 27)
        Me.Editar.TabIndex = 19
        Me.Editar.Text = "Editar"
        Me.Editar.UseVisualStyleBackColor = False
        '
        'Cercar
        '
        Me.Cercar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Cercar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cercar.Font = New System.Drawing.Font("Calibri", 7.8!)
        Me.Cercar.Location = New System.Drawing.Point(571, 62)
        Me.Cercar.Name = "Cercar"
        Me.Cercar.Size = New System.Drawing.Size(73, 24)
        Me.Cercar.TabIndex = 17
        Me.Cercar.Text = "Cercar"
        Me.Cercar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(387, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Estat:"
        '
        'estat
        '
        Me.estat.Location = New System.Drawing.Point(439, 62)
        Me.estat.Name = "estat"
        Me.estat.Size = New System.Drawing.Size(100, 20)
        Me.estat.TabIndex = 25
        '
        'data
        '
        Me.data.Location = New System.Drawing.Point(84, 62)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(200, 20)
        Me.data.TabIndex = 27
        '
        'cercar_per_data
        '
        Me.cercar_per_data.AutoSize = True
        Me.cercar_per_data.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cercar_per_data.ForeColor = System.Drawing.SystemColors.Control
        Me.cercar_per_data.Location = New System.Drawing.Point(291, 64)
        Me.cercar_per_data.Name = "cercar_per_data"
        Me.cercar_per_data.Size = New System.Drawing.Size(101, 18)
        Me.cercar_per_data.TabIndex = 28
        Me.cercar_per_data.Text = "Cercar per data?"
        Me.cercar_per_data.UseVisualStyleBackColor = True
        '
        'gestio_reserves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(665, 450)
        Me.Controls.Add(Me.cercar_per_data)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.estat)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.taula_reserves)
        Me.Controls.Add(Me.Editar)
        Me.Controls.Add(Me.Cercar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gestio_reserves"
        Me.Text = "Gestió Reserves"
        CType(Me.taula_reserves, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inici As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents taula_reserves As DataGridView
    Friend WithEvents Editar As Button
    Friend WithEvents Cercar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents estat As TextBox
    Friend WithEvents data As DateTimePicker
    Friend WithEvents cercar_per_data As CheckBox
End Class
