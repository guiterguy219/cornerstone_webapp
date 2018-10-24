$(document).ready(function () {
    faqA = $(".faq-panel");
    faqA.hide();
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
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
    if (document.getElementById("menu").getAttribute("class") == "navbar-collapse in") {
        $(".menu-toggle").click();
    }
}