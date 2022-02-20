using discountController.Models;

namespace discountController.Discount.Strategy
{
    public class NoDiscountStrategy : IDiscountCalculatorService
    {
        public double CalculateDiscount(CartBuyDto _cart)
        {
            return 0;
        }
    }
}
