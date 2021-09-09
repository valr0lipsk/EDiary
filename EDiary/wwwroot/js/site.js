
window.onscroll = function () { scrollFunction() };

function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        document.getElementById("onTop").style.display = "block";
    } else {
        document.getElementById("onTop").style.display = "none";
    }
}

function topFunction() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}

function generatePassword() {
    var length = 8,
        charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789",
        retVal = "";
    for (var i = 0, n = charset.length; i < length; ++i) {
        retVal += charset.charAt(Math.floor(Math.random() * n));
    }
    return retVal;
}

$(document).ready(function () {
    //добавить студента
    $('#addSt').click(function () {
        $("#partialDiv").load('/Admin/AddStudent');
    });

    //добавить преподавателя
    $('#addT').click(function () {
        $("#partialDiv").load('/Admin/AddTeacher');
    })
    //добавить предмет
    $('#addSb').click(function () {
        $("#partialDiv").load('/Admin/AddSubject');
    })
    //все студенты
    $('#allSt').click(function () {
        $("#partialDiv").load('/Admin/ShowStudents');
    })
    //все преподаватели
    $('#allT').click(function () {
        $("#partialDiv").load('/Admin/ShowTeachers');
    })
    //все предметы
    $('#allSb').click(function () {
        $("#partialDiv").load('/Admin/ShowSubjects');
    })
}
);