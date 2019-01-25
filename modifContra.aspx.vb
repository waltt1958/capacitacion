Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbConnection
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

        If (Not oDataReader.HasRows) Then
            Response.Write("<script>window.alert('No está dado de alta en el sistema.');</script>" +
            "<script>window.setTimeout(location.href='altaUsuario.aspx', 2000);</script>")
            oDataReader.Close()
            con.Close()
        Else
            While oDataReader.Read()

                Dim valorContra As String = oDataReader(2)
                Dim valorPass As String = contraVieja.Text

                If Equals(Trim(valorContra), Trim(valorPass)) Then

                    modificar = "UPDATE usuarios SET contrasena = '" & password.Text & " 'where Id_usuario = ?"
                    Dim cmd1 As New OleDbCommand(modificar, con)
                    cmd1.Parameters.Add(New OleDbParameter("Id_usuario", OleDbType.VarChar, 10))
                    cmd1.Parameters("Id_usuario").Value = legajo.Text
                    cmd1.ExecuteNonQuery()

                    Response.Write("<script>window.alert('Su contraseña fue actualizada con éxito');</script>" +
                    "<script>window.setTimeout(location.href='default.aspx', 2000);</script>")
                Else

                    Response.Write("<script>window.alert('La contraseña vieja que ingresó no coincide con la que tenía registrada. Vuelva a intentarlo ');</script>" +
                      "<script>window.setTimeout(location.href='modifContra.aspx', 2000);</script>")
                End If
            End While

            oDataReader.Close()
            con.Close()

        End If
        oDataReader.Close()
        con.Close()

    End Sub
End Class
