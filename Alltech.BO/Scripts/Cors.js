$(document).ready(function () {
    $("#example2").DataTable({
        "responsive": true,
        "lengthChange": true,
        "autoWidth": true,
        "processing": true,
        "serverSide": true,
        "searching": true,
        "ajax": {
            "url": "https://localhost:44352/api/Products",
            "type": "GET",
            "xhrFields": {
                "withCredentials": false
            }
        },

        "columns": [
            { "data": "id_prod" },
            { "data": "name_prod" },
            { "data": "desc_prod" },
            { "data": "category_prod" },
            { "data": "images" },
            { "data": "quantity_prod" },
            { "data": "status_prod" },
            { "data": "price_prod" },
            { "data": "date_entry_Prod" }

        ]


    });
});
