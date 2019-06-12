<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PresentacionWebForm.Login" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login</title>
    <link href="Content/css/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/css/sistema.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row mx-2 text-center">
                <div id="login" class="card col-md-4 col-sm-6 col-lg-4">
                    <div class="card-body">
                        <h3 class="card-title">Login</h3>
                        <div class="form-group">
                            <input id="nombre" class="form-control" type="text" name="" placeholder="Usuario">
                        </div>
                        <div class="form-group">
                            <input id="password" class="form-control" type="password" name="" placeholder="password">
                        </div>
                        <div id="error" class=" alert alert-danger hidden"></div>
                    </div>
                    <div class="card-footer bg-transparent">
                        <button id="ingresar" class="btn btn-primary" type="button">Ingresar</button>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script type="text/javascript" src="Scripts/jquery.1.11.1.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.js"></script>
    <script type="text/javascript" src="Scripts/Login.js"></script>

</body>
</html>
