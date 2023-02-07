<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tretmani.aspx.cs" Inherits="WebApplication1.Tretmani" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>SPISAK NASIH TRETMANA</h1>

    <asp:GridView ID="GridView1" runat="server" CssClass="table" EmptyDataText="NO DATA"></asp:GridView>

    <h2>NA OVIM LOKACIJAMA NAS MOZETE NACI</h2>
    <asp:GridView ID="GridView2" runat="server" CssClass="table" EmptyDataText="NO DATA"></asp:GridView>

    <asp:Label ID="Label1" runat="server" Text="" Font-Bold="true" ForeColor="Red"></asp:Label>
</asp:Content>
