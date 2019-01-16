Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader
Imports Microsoft.VisualBasic
Imports System.Web.Services.Description


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

        sql = "Select * from usuarios where Id_usuario= ?"

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("/bbdd/capacitacion.accdb")

        con.Open()
        Dim oDataReader As OleDbDataReader

        Dim cmd As New OleDbCommand(sql, con)
        cmd.Parameters.Add(New OleDbParameter("Id_usuario", OleDbType.VarChar, 10))
        cmd.Parameters("Id_usuario").Value = legajo.Text
        oDataReader = cmd.ExecuteReader()

        If oDataReader.Read() = False Then
            insertar = "INSERT INTO usuarios VALUES ('" & legajo.Text & "','" & aYnombre.Text & "','" & password.Text & "')"
            Dim cmd1 As New OleDbCommand(insertar, con)
            cmd1.ExecuteNonQuery()
            legajo.Text = String.Empty
            aYnombre.Text = String.Empty
            'Response.Write("<script type='text/javascript'> alert('Fue dado de alta exitosamente. Vuelva al inicio e ingrese')</script>")
            Response.Write("<script>window.alert('Fue dado de alta exitosamente. Recuerde su contraseña');</script>" +
                           "<script>window.setTimeout(location.href='Default.aspx', 2000);</script>")
        Else

            Response.Write("<script type='text/javascript'> alert('El legajo ingresado ya existe')</script>")
            legajo.Text = String.Empty
            aYnombre.Text = String.Empty

        End If

        oDataReader.Close()
        con.Close()
    End Sub

End Class
