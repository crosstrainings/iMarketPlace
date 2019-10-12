$(function () {
    loadUserProducts();
    $(".user-product-remove").click(function () {
        var products = getProducts();
        var productId = $(this).data("id");
        products.splice(products.findIndex(x => x.id === productId), 1)
        addProducts(products);
        loadUserProducts();
    });
});