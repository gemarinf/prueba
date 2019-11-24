<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="pagecalculos.aspx.cs" Inherits="pagecalculos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td colspan="4">
                <h1>Calculo</h1></td>
        </tr>
        <tr>
            <td rowspan="3" style="width: 60px">
                <asp:RadioButtonList ID="rdbcalculos" runat="server" Width="182px">
                    <asp:ListItem Value="1">suma</asp:ListItem>
                    <asp:ListItem Value="2">resta</asp:ListItem>
                    <asp:ListItem Value="3">producto</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td style="height: 38px; width: 214px">valor 1<asp:TextBox ID="txtvalor1" runat="server"></asp:TextBox>
            </td>
            <td style="height: 38px; width: 336px">valor 2<asp:TextBox ID="txtvalor2" runat="server"></asp:TextBox>
            </td>
            <td style="height: 38px">resultado<asp:TextBox ID="txtresultado" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 214px; height: 31px"></td>
            <td style="width: 336px; height: 31px"></td>
            <td style="height: 31px"></td>
        </tr>
        <tr>
            <td style="width: 214px">
                <asp:Button ID="btncalcular" runat="server" OnClick="btncalcular_Click" Text="Calculo" />
            </td>
            <td style="width: 336px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

