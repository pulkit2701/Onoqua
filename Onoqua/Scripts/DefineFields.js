function GetField(fieldId) {
    $.ajax({
        url: '../DefineFields/GetField',
        data: AddAntiForgeryToken({ fieldID: fieldId }),
        type: "post",
        success: function (result) {
            $('#fieldResult').html(result);
        }
    });

}
