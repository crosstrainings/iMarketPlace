$("#app-main-category-list li a").click(function () {

        var categoryId = $(this).attr("id");
        var products = getProducts();
        var filteredProducts = [];
        for (var i = 0; i < products.length; i++) {
            var product = products[i];
            if (product.categoryId === parseInt(categoryId)) {
                filteredProducts.push(product);
            }
        }
        renderMainProducts(filteredProducts);
});