import { dateTime } from './currentDateTime.js'
import { stickyTable } from './tableModule.js'
import { jurnalStyleTable } from './tableModule.js'

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

    //add group
    $('#addG').click(function () {
        $('#partialDiv').load('/Admin/AddGroup')
    })

    //all groups
    $('#allG').click(function () {
        $('#partialDiv').load('/Admin/ShowGroups')
    })

    //???
    $('.admin__menu').click(function () {
        if ($('.admin__sidebar').hasClass('d-none')) {
            $('.admin__sidebar').removeClass('d-none')
            $('.admin__sidebar').addClass('d-block')
        }
        else {
            $('.admin__sidebar').addClass('d-none')
            $('.admin__sidebar').removeClass('d-block')
        }

    })


    //-------------------------------------------
    //common funcs

    //filter subjects
    $('.subject__find').click(function () {
        const _this = this;
        const findType = $(this).attr('data-findType');
        $.ajax({
            type: 'GET',
            data: {
                'category': findType,
            },
            cache: false,
            async: true,
            success: function (result) {
                $('.subjects__block').replaceWith(result)
            }
        });
    })

    //get subject id from acc to open jurnal page
    $('body').on('click', '.item__title', function () {
        const subId = $(this).attr('data-id');
        const labId = $(this).attr('data-labaid');
        if (labId) {
            $.ajax({
                type: 'GET',
                data: {
                    'labId': labId,
                },
                cache: false,
                async: true,
                success: function (result) {
                    window.location.href = '/Marks/Jurnal?labId=' + labId;
                }
            });
        }
        else {
            $.ajax({
                type: 'GET',
                data: {
                    'id': subId
                },
                cache: false,
                async: true,
                success: function (result) {
                    window.location.href = '/Marks/Jurnal?id=' + subId;
                }
            });
        }
    })

    //open adding photo modal
    $('.openIconModal').click(function () {
        $('#iconModal').modal('show');
    });

    //setting current date and time
    setInterval(() => {
        $('#statusDate').text(dateTime());
    })

    //open kebab-menu in acc
    $('#icons__dots').click(() => {
        $('#dropdown').toggleClass('show');
    })

    //close kebab-menu in acc
    $(window).click(() => {
        if (!event.target.matches('#icons__dots')) {

            const dropdowns = $(document).find('.dropdown-content');
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
        $('#passwordHelpBlock').addClass('d-none');
    }

    //open and choose emoji status
    $('.openEmojiModal').click(function () {
        $('#statusModal').modal('show');
    })

    //emoji hover
    $('.selection__item').mouseover(function () {
        $(this).addClass('selection__item-hover');
    })
    $('.selection__item').mouseout(function () {
        $(this).removeClass('selection__item-hover');
    })

    $('.selection__item').click(function () {
        $.each($('.selection__item'), function () {
            if ($(this).hasClass('selection__item-hover')) {
                $(this).removeClass('selection__item-hover');
            }
            if ($(this).hasClass('selection__item-check')) {
                $(this).removeClass('selection__item-check');
            }
        })
        $(this).addClass('selection__item-check');
        $('#statusId').val($(this).attr('data-idStatus'));
    })

    $('#subjectFind').keyup(function () {
        const _this = this;
        $.each($)
    })

    //-----------------------------------------
    //jurnal funcs

    //fixed columns 
    stickyTable();

    //jurnal table style 
    jurnalStyleTable();

    //open adding lesson modal
    $('body').on('click', '#addLessModal', function () {
        $('#lessModal').modal('show');
    });

    //open delete lesson modal
    $('body').on('dblclick', 'th.delLes', function () {
        const id = $(this).attr('data-idLess');
        const data = $(this).text();
        $('#idLess').val(id);
        $('#delLabel').text('Удалить занятие за ' + data + '?');
        $('#delLessModal').modal('show');
    })

    //open stats modal 
    $('body').on('click', '#openStatModal', function () {
        $('#statModal').modal('show');
    })

    //month selection
    $('body').on('change', '#mounthSelection', function () {
        const month = $(this).val();
        if (month) {
            $.ajax({
                type: 'POST',
                data: {
                    'month': month,
                },
                cache: false,
                async: true,
                success: function (result) {
                    $('.jurnal__main').replaceWith(result)
                }
            });
        }
    })

    //update, remove or add mark in jurnal
    $('body').on('blur', 'td.pt-3-half', function () {
        if ($(this).attr('data-idsm')) { //update or delete
            const markID = $(this).attr('data-idsm');
            const td = $(this);
            const value = $(this).text().trim();
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
        else if ($(this).text()) { //add mark
            const lessId = $(this).attr('data-idLess');
            const studId = $(this).attr('data-idStud');
            const td = $(this);
            const value = $(this).text().trim();
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

    //open choose period modal
    $('body').on('click', '#periodBtn', function () {
        $('#periodModal').modal('show');
    })

    //link to another subj
    $('body').on('click', '.jurnal__link', function () {
        const subId = $(this).attr('data-subid');
        const labId = $(this).attr('data-labaid');
        if (labId) { //if subj is lab 
            $.ajax({
                type: 'GET',
                data: {
                    'labId': labId,
                },
                cache: false,
                async: true,
                success: function (result) {
                    window.location.href = '/Marks/Jurnal?labId=' + labId;
                }
            });
        }
        else { //if not
            $.ajax({
                type: 'GET',
                data: { 'id': subId },
                cache: false,
                async: true,
                success: function (result) {
                    window.location.href = '/Marks/Jurnal?id=' + subId;
                }
            });
        }
    })
});

