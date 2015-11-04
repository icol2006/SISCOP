<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Sitio.Master" AutoEventWireup="true" CodeBehind="frmProyectos.aspx.cs" Inherits="SISCOP.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:40px">
        <h3 style="font-weight:bold">Control de Proyectos</h3>
        
            
        <div>
            <h5 style="color:blue;float:left">Agregar Proyecto</h5>
            
            <asp:TextBox style="float:right" runat="server"></asp:TextBox>
            <label style="float:right">Buscar Proyecto  &nbsp;&nbsp;&nbsp</label>
        </div>
        
          <table class="table table-striped">
    <thead>
      <tr>
        <th>Id</th>
        <th>Estado</th>
        <th>Nombre</th>
        <th>Oferta</th>
        <th>Etapas</th>
        <th>Descripcion</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>1-PRO-24</td>
        <td>Sin hacer</td>
        <td>proyecto 1</td>
        <td><span style="color:blue">2-DSES-E</span></td>
        <td><span style="color:blue">Ver etapas</span></td>
        <td>Descripcion proyecto numero 1</td>
        <td><span style="color:blue">Ver detalles</span></td>
      </tr>
      <tr>
        <td>2-PRO-E</td>
        <td>Sin hacer</td>
        <td>proyecto 2</td>
        <td><span style="color:blue">2-SADFFIW-E</span></td>
        <td><span style="color:blue">Ver etapas</span></td>
        <td>Descripcion proyecto numero 2</td>
        <td><span style="color:blue">Ver detalles</span></td>
      </tr>
      <tr>
        <td>4-PRO-4</td>
        <td>Hecha</td>
        <td>proyecto 2</td>
        <td><span style="color:blue">4-AFDSKFJLASD-4</span></td>
        <td><span style="color:blue">Ver etapas</span></td>
        <td>Descripcion proyecto numero 3</td>
        <td><span style="color:blue">Ver detalles</span></td>
      </tr>

    </tbody>
  </table>
        
    </div>

</asp:Content>
