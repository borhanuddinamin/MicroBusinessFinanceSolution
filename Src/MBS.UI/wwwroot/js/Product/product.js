
let dataTable;
$(document).ready(function () {

    loadDataTable();
   
});

function loadDataTable() {

    dataTable = $('#productTBL').DataTable({

        "ajax": {
            "url": "/ShopUser/Products/GetAll"
        },
        "columns": [
            {
                "data": "imageUrl",
                "render": function (data, type, full, meta) {

                    return '<img src="'+data+'" width="50%" height="30px"/>'
                }
            },
            { "data": "code", "width": "10%" },
            { "data": "name", "width": "10%" },
            { "data": "category.name", "width": "10%" },
            { "data": "brand.name", "width": "15%" },
          
            { "data": "salePrice", "width": "10%" },
            { "data": "purchaseCost", "width": "10%" },
            {
                "data": "id",
                "render": function (data) {

                    return '<div class="button-group">'
                        + '<div class="getViewProduct">'
                        + '  <buttontype="button" onClick="getproductDetails(' + data + ')"  class="btn btn-secondary btn-sm" data-bs-toggle="modal" data-bs-target="#productsDetails"><i class="bi bi-eye-fill"></i></button> </div>'

                        + '<div class="dropdown action-button mx-2">'
                        + '<button class="btn btn-success btn-sm dropdown-toggle" type="button" id="dropdownMenuButton1" data-bs-toggle="dropdown" aria-expanded="false"><i class="bi bi-gear-fill"></i> Manage</button>'
                        + '<ul class="dropdown-menu" aria-labelledby="dropdownMenuButton1">'
                        + '<li><a  href="/ShopUser/Products/Upsert?Id=' + data + '" class="dropdown-item btn text-primary btn-primary"><i class="bi bi-pencil-square"></i> Edit </a></li>'
                        + '<li><a class="dropdown-item btn btn-primary text-danger" onClick="Delete(' + data + ')"><i class="bi bi-trash-fill"> </i> Delete</a> </li> </ul> </div>'

                    

                      
                      


                       
                },
                "width": "110%"
            },
        ]

        
    });
}









function Delete(id) {
    
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
                url: "/ShopUser/Products/Delete/" + id,
                type: 'DELETE',
                success: function (data) {
                    if (data.success) {
                        dataTable.ajax.reload();
                        toastr.success(data.message);
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        }
    })
}


function GetProductById(id) {
    
    var product = null;
    $.ajax({

        url: "/ShopUser/Products/GetById/" + id,
        method: "GET",
        type: "json",
        async: false,

        success: function (data) {
           
            product = data.data;
           
        }


    });
    
    return product;
}

function getproductDetails(id) {

    debugger
    $("#tbl_productModal").empty();  
    $("#ProductmodalImage").empty();  
    $("#staticBackdropLabel").empty();  
    var product = GetProductById(id);

    var data = product.product
    
    var imagediv = '<img src="' + data.imageUrl + '" class="product-modal-image"/>';
    var title = '<span >' + data.name + ' </span>'
            var rows = "<tr>"
                + "<td>Code</td> "
                + "<td class='prtoducttd'>" + data.code + "</td> </tr >"
                + "<tr>"
                + "<td>Category</td> "
                + "<td class='prtoducttd'>" + data.category.name + "</td> </tr >"
                + "<tr>"
                + "<td>Brand</td> "
                + "<td class='prtoducttd'>" + data.brand.name + "</td> </tr >"
                + "<tr>"
                + "<td> Price</td> "
                + "<td class='prtoducttd'>" + data.salePrice + "</td> </tr >"
                + "<tr>"
                + "<td>Cost</td> "
                + "<td class='prtoducttd'>" + data.purchaseCost + "</td> </tr >"
                + "<td>Stock</td> "
                + "<td class='prtoducttd'> </td> </tr >";
               
               
            $('#tbl_productModal').append(rows); 
            $('#ProductmodalImage').append(imagediv); 
             $('#staticBackdropLabel').append(title); 

        
    
    
}

function getBarCode(id) {
   
   
    var item = GetProductById(id);
   
    $("#barCodeImage  img ").remove(); 

    var Barcode =
         '<img src="/ShopUser/GenerateBarcode?productId=' + id + '" width="100%" height="50px"/>'

    $('#barProductCode').text(item.code);
    $('#barProductTitle').text(item.name);
    $('#barProductPrice').text(item.salePrice+" Tk");

    $('#barCodeImage  ').append(Barcode);

}

function printBarCode(elem) {
    var mywindow = window.open();
    var content = document.getElementById(elem).innerHTML;
    var realContent = document.body.innerHTML;
    mywindow.document.write(content);
    mywindow.document.close(); // necessary for IE >= 10
    mywindow.focus(); // necessary for IE >= 10*/
    mywindow.print();
    document.body.innerHTML = realContent;
    mywindow.close();
    return true;
}

