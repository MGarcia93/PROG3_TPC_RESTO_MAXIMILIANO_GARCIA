$("document").ready(function(){
    $.ajax({
        method:"POST",
        url:'Sistema.aspx/ListaMesas',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: show,
        failure: function (response) {
            alert("fail");
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
    function show(response){
        let contenedor =$("#panelMesa");
        $(response.d).each(function(){
            let card= document.createElement("div");
            let imagen = document.createElement("img");
            let numero = document.createElement("span");
            let url;
            switch (this.estado.id){
                case 0:
                    url="./Content/img/mesaInactiva.png"
                break;
                case 1:
                    url="./Content/img/mesa.png"
                break;
                case 2:
                url="./Content/img/mesaOcupada.png"
                break;
                case 3:
                break;
            }
            $(numero).attr("style", "font-size:3em;position: absolute; top:25%;left:40%; color:black;cursor:default")
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
            })
        });

    }           
})


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
                .attr("data-mesero", response.d.mesero.id);
            if (response.d.pedido!=null) {
                $("#Agregar").show();
                $("#Cerrar").show();
            }
            else {
                $("#Abrir").show();
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
    var datos = {};
    $.ajax({
        type: "POST",
        url: "Sistema.aspx/Generar",
        data: JSON.stringify(datos),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: (response) => {
            if (response.d) {

                showToast("Se abrio correctamente el pedido ", "Exito");
                $("#Agregar").show().removeAttr("disabled");
                $("#Cerrar").show().removeAttr("disabled");
                $("#Abrir").hide().Attr("disabled");
                $("#buscar").removeAttr("disabled");
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
    var datos = {};
    $.ajax({
        type: "POST",
        url: "Sistema.aspx/Agregar",
        data: JSON.stringify(datos),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: (response) => {
            if (response.d) {

                showToast("Se abrio correctamente el pedido ", "Exito");
                $("#Agregar").show().removeAttr("disabled");
                $("#Cerrar").show().removeAttr("disabled");
                $("#Abrir").hide().Attr("disabled");
                $("#buscar").removeAttr("disabled");
            }
            else {
                showToast("No se pudo abrir Pedido ", "Error");
            }
        },
        error: (response) => {
            showToast("Error: en la conexion" , "Error");
        }
    });
});


$("#buscar").click(() => {
    var datos = {id:1};
    $.ajax({
        type: "POST",
        url: "Sistema.aspx/Buscar",
        data: JSON.stringify(datos),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: (response) => {
            if (response.d) {

                Modal(1, respose.d);
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
    var filtros = document.createElementNS("div");
    $(filtros).css("filtros");
    if (tipo == "comida") {
        $(filtros).append(FiltroComida);
    }
    else {
        $(filtros).append(filtrosBebidas);
    }

    var textbox = document.createElement("imput");


    $(textbox).attr("type", "text").attr("id", "textSearch").attr("placeHolder", "texto a buscar");
    $(textbox).click(textBuscar());
    $(areaBusqueda).append(textbox)
        .append(filtos);
    var tabla = document.createElement("table").attr("id", "TablaProducto");
    $(tabla).append(
        $("<thead>").append(tipo == "comida" ? cabeceraComida() : cabeceraBebida())
    )
    $(tabla).append("<tbody>");
    var filas = [];
    $(datos).each(() => {
        document.createElement("tr");
        $(fila).attr("data-tipo")
        $(fila).append($("<td>").attr("role", "row").html("Nombre"))
            .append($("<td>").html("descripcion"))
            .append($("<td>").html("tipo"));
        $(tabla).find("tbody").append(tipo == "comida" ? contenidoComida(this) : contenidoBebida(this));
    });
    $(contenedor).append(areaBusqueda);
    $(contenedor).append(tabla);
    $(".modal-body").html(contenedor)
}



/////////////////////////////////////////////////////////////////////////////
// cabecera de las tablas por tipos
function CabeceraBebida() {
    let cabecera = document.createElement("tr");
    $(cabecera).append(
        $("<th>").html("codigo")
    ).append(
        $("<th>").html("Nombre")
    ).append(
        $("<th>").html("Descripcion")
    ).append(
        $("<th>").html("Tipo")
    ).append(
        $("<th>").html("Marca")
    ).append(
        $("<th>").html("C/Alcochol")
    ).append(
        $("<th>").html("Cantidad Restante")
    );
    return cabecera;
}

function CabeceraComida() {
    let cabecera = document.createElement("tr");
    $(cabecera).append(
        $("<th>").html("codigo")
    ).append(
        $("<th>").html("Nombre")
    ).append(
        $("<th>").html("Descripcion")
    ).append(
        $("<th>").html("Tipo")
    ).append(
        $("<th>").html("Cantidad Restante")
    );
    return cabecera;
}

// cabeceras de las tabla por tipo
///////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////
//contenido de la tabla por tipos

function contenidoComida(dato) {
    let fila = document.createElement("tr");
    $(fila).append(
        $("<td>").html(dato.codigo)
    ).append(
        $("<td>").html(dato.nombre)
    ).append(
        $("<td>").html(dato.descripcion)
    ).append(
        $("<td>").html(dato.tipo)
    ).append(
        $("<td>").html(dato.Cantidad)
    );
    return fila;
}

function contenidoBebida() {
    let fila = document.createElement("tr");
    $(fila).append(
        $("<td>").html(dato.codigo).attr("role", "codigo")
    ).append(
        $("<td>").html(dato.nombre).attr("role", "nombre")
    ).append(
        $("<td>").html(dato.descripcion).attr("role", "descripcion")
    ).append(
        $("<td>").html(dato.tipo).attr("role", "tipo")
    ).append(
        $("<td>").html(dato.marca).attr("role", "marca")
    ).append(
        $("<td>").html(dato.Alcochol).attr("role", "c/alcohol")
    ).append(
        $("<td>").html(dato.cantidad).attr("role", "cantidad")
    );
    return fila;
}

$("seleccionar").click(() => {
    let seleccion = ("#tablaProducto").find("[class='activa']");
    $("#codigo").value = $(seleccion).find("[role='codigo']").value;
    $("#nombre").value = $(seleccion).find("[role='nombre']").value;
    $("#cantidad").html("");
    for (var i = 1; i <= $(seleccion).find("[role='cantida']").value; i++) {
        let opcion = document.createElement("option");
        $(opcion).attr("value", "i");
        $("#cantidad").append(opcion);
    }
    $("#Modal").modal("hide");
});


function textoBuscar() {
    var texto = $("#textSearch").text().toLowerCase()
    if (texto.lenth > 3) {
        $("#tablaProducto").find("tbody").find("tr").each((e, d) => {
            if ($(d).find("[role='nombre']").text().toLowerCase().indexOf(texto) > -1) {
                if ($(d).hasClass("hide")) {
                    $(d).removeClass("hide");
                }
            }
            else {
                if (!$(d).hasClass("hide")) {
                    $(d).addClass("hide");
                }
            }
        });

    }
}
// contenido de la tabla por tipos
/////////////////////////////////////////////////////////////////////////

/// metodos para la muestra del modal de busqueda de producto  
////////////////////////////////////////////////////////////////////////////////////////
