$(function () {
    $(".admin-action").click(function (event) {
        event.preventDefault();
        const actionLoadingImage = "<img src='/Content/images/Animations/admin-action-loading.gif' style='height: 100px;margin-left:36%;margin-top:226px;'/>";
        const actionResultArea = ".admin-action-result";
        $(actionResultArea).html(actionLoadingImage);
        const action = $(this).data("action");
        const controller = $(this).data("controller");
        const area = $(this).data("area");
        let url = `/${area}/${controller}/${action}`;
        asyncAction(url, "get", (view) => {
            $(actionResultArea).html(view);
        }, () => { });
    });
});