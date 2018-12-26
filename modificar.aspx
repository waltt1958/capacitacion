<%@ Page Title="" Language="VB" MasterPageFile="~/M.Master" AutoEventWireup="false" CodeFile="modificar.aspx.vb" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div align="center">
<br>           
<br>
<br>   
             <asp:Button ID="btModificar" align="center" CssClass="button" runat="server" Text="MODIFICAR CONTRASEÑA"></asp:Button>
             <asp:Button ID="btAlta" CssClass="button" runat="server" Text="ALTA DE USUARIO"></asp:Button>
<br>
<br>
             <asp:Button ID="btVolver" PostBackUrl="~/Default.aspx" CssClass="button" runat="server" Text="VOLVER AL INICIO"></asp:Button>

</div>
</asp:Content>

