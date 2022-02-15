function stickyTable() {
    $(document).on('stickyTable', function () {
        const positionStickySupport = (function () {
            const el = document.createElement('a'),
                mStyle = el.style;
            mStyle.cssText = "position:sticky;position:-webkit-sticky;position:-ms-sticky;";
            return mStyle.position.indexOf('sticky') !== -1;
        })();

        let scrollTypeRTL = (function () {
            let definer = $('<div dir="rtl" style="font-size: 14px; width: 4px; height: 1px; position: absolute; top: -1000px; overflow: scroll">ABCD</div>').appendTo('body')[0],
                scrollTypeRTL = 'reverse';

            if (definer.scrollLeft > 0) {
                scrollTypeRTL = 'default';
            } else {
                definer.scrollLeft = 1;
                if (definer.scrollLeft === 0) {
                    scrollTypeRTL = 'negative';
                }
            }
            $(definer).remove();
            return scrollTypeRTL;
        })();

        if (positionStickySupport) {
            let offset = 0;
            $(".sticky-table").each(function () {
                offset = 0;
                $(this).find("table thead tr.sticky-header").each(function () {
                    $(this).find("th").css('top', offset);
                    $(this).find("td").css('top', offset);
                    offset += $(this).outerHeight();
                })

                offset = 0;
                $($(this).find("table tr.sticky-footer").get().reverse()).each(function () {
                    $(this).find("th").css('bottom', offset);
                    $(this).find("td").css('bottom', offset);
                    offset += $(this).outerHeight();
                })
            })

            $(".sticky-ltr-cells table tr").each(function () {
                offset = 0;
                $(this).find(".sticky-cell").each(function () {
                    $(this).css('left', offset);
                    offset += $(this).outerWidth();
                })

                offset = 0;
                $($(this).find(".sticky-cell-opposite").get().reverse()).each(function () {
                    $(this).css('right', offset);
                    offset += $(this).outerWidth();
                })
            })
        } else {
            if (navigator.userAgent.match(/Trident\/7\./)) {
                $('.sticky-table').on("mousewheel", function (event) {
                    event.preventDefault();
                    let wd = event.originalEvent.wheelDelta;
                    let csp = $(this).scrollTop();
                    $(this).scrollTop(csp - wd);
                });
            }

            $(".sticky-table").scroll(function () {
                let maxScroll = $(this).find("table").prop("clientHeight") - $(this).prop("clientHeight");
                $(this).find("table tr.sticky-footer th").css('bottom', maxScroll - $(this).scrollTop());
                $(this).find("table tr.sticky-footer td").css('bottom', maxScroll - $(this).scrollTop());
            }).scroll();

            $(window).scroll(function () {
                $(this).find("table tr.sticky-header th").css('top', $(this).scrollTop());
                $(this).find("table tr.sticky-header td").css('top', $(this).scrollTop());
            }).scroll()

            $(".sticky-ltr-cells").scroll(function () {
                $(this).find("table th.sticky-cell").css('left', $(this).scrollLeft());
                $(this).find("table td.sticky-cell").css('left', $(this).scrollLeft());
                var maxScroll = $(this).find("table").prop("clientWidth") - $(this).prop("clientWidth");
                $(this).find("table th.sticky-cell-opposite").css('right', maxScroll - $(this).scrollLeft());
                $(this).find("table td.sticky-cell-opposite").css('right', maxScroll - $(this).scrollLeft());
            }).scroll();
        }
        if ($(".sticky-rtl-cells").length && !(positionStickySupport && scrollTypeRTL == 'negative')) {
            if (positionStickySupport) {
                $(".sticky-rtl-cells table th.sticky-cell").css('position', "relative");
                $(".sticky-rtl-cells table td.sticky-cell").css('position', "relative");
                $(".sticky-rtl-cells table th.sticky-cell-opposite").css('position', "relative");
                $(".sticky-rtl-cells table td.sticky-cell-opposite").css('position', "relative");

                $(".sticky-table").scroll(function () {
                    var maxScroll = $(this).find("table").prop("clientHeight") - $(this).prop("clientHeight");
                    $(this).find("table tr.sticky-footer .sticky-cell").css('bottom', maxScroll - $(this).scrollTop());
                    $(this).find("table tr.sticky-footer .sticky-cell-opposite").css('bottom', maxScroll - $(this).scrollTop());
                }).scroll();

                $(window).scroll(function () {
                    $(this).find("table tr.sticky-header .sticky-cell").css('top', $(this).scrollTop());
                    $(this).find("table tr.sticky-header .sticky-cell-opposite").css('top', $(this).scrollTop());
                }).scroll()
            }
            $(".sticky-rtl-cells").scroll(function () {
                let maxScroll = $(this).find("table").prop("clientWidth") - $(this).prop("clientWidth");
                switch (scrollTypeRTL) {
                    case "default": // webKit Browsers
                        $(this).find("table th.sticky-cell").css('right', maxScroll - $(this).scrollLeft());
                        $(this).find("table td.sticky-cell").css('right', maxScroll - $(this).scrollLeft());
                        $(this).find("table th.sticky-cell-opposite").css('left', $(this).scrollLeft());
                        $(this).find("table td.sticky-cell-opposite").css('left', $(this).scrollLeft());
                        break;
                    case "negative": // Firefox, Opera
                        $(this).find("table th.sticky-cell").css('right', $(this).scrollLeft() * -1);
                        $(this).find("table td.sticky-cell").css('right', $(this).scrollLeft() * -1);
                        $(this).find("table th.sticky-cell-opposite").css('left', maxScroll + $(this).scrollLeft());
                        $(this).find("table td.sticky-cell-opposite").css('left', maxScroll + $(this).scrollLeft());
                        break;
                    case "reverse": // IE, Edge
                        $(this).find("table th.sticky-cell").css('right', $(this).scrollLeft());
                        $(this).find("table td.sticky-cell").css('right', $(this).scrollLeft());
                        $(this).find("table th.sticky-cell-opposite").css('left', maxScroll - $(this).scrollLeft());
                        $(this).find("table td.sticky-cell-opposite").css('left', maxScroll - $(this).scrollLeft());
                }
            }).scroll();
        }

        $(window).resize(function () {
            $(".sticky-table").scroll();
        });

    });
    $(document).ready(function () {
        $(document).trigger("stickyTable");
    });
}

function sortTable(f, n) {
    let rows = $('.table tbody  tr').get();

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
        let v = $(elm).children('td').eq(n).text().toUpperCase();
        if ($.isNumeric(v)) {
            v = parseInt(v, 10);
        }
        return v;
    }

    $.each(rows, function (index, row) {
        $('.table').children('tbody').append(row);
    });
}

function jurnalStyleTable() {
    const table = $('.table').find('th.vt-text');
    const OKRs = [], KRs = [], SRs = [], EKZs = [];
    for (let i = 0; i < table.length; i++) {
        if ($(table[i]).attr('data-lessType') === '2') {
            OKRs.push(i);
        }
        else if ($(table[i]).attr('data-lessType') === '3') {
            KRs.push(i);
        }
        else if ($(table[i]).attr('data-lessType') === '4') {
            SRs.push(i);
        }
        else if ($(table[i]).attr('data-lessType') === '5') {
            EKZs.push(i);
        }
    }
    const rows = $('.table').find('tr:not(:first)');
    for (let i = 0; i < rows.length; i++) {
        for (let j = 0; j < rows[i].children.length; j++) {
            if (OKRs.indexOf(j) != -1) {
                $(rows[i].children[j + 1]).addClass('lessOKR')
            }
            else if (KRs.indexOf(j) != -1) {
                $(rows[i].children[j + 1]).addClass('lessKR')
            }
            else if (SRs.indexOf(j) != -1) {
                $(rows[i].children[j + 1]).addClass('lessSR')
            }
            else if (EKZs.indexOf(j) != -1) {
                $(rows[i].children[j + 1]).addClass('lessEKZ')
            }
        }
    }
}

export { stickyTable };
export { sortTable };
export { jurnalStyleTable };