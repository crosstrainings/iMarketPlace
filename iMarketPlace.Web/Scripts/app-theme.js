var flatTheme = '<link href="./content/styles/themes/flat.css" rel="stylesheet">'
var gradientTheme = '<link href="./content/styles/themes/gradient.css" rel="stylesheet">'
$(".theme-option").click(function () {
    var userTheme = $(this).attr("id")
    if (userTheme === 'flat') {
        $(".theme-area").html(flatTheme);
    } else if (userTheme === 'gradient') {
        $(".theme-area").html(gradientTheme);
    } else {
        $(".theme-area").html("");
    }
});