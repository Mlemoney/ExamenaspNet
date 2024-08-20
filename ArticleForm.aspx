<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArticleForm.aspx.cs" Inherits="ECommerce.ArticleForm" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Article</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2><asp:Label ID="lblTitle" runat="server" Text="Ajouter un Article"></asp:Label></h2>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label><br />
            <asp:Label ID="lblNom" runat="server" Text="Nom:"></asp:Label>
            <asp:TextBox ID="txtNom" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblDescription" runat="server" Text="Description:"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblCategory" runat="server" Text="Catégorie:"></asp:Label>
            <asp:DropDownList ID="ddlCategory" runat="server"></asp:DropDownList><br />
            <asp:Label ID="lblGenre" runat="server" Text="Genre:"></asp:Label>
            <asp:DropDownList ID="ddlGenre" runat="server">
                <asp:ListItem Text="Masculin" Value="Masculin"></asp:ListItem>
                <asp:ListItem Text="Féminin" Value="Féminin"></asp:ListItem>
            </asp:DropDownList><br />
            <asp:Label ID="lblCouleur" runat="server" Text="Couleur:"></asp:Label>
            <asp:TextBox ID="txtCouleur" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblTaille" runat="server" Text="Taille:"></asp:Label>
            <asp:TextBox ID="txtTaille" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblPrix" runat="server" Text="Prix:"></asp:Label>
            <asp:TextBox ID="txtPrix" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnAjouter" runat="server" Text="Ajouter" OnClick="btnAjouter_Click" />
        </div>
    </form>
</body>
</html>
