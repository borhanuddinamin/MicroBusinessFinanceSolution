
	/*==================================================================
	[ Filter / Search product ]*/
	$('.js-show-filter').on('click', function () {
		$(this).toggleClass('show-filter');
	$('.panel-filter').slideToggle(400);

	if ($('.js-show-search').hasClass('show-search')) {
		$('.js-show-search').removeClass('show-search');
	$('.panel-search').slideUp(400);
		}
	});

	$('.js-show-search').on('click', function () {
		$(this).toggleClass('show-search');
	$('.panel-search').slideToggle(400);

	if ($('.js-show-filter').hasClass('show-filter')) {
		$('.js-show-filter').removeClass('show-filter');
	$('.panel-filter').slideUp(400);
		}
	});




function filterDivisionProduct(id) {

	

	var $filterbox = $('.filter-box-product');
    var $filterboxDivision = $('.filter-box-productDivision');
	$filterbox.hide();
   
    // Fetch product data; assume this is an array of product objects
    var data = getAllProductByDivisionId(id); // Example: [{Id: 1, Name: "Product 1", ImageUrl: "path/to/image1.jpg", SalePrice: 100}, ...]

    if (Array.isArray(data) && data.length > 0) {
        // Initialize an empty string for carousel items
        var carouselItems = '';

        // Loop through each product and build the carousel items
        data.forEach(product => {
            
            carouselItems += `
            <div class="col-md-3 col-sm-6 col-xs-12 cat-3 featured-items isotope-item">
                <div class="product-item">
                    <img src="${product.imageUrl}" class="img-responsive" width="255" height="322" alt="${product.name}">
                    <p>${product.name}</p>
                    <div class="product-hover">
                        <div class="product-meta">
                            <a href="#"><i class="fa-regular fa-eye"></i></a>
                            <a href="#" data-id="${product.id}" class="add-cart-btn"><i class="pe-7s-cart"></i>Add to Cart</a>
                        </div>
                    </div>
                    <div class="product-title">
                        <p>Price <span class="ps-2">৳ ${product.salePrice}</span></p>
                    </div>
                </div>
            </div>
        `;
        });

        debugger

        // Create the full carousel HTML
        var prodDiv = `
        <section class="featured-section">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="titie-section wow fadeInDown animated">
                            <h1>PRODUCTS</h1>
                        </div>
                    </div>
                </div>

                <div id="productCarousel" class="carousel slide" data-bs-ride="carousel">
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <div class="row ps-4 pb-5">
                                ${carouselItems}
                            </div>
                        </div>
                    </div>
                    <button class="carousel-control-prev" type="button" data-bs-target="#productCarousel" data-bs-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Previous</span>
                    </button>
                    <button class="carousel-control-next" type="button" data-bs-target="#productCarousel" data-bs-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Next</span>
                    </button>
                </div>
            </div>
        </section>`;

        // Append the generated HTML to your desired container
        $('.filter-box-productDivision').empty(); // Ensure this selector matches your actual container
        $('.filter-box-productDivision').append(prodDiv); // Ensure this selector matches your actual container
    } else {
        console.warn('No products available.');
    }



    // Append the generated HTML to your desired container
   

}

function reset() {

    location.reload();
}
function getAllProductByDivisionId(id) {

	var product = null;
	$.ajax({

		url: "/PublicUser/Products/GetAllByDivisionId/" + id,
		method: "GET",
		type: "json",
		async: false,

		success: function (data) {

			product = data.data;

		}


	});

	return product;
}
