<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sistema.aspx.cs" Inherits="PresentacionWebForm.Sistema" %>

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
                <div id="logout">
                    <img src="Content/img/logout.svg" alt="Salida del Sistema" />
                </div>
                <div class="p-3 center mb-10" >
                    <div style="border: solid 1px; border-radius:4%;" class="col-md-12 col-lg-12 col-sm-12 px-3 mb-5">
                        <div class="form-group row m-3">
                            <label for="mesa" class="col-lg-2 col-md-4 col-form-label">Mesa:</label>
                            <div class="offset-1 col-lg-8 col-md-6">
                                <input type="text" class="form-control" name="mesa" id="Mesa" data-mesa="" disabled>
                            </div> 
                            
                        </div>
                        <div class="form-group row m-3">
                            <label for="mesero" class="col-lg-2 col-md-4 col-form-label">Mesero:</label>
                            <div class="offset-1 col-lg-8 col-md-6">
                                <input type="text"  class="form-control" name="mesero" id="Mesero" data-mesero="" disabled>
                            </div>
                            
                        </div>
                    </div> 
                    <div class="form-group row m-3">
                        <label for="tipo" class=" col-form-label">Tipo:</label>
                        <div class="col-6">
                            <select name="tipo" id="Tipos" class="form-control" ></select>
                            
                        </div> 
                        <button class="btn btn-primary" id="Buscar" disabled> buscar</button>
                    </div>
                    <input type="text"  class="form-control" name="codigo" id="codigo" data-mesero="" hidden>
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
                            <button id="Agregar" class="btn btn-info hide" >Agregar</button>
                            <button id="Abrir" class="btn btn-success hide" > Generar</button>
                            <button id="Cerrar" class="btn btn-danger hide" >Cerrar</button>
                            <button id="Modificar" class="btn btn-info hide" >Modificar</button>
                            <button id="Cancelar" class="btn btn-danger hide">Cancelar</button>
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
                                        <th scope="col"> #</th>
                                        <th scope="col"> Descripcion</th>
                                        <th scope="col"> Tipo</th>
                                        <th scope="col"> P/unit</th>
                                        <th scope="col"> Cantidad</th>
                                        <th scope="col"> P/Total</th>
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
        <div class="modal fade" id="Modal" tabindex="-1" role="dialog" aria-hidden="true">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title">Productos</h5>
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


        <!-- MODAL PARA CONFIRMACION DE CIERRE-->
        <div class="modal fade" id="modalConfirmacion" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" >Confirmacion de Cierre</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                        <button id="CerrarPedido" type="button" class="btn btn-primary">Seleccionar</button>
                    </div>
                </div>
            </div>
        </div>


        <!-- MESAJE DE ALERTAS DE LOS DISTINTEOS SUCCESOS-->
        <div style="position:absolute; bottom:1em;right:0px;z-index:100">
            <div class="toast" role="alert" aria-live="assertive" aria-atomic="true" >
          <div class="toast-header">
            <strong class="mr-auto contenido">Bootstrap</strong>
            <button type="button" class="ml-2 mb-1 close" data-dismiss="toast" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div class="toast-body" style="background-color:dimgray">
            See? Just like this.
          </div>
        </div>
        </div>
        

        <div id="inactivo" >
            <div class="msg">
                JORNADA DEL DIA SIN GENERAR REALIZE LA GENERACION EN EL SISTEMA
            </div>
        </div>

    </form>
  
    
    <script src="https://code.jquery.com/jquery-3.4.1.js" integrity="sha256-WpOohJOqMqqyKL9FccASB9O0KwACQJpFTUBLTYOVvVU=" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jspdf/1.3.2/jspdf.min.js"></script>
    <script type="text/javascript" src="Scripts/sistema.js"></script>
    

</body>
</html>
