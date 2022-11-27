<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Practica_prograII.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Nombre&nbsp;
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <br />
            Apellido&nbsp;
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <br />
            <br />
            Puesto&nbsp;
            <asp:DropDownList ID="ddlPuesto" runat="server">
                <asp:ListItem Value="0">--Seleccione un puesto--</asp:ListItem>
                <asp:ListItem Value="1">Gerente</asp:ListItem>
                <asp:ListItem Value="2">Administrador</asp:ListItem>
                <asp:ListItem Value="3">Supervisor</asp:ListItem>
                <asp:ListItem Value="4">Operario</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Salario&nbsp;
            <asp:TextBox ID="txtSalario" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" Width="174px" OnClick="btnCalcular_Click" />
            <br />
            <br />
            <br />
            <br />

            <table border="1">
                <tr>
                    <th>Nombre completo</th>
                    <th>Salario base</th>
                    <th>Descuento de renta</th>
                    <th>Salario con renta</th>
                    <th>Puesto</th>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblNombre" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblSalarioBase" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblDescuentoRenta" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblSalarioNeto" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblPuesto" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
