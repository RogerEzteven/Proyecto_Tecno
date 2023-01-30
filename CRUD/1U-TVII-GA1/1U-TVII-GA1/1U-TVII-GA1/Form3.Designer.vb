<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bnt_editar = New System.Windows.Forms.Button()
        Me.btn_borar = New System.Windows.Forms.Button()
        Me.bnt_cargar = New System.Windows.Forms.Button()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.txt_pais = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnt_editar
        '
        Me.bnt_editar.BackColor = System.Drawing.Color.Gold
        Me.bnt_editar.Location = New System.Drawing.Point(522, 381)
        Me.bnt_editar.Name = "bnt_editar"
        Me.bnt_editar.Size = New System.Drawing.Size(75, 23)
        Me.bnt_editar.TabIndex = 33
        Me.bnt_editar.Text = "Editar"
        Me.bnt_editar.UseVisualStyleBackColor = False
        '
        'btn_borar
        '
        Me.btn_borar.BackColor = System.Drawing.Color.Gold
        Me.btn_borar.Location = New System.Drawing.Point(382, 381)
        Me.btn_borar.Name = "btn_borar"
        Me.btn_borar.Size = New System.Drawing.Size(75, 23)
        Me.btn_borar.TabIndex = 32
        Me.btn_borar.Text = "Borrar"
        Me.btn_borar.UseVisualStyleBackColor = False
        '
        'bnt_cargar
        '
        Me.bnt_cargar.BackColor = System.Drawing.Color.Gold
        Me.bnt_cargar.Location = New System.Drawing.Point(233, 381)
        Me.bnt_cargar.Name = "bnt_cargar"
        Me.bnt_cargar.Size = New System.Drawing.Size(75, 23)
        Me.bnt_cargar.TabIndex = 31
        Me.bnt_cargar.Text = "Cargar"
        Me.bnt_cargar.UseVisualStyleBackColor = False
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(162, 311)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(100, 20)
        Me.txt_numero.TabIndex = 29
        '
        'txt_pais
        '
        Me.txt_pais.Location = New System.Drawing.Point(162, 266)
        Me.txt_pais.Name = "txt_pais"
        Me.txt_pais.Size = New System.Drawing.Size(100, 20)
        Me.txt_pais.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Número"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Pais"
        '
        'btn_regresar
        '
        Me.btn_regresar.BackColor = System.Drawing.Color.Red
        Me.btn_regresar.Location = New System.Drawing.Point(66, 80)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(75, 23)
        Me.btn_regresar.TabIndex = 25
        Me.btn_regresar.Text = "Regresar"
        Me.btn_regresar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(303, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(411, 219)
        Me.DataGridView1.TabIndex = 24
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(162, 215)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(100, 20)
        Me.txt_correo.TabIndex = 23
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(162, 170)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 22
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(162, 124)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Correo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(361, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Secretaria"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(782, 444)
        Me.Controls.Add(Me.bnt_editar)
        Me.Controls.Add(Me.btn_borar)
        Me.Controls.Add(Me.bnt_cargar)
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
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bnt_editar As Button
    Friend WithEvents btn_borar As Button
    Friend WithEvents bnt_cargar As Button
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents txt_pais As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_regresar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
