<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Sitio.Master" AutoEventWireup="true" CodeBehind="frmComentariosTarea.aspx.cs" Inherits="SISCOP.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:40px">
        <h3 style="font-weight:bold">Comentario  Tarea - Procesar base</h3>
        
            
        <div>
            <h5 style="color:blue;float:left">Agregar comentario</h5>
            
            <asp:TextBox style="float:right" runat="server"></asp:TextBox>
            <label style="float:right">Buscar comentario  &nbsp;&nbsp;&nbsp</label>
        </div>
        
          <table class="table table-striped">
    <thead>
      <tr>
        <th>id</th>
        <th>comentario</th>
        <th>Hecho por</th>
       <th>Fecha publicacion</th>

      </tr>
    </thead>
    <tbody>
      <tr>
        <td>1</td>
        <td>La base fue recibida el jueves en la tarde</td>
        <td>Maykol</td>
        <td>16/05/2034 - 12:00pm</td>
      </tr>
      <tr>
        <td>1</td>
        <td>Envio de preguntas codificadas</td>
        <td>Maykol</td>
        <td>17/05/2034 - 12:00pm</td>
      </tr>
      <tr>
        <td>1</td>
        <td>Se encontraron muchos casos con duracion de entreivsta menor a 10min</td>
        <td>Maykol</td>
        <td>18/05/2034 - 12:00pm</td>
      </tr>


    </tbody>
  </table>
        
    </div>

</asp:Content>
