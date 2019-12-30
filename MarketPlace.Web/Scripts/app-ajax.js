function asyncAction(url, method, successFunc, errorFunc) {
    $.ajax({
        url: url,
        method: method
    }).done((result) => { successFunc(result); }).fail(errorFunc());
};
