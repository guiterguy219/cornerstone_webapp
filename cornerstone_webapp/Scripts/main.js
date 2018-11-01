$(document).ready(function () {
    faqA = $(".faq-panel");
    faqA.hide();
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
    var navbarTitle = document.getElementById("navbar-title")
    if (pageTitle == "Home") {
        navbarTitle.setAttribute("href", "#top");
    }

    $(function () {
        $('.scrolly').click(function () {
            if (location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '')
                && location.hostname == this.hostname) {

                var target = $(this.hash);
                target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
                if (target.length) {
                    $('html,body').animate({
                        scrollTop: target.offset().top - 20 //offsets for fixed header
                    }, 500);
                    return false;
                }
            }
        });

        $('.scrolly-50').click(function () {
            if (location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '')
                && location.hostname == this.hostname) {

                var target = $(this.hash);
                target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
                if (target.length) {
                    $('html,body').animate({
                        scrollTop: target.offset().top - 50 //offsets for fixed header
                    }, 500);
                    return false;
                }
            }
        });
        //Executed on page load with URL containing an anchor tag.
        if ($(location.href.split("#")[1])) {
            var target = $('#' + location.href.split("#")[1]);
            if (target.length) {
                $('html,body').animate({
                    scrollTop: target.offset().top - 20 //offset height of header here too.
                }, 500);
                return false;
            }
        }
    });

    setSizes();
})

function reveal_faqA(faqNum) {
    faqA.slideUp();
    if (document.getElementById("faq-" + faqNum + "-a").style.display == "none") {
        $("#faq-" + faqNum + "-a").slideToggle();
    }
}

function callNumber() {
    console.log("We arrived!");
    window.location.href = "tel:+13853093164";
}

function collapseMenu() {
    if (document.getElementById("collapsibleNavbar").getAttribute("class") == "navbar-collapse collapse show") {
        $(".menu-toggle").click();
    }
}

function setSizes() {
    if (window.innerWidth > 991) {
        var carouselCol = document.getElementById("demo");
        var captionCol = document.getElementById("captionCol");
        var carouselHeight = carouselCol.clientHeight
        captionCol.setAttribute("style", "max-height: " + carouselHeight + "px");
    }
}