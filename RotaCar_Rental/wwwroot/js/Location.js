﻿
var dataTable;
    $(document).ready(function () { 

        loadDataTable();

    });

function loadDataTable() {
   
    dataTable = $('#locationtblData').DataTable({
        "ajax": { url: '/admin/location/getall' },
        "columns": [
            { data: 'name', "width": "15%" },
            { data: 'street', "width": "10%" },
            { data: 'city', "width": "10%" },
            { data: 'state', "width": "10%" },
            { data: 'zip', "width": "10%" },
            { data: 'phone', "width": "15%" },
            { data: 'availableCar', "width": "5%" },
          

            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/admin/location/edit?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                     <a onClick=Delete('/admin/location/delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                    </div>`
                },
                "width": "25%"
            }
        ]
    });
   
}

 function Delete(url) {
        Swal.fire({
            title: 'Are you sure?',
            text: "You won't be able to revert this!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, delete it!'
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: url,
                    type: 'DELETE',
                    success: function (data) {
                        dataTable.ajax.reload();
                        toastr.success(data.message);
                    }
                })
            }
        })
    }