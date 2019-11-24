<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pageDefault.aspx.cs" Inherits="pageDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LoginView ID="LoginView1" runat="server">
                <RoleGroups>
                    <asp:RoleGroup>
                    </asp:RoleGroup>
                    <asp:RoleGroup>
                    </asp:RoleGroup>
                </RoleGroups>
            </asp:LoginView>
        </div>
    </form>
</body>
</html>
