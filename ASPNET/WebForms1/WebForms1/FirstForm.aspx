<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstForm.aspx.cs" Inherits="WebForms1.FirstForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">  <!-- HTML Server Control -->
        <div>
        </div>
        <!-- Web Server Control --> 
        <asp:DropDownList ID="DropDownList1" runat="server" Width="611px" OnSelectedIndexChanged="OnSelectionChanged" AutoPostBack="True">
            <asp:ListItem>Ferrari</asp:ListItem>
            <asp:ListItem>Mercedes</asp:ListItem>
            <asp:ListItem>Red Bull Racing</asp:ListItem>
        </asp:DropDownList>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
