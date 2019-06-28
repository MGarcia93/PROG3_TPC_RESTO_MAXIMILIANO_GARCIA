
$("#ingresar").click(function () {
    let nombre=$("#nombre")[0].value;
    let password=$("#password")[0].value;
    if(nombre.trim()!="" && password.trim()!=""){
        data = {
            user: nombre,
            pass: password
        }
        $.ajax({
            method:"POST",
            url: 'Login.aspx/Acceso',
            data: JSON.stringify(data),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function(response){
                if(response.d){
                    window.location.replace("sistema.aspx");
                }
                else{
                    error("Usuario o Password incorrecta");
                    $("#nombre")[0].value = "";
                    $("#password")[0].value = "";
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
    else{
        error("Rellene todos los datos");
    }
    
});
function error(msg){
    if($("#error").hasClass("hidden")){
        $("#error").removeClass("hidden");
        $("#error").html(msg);
        setTimeout(function(){
            $("#error").addClass("hidden");
        },3000);
    }
}

$("#nombre").keypress(function (e) {
    if (e.which == 13) {
        $("#ingresar").trigger("click")
    }
})
$("#password").keypress(function (e) {
    if (e.which == 13) {
        $("#ingresar").trigger("click")
    }
})

    