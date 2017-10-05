<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/Administrador.Master" AutoEventWireup="true" CodeBehind="Nueva_app.aspx.cs" Inherits="ReviewSoft.Administrador.Nuevos.Nueva_app" %>
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
                    <h2>Nueva app <small>Agrega nuevas app al catálogo existente</small></h2>
                    
                    <div class="clearfix"></div>
                  </div>
                  <div class="x_content">
                    <br />
                    <form id="form1" runat="server" class="form-horizontal form-label-left">

                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="first-name"> Nombre de la app <span class="required">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <asp:TextBox ID="txtNombre" required="required" CssClass="form-control col-md-7 col-xs-12" runat="server"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="last-name">Dirección Web <span class="required">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                         <asp:TextBox ID="txtURL" required="required" CssClass="form-control col-md-7 col-xs-12" runat="server"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                        <label for="middle-name" class="control-label col-md-3 col-sm-3 col-xs-12"> Descripción <span class="required">*</span> </label> 
                        <div class="col-md-6 col-sm-6 col-xs-12">
                           <asp:TextBox ID="txtDescripcion" required="required" CssClass="form-control col-md-7 col-xs-12" runat="server"></asp:TextBox>
                        </div>
                      </div>
                        <div class="form-group">
                        <label for="middle-name" class="control-label col-md-3 col-sm-3 col-xs-12"> Demo  </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                           <asp:CheckBox ID="chkDemo" runat="server" />
                        </div>
                      </div>
                      <div class="form-group">
                        <label for="middle-name" class="control-label col-md-3 col-sm-3 col-xs-12"> Soporte en Linea </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                           <asp:CheckBox ID="chkSoporte" runat="server" />
                        </div>
                      </div>
                      <div class="form-group">
                        <label for="middle-name" class="control-label col-md-3 col-sm-3 col-xs-12"> Precio Básico <span class="required">*</span> </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                           <asp:TextBox ID="txtPrecioBasico" TextMode="Number" runat="server" required="required" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" Type="Currency" Operator="DataTypeCheck" ControlToValidate="txtPrecioBasico" ErrorMessage="Ingrese un precio básico valido"></asp:CompareValidator>
                        </div>
                      </div>
                      <div class="form-group">
                        <label for="middle-name" class="control-label col-md-3 col-sm-3 col-xs-12"> Precio Premium <span class="required">*</span></label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                           <asp:TextBox ID="txtPrecioPremium" TextMode="Number" runat="server" required="required" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator2" runat="server" Type="Currency" Operator="DataTypeCheck" ControlToValidate="txtPrecioPremium" ErrorMessage="Ingrese un precio premium valido"></asp:CompareValidator>
                        </div>
                      </div>
                      <div class="form-group">
                        <label for="middle-name" class="control-label col-md-3 col-sm-3 col-xs-12"> Fecha de Publicación <span class="required">*</span></label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                           <asp:TextBox ID="txtFechaPublic" TextMode="Date" runat="server" required="required" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                        <label for="middle-name" class="control-label col-md-3 col-sm-3 col-xs-12"> Usuarios aproximados usando el software <span class="required">*</span></label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                           <asp:TextBox ID="txtUsuarios" TextMode="Number" runat="server"></asp:TextBox>
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
