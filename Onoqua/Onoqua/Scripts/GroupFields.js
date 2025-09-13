function AddFieldsToGroup(g) {
    var cboxes = document.getElementsByName('fieldCheckBox');
    var p = document.getElementsByName('Fieldpriority');
    var len = cboxes.length;
    var v = [];
    var a = $('.fieldSearch').get().forEach(function (m) {
        if (m.children[0].children[0].children[0].children[0].checked)
            v.push({
                "GroupID":g,
                "FieldID": m.children[0].children[0].children[0].children[0].value,
                "Priority": m.children[1].children[0].value
            });
    });
    $.ajax({
        url: '../DefineGroup/AddFieldToGroup',
        data: AddAntiForgeryToken({ fieldIds: v, groupid: g }),
        type: "post",
        success: function (result) {
            $('#SelectGroup').html(result);
        }
    });
}

function AddFieldToButton(value, name) {

    $.ajax({
        url: '../DefineGroup/AddFieldToGroup',
        data: AddAntiForgeryToken({ fieldId: value, FieldName: name }),
        type: "post",
        success: function (result) {
            $('#showFields').html(result);
        }
    });
}

function SearchFields(groupId) {
    $.ajax({
        url: '../DefineGroup/SearchField',
        data: AddAntiForgeryToken({ fieldName: document.getElementById("searchField").value, groupID: groupId }),
        type: "post",
        success: function (result) {
            $('#fieldResult').html(result);
        }
    });

}

function GetGroup(value) {
    $.ajax({
        url: '../DefineGroup/SelectedGroup',
        data: AddAntiForgeryToken({ GroupId: value }),
        type: "post",
        success: function (result) {
            $('#SelectGroup').html(result);
        }
    });
}


