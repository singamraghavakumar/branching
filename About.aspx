<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebToExplainBranching.About" %>

<%@ Register src="MyMenu.ascx" tagname="MyMenu" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="OurStyle.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>
                <uc1:MyMenu ID="MyMenu1" runat="server" />
            </td>
        </tr>
        <tr>
            <td><h1>About Page</h1></td>
        </tr>
    </table>
        <div>
        </div>
    </form>
</body>
</html>
