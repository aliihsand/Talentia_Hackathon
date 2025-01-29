using Talentia.Models;

namespace Talentia.Dto
{
    public class CartViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public decimal GrandTotal { get; set; }

    }
}
