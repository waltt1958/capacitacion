Imports System.Data.OleDb

Partial Class altaUsuario
    Inherits System.Web.UI.Page

    Protected Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btcancelar.Click
        legajo.Text = String.Empty
        aYnombre.Text = String.Empty
        password.Text = String.Empty
        password1.Text = String.Empty
        legajo.Focus()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        legajo.Focus()
    End Sub

    Protected Sub btaceptar_Click(sender As Object, e As EventArgs) Handles btaceptar.Click

        Dim con As New OleDbConnection
        Dim sql As String
        Dim insertar As String
        Dim resultado As Integer


        sql = "Select count(*) from usuarios where Id_usuario=" & legajo.Text
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("/bbdd/capacitacion.mdb")
        con.Open()
        Dim cmd As New OleDbCommand(sql, con)
        resultado = cmd.ExecuteScalar
        Response.Write(resultado)
        If resultado = 0 Then
            insertar = "INSERT INTO usuarios VALUES ('" & legajo.Text & "','" & aYnombre.Text & "','" & password.Text & "')"
            Dim cmd1 As New OleDbCommand(insertar, con)
            cmd1.ExecuteNonQuery()

        End If
        con.Close()

    End Sub
End Class
