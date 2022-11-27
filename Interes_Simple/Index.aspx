<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Interes_Simple.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Calculo de interes simple</h1>
            <br />
            <hr />
            <table>
                <tr>
                    <td><b>Capital</b></td>
                    <td>
                        <asp:TextBox ID="txtCapital" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><b>Tasa de interes</b></td>
                    <td>
                        <asp:TextBox ID="txtInteres" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><b>Años</b></td>
                    <td>
                        <asp:TextBox ID="txtAños" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <h2>Resultados</h2>
            <table>
                <tr>
                    <td><b>Interes ganado</b></td>
                    <td>
                        <asp:TextBox ID="txtGanancia" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><b>Monto total</b></td>
                    <td>
                        <asp:TextBox ID="txtMonto" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" Width="135px" />
&nbsp;&nbsp;
            <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar" Width="135px" />
            <br />
        </div>
    </form>
</body>
</html>
