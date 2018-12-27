
Partial Class modifContra
    Inherits System.Web.UI.Page

    Protected Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btcancelar.Click
        contraVieja.Value = String.Empty
        password.Value = String.Empty
        password1.Value = String.Empty
        contraVieja.Focus()
    End Sub

End Class
