<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="handin4.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous" />

    <title>Login page</title>
</head>
<body>
    <h5 class="text-center mt-5">Login</h5>
    <form id="form1" runat="server" class="container-sm">
        <div class="d-flex flex-column py-5">

            <asp:TextBox ID="NameInput" placeholder="Name" CSSClass="form-control mb-2" runat="server"></asp:TextBox>
            <asp:TextBox ID="PasswordInput" placeholder="Password" CSSClass="form-control mb-2" runat="server"></asp:TextBox>
            <asp:Button id="LoginBtn" runat="server" Text="Log in" OnClick="OnLogin" CSSClass="btn btn-block btn-primary"></asp:Button>
            <asp:Label ID="Message" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
