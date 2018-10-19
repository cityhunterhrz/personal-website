<%@ Page Language="C#" AutoEventWireup="true" CodeFile="reg.aspx.cs" Inherits="reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>注册</title>
    <link rel="stylesheet" href="css/reg.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="div1" class="maincenter">
            <ul>
                <li><a href="Home.aspx">返回首页</a></li>               
            </ul>
        </div>
        <br />
        <br />
        <br />
        <br />
        <div class="div2">
              用户名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            密码：<asp:TextBox ID="TextBox2" runat="server" MaxLength="20" TextMode="Password" Width="164px"></asp:TextBox>
            <br />
            <br />
            重复密码：<asp:TextBox ID="TextBox3" runat="server" MaxLength="20" TextMode="Password" Width="132px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="注册" Width="221px" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>  
        <div/>
            
    </form>
</body>
</html>
