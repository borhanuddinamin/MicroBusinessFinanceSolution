// Product retrieval functions
function getProduct(id) {
    let product = null;

    $.ajax({
        url: "/PublicUser/Home/GetProductById",
        method: "GET",
        data: { id: [id] },
        dataType: "json",
        async: false,
        success: function (response) {
            if (response && response.data && response.data.length > 0) {
                product = response.data[0];
            }
        },
        error: function (xhr, status, error) {
            console.error("Error fetching product:", error);
            showToast("Error fetching product details. Please try again.", "error");
        }
    });

    return product;
}
function getProductsByIds(productIds) {
    let items = [];

    if (!productIds || !productIds.length) {
        console.warn("No product IDs provided");
        return items;
    }

    $.ajax({
        url: "/PublicUser/Home/GetProductsByIds",
        method: "POST",
        contentType: "application/json", // Specify JSON content type
        data: JSON.stringify(productIds), // Convert the array to JSON format
        dataType: "json",
        async: false, // Use synchronous requests if needed (though not recommended for UX)
        success: function (response) {
            if (response && response.data) {
                items = response.data;
            }
        },
        error: function (xhr, status, error) {
            console.error("Error fetching products:", error);
            showToast("Error fetching product details. Please try again.", "error");
        }
    });

    return items;
}


// Shopping Cart Module
var shoppingCart = (function () {
    var cart = [];

    function Item(name, price, count, id) {
        this.name = name;
        this.price = parseFloat(price);
        this.count = parseInt(count);
        this.id = parseInt(id);
    }

    function saveCart() {
        localStorage.setItem('shoppingCart', JSON.stringify(cart));
        updateCartCount();
    }

    function loadCart() {
        cart = JSON.parse(localStorage.getItem('shoppingCart')) || [];
        // Ensure all numeric values are properly typed
        cart.forEach(item => {
            item.price = parseFloat(item.price);
            item.count = parseInt(item.count);
            item.id = parseInt(item.id);
        });
    }

    loadCart();

    var obj = {};

    obj.addItemToCart = function (name, price, count, id) {
        count = parseInt(count);
        if (isNaN(count) || count < 100) count = 100;
        price = parseFloat(price);
        id = parseInt(id);

        for (var i = 0; i < cart.length; i++) {
            if (cart[i].id === id) {
                cart[i].count = cart[i].count + count;
                saveCart();
                return;
            }
        }

        var item = new Item(name, price, count, id);
        cart.push(item);
        saveCart();
    };

    obj.setCountForItem = function (name, count) {
        count = parseInt(count);
        if (isNaN(count) || count < 100) count = 100;

        for (var i in cart) {
            if (cart[i].name === name) {
                cart[i].count = count;
                break;
            }
        }
        saveCart();
    };

    obj.removeItemFromCart = function (name) {
        for (var i in cart) {
            if (cart[i].name === name) {
                cart.splice(i, 1);
                break;
            }
        }
        saveCart();
    };

    obj.clearCart = function () {
        cart = [];
        saveCart();
    };

    obj.totalCount = function () {
        var total = 0;
        for (var i in cart) {
            total += cart[i].count;
        }
        return total;
    };

    obj.totalCart = function () {
        var total = 0;
        for (var i in cart) {
            total += cart[i].price * cart[i].count;
        }
        return Number(total.toFixed(2));
    };

    obj.listCart = function () {
        var cartCopy = [];
        for (var i in cart) {
            var item = cart[i];
            var itemCopy = {};
            for (var p in item) {
                itemCopy[p] = item[p];
            }
            itemCopy.total = Number(item.price * item.count).toFixed(2);
            cartCopy.push(itemCopy);
        }
        return cartCopy;
    };

    return obj;
})();

// Display cart function
function displayCart() {
    var cartArray = shoppingCart.listCart();
    var output = "";

    for (var i in cartArray) {
        output += `
            <tr>
                <td>${cartArray[i].name}</td>
                <td>?${cartArray[i].price}</td>
                <td>
                    <input type="number" 
                           class="item-count form-control" 
                           data-name="${cartArray[i].name}" 
                           value="${cartArray[i].count}" 
                           min="100" 
                           step="100">
                </td>
                <td>?${cartArray[i].total}</td>
                <td>
                    <button class="delete-item btn btn-link text-danger" 
                            data-name="${cartArray[i].name}">
                        <i class="fa-solid fa-square-xmark"></i>
                    </button>
                </td>
            </tr>`;
    }

    $('.show-cart').html(output);
    $('.total-cart').html(shoppingCart.totalCart());
    updateCartCount();
}

// Toast notification function
function showToast(message, type = 'success') {
    const toast = $('#cart-toast');
    if (toast.length) {
        toast.find('.toast-body').text(message);
        toast.find('.toast-header')
            .removeClass('bg-success bg-danger')
            .addClass(type === 'success' ? 'bg-success' : 'bg-danger');

        const bsToast = new bootstrap.Toast(toast);
        bsToast.show();
    } else {
        // Fallback if toast element doesn't exist
        alert(message);
    }
}

// Update cart count in navbar
function updateCartCount() {
    $('.total-count').text(shoppingCart.totalCount());
}

// Redirect to order page
function redirectToPage() {
    var cartArray = shoppingCart.listCart();
    if (!cartArray.length) {
        showToast("Your cart is empty!", "error");
        return;
    }

    const productIds = cartArray.map(item => item.id);
    var products = getProductsByIds(productIds);

    // Build query parameters
    const params = new URLSearchParams();
    cartArray.forEach((item, index) => {
        const product = products.find(p => p.id === item.id) || {};
        params.append(`cart[${index}].Id`, item.id);
        params.append(`cart[${index}].Name`, item.name);
        params.append(`cart[${index}].Price`, item.price);
        params.append(`cart[${index}].Count`, item.count);
        params.append(`cart[${index}].Total`, item.total);
        params.append(`cart[${index}].imagePath`, product.imageUrl || '');
    });

    // Redirect to PlaceOrder with query parameters
    window.location.href = `/PublicUser/Placed/PlaceOrder?${params.toString()}`;
}

// Event Handlers
$(document).ready(function () {
    // Display cart on page load
    displayCart();

    // Add to cart button handler
    $('.add-cart-btn').on('click', function (event) {
        event.preventDefault();

        var $btn = $(this);
        var $quantityInput = $btn.closest('.product-meta').find('.quantity-input');

        var id = $btn.data('id');
        var name = $btn.data('name');
        var price = parseFloat($btn.data('price'));
        var quantity = parseInt($quantityInput.val()) || 100;

        // Validate MOQ
        if (quantity < 100) {
            $quantityInput.addClass('is-invalid');
            return;
        }

        // Show loading state
        $btn.prop('disabled', true).html('<i class="fas fa-spinner fa-spin"></i> Adding...');

        // Add to cart
        shoppingCart.addItemToCart(name, price, quantity, id);

        // Update display
        displayCart();

        // Reset button state
        $btn.prop('disabled', false).html('<i class="pe-7s-cart"></i> Add to Quote');

        // Show success message
        showToast('Product added to cart successfully!');

        // Open cart modal
        $('#staticBackdrop').modal('show');
    });

    // Clear cart button handler
    $('.clear-cart').on('click', function () {
        if (confirm('Are you sure you want to clear the cart?')) {
            shoppingCart.clearCart();
            displayCart();
            showToast('Cart cleared successfully!');
        }
    });

    // Delete item button handler
    $(document).on('click', '.delete-item', function () {
        var name = $(this).data('name');
        shoppingCart.removeItemFromCart(name);
        displayCart();
        showToast('Item removed from cart!');
    });

    // Quantity change handler
    $(document).on('change', '.item-count', function () {
        var name = $(this).data('name');
        var count = Number($(this).val());
        if (count < 100) {
            count = 100;
            $(this).val(100);
        }
        shoppingCart.setCountForItem(name, count);
        displayCart();
    });

    // Quantity input validation handler
    $('.quantity-input').on('input', function () {
        var value = parseInt($(this).val());
        if (isNaN(value) || value < 100) {
            $(this).addClass('is-invalid');
        } else {
            $(this).removeClass('is-invalid');
        }
    });
});