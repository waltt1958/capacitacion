﻿<%@ Page Title="" Language="VB" MasterPageFile="~/M.Master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <h3>Ingrese su legajo y contraseña para continuar</h3>



    <table style="width: 40%;" align="center" border="2" cellspacing="0" bordercolor="black">
        <tr>
            <td width="50%"><asp:Label ID="Lbllegajo" Font-Size="20" runat="server" Font-Bold="True" Text="Legajo"></asp:Label></td>
            <td width="50%">
                <asp:TextBox  ID="legajo"  runat="server" MaxLength="8"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Complete su legajo" ControlToValidate="legajo" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>

         <tr>
            <td width="50%"><asp:Label ID="Lblpass" Font-Size="20" runat="server" Font-Bold="True" Text="Contraseña"></asp:Label></td>
            <td width="50%">
            <asp:TextBox ID="password" TextMode="Password" MaxLength="8" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Complete la contraseña" ControlToValidate="password" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>

            </td>
         </tr> 
         <tr>
            <td colspan="2" align="center" style="font-size: 20px">
                <asp:DynamicHyperLink NavigateUrl="~/modificar.aspx" ID="DynamicHyperLink1"  runat="server">Alta o modificación de contraseña</asp:DynamicHyperLink>
            </td>
        </tr>
        <tr>
           <td align="center"> <asp:Button ID="btaceptar" CssClass="button" runat="server" Text="ACEPTAR"></asp:Button></td>
           <td align="center"><asp:Button ID="btcancelar" CausesValidation="false" CssClass="button" runat="server" Text="CANCELAR"></asp:Button></td>
        </tr>
    </table>
    
 <script type="text/javascript">
    function VerificarCantidad(sender, args) {
        args.IsValid = (args.Value.length >= 9);
    }
</script>  
</asp:Content>

