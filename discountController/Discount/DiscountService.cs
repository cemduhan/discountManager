using discountController.Models;
using discountController.Discount.Strategy;

namespace discountController.Discount
{
    public class DiscountService
    {
        public double CalculateDiscountAmount(CartBuyDto _cart, IDiscountCalculatorService discountCalculatorService)
        {
            return discountCalculatorService.CalculateDiscount(_cart);
        }
    }
}
