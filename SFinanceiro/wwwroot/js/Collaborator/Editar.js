﻿document.addEventListener("DOMContentLoaded", function () {
    document.getElementById("IsAddress").addEventListener("click", function () {
        // Verifica se o checkbox está marcado e exibe/oculta a div com base nisso
        var divAddress = document.getElementById("divAddress");

        if (this.checked) {
            divAddress.style.display = "block";
        } else {
            divAddress.style.display = "none";
        }
    });
});

function aplicarMascaraCPFouCNPJ(value) {
    // Remove qualquer caractere que não seja dígito
    value = value.replace(/\D/g, '');

    // Aplica a máscara de CPF (000.000.000-00)
    if (value.length <= 11) {
        value = value.replace(/(\d{3})(\d)/, "$1.$2");
        value = value.replace(/(\d{3})(\d)/, "$1.$2");
        value = value.replace(/(\d{3})(\d{1,2})$/, "$1-$2");
    }
    // Aplica a máscara de CNPJ (00.000.000/0000-00)
    else {
        value = value.replace(/^(\d{2})(\d)/, "$1.$2");
        value = value.replace(/^(\d{2})\.(\d{3})(\d)/, "$1.$2.$3");
        value = value.replace(/\.(\d{3})(\d)/, ".$1/$2");
        value = value.replace(/(\d{4})(\d{1,2})$/, "$1-$2");
    }
    return value;
}

// Evento para aplicar a máscara conforme o usuário digita
const cpfCnpjInput = document.getElementById("Id");
cpfCnpjInput.addEventListener("input", function (event) {
    event.target.value = aplicarMascaraCPFouCNPJ(event.target.value);
});