        function zero_first_format(value) {
            if (value < 10) {
                value = '0' + value;
            }
            return value;
        }

    function date_time()
    {
        var current_datetime = new Date();
        var day = zero_first_format(current_datetime.getDate());
        var month = zero_first_format(current_datetime.getMonth()+1);
        var year = current_datetime.getFullYear();
        var hours = zero_first_format(current_datetime.getHours());
        var minutes = zero_first_format(current_datetime.getMinutes());
        var seconds = zero_first_format(current_datetime.getSeconds());

        return hours + ":" + minutes + ":" +seconds+" "+day+"."+month+"."+year;
    }

$(document).ready(function () {
    //admin funcs
    //add student
    $('#addSt').click(function () {
        $('#partialDiv').load('/Admin/AddStudent');
    });

    //add teacher
    $('#addT').click(function () {
        $('#partialDiv').load('/Admin/AddTeacher');
    })
    //add subj
    $('#addSb').click(function () {
        $('#partialDiv').load('/Admin/AddSubject');
    })
    //show all students
    $('#allSt').click(function () {
        $('#partialDiv').load('/Admin/ShowStudents');
    })
    //show all teachers
    $('#allT').click(function () {
        $('#partialDiv').load('/Admin/ShowTeachers');
    })
    //show all subjs
    $('#allSb').click(function () {
        $('#partialDiv').load('/Admin/ShowSubjects');
    })

    //-------------------------------------------
    //common funcs
    //get subject id from acc to open jurnal page
    $('.item__title').click(function () {
        const subId = $(this).attr('data-id');
        $.ajax({
            type: 'GET',
            data: { 'id': subId },
            cache: false,
            async: true,
            success: function (result) {
                window.location.href = '/Marks/Jurnal?id=' + subId;
            }
        });
    })

    //open adding photo modal
    $('.openIconModal').click(function () {
        $('#iconModal').modal('show');
    });

    //setting current date and time
    setInterval(() => {
        $('#statusDate').text(date_time());
    })

    //open kebab-menu in acc
    $('#icons__dots').click(() => {
        $('#dropdown').toggleClass('show');
    })

    $(window).click(() => {
        if (!event.target.matches('#icons__dots')) {

            const dropdowns = $(document).find('dropdown-content');
            for (let i = 0; i < dropdowns.length; i++) {
                const openDropdown = dropdowns[i];
                if (openDropdown.classList.contains('show')) {
                    openDropdown.classList.remove('show');
                }
            }
        }
    })

    //hide info messagge in pass changing
    if ($('#valForNew').text() != '') {
        $('#passwordHelpBlock').addClass('d-none')
    }



    //-----------------------------------------
    //jurnal funcs
    //open adding lesson modal
    $('#addLessModal').click(function () {
        $('#lessModal').modal('show');
    });

    //open delete lesson modal
    $('th.delLes').bind('dblclick', function () {
        const id = $(this).attr('data-idLess');
        const data = $(this).text();
        $('#idLess').val(id);
        $('#delLabel').text('Удалить занятие за ' + data + '?');
        $('#delLessModal').modal('show');
    })

    //update, delete and add mark in jurnal
    //$('td.pt-3-half').bind('click', function () {   
    //    if (!$(this).has('input').length) {
    //        if ($(this).attr('data-idsm')) { //update or delete mark
    //            const markID = $(this).attr('data-idsm'); 
    //            const td = $(this);
    //            const input = $('<input/>', {
    //                'type': 'text',
    //                'value': $(this).html(),
    //                blur: function () {
    //                    const newValue = $(this).val();
    //                    $.ajax({
    //                        url: this.URL,
    //                        type: "PUT",
    //                        data: {
    //                            'id': markID,
    //                            'value': newValue
    //                        },
    //                        cache: false,
    //                        async: true,
    //                        success: function (result) {
    //                            alert(result.message)
    //                            if (result.status === 'deleted') {
    //                                td[0].removeAttribute('data-idsm')
    //                            }
    //                        },
    //                        error: function (error) {
    //                            console.error(error);
    //                        }
    //                    });
    //                    $(this).replaceWith(newValue);
    //                }
    //            });
    //            $(this).empty();
    //            $(this).append(input);
    //        }
    //        else { //add mark
    //            lessId = $(this).attr('data-idLess');
    //            studId = $(this).attr('data-idStud');
    //            const td = $(this);
    //            const input = $('<input/>', {
    //                'type': 'text',
    //                'class': 'tdInput',
    //                'value': $(this).html(),
    //                blur: function () {
    //                    const newValue = $(this).val();
    //                    $.ajax({
    //                        url: this.URL,
    //                        type: "POST",
    //                        data: {
    //                            'lessId': lessId,
    //                            'studId': studId,
    //                            'value': newValue
    //                        },
    //                        cache: false,
    //                        async: true,
    //                        success: function (result) {
    //                            alert(result.message)
    //                            td[0].setAttribute('data-idsm', result.markId)
    //                        },
    //                        error: function (error) {
    //                            console.error(error);
    //                        }
    //                    });
    //                    $(this).replaceWith(newValue);
    //                }
    //            });
    //            $(this).empty();
    //            $(this).append(input);
    //        }
    //    }
    //});
    $('td.pt-3-half').bind('blur', function () {
        if ($(this).attr('data-idsm')) {
            const markID = $(this).attr('data-idsm');
            const td = $(this);
            const value = $(this).text();
            $.ajax({
                url: this.url,
                type: "PUT",
                data: {
                    'id': markID,
                    'value': value
                },
                cache: false,
                async: true,
                success: function (result) {
                    //alert(result.message)
                    if (result.status === 'deleted') {
                        td[0].removeAttribute('data-idsm')
                    }
                },
                error: function (error) {
                    if (error) {
                        td.text('')
                    }
                    console.error(error);
                }
            })
        }
        else {
            lessId = $(this).attr('data-idLess');
            studId = $(this).attr('data-idStud');
            const td = $(this);
            const value = $(this).text();
            $.ajax({
                url: this.URL,
                type: "POST",
                data: {
                    'lessId': lessId,
                    'studId': studId,
                    'value': value
                },
                cache: false,
                async: true,
                success: function (result) {
                    //alert(result.message)
                    td[0].setAttribute('data-idsm', result.markId)
                },
                error: function (error) {
                    if (error) {
                        td.text('')
                    }
                    console.error(error);
                }
            });
        }
    })

    $('#periodBtn').click(function () {
        $('#periodModal').modal('show');
    })

    //jurnal table style
    const table = $('.table').find('th.vt-text');
    const OKRs = [], KRs = [], SRs = [], EKZs = [];
    for (let i = 0; i < table.length; i++) {
        if ($(table[i]).attr('data-lessType') === 2) {
            OKRs.push(i);
        }
        else if ($(table[i]).attr('data-lessType') === 3) {
            KRs.push(i);
        }
        else if ($(table[i]).attr('data-lessType') === 4) {
            SRs.push(i);
        }
        else if ($(table[i]).attr('data-lessType') === 5) {
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

    $('.jurnal__link').click(function () {
        const subId = $(this).attr('data-subId');
        $.ajax({
            type: 'GET',
            data: { 'id': subId },
            cache: false,
            async: true,
            success: function (result) {
                window.location.href = '/Marks/Jurnal?id=' + subId;
            }
        });
    })
});




