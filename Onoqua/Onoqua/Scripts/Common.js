function AddAntiForgeryToken(data) {
    data.__RequestVerificationToken = $('#__AjaxAntiForgeryForm input[name=__RequestVerificationToken]').val();
    return data;
};

function ModelPopup(target, url, d) {
    event.preventDefault();
    $.ajax({
        url: url,
        data: d,
        type: "GET",
    })
        .done(function (result) {
            $(target).html(result).dialog("open");
        });



}
