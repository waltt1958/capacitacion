<%@ Page Title="" Language="VB" MasterPageFile="~/M.Master" AutoEventWireup="false" CodeFile="cursos.aspx.vb" Inherits="cursos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>CURSOS HABILITADOS</h3>

   


<%--    <asp:Table ID="TablaCursos" width="75%" HorizontalAlign="Center" BorderColor="#9900CC" BorderStyle="Solid" BorderWidth="3px" runat="server" GridLines="Both" Font-Bold="True" Font-Size="Large">
            <asp:TableRow HorizontalAlign="Center" Font-Bold="true" Font-Size="X-Large" BorderStyle="Solid"> 
                 <asp:TableCell Width="15%" HorizontalAlign="Center">Orden</asp:TableCell> 
                 <asp:TableCell Width="85%" HorizontalAlign="Center">Curso</asp:TableCell> 
            </asp:TableRow> 
    </asp:Table>--%>



    <asp:GridView ID="GridView1" runat="server" BorderWidth="1px" Font-Bold="True" Font-Size="Large" HorizontalAlign="Center" AutoGenerateColumns="False" BorderColor="#999999" DataKeyNames="Id_curso" DataSourceID="SqlDataSource1" Height="167px" ShowHeaderWhenEmpty="True" Width="561px" BackColor="White" BorderStyle="Solid" CellPadding="3" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:BoundField DataField="Id_curso"  HeaderText="Nro de curso" ReadOnly="True" SortExpression="Id_curso" Visible="False" >
            <FooterStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:HyperLinkField DataNavigateUrlFields="Id_curso" ItemStyle-HorizontalAlign="Center" DataNavigateUrlFormatString="{0}.aspx" HeaderText="Realizar curso:" Text="Ingresar" >
<ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:HyperLinkField>
            <asp:BoundField DataField="descripcion" HeaderText="Descripción del curso" SortExpression="descripcion" />
        </Columns>
        <EditRowStyle HorizontalAlign="Center" />
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle Font-Bold="True" Font-Size="X-Large" HorizontalAlign="Center" BackColor="Black" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BorderStyle="Solid" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>



    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:capacitacionConnectionString %>" ProviderName="<%$ ConnectionStrings:capacitacionConnectionString.ProviderName %>" SelectCommand="SELECT [Id_curso], [descripcion] FROM [cursos] ORDER BY [Id_curso]"></asp:SqlDataSource>



</asp:Content>


