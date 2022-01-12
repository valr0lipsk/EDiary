

$(document).ready(function () {
    //admin funcs
    //add student
    $('#addSt').click(function () {
        $("#partialDiv").load('/Admin/AddStudent');
    });

    //add teacher
    $('#addT').click(function () {
        $("#partialDiv").load('/Admin/AddTeacher');
    })
    //add subj
    $('#addSb').click(function () {
        $("#partialDiv").load('/Admin/AddSubject');
    })
    //show all students
    $('#allSt').click(function () {
        $("#partialDiv").load('/Admin/ShowStudents');
    })
    //show all teachers
    $('#allT').click(function () {
        $("#partialDiv").load('/Admin/ShowTeachers');
    })
    //show all subjs
    $('#allSb').click(function () {
        $("#partialDiv").load('/Admin/ShowSubjects');
    })

    //-------------------------------------------
    //common funcs
    //get subject id from acc to open jurnal page
    $('#list li').click(function () {
        const subId = $(this).attr("data-id");
        $.ajax({
            type: "GET",
            data: { 'id': subId },
            cache: false,
            async: true,
            success: function (result) {
                window.location.href = "/Marks/Jurnal?id=" + subId;
            }
        });
    })

    //open adding photo modal
    $('#openIconModal').click(function () {
        $('#iconModal').modal('show');
    });


    //-----------------------------------------
    //jurnal funcs
    //open adding lesson modal
    $('#addLessModal').click(function () {
        $('#lessModal').modal('show');
    });

    //update, delete and add mark in jurnal
    $('td').bind('dblclick', function () {   
        if (!$(this).has('input').length) {
            if ($(this).attr('data-idsm')) { //update or delete mark
                const markID = $(this).attr('data-idsm');  
                const input = $('<input/>', {
                    'type': 'text',
                    'value': $(this).html(),
                    blur: function () {
                        const newValue = $(this).val();
                        $.ajax({
                            url: this.URL,
                            type: "PUT",
                            data: {
                                'id': markID,
                                'value': newValue
                            },
                            cache: false,
                            async: true,
                            success: function (result) {
                                alert(result.message)
                                if (result.status === 'deleted') {
                                    $(this).parent.attr('data-idsm') = null
                                }
                            },
                            error: function (error) {
                                console.error(error);
                            }
                        });
                        $(this).replaceWith(newValue);
                    }
                });
                $(this).empty();
                $(this).append(input);
            }
            else { //add mark
                lessId = $(this).attr('data-idLess');
                studId = $(this).attr('data-idStud');
                const input = $('<input/>', {
                    'type': 'text',
                    'value': $(this).html(),
                    blur: function () {
                        const newValue = $(this).val();
                        $.ajax({
                            url: this.URL,
                            type: "POST",
                            data: {
                                'lessId': lessId,
                                'studId': studId,
                                'value': newValue
                            },
                            cache: false,
                            async: true,
                            success: function (result) {
                                alert(result.message)
                                $(this).parent.attr('data-idsm') = result.markId
                            },
                            error: function (error) {
                                console.error(error);
                            }
                        });
                        $(this).replaceWith(newValue);
                    }
                });
                $(this).empty();
                $(this).append(input);
            }
        }
    });


    const table = $(".editableTable").find('th.vt-text');
    const OKRs = [], KRs = [], SRs = [], EKZs = [];
    for (let i = 0; i < table.length; i++) {
        if ($(table[i]).hasClass('lessOKR')) {
            OKRs.push(i);
        }
        else if ($(table[i]).hasClass('lessKR')) {
            KRs.push(i);
        }
        else if ($(table[i]).hasClass('lessSR')) {
            SRs.push(i);
        }
        else if ($(table[i]).hasClass('lessEKZ')) {
            EKZs.push(i);
        }
    }
    console.log(OKRs)
    const rows = $('.editableTable').find('tr:not(:first)');
    console.log(rows[1].children[1]);
    for (let i = 0; i < rows.length; i++) {
        for (let j = 0; j < rows[i].children.length; j++) {
            if (OKRs.indexOf(j) != -1) {
                $(rows[i].children[j+1]).addClass('lessOKR')
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
});



