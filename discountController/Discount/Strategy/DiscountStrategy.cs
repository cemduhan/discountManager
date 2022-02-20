using discountController.Models;

namespace discountController.Discount.Strategy
{
    public interface IDiscountCalculatorService
    {
        double CalculateDiscount(CartBuyDto _cart);
    }
}
