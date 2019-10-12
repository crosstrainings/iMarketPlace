function renderMainProducts(products) {
    $("#app-main-products").html("");
    for (var i = 0; i < products.length; i++) {
        var temp = `<div class="col-lg-3 col-md-3 col-sm-4 col-xs-6">
                <div class="well well-default" style="padding-top: 10px;padding-bottom: 5px">
                    <div class="row" style="height: 145px;">
                        <div class="thumbnail">
                            <img src="${products[i].image}" class="img-responsive" style="height:130px" />
                        </div>
                    </div>
                    <div class="row">
                        <span style="font-weight: bold;font-size: 12px">${products[i].title}</span>
                    </div>
                    <div class="row">
                        <span class="pull-left" style="font-size: 10px;font-weight: bold;">
                            <img src="./content/images/1.png" class="img-circle img-thumbnail"
                                style="height: 20px;width: 20px">
                            <span>Irshad Ahmed</span>
                        </span>
                        <span class="pull-right" style="font-size: 10px;margin-top: 2px;font-weight: bold;">$
                            ${products[i].price}
                        </span>
                    </div>
                    <div class="row">
                        <span class="pull-right">
                            <button class="btn btn-primary btn-xs">
                                <span class="glyphicon glyphicon-shopping-cart"></span>
                            </button>
                            <button class="btn btn-success btn-xs">
                                <span class="glyphicon glyphicon-earphone"></span>
                            </button>
                            <button onclick="onFavoriteButtonClick()" onmouseover="onFavoriteButtonMouseOver()"
                                id="fav-btn" class="btn btn-default btn-xs">
                                <span class="glyphicon glyphicon-heart-empty"></span>
                            </button>
                        </span>
                    </div>
                </div>
            </div>`;
        $("#app-main-products").append(temp);
    }
}