var cartItemsCountArea = ".cart-item-count-area";
$(function () {
    $(".add-to-cart-btn").click(function () {
        var advertId = $(this).attr("id");
        var url = `Cart/Add/${advertId}`;
        asyncAction(url, "get", (added) => {
            if (added) {
                var cartCount = parseInt($(cartItemsCountArea).html());
                $(cartItemsCountArea).html(++cartCount);
            }
        }, () => { });
    });
    $(".cart-summary-toggle-btn").click((event) => {
        var summaryView = "summary-view"; 
        event.preventDefault();
        var inView = $(this).data(summaryView);
        if (inView === 0) {
            loadUserCartSummary();
            $(this).data(summaryView, 1);
        } else {
            $(this).data(summaryView, 0);
        }
    });
});
function loadUserCartSummary() {
    var url = "Cart/Summary";
    asyncAction(url, "get", (summary) => {
        var area = ".user-cart-summary-area";
        var areaFooter = `<li class="divider"></li><li><a class="text-center" href="">View Cart</a></li>`;
        var result = summary.view + areaFooter;
        $(cartItemsCountArea).html(summary.Count);
        $(area).html(result);
    }, () => { });
}