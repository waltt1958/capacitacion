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



    <asp:GridView ID="GridView1" runat="server" BorderWidth="3px" Font-Bold="True" Font-Size="Large" HorizontalAlign="Center" AutoGenerateColumns="False" BorderColor="Black" DataKeyNames="Id_curso" DataSourceID="SqlDataSource1" Height="167px" ShowHeaderWhenEmpty="True" Width="515px">
        <Columns>
            <asp:BoundField DataField="Id_curso" HeaderText="Id_curso" ReadOnly="True" SortExpression="Id_curso" />
            <asp:BoundField DataField="descripcion" HeaderText="descripcion" SortExpression="descripcion" />
        </Columns>
        <EditRowStyle HorizontalAlign="Center" />
        <HeaderStyle Font-Bold="True" Font-Size="X-Large" HorizontalAlign="Center" />
        <RowStyle BorderStyle="Solid" />
    </asp:GridView>



    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:capacitacionConnectionString %>" ProviderName="<%$ ConnectionStrings:capacitacionConnectionString.ProviderName %>" SelectCommand="SELECT [Id_curso], [descripcion] FROM [cursos] ORDER BY [Id_curso]"></asp:SqlDataSource>



</asp:Content>


