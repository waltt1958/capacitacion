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
        If Session("alta") = "si" Then

            Dim message As String = "No está dado de alta. Para continuar ingrese los datos solicitados."
            Dim sb As New System.Text.StringBuilder()
            sb.Append("<script type = 'text/javascript'>")
            sb.Append("window.onload=function(){")
            sb.Append("alert('")
            sb.Append(message)
            sb.Append("')};")
            sb.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
            Session.Remove("alta")
        End If

        If Session("errorContr") = "si" Then

            Dim message As String = "Ingresó una contraseña errónea. Vuelva a intentarlo."
            Dim sb As New System.Text.StringBuilder()
            sb.Append("<script type = 'text/javascript'>")
            sb.Append("window.onload=function(){")
            sb.Append("alert('")
            sb.Append(message)
            sb.Append("')};")
            sb.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
            Session.Remove("errorContr")

        End If

        If Session("altaExit") = "si" Then

            Dim message As String = "Fue dado de alta exitosamente. Recuerde su contraseña."
            Dim sb As New System.Text.StringBuilder()
            sb.Append("<script type = 'text/javascript'>")
            sb.Append("window.onload=function(){")
            sb.Append("alert('")
            sb.Append(message)
            sb.Append("')};")
            sb.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
            Session.Remove("altaExit")

        End If

        If Session("contrActual") = "si" Then

            Dim message As String = "Su contraseña fue actualizada con éxito."
            Dim sb As New System.Text.StringBuilder()
            sb.Append("<script type = 'text/javascript'>")
            sb.Append("window.onload=function(){")
            sb.Append("alert('")
            sb.Append(message)
            sb.Append("')};")
            sb.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
            Session.Remove("contrActual")

        End If

        If Session("noHabilit") = "si" Then

            Dim message As String = "Debe ingresar con su usuario y contraseña."
            Dim sb As New System.Text.StringBuilder()
            sb.Append("<script type = 'text/javascript'>")
            sb.Append("window.onload=function(){")
            sb.Append("alert('")
            sb.Append(message)
            sb.Append("')};")
            sb.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
            Session.Remove("noHabilit")

        End If


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

            Session("alta") = "si"
            Response.Write("<script>window.setTimeout(location.href='altaUsuario.aspx', 2000);</script>")
            oDataReader.Close()
            con.Close()

        Else
            While oDataReader.Read()

                Dim valorContra As String = oDataReader(2)
                Dim valorPass As String = password.Text

                If Equals(Trim(valorContra), Trim(valorPass)) Then

                    Session("legajo") = legajo.Text
                    Response.Write("<script>window.setTimeout(location.href='cursos.aspx', 2000);</script>")

                Else
                    Session("errorContr") = "si"
                    Response.Write("<script>window.setTimeout(location.href='default.aspx', 2000);</script>")
                End If
            End While

        End If

    End Sub
End Class
