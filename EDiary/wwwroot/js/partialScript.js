import { sortTable } from './tableModule.js'

$(document).ready(function ()
{
    let f_sl = 1;

    //sort table by thead clicking
    $('.table thead tr th').click(function ()
    {
        f_sl *= -1;
        const n = $(this).prevAll().length;
        sortTable(f_sl, n);
    });

    //confirm deleting smth
    $('.btnRemove').click(function () {
        console.log($(this).attr('data-object'))
        if ($(this).attr('data-object') === 'subject') {
            const cell1 = $(this).parent().parent().children()[0];
            $('#tSubjectIdRmv').val($(cell1).attr('data-idTSub'));
            $('#confirmText').text('Вы действительно хотите удалить запись "' + $(this).parent().parent().children()[0].textContent.trim() + '"?');
        }
        else {
            $('#userLog').val($(this).parent().parent().children()[0].textContent);
            $('#confirmText').text('Вы действительно хотите удалить запись "' + $(this).parent().parent().children()[1].textContent + ' ' + $(this).parent().parent().children()[2].textContent + ' ' + $(this).parent().parent().children()[3].textContent + '"?');
        }
        $('#сonfirmModal').modal('show');
    })

    //fill update inputs
    $('.btnUpdate').click(function ()
    {
        if ($(this).attr('data-object') === 'user') {
            $('#userLogin').val($(this).parent().parent().children()[0].textContent);
            $('#userSurname').val($(this).parent().parent().children()[1].textContent);
            $('#userName').val($(this).parent().parent().children()[2].textContent);
            $('#userLastname').val($(this).parent().parent().children()[3].textContent);
            $('#userEmail').val($(this).parent().parent().children()[4].textContent);
            if ($('#userGroup')) {
                $('#userGroup').val($(this).parent().parent().children()[5].textContent);
            }

        }
        else if ($(this).attr('data-object') === 'subject') {
            $('#subName').val($(this).parent().parent().children()[0].textContent);
            const cell1 = $(this).parent().parent().children()[0];
            $('#tSubjectIdUpdt').val($(cell1).attr('data-idTSub'));
            $('#subjectTeacher').val($(this).parent().parent().children()[1].textContent);
            $('#subjectGroup').val($(this).parent().parent().children()[2].textContent);
        }
        $('#updateModal').modal('show');
    })

    //find smth in tables
    $('#findInput').keyup(function () {
        const _this = this;

        $.each($('.table tbody tr'), function () {
            if ($(this).text().toLowerCase().indexOf($(_this).val().toLowerCase()) === -1) {
                $(this).hide();
            } else {
                $(this).show();
            }
        })
    })

    //show labs inputs
    $('#labsCheck').change(function () {
        $('.labs__block').toggleClass('d-none');
    })

    //show admin menu in mobile/small desktop version
    $('#admin__menu').click(function () {
        $('#admin__sidebar').toggle('d-md-none border-bottom')
    })


    //img selection in adding subject
    $('.img__selection').click(function () {
        event.preventDefault();
        if ($('.dropdown-menu').hasClass('show')) {
            $('.dropdown-menu').dropdown('hide');
        }
        else {
            $('.dropdown-menu').dropdown('show');
        }

        $('.selection__item').click(function () {
            $.each($('.selection__item'), function () {
                if ($(this).hasClass('checked')) {
                    $(this).removeClass('checked');
                }
            })
            $(this).toggleClass('checked');
            $('#sImgId').val($(this).attr('data-idImg'));
        })
    })

})