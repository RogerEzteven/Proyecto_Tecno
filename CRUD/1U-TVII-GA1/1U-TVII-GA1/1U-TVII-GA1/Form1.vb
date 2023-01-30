Imports System.Data.SqlClient
Public Class Form1

    Public con As SqlConnection = New SqlConnection(My.Settings.Conexion)
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public cmd As SqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Function Verifricacion(ByVal sql)

        con.Open()
        cmd = New SqlCommand(sql, con)
        Dim i As Integer = cmd.ExecuteNonQuery
        con.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim verificAR As String = "Update login set roll=roll where Nombre='" + TextBox1.Text + "'and contrasena='" + TextBox2.Text + "' and roLl='Administrador'"

        Dim verificacion1 As String = "Update login set roll=roll where Nombre='" + TextBox1.Text + "'and contrasena='" + TextBox2.Text + "' and roll='Secretaria'"

        Dim verificacion2 As String = "Update login set roll=roll where Nombre='" + TextBox1.Text + "'and contrasena='" + TextBox2.Text + "' and roll='Usuario'"

        If Verifricacion(verificAR) Then
            MsgBox("Administrador")
            Me.Hide()
            TextBox1.Text = " "
            TextBox2.Text = " "
            Form2.Show()
        ElseIf Verifricacion(verificacion1)
            MsgBox("Secretaria")
            Me.Hide()
            TextBox1.Text = " "
            TextBox2.Text = " "
            Form3.Show()
        ElseIf Verifricacion(verificacion2)
            MsgBox("Usuario")
            Me.Hide()
            TextBox1.Text = " "
            TextBox2.Text = " "
            Form4.Show()

        End If
    End Sub
End Class
