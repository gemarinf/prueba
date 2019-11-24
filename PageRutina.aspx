<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PageRutina.aspx.cs" Inherits="PageClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   
       <form id="form2" runat="server">
    <table style="width: 100%">
        <tr>
            <td colspan="3">
                <h1> Rutinas</h1>
                </td>
        </tr>
        <tr>
            <td style="width: 26px;" class="center" rowspan="6">
                <img alt="Clientes" src="images/clientes.jpeg" style="width: 367px; height: 119px" /></td>
            <td style="height: 30px">
                Cedula</td>
            <td style="font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; height: 30px">
                <asp:TextBox ID="txtcedula" runat="server"></asp:TextBox>
                <asp:DropDownList ID="DropCedula" runat="server" DataSourceID="SqlDataSource1" DataTextField="cedula" DataValueField="cedula" Height="174px" OnSelectedIndexChanged="DropCedula_SelectedIndexChanged" Width="134px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:clientesConnectionString2 %>" SelectCommand="SELECT [cedula] FROM [rutinas]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td style="height: 30px">
                Ejercicio</td>
            <td style="height: 30px; font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px">
                <asp:TextBox ID="txtejercicio" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 30px">
                Cantidad</td>
            <td style="height: 30px; font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px">
                <asp:TextBox ID="txtcantidad" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 30px">
                Repeticion</td>
            <td style="height: 30px">
                <asp:TextBox ID="txtrepeticion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Finalidad</td>
            <td>
                <asp:TextBox ID="txtfinalidad" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Fecha</td>
            <td>
                <asp:TextBox ID="txtfecha" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 26px">
                <asp:Label ID="lblestado" runat="server"></asp:Label>
                <asp:Label ID="lblestado1" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnagregar" runat="server" Text="Agregar" OnClick="btnagregar_Click" />
                <asp:Button ID="btneliminar" runat="server" OnClick="btneliminar_Click" Text="Eliminar" />
                <asp:Button ID="btnbuscar" runat="server" OnClick="btnbuscar_Click" Text="Buscar" />
            </td>
        </tr>
    </table>
</form>
    
</body>
</html>
