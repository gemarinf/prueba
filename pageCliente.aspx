<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="pageCliente.aspx.cs" Inherits="pagecliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <table style="width: 100%">
        <tr>
            <td colspan="3">
                <h1> Clientes</h1>
                </td>
        </tr>
        <tr>
            <td style="width: 26px;" class="center" rowspan="5">
                <img alt="Clientes" src="images/clientes.jpeg" style="width: 367px; height: 119px" /></td>
            <td style="height: 30px">
                <asp:Label ID="Label1" runat="server" Text="Id Cliente"></asp:Label>
            </td>
            <td style="font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; height: 30px">
                <asp:DropDownList ID="drpClientes" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourceClientes" DataTextField="nombre" DataValueField="idcliente" OnSelectedIndexChanged="drpClientes_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceClientes" runat="server" ConnectionString="<%$ ConnectionStrings:clientesConnectionString %>" SelectCommand="SELECT [idcliente], [nombre] FROM [cliente]"></asp:SqlDataSource>
                <asp:TextBox ID="txtcliente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 30px">
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td style="height: 30px; font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px">
                <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 30px">
                Apellidos</td>
            <td style="height: 30px; font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px">
                <asp:TextBox ID="txtapellidos" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 30px">
                <asp:Label ID="Label3" runat="server" Text="direccion"></asp:Label>
            </td>
            <td style="height: 30px">
                <asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
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
</asp:Content>

