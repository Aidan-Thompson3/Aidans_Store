
namespace Library.eCommerce.Models;

    public class CartItem
    {
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        
        public decimal Subtotal 
        { 
            get 
            {
                return (Product?.Price ?? 0) * Quantity;
            }
        }
    }