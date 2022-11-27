<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="Ventas_asp.Mantenimiento.Categorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Bienvendio al sistema <asp:Label ID="lblUsuario" runat="server" Text=""></asp:Label></h1>
    <p>
        <br />
    </p>
    <p>
        <asp:GridView ID="GvCategoria" runat="server" AutoGenerateColumns="False" DataKeyNames="id_categoria" DataSourceID="SqlDataSourceCategorias" Height="16px" Width="174px">
            <Columns>
                <asp:BoundField DataField="id_categoria" HeaderText="id_categoria" InsertVisible="False" ReadOnly="True" SortExpression="id_categoria" />
                <asp:BoundField DataField="Nombre_categoria" HeaderText="Nombre_categoria" SortExpression="Nombre_categoria" />
                <asp:BoundField DataField="Descripcion_categoria" HeaderText="Descripcion_categoria" SortExpression="Descripcion_categoria" />
                <asp:BoundField DataField="usuario_inserta" HeaderText="usuario_inserta" SortExpression="usuario_inserta" />
                <asp:BoundField DataField="fecha_inserta" HeaderText="fecha_inserta" SortExpression="fecha_inserta" />
                <asp:BoundField DataField="usuario_actualiza" HeaderText="usuario_actualiza" SortExpression="usuario_actualiza" />
                <asp:BoundField DataField="fecha_actualiza" HeaderText="fecha_actualiza" SortExpression="fecha_actualiza" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceCategorias" runat="server" ConnectionString="<%$ ConnectionStrings:Ventas_progra2ConnectionString %>" SelectCommand="SELECT [id_categoria], [Nombre_categoria], [Descripcion_categoria], [usuario_inserta], [fecha_inserta], [usuario_actualiza], [fecha_actualiza] FROM [Categorias]"></asp:SqlDataSource>
    </p>
    <p>
        Nombre categoria:
        <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" Height="16px" Width="340px"></asp:TextBox>
    </p>
    <p>
        Descripcion:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDescripcion" CssClass="form-control" runat="server" Height="16px" Width="340px"></asp:TextBox>
    </p>
    <p>
       <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text=" Guardar Categoria" Width="155px" />
        <asp:Label ID="LblUsuario_ins" runat="server" ForeColor="Black" Visible="False"></asp:Label>
        <asp:Button ID="BtnProducto" runat="server" OnClick="BtnProducto_Click" Text="Ir a productos" Width="209px" />
    </p>
    <p>
        <asp:Label ID="lblMensaje" runat="server" ForeColor="#FF6600"></asp:Label>
    </p>
</asp:Content>
