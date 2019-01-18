Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.DataTable
Imports System.Data.OleDb.OleDbDataAdapter
Imports System.Data
Imports Microsoft.VisualBasic


Partial Class modifContra
    Inherits System.Web.UI.Page

    Protected Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btcancelar.Click
        legajo.Text = String.Empty
        contraVieja.Text = String.Empty
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
        Dim modificar As String
        Dim oDataReader As OleDbDataReader

        sql = "Select * from usuarios where Id_usuario= ?"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("/bbdd/capacitacion.accdb")
        con.Open()

        Dim cmd As New OleDbCommand(sql, con)
        cmd.Parameters.Add(New OleDbParameter("Id_usuario", OleDbType.VarChar, 10))
        cmd.Parameters("Id_usuario").Value = legajo.Text
        oDataReader = cmd.ExecuteReader()

        If oDataReader.Read() = True Then
            Response.Write("              esta lleno")
        Else
            Response.Write("           esta vacio")
        End If
        Response.Write(oDataReader("aYnombre")) ' & "    " & oDataReader("aYnombre") & "     " & oDataReader("contravieja"))
        If oDataReader.Read() = False Then

            ' Response.Write(oDataReader("aYnombre")) ' & "111111" & "  " & contraVieja.Text & "   " & legajo.Text)

            oDataReader.Close()
            con.Close()
            ' Response.Write("<script>window.alert('Nunca se ha registrado con ese legajo. ');</script>" +
            '  "<script>window.setTimeout(location.href='altaUsuario.aspx', 2000);</script>")

        ElseIf (oDataReader("Id_usuario") = legajo.Text) And (oDataReader("contrasena") = contraVieja.Text) Then

            Response.Write(oDataReader("aYnombre") & "2222222" & "  " & contraVieja.Text & "   " & legajo.Text)

            modificar = "UPDATE usuarios SET contrasena = '" & password.Text & " 'where Id_usuario = ?"
            Dim cmd1 As New OleDbCommand(modificar, con)
            cmd1.Parameters.Add(New OleDbParameter("Id_usuario", OleDbType.VarChar, 10))
            cmd1.Parameters("Id_usuario").Value = legajo.Text
            cmd1.ExecuteNonQuery()
            oDataReader.Close()
            con.Close()
            'Response.Write("<script>window.alert('Su contraseña fue actualizada con éxito');</script>" +
            '"<script>window.setTimeout(location.href='default.aspx', 2000);</script>")

        Else
            Response.Write(oDataReader("contrasena") & "333333" & "  " & contraVieja.Text & "   " & legajo.Text)
            oDataReader.Close()
            con.Close()
            ' Response.Write("<script>window.alert('La contraseña vieja que ingresó no coincide con la que tenía registrada. Vuelva a intentarlo ');</script>" +
            '   "<script>window.setTimeout(location.href='modifContra.aspx', 2000);</script>")

        End If

        oDataReader.Close()
        con.Close()
    End Sub
End Class
