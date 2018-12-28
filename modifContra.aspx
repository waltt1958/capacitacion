<%@ Page Title="" Language="VB" MasterPageFile="~/M.Master" AutoEventWireup="false" CodeFile="modifContra.aspx.vb" Inherits="modifContra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Modificación de la contraseña</h3>

   <table style="width: 45%;" align="center" border="2" cellspacing="0" bordercolor="black">
        <tr>
            <td width="50%"><asp:Label ID="LblLegajo" Font-Size="20" runat="server" Font-Bold="True" Text="Legajo"></asp:Label></td>
            <td width="30%" align="center">
                <asp:TextBox ID="legajo" MaxLength="8" runat="server" Height="19px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Complete el legajo" ControlToValidate="legajo" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td width="50%"><asp:Label ID="lblvieja" Font-Size="20" runat="server" Font-Bold="True" Text="Contraseña anterior"></asp:Label></td>
            <td width="30%" align="center">
                <asp:TextBox ID="contraVieja" MaxLength="8" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Complete la contraseña anterior"  ControlToValidate="contraVieja" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
                  <tr>
            <td width="50%"><asp:Label ID="Lblpass" Font-Size="20" runat="server" Font-Bold="True" Text="Ingrese la nueva contraseña"></asp:Label></td>
            <td width="30%" align="center">
                <asp:TextBox ID="password" TextMode="Password" MaxLength="8" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Complete la contraseña nueva" ControlToValidate="password" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>  
         <tr>
            <td width="50%"><asp:Label ID="Lblpass1" Font-Size="20" runat="server" Font-Bold="True" Text="Repita la contraseña nueva"></asp:Label></td>
            <td width="30%" align="center">
                <asp:TextBox ID="password1" TextMode="Password" MaxLength="8" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Repita la nueva contraseña" ControlToValidate="password1" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="password" ControlToValidate="password1" ErrorMessage="No coinciden las contraseñas" Font-Bold="true" ForeColor="Red"></asp:CompareValidator>
            </td>
         </tr> 
        <tr>
           <td align="center"> <asp:Button ID="btaceptar" CssClass="button" runat="server" Text="ACEPTAR"></asp:Button></td>
           <td align="center"><asp:Button ID="btcancelar" CausesValidation="false" CssClass="button" runat="server" Text="CANCELAR"></asp:Button></td>
        </tr>
        <tr>
           <td colspan="2" align="center">
           <asp:Button ID="btVolver" PostBackUrl="~/Default.aspx" CausesValidation="false" CssClass="button" runat="server" Text="VOLVER AL INICIO"></asp:Button>
        </td>
        </tr>
    </table>
    
</asp:Content>

