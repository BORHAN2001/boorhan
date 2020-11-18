<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="WebApplication7.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="firstname :"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="lastname :"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="recovery" />
&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="add" />
&nbsp;
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="querystring" />
&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="cookies" />
&nbsp;
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="hiddenfield" />
&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="hiddenfield"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server">0</asp:TextBox>
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="viewstate" />
    
    </div>
    </form>
</body>
</html>
