<%@ Page Title="" Language="C#" MasterPageFile="~/Encabezado.Master" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="ReviewSoft.IniciarSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
                <link rel="stylesheet" href="../css/login.css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pen-title">
  <h1>Iniciar Sesión</h1><span> Ingresa tu usuario y contraseña  <i class='fa fa-code'></i></span>
</div>
<!-- Form Module-->
<div class="module form-module">
  <div class="toggle">
  </div>
  <div class="form">
    <h2>Iniciar Sesión</h2>
    <form runat="server">
        <asp:Label ID="lblEsado" runat="server" Text="" />
        <asp:TextBox ID="txtUsuario" runat="server" placeholder="Correo Electronico" TextMode="Email"></asp:TextBox>
        <asp:TextBox ID="txtContraseña" runat="server" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
        <asp:CheckBox ID="chkRecordar" runat="server" Text="¿Recordar Contraseña?"/>

        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    </form>
  </div>
  


    <script  src="../js/index.js"></script>
  
</asp:Content>
