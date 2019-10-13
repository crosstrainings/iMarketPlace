    $(function () {
        $("#app-create-ad-btn").click(function () {
            var id = $("#app-ad-id").val();
            var title = $("#app-ad-title").val();
            var price = $("#app-ad-price").val();
            var categoryId = parseInt($("#app-ad-categories").val());
            var img = $("#app-ad-img").val();

            var products = JSON.parse(window.localStorage.getItem("products"));
            if (products == null) {
                products = [];
            }
            // Add Product
            if (id === "") {
                //JSON
                var product = {
                    "id": products.length + 1,
                    "title": title,
                    "price": price,
                    "image": img,
                    "categoryId": categoryId
                }

                products.push(product);
                addProducts(products);
            } else {
                var product = products.find(x => x.id === parseInt(id));
                product.title = title;
                product.price = price;
                product.image = img;
                product.categoryId = categoryId;
                products.splice(products.findIndex(x => x.id === product.id), 1)
                products.push(product);
                addProducts(products);
            }
            window.location.href = "index.html";
        });
    });