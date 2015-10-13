<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Sitio.Master" AutoEventWireup="true" CodeBehind="frmOfertas.aspx.cs" Inherits="SISCOP.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:40px">
        <h3 style="font-weight:bold">Control de Ofertas</h3>
        
            
        <div>
            <h5 style="color:blue;float:left">Agregar Oferta</h5>
            
            <asp:TextBox style="float:right" runat="server"></asp:TextBox>
            <label style="float:right">Buscar Oferta  &nbsp;&nbsp;&nbsp</label>
        </div>
        
          <table class="table table-striped">
    <thead>
      <tr>
        <th>Id</th>
        <th>Estado</th>
        <th>Cliente</th>
        <th>Nombre</th>
        <th>Descripcion</th>

      </tr>
    </thead>
    <tbody>
      <tr>
        <td>1-ASDFLKJ-24</td>
        <td>Sin hacer</td>
        <td>Doe</td>
        <td>Oferta 1</td>
        <td>Descripcion oferta numero 1</td>
        <td><span style="color:blue">Ver detalles</span></td>
      </tr>
      <tr>
        <td>2-SADFFIW-E</td>
        <td>Sin hacer</td>
        <td>Moe</td>
        <td>Oferta 2</td>
        <td>Descripcion oferta numero 2</td>
        <td><span style="color:blue">Ver detalles</span></td>
      </tr>
      <tr>
        <td>4-AFDSKFJLASD-4</td>
        <td>Hecha</td>
        <td>Dooley</td>
        <td>Oferta 2</td>
        <td>Descripcion oferta numero 3</td>
        <td><span style="color:blue">Ver detalles</span></td>

      </tr>

    </tbody>
  </table>
        
    </div>

</asp:Content>
