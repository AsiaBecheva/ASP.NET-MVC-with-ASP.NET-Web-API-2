$(document).ready(function () {
    smoothScroll.init({
        selector: '[data-scroll]', // Selector for links (must be a class, ID, data attribute, or element tag)
        selectorHeader: null, // Selector for fixed headers (must be a valid CSS selector) [optional]
        speed: 700, // Integer. How fast to complete the scroll in milliseconds
        easing: 'easeInOutCubic' // Easing pattern to use
    });

    var wow = new WOW(
        {
            boxClass: 'wow', // default
            animateClass: 'animated', // default
            offset: 0, // default
            mobile: true, // default
            live: true // default
        }
    );
    wow.init();
});