<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/Administrador.Master" AutoEventWireup="true" CodeBehind="Nueva_Empresa.aspx.cs" Inherits="ReviewSoft.Administrador.Nuevos.Nueva_Empresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="right_col" role="main">
          <div class="">
            <div class="page-title">
              <div class="title_left">
                <h3>Agregar a catálogo</h3>
              </div>

              <div class="title_right">
              </div>
            </div>
            <div class="clearfix"></div>
            <div class="row">
              <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="x_panel">
                  <div class="x_title">
                    <h2>Nueva Empresa <small>Agrega nuevas empresas al catálogo existente</small></h2>
                    
                    <div class="clearfix"></div>
                  </div>
                  <div class="x_content">
                    <br />
                    <form id="form1" runat="server" class="form-horizontal form-label-left">

                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="first-name"> Nombre de la empresa<span class="required">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <asp:TextBox ID="txtNombre" required="required" CssClass="form-control col-md-7 col-xs-12" runat="server"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="last-name"> Sitio Web 
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                         <asp:TextBox ID="txtURL" CssClass="form-control col-md-7 col-xs-12" runat="server" TextMode="Url"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                        <label for="middle-name" class="control-label col-md-3 col-sm-3 col-xs-12"> Valor de Mercado 
                        <div class="col-md-6 col-sm-6 col-xs-12">
                           <asp:TextBox ID="txtValorMercado" CssClass="form-control col-md-7 col-xs-12" runat="server" TextMode="Number"></asp:TextBox>
                        </div>
                      </div>
                        <div class="form-group">
                        <label for="middle-name" class="control-label col-md-3 col-sm-3 col-xs-12"> Fundación  </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                           <asp:TextBox ID="txtFechaFundacion" required="required" CssClass="form-control col-md-7 col-xs-12" runat="server" TextMode="Date"></asp:TextBox>
                        </div>
                      </div>
                        <div class="form-group">
                        <label for="middle-name" class="control-label col-md-3 col-sm-3 col-xs-12"> Email de Contacto  </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                           <asp:TextBox ID="txtEmailContacto" required="required" CssClass="form-control col-md-7 col-xs-12" runat="server" TextMode="Email"></asp:TextBox>
                        </div>
                      </div>
                        <div class="form-group">
                        <label for="middle-name" class="control-label col-md-3 col-sm-3 col-xs-12"> Twitter  </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                           <asp:TextBox ID="txtTwitter" CssClass="form-control col-md-7 col-xs-12" runat="server" TextMode="Url" ></asp:TextBox>
                        </div>
                      </div>
                       <div class="form-group">
                        <label for="middle-name" class="control-label col-md-3 col-sm-3 col-xs-12"> Facebook  </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                           <asp:TextBox ID="TextBox1" CssClass="form-control col-md-7 col-xs-12" runat="server" TextMode="Url"></asp:TextBox>
                        </div>
                      </div>


                      <div class="ln_solid"></div>
                      <div class="form-group">
                        <div class="col-md-6 col-sm-6 col-xs-12 col-md-offset-3">
                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click"/>
                            <asp:Button ID="btnAceptar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnAceptar_Click"/>
                        </div>
                      </div>

                    </form>
                  </div>
                </div>
              </div>
            </div>
            </div>
</div>
</asp:Content>
