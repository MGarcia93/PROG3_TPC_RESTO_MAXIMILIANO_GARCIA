
$.ajax({
    method: "POST",
    url: 'index.aspx/listarMenu',
    contentType: "application/json; charset=utf-8",
    dataType: "json",
    success: (response) => {
        menu(response.d)
    },
    failure: function (response) {
        alert("fail");
    },
    error: function (response) {
        alert(response.responseText);
    }
});

function menu(datos) {
    var menu = $("#menu-list")
    var contenido, seccion, titulo;
    var tipo = "";
    $(datos).each(function () {
        if (this.tipo != tipo) {
            tipo = this.tipo;
            contenedor = document.createElement("div");
            seccion = document.createElement("div");
            titulo = document.createElement("h2");
            $(contenedor).addClass("col-xs12 col-sm-6");
            $(titulo).html(this.tipo)
                .addClass("menu-section-title");
            $(seccion).addClass("menu-section")
                .append(titulo)
                .append($("<hr>"));
            $(menu).append(contenedor);

        }
        let item = document.createElement("div");
        let nombre = document.createElement("div");
        let precio = document.createElement("div");
        let descripcion = document.createElement("div");
        $(nombre).addClass("menu-item-name")
            .html(this.nombre);
        $(precio).addClass("menu-item-price")
            .html("$"+this.precio);
        $(descripcion).addClass("menu-item-description")
            .html(this.descripcion != undefined ? this.descripcion : "");
        $(item).addClass("menu-item")
            .append(nombre)
            .append(precio)
            .append(descripcion);
        $(seccion).append(item);
        $(contenedor).append(seccion);

    })
}