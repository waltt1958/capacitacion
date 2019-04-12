Imports System.Web.UI.WebControls.Repeater


Partial Class _1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("legajo") <= 0 Then

            Session("noHabilit") = "si"
            Response.Write("<script>window.setTimeout(location.href='default.aspx', 2000);</script>")

        Else



        End If

    End Sub


End Class
