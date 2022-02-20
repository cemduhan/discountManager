using discountController.Models;

namespace discountController.Cart
{
    public interface ICartsService
    {
        Invoice BuyCart(User _user, CartBuyDto _cart);
    }
}
