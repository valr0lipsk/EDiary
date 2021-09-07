
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
        var url = '@Url.Action("AddStudent", "Admin")';
        $("#partialDiv").load(url);
        //$('#partialdiv').load('@Url.Content("~/Admin/AddStudent")')
    }
    )
}
)
//    window.history.forward();
//function noBack() { window.history.forward(); }