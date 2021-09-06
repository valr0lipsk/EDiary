// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
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
$(document).ready(function () {
    $('#addSt').click(function () {
        //var url = '@Url.Action("AddStudent", "Admin")';
        //$("#partialDiv").load(url);
        $('#partialdiv').load('@url.content("~/admin/addstudent")')
    }
    )
}
)