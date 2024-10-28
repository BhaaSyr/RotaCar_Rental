
var dataTable;
    $(document).ready(function () { 

        loadDataTable();

    });

function loadDataTable() {

    dataTable = $('#cartblData').DataTable({
        "ajax": { url: '/admin/CarCrud/getall' },
        "columns": [
            { data: 'make', "width": "5%" },
            { data: 'model', "width": "10%" },
            { data: 'year', "width": "5%" },
            { data: 'mileage', "width": "1%" },
            { data: 'seats', "width": "1%" },
            { data: 'type', "width": "5%" },
            { data: 'fuel', "width": "5%" },
            { data: 'transmission', "width": "10%" },
            { data: 'licensePlate', "width": "10%" },
            { data: 'locationID', "width": "1%" },
            { data: 'rentalRateDaily', "width": "1%" },
            { data: 'rentalRateWeekly', "width": "1%" },
            { data: 'status', "width": "10%" },


            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/admin/CarCrud/Edit?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                     <a onClick=Delete('/admin/CarCrud/Delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
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