<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Sitio.Master" AutoEventWireup="true" CodeBehind="frmEtapas.aspx.cs" Inherits="SISCOP.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:40px">
        <h3 style="font-weight:bold">Control de Etapas</h3>
        
            
        <div>
            <h5 style="color:blue;float:left">Agregar etapa</h5>
            
            <asp:TextBox style="float:right" runat="server"></asp:TextBox>
            <label style="float:right">&nbsp;&nbsp;Buscar etapa  &nbsp;&nbsp;&nbsp</label>
            <button style="float:right">Ver Grafico Gann </button>
        </div>
        
          <table class="table table-striped">
    <thead>
      <tr>
        <th>Etapa</th>
        <th>Estado</th>
        <th>Inicio</th>
        <th>Finalizacion</th>
        <th>Documentos</th>
        <th>Listado tareas</th>
        <th>Detalles</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>Muestra</td>
        <td>Hecho</td>
        <td>19-02-12</td>
        <td>29-02-12</td>
        <td><span style="color:blue">Ver documentos</span></td>
        <td><span style="color:blue">Ver tareas</span></td>
        <td><span style="color:blue">Ver Detalles</span></td>
      </tr>
      <tr>
        <td>Cuestionario</td>
        <td>Hecho</td>
        <td>19-02-12</td>
        <td>29-02-12</td>
        <td><span style="color:blue">Ver documentos</span></td>
        <td><span style="color:blue">Ver tareas</span></td>
        <td><span style="color:blue">Ver Detalles</span></td>
      </tr>
      <tr>
        <td>Capacitacion</td>
        <td>Hecho</td>
        <td>19-02-12</td>
        <td>29-02-12</td>
        <td><span style="color:blue">Ver documentos</span></td>
        <td><span style="color:blue">Ver tareas</span></td>
        <td><span style="color:blue">Ver Detalles</span></td>
      </tr>
      <tr>
        <td>Campo</td>
        <td>Hecho</td>
        <td>19-02-12</td>
        <td>29-02-12</td>
        <td><span style="color:blue">Ver documentos</span></td>
        <td><span style="color:blue">Ver tareas</span></td>
        <td><span style="color:blue">Ver Detalles</span></td>
      </tr>
      <tr>
        <td>Digitacion</td>
        <td>No hecho</td>
        <td>19-02-12</td>
        <td>29-02-12</td>
        <td><span style="color:blue">Ver documentos</span></td>
        <td><span style="color:blue">Ver tareas</span></td>
        <td><span style="color:blue">Ver Detalles</span></td>
      </tr>
      <tr>
        <td>Procesamiento</td>
        <td>No hecho</td>
        <td>19-02-12</td>
        <td>29-02-12</td>
        <td><span style="color:blue">Ver documentos</span></td>
        <td><span style="color:blue">Ver tareas</span></td>
        <td><span style="color:blue">Ver Detalles</span></td>
      </tr>
      <tr>
        <td>Informe</td>
        <td>No hecho</td>
        <td>19-02-12</td>
        <td>29-02-12</td>
        <td><span style="color:blue">Ver documentos</span></td>
        <td><span style="color:blue">Ver tareas</span></td>
        <td><span style="color:blue">Ver Detalles</span></td>
      </tr>
      <tr>
        <td>Cobro</td>
        <td>No hecho</td>
        <td>19-02-12</td>
        <td>29-02-12</td>
        <td><span style="color:blue">Ver documentos</span></td>
        <td><span style="color:blue">Ver tareas</span></td>
        <td><span style="color:blue">Ver Detalles</span></td>
      </tr>


    </tbody>
  </table>
        
    </div>

</asp:Content>
