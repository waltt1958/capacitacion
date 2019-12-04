Imports System.Web.UI.WebControls.Repeater
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb.OleDbDataReader
Imports System.Data
Imports Microsoft.VisualBasic


Partial Class _1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Session("legajo") <= 0 Then

            Session("noHabilit") = "si"
            Response.Write("<script>window.setTimeout(location.href='default.aspx', 2000);</script>")

        Else
            Dim con As New OleDbConnection
            Dim cadena As String
            Dim oDataReader As OleDbDataReader

            cadena = "select * from cursosHechos where Id_usuario= ?"
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("/bbdd/capacitacion.accdb")

            con.Open()

            Dim cmd As New OleDbCommand(cadena, con)
            cmd.Parameters.Add(New OleDbParameter("Id_usuario", OleDbType.VarChar, 10))
            cmd.Parameters("Id_usuario").Value = Session("legajo")
            oDataReader = cmd.ExecuteReader()


            If oDataReader.HasRows Then

                Session("cursosReal") = "si"
                Response.Write("<script>window.setTimeout(location.href='cursos.aspx', 2000);</script>")
                oDataReader.Close()
                con.Close()

            Else

                Response.Write("aaaaaaaaaaaaaaaaaaaaaaaaaa")
                Response.Write(Session("curso"))

            End If

        End If

    End Sub


End Class
