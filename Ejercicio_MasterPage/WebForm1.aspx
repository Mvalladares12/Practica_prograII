<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ejercicio_MasterPage.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-6">
            <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div class="col-6">
            <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server"></asp:TextBox>
        </div>

        <div class="row">
        <div class="col-6">
            <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        <div class="col-6">
            <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server"></asp:TextBox>
        </div>
    </div>
</asp:Content>
