<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ECommerce.Register" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Inscription</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Inscription</h2>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label><br />
            <asp:Label ID="lblNom" runat="server" Text="Nom:"></asp:Label>
            <asp:TextBox ID="txtNom" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblPrenoms" runat="server" Text="Prénoms:"></asp:Label>
            <asp:TextBox ID="txtPrenoms" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblDateNaissance" runat="server" Text="Date de naissance:"></asp:Label>
            <asp:TextBox ID="txtDateNaissance" runat="server" TextMode="Date"></asp:TextBox><br />
            <asp:Label ID="lblLogin" runat="server" Text="Login:"></asp:Label>
            <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblPassword" runat="server" Text="Mot de passe:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Button ID="btnRegister" runat="server" Text="Valider" OnClick="btnRegister_Click" /><br />
            <asp:HyperLink ID="lnkLogin" runat="server" NavigateUrl="Login.aspx">Connexion</asp:HyperLink>
        </div>
    </form>
</body>
</html>
