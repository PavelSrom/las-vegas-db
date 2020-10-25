<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="handin4.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="HomeGridView" runat="server" EmptyDataText="No data yet">
            </asp:GridView>
            <asp:Label ID="Message" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
