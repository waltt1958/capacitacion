﻿
Partial Class Index
    Inherits System.Web.UI.Page

    Protected Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btcancelar.Click

        legajo.Text = String.Empty
        password.Value = String.Empty
        legajo.Focus()

    End Sub
End Class
