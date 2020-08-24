
//CAMPOS COM MÁSCARA
$(document).ready(function () {
    var $seuCampoCpf = $("#txtCpf");
    var $seuCampoTel = $("#txtTel");

    $seuCampoCpf.mask('000.000.000-00', { reverse: true });
    $seuCampoTel.mask(' (00) 00000-0000', { reverse: true });
});
//FUNÇÃO VERIFICA EMAIL
function verifica() {
    if (document.forms[0].email.value.length == 0) {
        alert('Por favor, informe o seu EMAIL.');
        document.frmEnvia.email.focus();
        return false;
    }
    return true;
}

function checarEmail() {
    if (document.forms[0].email.value == ""
        || document.forms[0].email.value.indexOf("@") == -1
        || document.forms[0].email.value.indexOf('.') == -1) {
        alert("Por favor, informe um E-MAIL válido!");
        return false;
    }
}

//valida CPF
function MascaraCPF(cpf) {
    if (mascaraInteiro(cpf) == false) {
        event.returnValue = false;
    }
    return formataCampo(cpf, '000.000.000-00', event);
}

function ValidarCPF(Objcpf) {
    var cpf = Objcpf.value;
    exp = /\.|\-/g
    cpf = cpf.toString().replace(exp, "");
    var digitoDigitado = eval(cpf.charAt(9) + cpf.charAt(10));
    var soma1 = 0, soma2 = 0;
    var vlr = 11;

    for (i = 0; i < 9; i++) {
        soma1 += eval(cpf.charAt(i) * (vlr - 1));
        soma2 += eval(cpf.charAt(i) * vlr);
        vlr--;
    }
    soma1 = (((soma1 * 10) % 11) == 10 ? 0 : ((soma1 * 10) % 11));
    soma2 = (((soma2 + (2 * soma1)) * 10) % 11);

    var digitoGerado = (soma1 * 10) + soma2;
    if (digitoGerado != digitoDigitado)
        alert('CPF Invalido!');
}

function mascaraInteiro() {
    if (event.keyCode < 48 || event.keyCode > 57) {
        event.returnValue = false;
        return false;
    }
    return true;
}
