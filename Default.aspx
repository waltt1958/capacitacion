<%@ Page Title="" Language="VB" MasterPageFile="~/M.Master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <h3>Ingrese su legajo y contraseña para continuar</h3>

    <asp:Table ID="Table1" runat="server">
    <asp:Label ID="Lbllegajo" runat="server" Font-Bold="True" Text="Legajo"></asp:Label>

    <asp:TextBox ID="legajo" runat="server"></asp:TextBox>

</asp:Table>
</asp:Content>

