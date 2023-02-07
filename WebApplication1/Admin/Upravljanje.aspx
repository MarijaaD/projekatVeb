<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Upravljanje.aspx.cs" Inherits="WebApplication1.Admin.Upravljanje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>TRETMANI</h1>
    <asp:GridView ID="GridView1" runat="server" CssClass="table" EmptyDataText="NO DATA"></asp:GridView>

    <h1>Dodaj jos tretmana</h1>
    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Ime radnice"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Ime tretmana"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Trajanje:"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Dodaj tretman" OnClick="Button1_Click" CssClass="btn btn-success" />
        <asp:Label ID="Label5" runat="server" Text="" Font-Bold="true" ForeColor="Red"></asp:Label>
    </div>


</asp:Content>
