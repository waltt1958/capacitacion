<%@ Page Title="" Language="VB" MasterPageFile="~/M.Master" AutoEventWireup="false" CodeFile="1.aspx.vb" Inherits="_1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>PRACTICA CADENA DE FRIO</h3>



<asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
<ItemTemplate>
    <asp:RadioButton ID="RadioButton1" runat="server" />

</ItemTemplate>
</asp:Repeater>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionCursos %>" ProviderName="<%$ ConnectionStrings:ConnectionCursos.ProviderName %>" SelectCommand="SELECT * FROM [cursosHechos]"></asp:SqlDataSource>



</asp:Content>


