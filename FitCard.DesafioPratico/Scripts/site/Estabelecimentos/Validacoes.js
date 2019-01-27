$(function () {
    jQuery.validator.addMethod("cnpj", function (cnpj, element) {
        cnpj = jQuery.trim(cnpj);

        // DEIXA APENAS OS NÚMEROS
        cnpj = cnpj.replace('/', '');
        cnpj = cnpj.replace('.', '');
        cnpj = cnpj.replace('.', '');
        cnpj = cnpj.replace('-', '');

        var numeros, digitos, soma, i, resultado, pos, tamanho, digitos_iguais;
        digitos_iguais = 1;

        if (cnpj.length < 14 && cnpj.length < 15) {
            return this.optional(element) || false;
        }
        for (i = 0; i < cnpj.length - 1; i++) {
            if (cnpj.charAt(i) != cnpj.charAt(i + 1)) {
                digitos_iguais = 0;
                break;
            }
        }

        if (!digitos_iguais) {
            tamanho = cnpj.length - 2
            numeros = cnpj.substring(0, tamanho);
            digitos = cnpj.substring(tamanho);
            soma = 0;
            pos = tamanho - 7;

            for (i = tamanho; i >= 1; i--) {
                soma += numeros.charAt(tamanho - i) * pos--;
                if (pos < 2) {
                    pos = 9;
                }
            }
            resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
            if (resultado != digitos.charAt(0)) {
                return this.optional(element) || false;
            }
            tamanho = tamanho + 1;
            numeros = cnpj.substring(0, tamanho);
            soma = 0;
            pos = tamanho - 7;
            for (i = tamanho; i >= 1; i--) {
                soma += numeros.charAt(tamanho - i) * pos--;
                if (pos < 2) {
                    pos = 9;
                }
            }
            resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
            if (resultado != digitos.charAt(1)) {
                return this.optional(element) || false;
            }
            return this.optional(element) || true;
        } else {
            return this.optional(element) || false;
        }
    }, "Informe um CNPJ válido."); // Mensagem padrão


    //Máscaras ----------------------------------
    $("#CNPJ").mask("99.999.999/9999-99");
    $("#Agencia").mask("999-9");
    $("#Conta").mask("99.999-9");
    $("#Telefone").mask("(99) 9999-9999?9")
        .focusout(function (event) {
            var target, phone, element;
            target = (event.currentTarget) ? event.currentTarget : event.srcElement;
            phone = target.value.replace(/\D/g, '');
            element = $(target);
            element.unmask();
            if (phone.length > 10) {
                element.mask("(99) 99999-999?9");
            } else {
                element.mask("(99) 9999-9999?9");
            }
        });
    //-------------------------------------------

    //Validators ----------------------------
    $("#Categoria").on("change", e => {
        $("#Telefone").rules("remove", "required");
        if ($("#Categoria")[0].value == "0") {
            $("#Telefone").rules("add", {
                required: true,
                messages: {
                    required: "O preenchimento do telefone é obrigatório para Estabelecimentos da categoria 'Supermercado'."
                }
            });
        }
    });
    $("#CNPJ").rules("add", "cnpj");
    //---------------------------------------


});