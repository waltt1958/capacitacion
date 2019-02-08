<%@ Page Title="" Language="VB" MasterPageFile="~/M.Master" AutoEventWireup="false" CodeFile="cursos.aspx.vb" Inherits="cursos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>CURSOS HABILITADOS</h3>

   


    <asp:Table ID="TablaCursos" width="75%" HorizontalAlign="Center" BorderColor="#9900CC" BorderStyle="Solid" BorderWidth="3px" runat="server" GridLines="Both" Font-Bold="True" Font-Size="Large">
            <asp:TableRow HorizontalAlign="Center" Font-Bold="true" Font-Size="X-Large" BorderStyle="Solid"> 
                 <asp:TableCell Width="15%" HorizontalAlign="Center">Orden</asp:TableCell> 
                 <asp:TableCell Width="85%" HorizontalAlign="Center">Curso</asp:TableCell> 
            </asp:TableRow> 
    </asp:Table>



</asp:Content>


