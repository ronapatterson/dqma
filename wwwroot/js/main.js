var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/api/statement",
            "dataSrc": ""
        },
        "columns": [
            { "data": "incidentDate", "width": "15%" },
            { "data": "divisionName", "width": "15%" },
            { "data": "offenseName", "width": "15%" },
            { "data": "victimName", "width": "15%" },
            { "data": "victimCountry", "width": "15%" },
            { "data": "motive", "width": "15%" },
            { "data": "status", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                           <div class="text-center">
                                <a onclick=Get("/api/statement/${data}") class="btn btn-success text-white" style="cursor:pointer">
                                    <i class="fa fa-edit"></i> 
                                </a>
                                <a onclick=Delete("/api/statement/${data}") class="btn btn-danger text-white" style="cursor:pointer">
                                    <i class="fa fa-trash-o"></i> 
                                </a>
                           </div>
                           `;
                }, "width": "40%"
            }
        ]
    });
}

async function addStatement() {
    await getCategories();
    await getOffense();
    await getDivision();
    await getMotives();
    await getParishes();
    await getCountry();

    $("#modalForm").modal();
}

function editStatement() {
    $("#modalForm").modal();

    var statement = "";
    loadStatementForm(statement);
}

function Get(url) {
    $.ajax({
        url: url,
        dataType: 'json',
        type: 'GET',
        cache: false,
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(errorThrown);         
        },
        success: function (json) {
            loadStatementForm(json);
        }
    });
}

function Delete(url) {
    swal({
        title: "Are you sure you want to Delete?",
        text: "You will not be able to restore the data!",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}