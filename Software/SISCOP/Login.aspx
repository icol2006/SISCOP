<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SISCOP.Login" %>

<!DOCTYPE html>
<html lang="en">
	<head>
		<meta http-equiv="content-type" content="text/html; charset=UTF-8">
		<meta charset="utf-8">
		<title>Login SISCOP</title>
		<meta name="generator" content="Bootply" />
		<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
		<link href="Content/bootstrap.min.css" rel="stylesheet">
		<!--[if lt IE 9]>
			<script src="//html5shim.googlecode.com/svn/trunk/html5.js"></script>
		<![endif]-->
		<link href="Content/styles_login.css" rel="stylesheet">
	</head>
	<body>
<h1 class="text-center" style="color:#337AB7">SISTEMA SISCOP</h1>
<br>
<!--login modal-->

<div id="loginModal" class="modal show" tabindex="-1" role="dialog" aria-hidden="true">
  <div class="modal-dialog">
  <div class="modal-content">
      <div class="modal-header">
          <h1 class="text-center">Login</h1>
      </div>
      <div class="modal-body">
          <form class="form col-md-12 center-block" runat="server" >
            <div class="form-group">
                <asp:TextBox class="form-control input-lg" ID="txtemail" placeholder="Email" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
               <asp:TextBox class="form-control input-lg" ID="txtpassword" placeholder="Password" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Button class="btn btn-primary btn-lg btn-block" ID="btnlogin" runat="server" Text="Iniciar sesion" />
               <span class="pull-right"><a href="#">Registrarse</span>
            </div>
          </form>
      </div>
      <div class="modal-footer">
          <div class="col-md-12">
 
		  </div>	
      </div>
  </div>
  </div>
</div>

	<!-- script references -->
		<script src="//ajax.googleapis.com/ajax/libs/jquery/2.0.2/jquery.min.js"></script>
		<script src="Scripts/bootstrap.min.js"></script>
	</body>
</html>
