$(function () {
    $(".admin-action").click(function (event) {
        event.preventDefault();
        const action = $(this).data("action");
        const controller = $(this).data("controller");
        const area = $(this).data("area");
        let url = `/${area}/${controller}/${action}`;
        asyncAction(url, "get", (view) => {
            $(".admin-action-result").html(view);
        }, () => { });
    });
});