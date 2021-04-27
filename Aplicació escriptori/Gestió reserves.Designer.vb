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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cercar = New System.Windows.Forms.Button()
        Me.data = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.estat = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.editar = New System.Windows.Forms.Button()
        Me.inici = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Data:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 31)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Gestió Reserves"
        '
        'Cercar
        '
        Me.Cercar.Location = New System.Drawing.Point(432, 67)
        Me.Cercar.Name = "Cercar"
        Me.Cercar.Size = New System.Drawing.Size(75, 20)
        Me.Cercar.TabIndex = 16
        Me.Cercar.Text = "Cercar"
        Me.Cercar.UseVisualStyleBackColor = True
        '
        'data
        '
        Me.data.Location = New System.Drawing.Point(93, 67)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(100, 20)
        Me.data.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(224, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Estat:"
        '
        'estat
        '
        Me.estat.Location = New System.Drawing.Point(282, 67)
        Me.estat.Name = "estat"
        Me.estat.Size = New System.Drawing.Size(100, 20)
        Me.estat.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(600, 300)
        Me.DataGridView1.TabIndex = 21
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(295, 413)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(75, 23)
        Me.eliminar.TabIndex = 23
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'editar
        '
        Me.editar.Location = New System.Drawing.Point(136, 413)
        Me.editar.Name = "editar"
        Me.editar.Size = New System.Drawing.Size(75, 23)
        Me.editar.TabIndex = 22
        Me.editar.Text = "Editar"
        Me.editar.UseVisualStyleBackColor = True
        '
        'inici
        '
        Me.inici.BackgroundImage = CType(resources.GetObject("inici.BackgroundImage"), System.Drawing.Image)
        Me.inici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inici.Location = New System.Drawing.Point(602, 12)
        Me.inici.Name = "inici"
        Me.inici.Size = New System.Drawing.Size(40, 35)
        Me.inici.TabIndex = 24
        Me.inici.UseVisualStyleBackColor = True
        '
        'gestio_reserves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(665, 450)
        Me.Controls.Add(Me.inici)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.editar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.estat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cercar)
        Me.Controls.Add(Me.data)
        Me.Name = "gestio_reserves"
        Me.Text = "Gestió Reserves"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Cercar As Button
    Friend WithEvents data As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents estat As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents eliminar As Button
    Friend WithEvents editar As Button
    Friend WithEvents inici As Button
End Class
