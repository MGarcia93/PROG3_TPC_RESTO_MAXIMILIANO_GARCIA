﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sistema.aspx.cs" Inherits="PresentacionWebForm.Sistema" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sistema Restaurant</title>
    <link href="Content/css/sistema.css" type="text/css" rel="stylesheet" />
   <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div id="main">
            <div id="izquierda">
                <h2 class="text-center">Datos</h2>
                <div class="p-3 center mb-5" >
                    <div style="border: solid 1px; border-radius:4%;" class="col-md-10 col-lg-10 col-sm-12 px-3 mb-5">
                        <div class="form-group row m-3">
                            <label for="mesa" class="col-lg-2 col-md-4 col-form-label">Mesa:</label>
                            <div class="offset-2 col-6">
                                <input type="text" class="form-control" name="mesa" id="Mesa" data-mesa="" disabled>
                            </div> 
                            
                        </div>
                        <div class="form-group row m-3">
                            <label for="mesero" class="col-lg-2 col-md-4 col-form-label">Mesero:</label>
                            <div class="offset-2 col-6">
                                <input type="text"  class="form-control" name="mesero" id="Mesero" data-mesero="" disabled>
                            </div>
                            
                        </div>
                    </div> 
                    <div class="form-group row m-3">
                        <label for="tipo" class=" col-form-label">Tipo:</label>
                        <div class="col-6">
                            <select name="tipo" id="tipo" class="form-control" ></select>
                            
                        </div> 
                        <button class="btn btn-primary" id="buscar"> buscar</button>
                    </div>
                    <div class="form-group row m-3">
                        <label for="descripcion" class="col-form-label">Descripcion:</label>
                        <div class="col-8">
                            <input type="text"  class="form-control" name="descipcion" id="descripcion" data-mesero="" disabled>
                        </div>  
                    </div>
                    <div class="form-group row m-3">
                        <label for="cantidad" class="col-form-label">cantidad:</label>
                        <div class="col-6">
                                <select name="tipo" id="cantidad" class="form-control" ></select>
                                
                        </div>   
                    </div>
                   
                </div>
                <div  class="text-center col-12 mt-5">
                    <div id="botonera">
                            <button id="Agregar" class="btn btn-info">Agregar</button>
                            <button id="Abrir" class="btn btn-success"> Generar</button>
                            <button id="Cerrar" class="btn btn-danger">Cerrar</button>
                    </div>  
                </div>     
                   
            </div>
            <div id="derecha">
                <div id="panelMesa" class="row panelMesa">

                </div>
                <div class="row detallePedido">
                    <div id="detallePedido" class="form-group col-12" >
                            <div class="table-responsive">
                                <table class="table">
                                    <thead>
                                        <th scope="col"> Nombre</th>
                                        <th scope="col"> Descripcion</th>
                                        <th scope="col"> Tipo</th>
                                        <th scope="col"> Precio</th>
                                        <th scope="col"> Cantidad</th>
                                    </thead>  
                                    <tbody>
                                        
                                    </tbody>
                                </table>
                            </div>
                        </div>     
                </div>
            </div>
    </div>
        <!-- MODAL PARA LA BUSQUEDA DEL PRODUCTO -->
        <div class="modal fade" id="Modal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Productos</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                        <button id="seleccionar" type="button" class="btn btn-primary">Seleccionar</button>
                    </div>
                </div>
            </div>
        </div>


        <!-- MESAJE DE ALERTAS DE LOS DISTINTEOS SUCCESOS-->
        <div aria-live="polite" aria-atomic="true" style="position: absolute; min-height: 200px;">
            <div class="toast bg-dark text-white" style="position: absolute; top: 0; right: 0;">
                <div class="toast-header">
                    <img src="..." class="rounded mr-2" alt="...">
                    <strong class="contenido" class="mr-auto">Bootstrap</strong>
                    <button type="button" class="ml-2 mb-1 close" data-dismiss="toast" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="toast-body" style="background: rbga(150,150,150,0.4)">
                </div>
            </div>
        </div>

    </form>
  
    
    <script src="https://code.jquery.com/jquery-3.4.1.js" integrity="sha256-WpOohJOqMqqyKL9FccASB9O0KwACQJpFTUBLTYOVvVU=" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    <script type="text/javascript" src="Scripts/sistema.js"></script>

</body>
</html>
