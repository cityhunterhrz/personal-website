<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CityhunterHrz首页</title>
    <link rel="stylesheet" href="css/Home.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="navdiv" class="maincenter">
            <ul>
                <li><a href="login.aspx">登陆</a></li>
                <li><a href="reg.aspx">注册</a></li>
                <li><a href="Home.aspx">首页</a></li>               
            </ul>
        </div>        
    </form>
    <div class="homepage">
        Welcome to CityhunterHrz !
    </div>
    <br/>
    <div class="introduction">
        &nbsp;This is Huang Rongzhong's personal website dedicated to sharing work , emotions and life .
    </div>
    <br/>
    <div class="img">
        <img src="nuokanpu.jpg" alt="make the change" title="make the change"/>
    </div>
    <br/>
    <div class="copyright">
        Copyright &copy; 2018-2019 cityhunterhrz All Rights Reserved
        <span>|</span>
        <a href="http://www.miitbeian.gov.cn">粤ICP备18065294号</a>
    </div>
</body>
</html>
