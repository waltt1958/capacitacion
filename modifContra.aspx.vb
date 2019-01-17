Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.DataTable
Imports System.Data.OleDb.OleDbDataAdapter
Imports System.Data

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
        Dim sqlModifica As String
        Dim sqlBuscar As String
        Dim da As OleDbDataAdapter
        Dim dt As DataSet
        Dim con As New OleDbConnection

        sqlBuscar = " select * from usuarios where Id_usuario=" & legajo.Text
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("/bbdd/capacitacion.accdb")

        ' Dim cmd As New OleDbCommand(sqlBuscar, con)
        ' cmd.Parameters.Add(New OleDbParameter("Id_usuario", OleDbType.VarChar, 10))
        ' cmd.Parameters("Id_usuario").Value = legajo.Text

        da = New OleDbDataAdapter(sqlBuscar, con)
        dt = New DataSet
        da.Fill(dt, "usuarios")


        Response.Write(dt.Tables("usuarios").Rows(0).Item("Id_usuario"))



        'Dim cmd As New OleDbCommand(sqlBuscar, con)
        'cmd.Parameters.Add(New OleDbParameter("Id_usuario", OleDbType.VarChar, 10))
        'cmd.Parameters("Id_usuario").Value = legajo.Text
        'odataReader = cmd.ExecuteReader()

        'If odataReader.Read() = False Then
        ' Response.Write("<script>window.alert('Nunca se ha registrado con ese legajo. ');</script>" +
        '   "<script>window.setTimeout(location.href='altaUsuario.aspx', 2000);</script>")
        'ElseIf odataReader("Id_usuario") = legajo.Text And odataReader("contrasena") = contraVieja.Text Then



        'End If

    End Sub
End Class
