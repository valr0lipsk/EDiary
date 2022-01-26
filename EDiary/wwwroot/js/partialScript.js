$(document).ready(function () {

    function sortTable(f, n) {
        var rows = $('.table tbody  tr').get();
        console.log(rows);

        rows.sort(function (a, b) {

            const A = getVal(a);
            const B = getVal(b);

            if (A < B) {
                return -1 * f;
            }
            if (A > B) {
                return 1 * f;
            }
            return 0;
        });

        function getVal(elm) {
            var v = $(elm).children('td').eq(n).text().toUpperCase();
            if ($.isNumeric(v)) {
                v = parseInt(v, 10);
            }
            return v;
        }

        $.each(rows, function (index, row) {
            $('.table').children('tbody').append(row);
        });
    }
    const f_sl = 1;


    $(".table thead tr th").click(function () {
        f_sl *= -1;
        const n = $(this).prevAll().length;
        sortTable(f_sl, n);
    });

    $('.btnRemove').click(function () {
        $('#userlogin').val($(this).parent().parent().children()[0].textContent)
        $('#confirmText').text('Вы действительно хотите удалить запись "'+ $(this).parent().parent().children()[2].textContent + ' ' + $(this).parent().parent().children()[3].textContent + ' ' + $(this).parent().parent().children()[4].textContent + '"?');
        $('#сonfirmModal').modal('show');
    })
})