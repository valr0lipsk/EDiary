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
})