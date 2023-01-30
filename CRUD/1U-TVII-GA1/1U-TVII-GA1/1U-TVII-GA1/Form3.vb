Imports System.Data.SqlClient
Public Class Form3

    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim mensaje, sentencia As String

    Sub EjecutarSql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub bnt_cargar_Click(sender As Object, e As EventArgs) Handles bnt_cargar.Click
        Try
            Dim da As New SqlDataAdapter("Select *from Usuarios", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_borar_Click(sender As Object, e As EventArgs) Handles btn_borar.Click
        sentencia = "Delete Usuarios where ID = " + txt_id.Text + " "
        mensaje = "Datos eliminados correctamente"
        EjecutarSql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select *from Usuarios", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bnt_editar_Click(sender As Object, e As EventArgs) Handles bnt_editar.Click
        sentencia = "Update Usuarios Set Nombre= '" + txt_nombre.Text + "',Correo='" + txt_correo.Text + "',Pais='" + txt_pais.Text + "',Numero=" + txt_numero.Text + " where ID= " + txt_id.Text + ""
        mensaje = "Datos actualizados correctamente"
        EjecutarSql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select *from Usuarios", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
            txt_correo.Text = " "
            txt_id.Text = " "
            txt_nombre.Text = " "
            txt_numero.Text = " "
            txt_pais.Text = " "
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class