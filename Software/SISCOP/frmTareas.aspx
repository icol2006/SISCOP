<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Sitio.Master" AutoEventWireup="true" CodeBehind="frmTareas.aspx.cs" Inherits="SISCOP.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:40px">
        <h3 style="font-weight:bold">Control de Tareas - Etapa Procesamiento</h3>
        
            
        <div>
            <h5 style="color:blue;float:left">Agregar tarea</h5>
            
            <asp:TextBox style="float:right" runat="server"></asp:TextBox>
            <label style="float:right">Buscar tarea  &nbsp;&nbsp;&nbsp</label>
        </div>
        
          <table class="table table-striped">
    <thead>
      <tr>
        <th>id</th>
        <th>tarea</th>
        <th>Inicio</th>
        <th>Finalizacion</th>
        <th>Prioridad</th>
        <th>Estado Avance</th>
        <th>Encargado</th>
        <th>Comentarios</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>1</td>
        <td>Procesar base</td>
        <td>19-02-12</td>
        <td>29-02-12</td>
        <td>Normal</td>
        <td>30%</td>
        <td>Maykol</td>
        <td><span style="color:blue">Ver Comentarios</span></td>
      </tr>
      <tr>
        <td>2</td>
        <td>Hacer cuadros spss</td>
        <td>19-02-12</td>
        <td>29-02-12</td>
        <td>Alta</td>
        <td>0%</td>
        <td>Rafael</td>
        <td><span style="color:blue">Ver Comentarios</span></td>
      </tr>
      <tr>
        <td>2</td>
        <td>Hacer Resumen ejecutivo</td>
        <td>19-02-12</td>
        <td>29-02-12</td>
        <td>Baja</td>
        <td>0%</td>
        <td>Eduardo</td>
        <td><span style="color:blue">Ver Comentarios</span></td>
      </tr>
      <tr>
        <td>2</td>
        <td>Hacer Graficos</td>
        <td>19-02-12</td>
        <td>29-02-12</td>
        <td>Baja</td>
        <td>0%</td>
         <td>Eduardo</td>
        <td><span style="color:blue">Ver Comentarios</span></td>
      </tr>

    </tbody>
  </table>
        
    </div>

</asp:Content>
