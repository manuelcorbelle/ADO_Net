<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Create_Drop_Table.aspx.vb" Inherits="BD_Operaciones.Create_Drop_Table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="btnCreateTable" Text="Create Table" runat="server" OnClick="CreateTable" />
    <asp:Button ID="btnDropTable" Text="Drop Table" runat="server" OnClick="DropTable" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
