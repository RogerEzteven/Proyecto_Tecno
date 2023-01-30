Imports System.Data.SqlClient
Public Class Form4

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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        Me.Hide()
        Form1.Show()
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
End Class