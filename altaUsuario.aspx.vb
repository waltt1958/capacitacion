﻿
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
End Class