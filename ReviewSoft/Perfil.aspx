<%@ Page Title="" Language="C#" MasterPageFile="~/Encabezado.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="ReviewSoft.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div class="pen-title">
  <h1>Perfil</h1><span>Puedes ver los datos de tu perfil y modificarlos <i class='fa fa-paint-brush'></i></span>
</div>
<!-- Form Module-->
<div class="module form-module">
  <div class="toggle">
  </div>
  <div class="form">
    <h2>Crear una cuenta</h2>
    <form runat="server">
        <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre"></asp:TextBox>
        <asp:TextBox ID="txtApellido" runat="server" placeholder="Apellido"></asp:TextBox>     
        <asp:TextBox ID="txtContraseña" runat="server" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txtCorreo" runat="server" placeholder="Correo Electronico" TextMode="Email" Enabled="false"></asp:TextBox>
        <asp:TextBox ID="txtNacimiento" runat="server" placeholder="Fecha de Nacimiento" TextMode="Date"></asp:TextBox>
        <asp:DropDownList ID="ddlProfesion" runat="server" placeholder="Profesion"></asp:DropDownList>
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="button" OnClick="btnGuardar_Click"/>
    </form>
  </div>
</div>
</asp:Content>
