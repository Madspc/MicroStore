$(document).ready(function () {
    $(".txt1").keyup(function () {
        $(".txt2").css("visibility", "visible");
    });
    $(".txt2").keyup(function () {
        $(".txt3").css("visibility", "visible");
    });
    $(".txt3").keyup(function () {
        $(".txt4").css("visibility", "visible");
    });
    $(".txt4").keyup(function () {
        $(".txt5").css("visibility", "visible");
    });
    $(".txt5").keyup(function () {
        $(".txt6").css("visibility", "visible");
    });
});