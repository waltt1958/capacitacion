<%@ Page Title="" Language="VB" MasterPageFile="~/M.Master" AutoEventWireup="false" CodeFile="modifContra.aspx.vb" Inherits="modifContra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Modificación de la contraseña</h3>

   <table style="width: 40%;" align="center" border="2" cellspacing="0" bordercolor="black">
        <tr>
            <td width="50%"><asp:Label ID="LblpassAnt" Font-Size="20" runat="server" Font-Bold="True" Text="Contraseña anterior"></asp:Label></td>
            <td width="30%" align="center">
                 <input id="contraVieja" type="password" runat="server" maxlength="8" />
            </td>
        </tr>

         <tr>
            <td width="50%"><asp:Label ID="Lblpass1" Font-Size="20" runat="server" Font-Bold="True" Text="Contraseña nueva"></asp:Label></td>
            <td width="30%" align="center">
                <input id="password" type="password" runat="server" maxlength="8" />
            </td>
         </tr> 
                <tr>
            <td width="50%"><asp:Label ID="Lblpass2" Font-Size="20" runat="server" Font-Bold="True" Text="Repita la contraseña nueva"></asp:Label></td>
            <td width="30%" align="center">
                <input id="password1" type="password" runat="server" maxlength="8" />
            </td>
         </tr> 
        <tr>
           <td align="center"> <asp:Button ID="btaceptar" CssClass="button" runat="server" Text="ACEPTAR"></asp:Button></td>
           <td align="center"><asp:Button ID="btcancelar" CssClass="button" runat="server" Text="CANCELAR"></asp:Button></td>
        </tr>
    </table>
    
</asp:Content>

