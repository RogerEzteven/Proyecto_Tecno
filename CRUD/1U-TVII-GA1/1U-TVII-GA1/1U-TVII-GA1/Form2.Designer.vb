<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_pais = New System.Windows.Forms.TextBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.bnt_cargar = New System.Windows.Forms.Button()
        Me.btn_borar = New System.Windows.Forms.Button()
        Me.bnt_editar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(310, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Administrador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Correo"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(108, 56)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 4
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(108, 102)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 5
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(108, 147)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(100, 20)
        Me.txt_correo.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(249, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(411, 219)
        Me.DataGridView1.TabIndex = 7
        '
        'btn_regresar
        '
        Me.btn_regresar.BackColor = System.Drawing.Color.Red
        Me.btn_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_regresar.Location = New System.Drawing.Point(12, 12)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(75, 23)
        Me.btn_regresar.TabIndex = 8
        Me.btn_regresar.Text = "Regresar"
        Me.btn_regresar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Pais"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Número"
        '
        'txt_pais
        '
        Me.txt_pais.Location = New System.Drawing.Point(108, 198)
        Me.txt_pais.Name = "txt_pais"
        Me.txt_pais.Size = New System.Drawing.Size(100, 20)
        Me.txt_pais.TabIndex = 11
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(108, 243)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(100, 20)
        Me.txt_numero.TabIndex = 12
        '
        'btn_insertar
        '
        Me.btn_insertar.BackColor = System.Drawing.Color.Gold
        Me.btn_insertar.Location = New System.Drawing.Point(108, 313)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(75, 23)
        Me.btn_insertar.TabIndex = 13
        Me.btn_insertar.Text = "Insertar"
        Me.btn_insertar.UseVisualStyleBackColor = False
        '
        'bnt_cargar
        '
        Me.bnt_cargar.BackColor = System.Drawing.Color.Gold
        Me.bnt_cargar.Location = New System.Drawing.Point(237, 313)
        Me.bnt_cargar.Name = "bnt_cargar"
        Me.bnt_cargar.Size = New System.Drawing.Size(75, 23)
        Me.bnt_cargar.TabIndex = 14
        Me.bnt_cargar.Text = "Cargar"
        Me.bnt_cargar.UseVisualStyleBackColor = False
        '
        'btn_borar
        '
        Me.btn_borar.BackColor = System.Drawing.Color.Gold
        Me.btn_borar.Location = New System.Drawing.Point(374, 313)
        Me.btn_borar.Name = "btn_borar"
        Me.btn_borar.Size = New System.Drawing.Size(75, 23)
        Me.btn_borar.TabIndex = 15
        Me.btn_borar.Text = "Borrar"
        Me.btn_borar.UseVisualStyleBackColor = False
        '
        'bnt_editar
        '
        Me.bnt_editar.BackColor = System.Drawing.Color.Gold
        Me.bnt_editar.Location = New System.Drawing.Point(488, 313)
        Me.bnt_editar.Name = "bnt_editar"
        Me.bnt_editar.Size = New System.Drawing.Size(75, 23)
        Me.bnt_editar.TabIndex = 16
        Me.bnt_editar.Text = "Editar"
        Me.bnt_editar.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(687, 382)
        Me.Controls.Add(Me.bnt_editar)
        Me.Controls.Add(Me.btn_borar)
        Me.Controls.Add(Me.bnt_cargar)
        Me.Controls.Add(Me.btn_insertar)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.txt_pais)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_regresar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_regresar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_pais As TextBox
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents btn_insertar As Button
    Friend WithEvents bnt_cargar As Button
    Friend WithEvents btn_borar As Button
    Friend WithEvents bnt_editar As Button
End Class
