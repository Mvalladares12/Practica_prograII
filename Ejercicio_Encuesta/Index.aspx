<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Ejercicio_Encuesta.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            width: 83px;
        }
        .auto-style4 {
            height: 23px;
            width: 83px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Ejercicio Encuesta.</h1>
            <hr />
            <table>
                <tr>
                    <td class="auto-style3">Nombre</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Profesion</td>
                    <td>
                        <asp:DropDownList ID="ddlProfesion" runat="server">
                            <asp:ListItem Value="1">Informatico</asp:ListItem>
                            <asp:ListItem Value="2">Contador</asp:ListItem>
                            <asp:ListItem Value="3">Servicio al cliente</asp:ListItem>
                            <asp:ListItem Value="4">Abogado</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Trabaja </td>
                    <td class="auto-style1">
                        <asp:CheckBox ID="chkTrabaja" runat="server" Text="¿Actualmente trabaja?" />
&nbsp;&nbsp;&nbsp;
                        </td>
                </tr>
                <tr>
                    <td class="auto-style3">Edad</td>
                    <td>
                        <asp:TextBox ID="txtEdad" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar encuesta" Width="127px" OnClick="Button1_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnVer" runat="server" Text="Ver resultados" Width="128px" OnClick="btnVer_Click" />
                    </td>
                </tr>
            </table>
            <hr />
            <table border="1" style="width: 511px">
                <tr>
                    <td>Informaticos que trabajan</td>
                    <td>
                        <asp:Label ID="lblInformaticos" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Contadores que no trabajan</td>
                    <td>
                        <asp:Label ID="lblContadores" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Abogados mayores de 35 años</td>
                    <td>
                        <asp:Label ID="lblAbogados" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Servicio al cliente que no trabaja y tienen entre 25 y 35 años</td>
                    <td class="auto-style2">
                        <asp:Label ID="lblServicio" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
