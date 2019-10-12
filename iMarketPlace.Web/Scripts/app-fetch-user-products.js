function loadUserProducts() {
    $("#app-user-product-area").html("");
    var products = JSON.parse(window.localStorage.getItem("products"));
    for (var i = 0; i < products.length; i++) {
        var product = products[i];
        var temp = ` <tr>
                        <td>${product.id}</td>
                        <td><img src="${product.image}" class="img-circle img-thumbnail" style="height:30px;width:30px" /></td>
                        <td>${product.title}</td>
                        <td>${product.price}</td>
                        <td>
                            <span data-id="${product.id}" class="user-product-remove glyphicon glyphicon-trash text-danger">
                            </span>
                            &nbsp;|&nbsp;
                            <span data-id="${product.id}" data-image="${product.image}" data-title="${product.title}" data-price="${product.price}"  class="user-product-update glyphicon glyphicon-pencil text-primary">
                            </span>
                        </td>
                    </tr>`
        $("#app-user-product-area").append(temp);
    }
}