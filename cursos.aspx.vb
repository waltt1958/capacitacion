Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb.OleDbDataReader
Imports System.Data
Imports Microsoft.VisualBasic
Partial Class cursos
    Inherits System.Web.UI.Page

    Private Property HyperLink As Object

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("legajo") <> 0 Then

            'Dim con As New OleDbConnection
            'Dim cadena As String
            'Dim oDataReader As OleDbDataReader

            'cadena = "select * from cursos"
            'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("/bbdd/capacitacion.accdb")

            'con.Open()

            'Dim cmd As New OleDbCommand(cadena, con)
            'oDataReader = cmd.ExecuteReader()

            'GridView1.Columns(0).HeaderText = "Nro de curso"
            'GridView1.Columns(1).HeaderText = "Descripción del curso"

            'While oDataReader.Read()
            '    Dim row As TableRow
            '    Dim cell1 As TableCell
            '    Dim cell2 As TableCell
            '    row = New TableRow()
            '    cell1 = New TableCell()
            '    cell2 = New TableCell()
            '    cell1.Text = oDataReader(0)
            '    cell1.HorizontalAlign = HorizontalAlign.Center
            '    cell2.Text = oDataReader(1)
            '    row.Cells.Add(cell1)
            '    row.Cells.Add(cell2)
            '    TablaCursos.Rows.Add(row)
            'End While

        Else

            Session("noHabilit") = "si"
            Response.Write("<script>window.setTimeout(location.href='default.aspx', 2000);</script>")

        End If

        If Session("cursosReal") = "si" Then

            Dim message As String = "El curso seleccionado ya fue realizado por Uds. Seleccione otro curso."
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
    End Sub


    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class
