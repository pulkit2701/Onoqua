function ShowRegister() {
    $.ajax({
        url: '../Register/Index',
        success: function (result) {
            $('#HomeBody').html(result);
        }
    });
}

function Register(value) {
    var checkedValue = '';
    var inputElements = document.getElementsByClassName('messageCheckbox');
    for (var i = 0; inputElements[i]; ++i) {
        if (inputElements[i].checked) {
            checkedValue = checkedValue + inputElements[i].id + ',';
        }
    }
    $.ajax({
        url: '../Register/AddModules',
        data: { value: checkedValue },
        success: function () { window.open("main/Index"); }
        
    });
}




function loadUI(uiID) {
    Url.Action()

    $.ajax({
        type: "POST",
        url: '../Form/Index',
        data: { processID: uiID },
        success: function (result) {
            $('#form').html(result);
        }
    });
}

function Redirect(url)
{
    alert(url);
    window.location = url;
}

//function MoveNext(btn) {
//    var postData = $(btn).parents('form').serialize();
//    alert(postData);
//    $.ajax({
//        url: '../form/GetNextUserInterFace',
//        data: JSON.stringify(postData),
//        dataType: 'json',
//        contentType: "application/json",
//        success: function (result) {
//            $('#form').html(result);
//        }
//    });
//}