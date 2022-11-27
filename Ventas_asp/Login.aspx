<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ventas_asp.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-4"></div>
        <div class="col-4">
            <table class="table">
                <tr>
                    <td> Usuario <asp:TextBox ID="txtusuario" CssClass="form-control" runat="server"></asp:TextBox></td>
                    <td> Contraseña <asp:TextBox ID="txtcontra" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
            </table>
            <asp:Button ID="btnlogin" runat="server" Text="Iniciar sesion" Height="51px" Width="328px" OnClick="btnlogin_Click" />

            <asp:Label ID="lblmensaje" runat="server" ForeColor="#FF3300"></asp:Label>

        </div>
        <div class="col-4"></div>
    </div>

</asp:Content>
