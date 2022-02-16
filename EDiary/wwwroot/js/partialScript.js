import { sortTable } from './tableModule.js'

$(document).ready(function ()
{
    let f_sl = 1;

    //sort table by thead clicking
    $('body').on('click', '.table thead tr th', function () {
        f_sl *= -1;
        const n = $(this).prevAll().length;
        sortTable(f_sl, n);
    });

    //confirm deleting smth
    $('body').on('click', '.btnRemove', function () {
        console.log($(this).attr('data-object'))
        if ($(this).attr('data-object') === 'subject') {
            const cell1 = $(this).parent().parent().children()[0];
            $('#tSubjectIdRmv').val($(cell1).attr('data-idTSub'));
            $('#confirmText').text('Вы действительно хотите удалить запись "' + $(this).parent().parent().children()[0].textContent.trim() + '"?');
        }
        else if ($(this).attr('data-object') === 'group') {
            $('#idGr').val($(this).parent().parent().children()[0]);
            $('#confirmText').text('Вы действительно хотите удалить запись "' + $(this).parent().parent().children()[0].textContent.trim() + '"?');
        }
        else {
            $('#userLog').val($(this).parent().parent().children()[0].textContent);
            $('#confirmText').text('Вы действительно хотите удалить запись "' + $(this).parent().parent().children()[1].textContent + ' ' + $(this).parent().parent().children()[2].textContent + ' ' + $(this).parent().parent().children()[3].textContent + '"?');
        }
        $('#сonfirmModal').modal('show');
    });

    //fill update inputs
    $('body').on('click', '.btnUpdate', function () {
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
        else if ($(this).attr('data-object') === 'group') {
            $('#numberGr').val($(this).parent().parent().children()[0].textContent);
            $('#teacherGr').val($(this).parent().parent().children()[1].textContent);
        }
        $('#updateModal').modal('show');
    });

    //find smth in tables
    $('body').on('keyup', '#findInput', function () {
        const _this = this;

        $.each($('.table tbody tr'), function () {
            if ($(this).text().toLowerCase().indexOf($(_this).val().toLowerCase()) === -1) {
                $(this).hide();
            } else {
                $(this).show();
            }
        })
    });

    //show labs inputs
    $('body').on('change', '#labsCheck', function () {
        $('.labs__block').toggleClass('d-none');
    });

    //show admin menu in mobile/small desktop version
    $('body').on('click', '#admin__menu', function () {
        $('#admin__sidebar').toggle('d-md-none border-bottom')
    });

    //img selection in adding subject
    $('body').on('click', '.img__selection', function () {
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
    });

})