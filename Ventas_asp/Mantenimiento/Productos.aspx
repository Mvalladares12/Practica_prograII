<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Ventas_asp.Mantenimiento.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <p>
        <br />
    </p>
    <p>
        Nombre Producto&nbsp;
        <asp:TextBox ID="TxtNombreProd" runat="server" Width="155px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        Precio Producto&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtPrecioProd" runat="server" Width="155px"></asp:TextBox>
    </p>
    <p>
        ID Producto&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtIDCate" runat="server" Width="155px" TextMode="Number"></asp:TextBox>
    </p>
    <p>
        Categoría&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DdlCategoria" runat="server" DataSourceID="Categoria" DataTextField="Nombre_categoria" DataValueField="id_categoria" Width="155px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="Categoria" runat="server" ConnectionString="<%$ ConnectionStrings:Ventas_progra2ConnectionString %>" SelectCommand="SELECT [id_categoria], [Nombre_categoria] FROM [Categorias]"></asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;
    </p>
    <asp:GridView ID="GvProducto" runat="server" AutoGenerateColumns="False" DataKeyNames="id_producto" DataSourceID="SqlDataSourceProducto" OnSelectedIndexChanged="GvProducto_SelectedIndexChanged" >
        <Columns>
            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="" />
            <asp:BoundField DataField="id_producto" HeaderText="id_producto" InsertVisible="False" ReadOnly="True" SortExpression="id_producto" />
            <asp:BoundField DataField="Nombre_producto" HeaderText="Nombre_producto" SortExpression="Nombre_producto" />
            <asp:BoundField DataField="id_categoria" HeaderText="id_categoria" SortExpression="id_categoria" />
            <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio" />
            <asp:BoundField DataField="usuario_inserta" HeaderText="usuario_inserta" SortExpression="usuario_inserta" />
            <asp:BoundField DataField="fecha_inserta" HeaderText="fecha_inserta" SortExpression="fecha_inserta" />
            <asp:BoundField DataField="usuario_actualiza" HeaderText="usuario_actualiza" SortExpression="usuario_actualiza" />
            <asp:BoundField DataField="fecha_actualiza" HeaderText="fecha_actualiza" SortExpression="fecha_actualiza" />

        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSourceProducto" runat="server" ConnectionString="<%$ ConnectionStrings:Ventas_progra2ConnectionString %>" SelectCommand="SELECT * FROM [Productos]" DeleteCommand="SP_EliminarProducto" DeleteCommandType="StoredProcedure" UpdateCommand="SP_ActualizaProducto" UpdateCommandType="StoredProcedure">
        <DeleteParameters>
            <asp:Parameter Name="id_producto" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="idproducto" Type="Int32" />
            <asp:Parameter Name="NombreProd" Type="String" />
            <asp:Parameter Name="Precio" Type="Decimal" />
            <asp:Parameter Name="UsuarioIns" Type="String" />
            <asp:Parameter Name="UsuarioAct" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <br />
    <p>
        <asp:Button ID="BtnGuardarProd" runat="server" Height="46px" OnClick="BtnGuardarProd_Click" Text="Guardar producto" Width="216px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnModificarProd" runat="server" Height="46px" OnClick="BtnModificarProd_Click" Text="Modificar producto" Width="216px" />
    </p>
    <p>
        <asp:Label ID="LblMensaje" runat="server" ForeColor="#FF6600"></asp:Label>
    </p>
    <p>
        &nbsp;</p>


</asp:Content>
