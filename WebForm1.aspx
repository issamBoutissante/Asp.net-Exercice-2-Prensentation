<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Exercice_2_Presentation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Nom Produit<p>
            <asp:TextBox ID="nomProduit" runat="server"></asp:TextBox>
        </p>
        Prix unitaire :<p>
            <asp:TextBox ID="PrixUnitaire" runat="server"></asp:TextBox>
        </p>
        <p>
            Quantite</p>
        <asp:TextBox ID="Quantite" runat="server"></asp:TextBox>
        <p>
            TVA</p>
        <p>
            <asp:TextBox ID="TVA" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Calculer" runat="server" OnClick="Calculer_Click" Text="Calculer" />
        <p>
            <asp:Label ID="error" runat="server" ForeColor="Red"></asp:Label>
        </p>
    </form>
</body>
</html>
