<%@ Page Title="" Language="VB" MasterPageFile="~/M.Master" AutoEventWireup="false" CodeFile="2.aspx.vb" Inherits="_1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>ATC</h3>



    <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="levantaPreg" DataTextField="Id_curso" DataValueField="Id_curso">
    </asp:RadioButtonList>
    <asp:SqlDataSource ID="levantaPreg" runat="server" ConnectionString="<%$ ConnectionStrings:levantaPreg %>" ProviderName="<%$ ConnectionStrings:levantaPreg.ProviderName %>" SelectCommand="SELECT cursos.Id_curso, preguntas.Id_curso AS Expr1, preguntas.Id_pregunta, preguntas.desc_pregunta, respuestas.Id_pregunta AS Expr2, respuestas.Id_respuesta, respuestas.Id_curso AS Expr3 FROM ((cursos INNER JOIN preguntas ON cursos.Id_curso = preguntas.Id_curso) INNER JOIN respuestas ON preguntas.Id_pregunta = respuestas.Id_pregunta)"></asp:SqlDataSource>



</asp:Content>


