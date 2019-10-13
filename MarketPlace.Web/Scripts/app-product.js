function getProducts() {
    var products = JSON.parse(window.localStorage.getItem("products"));
    return products;
}
function addProducts(products) {
    window.localStorage.setItem("products", JSON.stringify(products));
}