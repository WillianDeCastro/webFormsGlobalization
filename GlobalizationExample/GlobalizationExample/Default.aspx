<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GlobalizationExample._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div>

        <h1>Pagina inicial</h1>
        <asp:Label ID="traducao" runat="server" Text="Label"></asp:Label>
    </div>
    <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="true">
        <asp:ListItem Value="pt-BR" Selected="True"></asp:ListItem>
        <asp:ListItem Value="es-ES"></asp:ListItem>
    </asp:ListBox>

</asp:Content>
