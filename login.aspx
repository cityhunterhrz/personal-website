<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登陆</title>
    <link rel="stylesheet" href="css/login.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="div1">
            <h2>您即将登录CityhunterHrz</h2>
            用户名： <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;密码： <asp:TextBox ID="TextBox2" runat="server" MaxLength="20" TextMode="Password" Width="162px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="登陆" Height="28px" OnClick="Button1_Click" Width="231px" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
    
</body>
</html>
