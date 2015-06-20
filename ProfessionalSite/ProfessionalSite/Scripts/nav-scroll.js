//refresh on dom load
$(document).ready(function () {
    $(window).scrollTop(0);
});

//jQuery for page scrolling feature - requires jQuery Easing plugin
$(function () {
    $('a.page-scroll').bind('click', function (event) {
        var $anchor = $(this);
        $('html, body').stop().animate({
            scrollTop: $($anchor.attr('href')).offset().top
        }, 1500, 'easeInOutExpo');
        event.preventDefault();
    });
});
$(document).ready(function () {
    $('.scrollimation').waypoint(function () {
        $(this).addClass('in');
    }, {
        offset: function () {
            var h = $(window).height();
            var elemh = $(this).outerHeight();
            if (elemh > h * 0.5) {
                return h * 0.7;
            } else {
                return h - elemh;
            }
        }
    });
    $('.picture').waypoint(function () {
        $(this).addClass('in');
    }, {
        offset: function () {
            var h = $(window).height();
            var elemh = $(this).outerHeight();
            if (elemh > h * 0.3) {
                return h;
            } else {
                return h - elemh;
            }
        }
    });
});