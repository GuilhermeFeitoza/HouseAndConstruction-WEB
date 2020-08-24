$(document).ready(function () {
    var $seuCampoCpf = $("#txtCpf");
   
    $seuCampoCpf.mask('000.000.000-00');
});

function MascaraCPF(cpf) {
    if (mascaraInteiro(cpf) == false) {
        event.returnValue = false;
    }
    return formataCampo(cpf, '000.000.000-00', event);
}