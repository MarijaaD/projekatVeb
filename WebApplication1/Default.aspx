<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>DM BEAUTY</h1>
        <p class="lead">Mesto gde je sve podređeno Vama i Vašim željama, kutak u kome
        Vas čeka kraljevski tretman, a u kome ćete se opustiti kao u
        udobnosti svog doma. Pažljivo razmatrajući svaki detalj, DM Beauty
        svojim klijentima pruža udobnost vodećih beauty centara evropskih
        prestonica – izuzetna lokacija i luksuzni enterijer, ekskluzivne usluge
        i stručno, profesionalno i pažljivo osoblje.
        </p>
        <a href="Tretmani.aspx" class="btn btn-primary">Saznajte vise o nasim tretmanima</a>
    </div>
    
    <div class="jumbotron">
        <h2>Prijavite se da vidite novosti o nasim tretmanima</h2>

        <asp:Label ID="Label1" runat="server" Text="Ime:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Prijavite se" CssClass="btn btn-primary" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="" ForeColor="Red" Font-Bold="true"></asp:Label>
    </div>

</asp:Content>
