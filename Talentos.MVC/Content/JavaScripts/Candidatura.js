$(function () {

    $('.js-Slider').slider({
        formatter: function (value) {
            return 'Nível habilidade: ' + value;
        }
    });

    InitLoader();

});

var frmCandidatura = $("#frmCandidatura");

frmCandidatura.submit((event) => {

    ShowLoader();

    event.preventDefault();


    $.ajax({
        type: "POST",
        url: frmCandidatura.attr('action'),
        data: frmCandidatura.serializeArray(),
        success: (response) => {

            $('#form').hide();
            $('#footer-btns').hide();
            $('#mensagem').show();


            swal({
                title: response.title,
                text: response.text,
                type: response.type,
                confirmButtonText: 'Ok'
            });

            showPage();

        },
        error: (response) => {

            swal({
                title: 'Erro!',
                text: 'Erro ao tentar efetuar a candidatura. Tente novamente.',
                type: 'error',
                confirmButtonText: 'Ok'
            });

            showPage();
        }

    });


});

