<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArticleList.aspx.cs" Inherits="ECommerce.ArticleList" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Liste des Articles</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Liste des Articles</h2>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Nom" HeaderText="Nom" />
                    <asp:BoundField DataField="Description" HeaderText="Description" />
                    <asp:BoundField DataField="Categorie" HeaderText="Catégorie" />
                    <asp:BoundField DataField="Genre" HeaderText="Genre" />
                    <asp:BoundField DataField="Couleur" HeaderText="Couleur" />
                    <asp:BoundField DataField="Taille" HeaderText="Taille" />
                    <asp:BoundField DataField="Prix" HeaderText="Prix" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server" Text="Modifier" CommandName="Edit" CommandArgument='<%# Eval("Id") %>' />
                            <asp:Button ID="btnDelete" runat="server" Text="Supprimer" CommandName="Delete" CommandArgument='<%# Eval("Id") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
