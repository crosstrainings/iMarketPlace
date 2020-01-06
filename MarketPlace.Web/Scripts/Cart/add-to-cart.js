var cartItemsCountArea = ".cart-item-count-area";
var cartSummaryToggleBtn = ".cart-summary-toggle-btn";
$(function () {
    $(".add-to-cart-btn").click(function () {
        var advertId = $(this).attr("id");
        var url = `Cart/Add/${advertId}`;
        asyncAction(url, "get", (added) => {
            if (added === true) {
                var cartCount = parseInt($(cartItemsCountArea).html());
                $(cartItemsCountArea).html(++cartCount);
            }
        }, () => { });
    });
    $(".cart-summary-toggle-btn").click((event) => {
        event.preventDefault();
        var summaryView = "summary-view";
        var inView = $(cartSummaryToggleBtn).data(summaryView);
        var display = inView;
        if (inView === 0) {
            display = 1;
        } else {
            display = 0;
        }
        if (display === 1) {
            loadUserCartSummary();
            display = 0;
        }
        $(cartSummaryToggleBtn).data(summaryView, display);
    });
});
function loadUserCartSummary() {
    var url = "Cart/Summary";
    asyncAction(url, "get", (summary) => {
        var area = ".user-cart-summary-area";
        var areaFooter = `<li class="divider"></li><li><a class="text-center" href="">View Cart</a></li>`;
        var result = summary.view + areaFooter;
        $(cartItemsCountArea).html(summary.Total);
        $(area).html(result);
    }, () => { });
}