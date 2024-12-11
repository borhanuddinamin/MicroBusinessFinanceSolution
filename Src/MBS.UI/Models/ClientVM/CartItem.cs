namespace MBS.UI.Models.ClientVM
{
    public class CartItem
    {
        public int Id { get; set; }            // Unique identifier for the item
        public string Name { get; set; }       // Name of the item
        public decimal Price { get; set; }     // Price of the item
        public int Count { get; set; }         // Quantity of the item in the cart
        public decimal Total { get; set; }  // Total price for the quantity of the item
        public string ImagePath { get; set; }  // Total price for the quantity of the item
    }
}
