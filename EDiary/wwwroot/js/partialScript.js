$(document).ready(function ()
{

    function sortTable(f, n)
    {
        var rows = $('.table tbody  tr').get();
        console.log(rows);

        rows.sort(function (a, b)
        {

            const A = getVal(a);
            const B = getVal(b);

            if (A < B)
            {
                return -1 * f;
            }
            if (A > B)
            {
                return 1 * f;
            }
            return 0;
        });

        function getVal(elm)
        {
            var v = $(elm).children('td').eq(n).text().toUpperCase();
            if ($.isNumeric(v))
            {
                v = parseInt(v, 10);
            }
            return v;
        }

        $.each(rows, function (index, row)
        {
            $('.table').children('tbody').append(row);
        });
    }
    let f_sl = 1;


    $('.table thead tr th').click(function ()
    {
        f_sl *= -1;
        const n = $(this).prevAll().length;
        sortTable(f_sl, n);
    });

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

    $('#findInput').keyup(function () {
        _this = this;

        $.each($('.table tbody tr'), function () {
            if ($(this).text().toLowerCase().indexOf($(_this).val().toLowerCase()) === -1) {
                $(this).hide();
            } else {
                $(this).show();
            }
        })
    })

    $('#labsCheck').change(function () {
        $('.labs__block').toggleClass('d-none');
    })

    $('#admin__menu').click(function () {
        $('#admin__sidebar').toggle('d-md-none border-bottom')
    })

    //$('.dropdown-menu').parent().on('shown.bs.dropdown', function () {
        
    //});
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