Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb.OleDbDataReader
Imports System.Data
Imports Microsoft.VisualBasic

Partial Class Index
    Inherits System.Web.UI.Page

    Protected Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btcancelar.Click

        legajo.Text = String.Empty
        password.Text = String.Empty
        legajo.Focus()

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        legajo.Focus()

    End Sub

    Protected Sub btaceptar_Click(sender As Object, e As EventArgs) Handles btaceptar.Click

        Dim con As New OleDbConnection
        Dim cadena As String
        Dim oDataReader As OleDbDataReader

        cadena = "select * from usuarios where Id_usuario= ?"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("/bbdd/capacitacion.accdb")

        con.Open()

        Dim cmd As New OleDbCommand(cadena, con)
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
                Dim valorPass As String = password.Text

                If Equals(Trim(valorContra), Trim(valorPass)) Then

                    Response.Write("<script>window.setTimeout(location.href='cursos.aspx', 2000);</script>")

                Else

                    Response.Write("<script>window.alert('La contraseña que ingresó no coincide con la que tenía registrada. Vuelva a intentarlo ');</script>" +
                      "<script>window.setTimeout(location.href='default.aspx', 2000);</script>")
                End If
            End While

        End If

    End Sub
End Class
