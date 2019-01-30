Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb.OleDbDataReader
Imports System.Data
Imports Microsoft.VisualBasic
Partial Class cursos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("legajo") <> 0 Then

            Dim con As New OleDbConnection
            Dim cadena As String
            Dim oDataReader As OleDbDataReader

            cadena = "select * from cursos"
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("/bbdd/capacitacion.accdb")

            con.Open()

            Dim cmd As New OleDbCommand(cadena, con)
            oDataReader = cmd.ExecuteReader()







        Else

            Response.Write("<script>window.alert('Debe ingresar con su usuario y contraseña ');</script>" +
            "<script>window.setTimeout(location.href='default.aspx', 2000);</script>")
        End If
    End Sub
End Class
