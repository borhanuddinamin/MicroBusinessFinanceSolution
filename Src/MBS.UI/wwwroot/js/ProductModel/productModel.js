$(document).ready(function () {
    $('.productModelBox').hide();
})

//$('#productInput').change(function () {
//    $('.productModelBox').hide();
//    $('#ProductmodalImage').empty();

//    debugger

//    var modelId = $('#productInput option:selected').val();


//    $.ajax({

//        url: "/Admin/ProductModels/GetProductDetailsById/" + modelId,
//        method: "GET",
//        type: "json",
//        async: false,

//        success: function (data) {
//            debugger

//            var obj = data.data;
//            $('.productModelBox').show();

//            var productImage = '<img src="' + obj.product.imageUrl + '" class="product-modal-image">';
//            // var isActiveSwitch = '<input checked asp-for="ProductModel.IsActive" class="form-check-input" type="checkbox" id="flexSwitchCheckDefault">';
//            // var isArrivalSwitch = '<input checked asp-for="ProductModel.IsArrival" class="form-check-input" type="checkbox" id="flexSwitchCheckDefault">';
//            //if (obj.isActive == true)
//            //{
//            //    $('#isActiveSwitch').append(isActiveSwitch);

//            //}
//            //if (obj.isArrival == true) {

//            //    $('#isArrivalSwitch').append(isArrivalSwitch);
//            //}
//            $('#staticBackdropLabel').text(obj.product.name);
//            $('#productCode').text(obj.product.code);
//            $('#ProductmodalImage').append(productImage);
//            $('#salePrice').text(obj.product.salePrice);



//        }


//    });


//    // product Model

//    $.ajax({

//        url: "/Admin/ProductModels/Edit/" + modelId,
//        method: "GET",
//        type: "json",
//        async: false,

//        success: function (data) {
//            debugger

//            var obj = data.data;
//            $('.productModelBox').show();

//            var productImage = '<img src="' + obj.product.imageUrl + '" class="product-modal-image">';
//            // var isActiveSwitch = '<input checked asp-for="ProductModel.IsActive" class="form-check-input" type="checkbox" id="flexSwitchCheckDefault">';
//            // var isArrivalSwitch = '<input checked asp-for="ProductModel.IsArrival" class="form-check-input" type="checkbox" id="flexSwitchCheckDefault">';
//            //if (obj.isActive == true)
//            //{
//            //    $('#isActiveSwitch').append(isActiveSwitch);

//            //}
//            //if (obj.isArrival == true) {

//            //    $('#isArrivalSwitch').append(isArrivalSwitch);
//            //}
//            $('#staticBackdropLabel').text(obj.product.name);
//            $('#productCode').text(obj.product.code);
//            $('#ProductmodalImage').append(productImage);
//            $('#salePrice').text(obj.product.salePrice);



//        }


//    });


//});



$('#productInput').change(function () {

    
    var modelId = $('#productInput option:selected').val();
    var url = '/Admin/ProductModels/UpdateProductModel/' + modelId;
    window.location.href = url;

  

    // product Model

   

});