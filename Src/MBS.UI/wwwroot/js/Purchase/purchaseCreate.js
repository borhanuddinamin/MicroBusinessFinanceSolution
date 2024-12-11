


var counter = 0;
var index = 0;
var productPrice = 0;
var product = null;
var productVm = null;




$("#ProductList").on("change", function () {
    var productId = $("#ProductList option:selected").val();
    var productName = $("#ProductList option:selected").text();
    counter++;

    $.ajax({
        url: "/ShopUser/Products/GetById/" + productId,
        method: "GET",
        success: function (data) {
            let productVm = data.data;
            let product = data.data.product;
            let productPrice = product.purchaseCost;

            // Create input fields based on whether the product has subunits
            let singleUnit = `
                <td class="pr-3">
                    <div class="form-row d-flex">
                        <label class="ml-4 mr-2">${product.unit.name}:</label>
                        <input type="number" value="0" class="form-control col main_qty" 
                               name="Purchase.PurchaseItems[${index}].Quantity" 
                               oninput="UpdateHiddenQuantity(this)">
                    </div>
                </td>`;

            let doubleUnit = `
                <td class="pr-3">
                    <div class="form-row d-flex">
                        <label class="ml-4 mr-2">${product.unit.name}:</label>
                        <input type="number" value="0" class="form-control col main_qty" data-relatedby="${product.unit.relatedBy }" 
                               name="Purchase.PurchaseItems[${index}].Quantity" 
                               oninput="CalculateSubTotal()">
                        <label class="ml-4 mr-2">${productVm.subUnit.name}:</label>
                        <input type="number" value="0" class="form-control col sub_qty" data-relatedby="${product.unit.relatedBy }"  
                               name="Purchase.PurchaseItems[${index}].SubQuantity" 
                               oninput="CalculateSubTotal()">
                    </div>
                </td>`;

            let quantityInput = productVm.subUnit ? doubleUnit : singleUnit;

            // Construct the product row
            let productRow = `
                <tr>
                    <td>${counter}</td>
                    <td>
                        <span class="productName">${productName}</span>
                        <input type="hidden" value="${productId}" class="ProductId" 
                               name="Purchase.PurchaseItems[${index}].ProductId">
                    </td>
                    <td style="width:150px">
                        <input type="text" value="${productPrice}" class="form-control rate" 
                               name="Purchase.PurchaseItems[${index}].Price" 
                               onkeyup="CalculateSubTotal()">
                    </td>
                    ${quantityInput}
                    <input type="hidden" class="quantity"name="Purchase.PurchaseItems[${index}].Quantity" value="0" />
                    <input type="hidden" class="quantity"name="Purchase.PurchaseItems[${index}].SubQuantity" value="0" />
                    <td>
                        <strong><span class="sub_total">0</span> Tk</strong>
                        <input type="hidden" name="Purchase.PurchaseItems[${index}].SubTotal" 
                               class="subtotal_input" value="0">
                    </td>
                    <td>
                        <a onclick="RemoveProduct(this)" class="removeProduct">
                            <i class="fa fa-trash"></i>
                        </a>
                    </td>
                </tr>`;

            // Append the product row to the table body
            $("#purchaseProduct tbody").append(productRow);
            index++;
            $("#ProductList option:selected").remove(); // Remove selected product from dropdown
        },
        error: function (xhr, status, error) {
            console.error("Error fetching product details:", error);
        }
    });
});



function UpdateHiddenQuantity(input) {
    const quantityValue = $(input).val();
    const hiddenInput = $(input).closest('tr').find('.quantity');
    hiddenInput.val(quantityValue); // Update hidden input with quantity
}







//$("#ProductList").on("change", function () {
   
//    var productId = $("#ProductList option:selected").val();
//    var productName = $("#ProductList option:selected").text();
//    counter++;
//    $.ajax({

//        url: "/Admin/Products/GetById/" + productId,
//        method: "GET",
//        type: "json",
//        async: false,

//        success: function (data) {
            
            
//            productVm = data.data;
//            product = data.data.product;
//            productPrice = product.purchaseCost;

//        } 
//    });
    
//    var singleUnit = '<td class="pr-3"> <div class="form-row d-flex"><label class="ml-4 mr-2">###unitname###:</label>' +
//        '<input type = "number" value = "0" class="form-control col main_qty" name ="" data-relatedby="' + product.unit.relatedBy + '" oninput = "CalculateSubTotal()"></div> </td>';

//    var doubleUnit = '<td class="pr-3"> <div class="form-row d-flex"><label class="ml-4 mr-2">###unitname###:</label>' +
//        '<input type = "number" value = "0" class="form-control col main_qty" name ="" data-relatedby="' + product.unit.relatedBy + '" oninput = "CalculateSubTotal()">' +
//        '<label class="ml-4 mr-2">###subunitname###:</label><input type = "number" value = "0" class="form-control col sub_qty" name = "" oninput = "CalculateSubTotal()"> </div> </td>';
//    if (productVm.subUnit != null) {
//        doubleUnit = doubleUnit.replace("###unitname###", product.unit.name).replace("###subunitname###", productVm.subUnit.name);
//    }
//    else {
//        singleUnit = singleUnit.replace("###unitname###", product.unit.name);
//    }

//    let test = Number( 187500);

//    var productRow = '<tr><td>' + counter + '</td>'+
//        '<td> <span class="productName">' + productName + '</span> <input type = "hidden" value = "' + productId + '" class="ProductId" name = "Purchase.PurchaseItems[' + index + '].ProductId" class="" ></td>' +
//        '<td style="width:150px"><input type="text" value="' + productPrice + '" class="form-control rate" name="Purchase.PurchaseItems[' + index + '].Price" onkeyup="CalculateSubTotal()"></td>' +
//        '###quantityinput### <input type="hidden" class="quantity" type="text"  name="Purchase.PurchaseItems' + index + '].Quantity"   />' +
//        '<td> <strong><span class="sub_total">0</span> Tk</strong> <input type="hidden" name="Purchase.PurchaseItems[' + index + '].SubTotal" class="subtotal_input" value="0"></td>' +
//        '<td> <a onclick="RemoveProduct(this)" class="removeProduct">  <i class="fa fa-trash"></i> </a> </td>  </tr> ';

//    if (productVm.subUnit != null) {
//        productRow = productRow.replace("###quantityinput###", doubleUnit);
//    }
//    else {
//        productRow = productRow.replace("###quantityinput###", singleUnit);
//    }


//    $("#purchaseProduct tbody").append(productRow);
//    index++;
//    $("#ProductList option:selected").remove();

//});

























function CalculateSubTotal() {

    
    var rows = $("#purchaseProduct tbody tr");
    rows.each(function () {

        
        var main_qty = 0;
        var sub_qty = 0;
        var tot_qty = 0;
        var relatedBy = 0;
        var price = parseFloat($(this).find(".rate").val()).toFixed(2);
        main_qty = parseInt($(this).find(".main_qty").val());
        relatedBy = parseInt($(this).find(".main_qty").attr("data-relatedby"));
        if ($(this).find(".sub_qty").length > 0) {
            sub_qty = parseInt($(this).find(".sub_qty").val());
           
            $(this).find(".subtotal_input").val(parseFloat((price * main_qty) + ((price / relatedBy) * sub_qty)).toFixed(2));
            tot_qty = (main_qty * relatedBy) + sub_qty;
        }
        else {

            $(this).find(".subtotal_input").val(price * main_qty);
              tot_qty = (main_qty * relatedBy) + sub_qty;
        }
      
        $(this).find(".quantity").val(tot_qty);
       
        $(this).find(".sub_total").html($(this).find(".subtotal_input").val());

    });

    CalculateGrandTotal();

}

function CalculateGrandTotal() {
  
    var rows = $("#purchaseProduct tbody tr");
    var grandTotal = 0;
    rows.each(function () {
        

        grandTotal += parseFloat($(this).find(".subtotal_input").val());
        
    });

    $("#PurchaseGrandTotal").val(grandTotal);
    $("#grandTotalTxt").html($("#PurchaseGrandTotal").val());

}

function RemoveProduct(elem) {
    
    var row = $(elem).parent().parent();
    var productName = row.find(".productName").text();
    var productId = row.find(".ProductId").val();
    var data = {
        id: productId,
        text: productName
    };

    var newOption = new Option(data.text, data.id, false, false); 
    row.remove();
    $("#ProductList").append(newOption);
    CalculateGrandTotal();
}

$("#paymentForm").on("shown.bs.modal", function () {
    
    var grandTotal = $("#PurchaseGrandTotal").val();
    $("#totalPayable").html(grandTotal);
    $("#due_txt").html(grandTotal);
    $("#totalPayable_input").val(grandTotal);
    $("#due_input").val(grandTotal);

  //  var productName = $("#ProductList option:selected").text();
   // $("#items").text(productName);


})


function SetPaidAmount() {
    

    var grandTotal = $("#PurchaseGrandTotal").val();
    $("#pay_amount").val(grandTotal);
    $("#due_txt").html("0");
    $("#due_input").val(0);
}

$("#pay_amount").keyup(function () {
    
    var grandTotal = $("#PurchaseGrandTotal").val();
    var payAmount = $("#pay_amount").val();
    var due = parseFloat(grandTotal - payAmount);
    $("#due_txt").html(due);
    $("#due_input").val(due);

})



function SaveSupplier() {

    
    let name = $("#supplierName").val();
    let email = $("#supplierEmail").val();
    let phone = $("#supplierPhone").val();
    let address = $("#supplierAddress").val();
    let openeingReceivable = $("#openeingReceivable").val();
    let openeingPayable = $("#openeingPayable").val();

    if ($("#supplierForm").valid()) {

        var formData = $("#supplierForm").serialize();
        $.ajax({
            url: "/Suppliers/Upsert",
            type: "POST",
            data: formData,
            success: function (response) {
                
                location.reload(true);
            },
            error: function (request, status, error) {
                alert(request.responseText);
            }
        });



    }

}