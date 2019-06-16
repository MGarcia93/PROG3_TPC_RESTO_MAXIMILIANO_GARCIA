$("document").ready(function () {

    ListarMesas();         

    $.ajax({
        method: "POST",
        url: 'Sistema.aspx/TiposInsumos',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: (response) => {
            if (response.d) {
                $(response.d).each(function () {
                    $("#Tipos").append(
                        $("<option>").attr("value", this.id)
                            .html(this.descripcion)
                    )
                })
            }
            else {
                showToast("Error: no se trajo ningun tipo de insumo", "ERROR");
            }
        },
        failure: function (response) {
            alert("fail");
        },
        error: function (response) {
            alert(response.responseText);
        }
    });

})

function ListarMesas() {
    ("#panelMesa").html = "";
    $.ajax({
        method: "POST",
        url: 'Sistema.aspx/ListaMesas',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            let contenedor = $("#panelMesa");
            $(response.d).each(function () {
                let card = document.createElement("div");
                let imagen = document.createElement("img");
                let numero = document.createElement("span");
                let url;
                switch (this.estado.id) {
                    case 0:
                        url = "./Content/img/mesaInactiva.png"
                        break;
                    case 1:
                        url = "./Content/img/mesa.png"
                        break;
                    case 2:
                        url = "./Content/img/mesaOcupada.png"
                        break;
                    case 3:
                        break;
                }
                $(numero).addClass("numeroMesa")
                    .html(this.numero);
                $(imagen).attr("src", url)
                    .addClass("mesa");
                $(card).attr("id", this.id)
                    .addClass("col-sm-4 col-md-4 col-lg-3")
                $(card).attr("data-estado", this.estado.id)
                    .attr("role", "mesa");
                $(card).append(imagen);
                $(card).append(numero);
                $(contenedor).append(card);
                $(card).click(function () {
                    if ($(this).attr("data-estado") != 0) {

                        $("#panelMesa").find("[class*='activo']").removeClass("activo");
                        $(this).addClass("activo");
                        mesaSeleccionada($(this).attr("id"));
                    }
                });
            })
        },
        failure: function (response) {
            alert("fail");
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
    

}

function mesaSeleccionada(idMesa) {
    var dato = {id:idMesa}
    $.ajax({
        method: "POST",
        url: 'Sistema.aspx/mesaSeleccionada',
        data: JSON.stringify(dato),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: (response) => {
            $("#Mesa").val(response.d.numero)
                .attr("data-mesa",response.d.id);
            $("#Mesero").val(response.d.mesero.nombre + " " + response.d.mesero.apellido)
                .attr("data-mesero", response.d.mesero.legajo);
            if (response.d.pedido != null) {
                $("#Agregar").removeClass("hide");
                $("#Cerrar").removeClass("hide");
                $("#Buscar").removeAttr("disabled");
                listarDetallePedido();
                ListarMesas();
            }
            else {
                $("#Agregar").addClass("hide");
                $("#Cerrar").addClass("hide");
                $("#Buscar").attr("disabled", "true");
                $("#Abrir").removeClass("hide");
                $("tbody").html("");
            }
        },
        failure: function (response) {
            alert("fail");
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
}



/// configuaracion para que ande el toast correctamente
$(".toast").toast({ delay: 2000 });

$(function () {
    $('[data-toggle="tooltip"]').tooltip()
})

////////////////////////////////////////////////////////////////
// llammados ajax para los distintos botones
$("#Abrir").click((e) => {
    e.preventDefault();
    var datos = {mesa:$("#Mesa").attr("data-mesa"), mesero:$("#Mesero").attr("data-mesero")};
    $.ajax({
        method: "POST",
        url: "Sistema.aspx/Generar",
        data: JSON.stringify(datos),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: (response) => {
            if (response.d) {

                showToast("Se abrio correctamente el pedido ", "Exito");
                $("#Agregar").removeClass("hide").removeAttr("disabled");
                $("#Cerrar").removeClass("hide").removeAttr("disabled");
                $("#Abrir").addClass("hide").Attr("disabled");
                $("#Buscar").removeAttr("disabled");
            }
            else {
                showToast("No se pudo abrir Pedido ", "Error");

            }
        },
        error: (response) => {
            showToast("Error: " + response.responseText, "Error");
        }
    });
});

$("#Agregar").click((e) => {
    e.preventDefault();
    var datos = {
        idInsumo: $("#codigo").val(),
        cantidad: $("#cantidad").val()
    };
    if (datos.idInsumo == "" || datos.cantidad == "") {
        showToast("eliga un producto y seleccion su cantidad", "alerta");
        return;
    }
    $.ajax({
        method: "POST",
        url: "Sistema.aspx/Agregar",
        data: JSON.stringify(datos),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: (response) => {
            if (response.d) {

                showToast("Se agrego correctamente al pedido ", "Exito");
                listarDetallePedido();
            }
            else {
                showToast("No se pudo agrego al Pedido ", "Error");
            }
        },
        error: (response) => {
            showToast("Error: en la conexion" , "Error");
        }
    });
});


$("#Cerrar").click(function (e) {
    e.preventDefault();
    $("#modalCierrePedido").modal("show");
});



$("#Buscar").click((e) => {
    e.preventDefault();
    var dato = {tipo:$("#Tipos").val()};
    $.ajax({
        method: "POST",
        url: 'Sistema.aspx/Buscar',
        data: JSON.stringify(dato),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: (response) => {
            if (response.d.length) {

                modal($("#Tipos").val(), response.d);
                $("#Modal").modal("show");
            }
            else {
                showToast("No se encontro mercaderia usable de este tipo ", "Error");
            }
        },
        error: (response) => {
            showToast("Error: " + response.responseText, "Error");
        }
    });
});

$("#CerrarPedido").click(function () {
    datos = { mesa: $("#Mesa").attr("data-mesa") };
    $.ajax({
        method: "POST",
        url: 'Sistema.aspx/CerrarPedido',
        data: JSON.stringify(datos),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: (response) => {
            if (response.d = "ok") {
                showToast("El pedido se cerro correctamente", "Afirmacion");
                $("tbody").html("");
                ListarMesas();
            }
            else if (response.d = "noCierre") {
                showToast("ERROR: no se pudo cerrar el pedido", "Error");
            }
            else {
                showToast("ERROR: no se pudo cerrar el pedido", "Error");
                setTimeout(function () {
                    window.location = "Login.aspx"
                }, 1000);
            }
        },
        error: (response) => {
            showToast("Error: " + response.responseText, "Error");
        }
    });
});

// llammados ajax para los distintos botones
////////////////////////////////////////////////////////////////////////




////////////////////////////////////////////////////////////////////////
/// metodo para la muestra de una  alerta
function showToast(msg, titulo) {
    $(".toast-header").find("[class*='contenido']").html(titulo);
    $(".toast-body").html(msg);
    $(".toast").toast("show");
}
/// metodo para la muestra de una  alerta
////////////////////////////////////////////////////////////////////////




////////////////////////////////////////////////////////////////////////////////////////
/// metodos para la muestra del modal de busqueda de producto  



// constructor  de la estructura general
function modal(tipo, datos) {
    var contenedor = document.createElement("div");
    var areaBusqueda = document.createElement("div");
    $(areaBusqueda).css("areaBusqueda");
    var filtros = document.createElement("div");
    $(filtros).css("filtros");
    /*filtros futuros para una busqueda mejor
     * if (tipo == "comida") {
        $(filtros).append(FiltroComida);
    }
    else {
        $(filtros).append(filtrosBebidas);
    }*/

    var textbox = document.createElement("input");


    $(textbox).attr("type", "text").attr("id", "textSearch").attr("placeHolder", "texto a buscar");
    $(textbox).keypress(function (e) {
        if (e.currentTarget.value.length > 3)
            textoBuscar();
        else
            $("#TablaProducto").find("tr").removeClass("hide");
    });
    $(areaBusqueda).append(textbox)
        //.append(filtros);
    var tabla = document.createElement("table");
    $(tabla).attr("id", "TablaProducto");
    $(tabla).append(
        $("<thead>").append(tipo == 2 ? CabeceraComida() : CabeceraBebida())
    )
    $(tabla).append("<tbody>");
    $(tabla).addClass("table");
    var filas = [];
    $(datos).each(function() {
        let fila = tipo == 2 ? ContenidoComida(this) : ContenidoBebida(this);
        $(fila).css("cursor", "pointer");
        $(fila).click(function () {
            $(tabla).find("[class='activa']").removeClass("activa");
            $(fila).addClass("activa");
        })
        $(tabla).find("tbody").append(fila);
    });
    $(contenedor).append(areaBusqueda);
    $(contenedor).append(tabla);
    contenedor.style = "max-height: 50vh;overflow: auto; min - width: 70 %;"
    $(".modal-body").html(contenedor)
}



/////////////////////////////////////////////////////////////////////////////
// cabecera de las tablas por tipos
function CabeceraBebida() {
    let cabecera = document.createElement("tr");
    $(cabecera).append(
        $("<th>").html("codigo")
            .attr("scope","col")
    ).append(
        $("<th>").html("Descripcion")
            .attr("scope", "col")
    ).append(
        $("<th>").html("Tipo")
            .attr("scope", "col")
    ).append(
        $("<th>").html("Marca")
            .attr("scope", "col")
    ).append(
        $("<th>").html("C/Alcochol")
            .attr("scope", "col")
    ).append(
        $("<th>").html("Cantidad Restante")
            .attr("scope", "col")
    ).attr("scope", "row");
    return cabecera;
}

function CabeceraComida() {
    let cabecera = document.createElement("tr");
    $(cabecera).append(
        $("<th>").html("codigo")
            .attr("scope", "col")
    ).append(
        $("<th>").html("Descripcion")
            .attr("scope", "col")
    ).append(
        $("<th>").html("Tipo")
            .attr("scope", "col")
    ).append(
        $("<th>").html("Cantidad Restante")
            .attr("scope", "col")
    ).attr("scope", "row");
    return cabecera;
}

// cabeceras de las tabla por tipo
///////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////
//contenido de la tabla por tipos

function ContenidoComida(dato) {
    let fila = document.createElement("tr");
    $(fila).append(
        $("<td>").html(dato.id).attr("role","id")
    ).append(
        $("<td>").html(dato.descripcion).attr("role", "nombre")
    ).append(
        $("<td>").html(dato.tipo).attr("role", "tipo")
    ).append(
        $("<td>").html(dato.cantidad).attr("role", "cantidad")
    ).attr("scope", "row")
        ;
    return fila;
}

function ContenidoBebida() {
    let fila = document.createElement("tr");
    $(fila).append(
        $("<td>").html(dato.codigo).attr("role", "id")
    ).append(
        $("<td>").html(dato.descripcion).attr("role", "nombre")
    ).append(
        $("<td>").html(dato.tipo).attr("role", "tipo")
    ).append(
        $("<td>").html(dato.marca).attr("role", "marca")
    ).append(
        $("<td>").html(dato.Alcochol).attr("role", "c/alcohol")
    ).append(
        $("<td>").html(dato.cantidad).attr("role", "cantidad")
    ).attr("scope", "row");
    return fila;
}

$("#seleccionar").click((e) => {
    e.preventDefault();
    let seleccion = $("#TablaProducto").find("[class='activa']");
    $("#codigo").val($(seleccion).find("[role='id']").text());
    $("#descripcion").val($(seleccion).find("[role='nombre']").text());
    $("#cantidad").html("");
    for (var i = 1; i <= $(seleccion).find("[role='cantidad']").text(); i++) {
        let opcion = document.createElement("option");
        $(opcion).attr("value", i);
        $(opcion).html(i);
        $("#cantidad").append(opcion);
    }
    $("#Modal").modal("hide");
});


function textoBuscar() {
    var texto = $("#textSearch").val().toLowerCase();
    var filas=$("#TablaProducto").find("tbody").find("tr");
    for (var key in filas) {
        if ($(filas[key]).find("[role='nombre']").text().toLowerCase().indexOf(texto) > -1 || texto.length<3) {
            if ($(filas[key]).hasClass("hide")) {
                $(filas[key]).removeClass("hide");
            }
        }
        else {
            if (!$(filas[key]).hasClass("hide")) {
                $(filas[key]).addClass("hide");
            }
        }
    };

   
}
// contenido de la tabla por tipos
/////////////////////////////////////////////////////////////////////////

/// metodos para la muestra del modal de busqueda de producto  
////////////////////////////////////////////////////////////////////////////////////////


/////////////////////////////////////////////////////////////////////////////////7
/// detalle del pedido
function listarDetallePedido() {
    $("#detallePedido").find("tbody").html("");
    $.ajax({
        method: "POST",
        url: 'Sistema.aspx/detallePedido',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: (response) => {
            if (response.d) {
                var detalle = $("#detallePedido").find("tbody");
                var total = 0;
                $(response.d).each(function () {
                    $(detalle).append(
                        $("<tr>").attr("scope", "row")
                            .append(
                                $("<td>").html(this.producto.id)
                        ).append(
                            $("<td>").html(this.producto.nombre)
                        ).append(
                            $("<td>").html(this.tipo)
                        ).append(
                            $("<td>").html(this.precioUnitario)
                        ).append(
                            $("<td>").html(this.cantidad)
                        ).append(
                            $("<td>").html(this.precioTotal)
                        )
                        
                    )
                    total += this.precioTotal;
                })
                $("#precioTotal").html(total)
            }
            else {
                showToast("Error: no se trajo ningun tipo de insumo", "ERROR");
            }
        },
        failure: function (response) {
            alert("fail");
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
}
/// detalle del pedido
/////////////////////////////////////////////////////////////////////////////////7


