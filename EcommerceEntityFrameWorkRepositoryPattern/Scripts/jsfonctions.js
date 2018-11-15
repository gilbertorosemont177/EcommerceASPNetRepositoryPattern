$(document).ready(function () {
    var navoffset = $("nav").offset().top;
    var jum = $("nav").offset().top;
    $(window).scroll(function () {

        var scrollpos = $(window).scrollTop();

        if (scrollpos >= jum) {
            $("nav").addClass("fixed");
        }
        else {
            $("nav").removeClass("fixed");

        }


    });


});