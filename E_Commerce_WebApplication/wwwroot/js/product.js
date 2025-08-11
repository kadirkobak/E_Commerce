

$(document).ready(function () {
    loaddataTable();
});

function loaddataTable() {
    $('#tblData').DataTable({
        "ajax": {
            "url": "/admin/product/getall",
            "dataSrc": ""     },
   
        "columns": [
            { "data": "name", "width": "%15" },
            { "data": "position", "width": "%15" },
            { "data": "salary", "width": "%15" },
            { "data": "office", "width": "%15" }
        ]
    });


}


