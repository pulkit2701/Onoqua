function searchQueries() {
    $.ajax({
        url: '../DefineQuery/SearchQuery',
        data: AddAntiForgeryToken({ query: document.getElementById("searchQuery").value }),
        type: "post",
        success: function (result) {
            $('#searchResult').html(result);
        }
    });
    
   
}