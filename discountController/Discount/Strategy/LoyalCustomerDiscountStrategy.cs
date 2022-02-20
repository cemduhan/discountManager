using discountController.Models;

namespace discountController.Discount.Strategy
{
    public class LoyalCustomerDiscountStrategy : IDiscountCalculatorService
    {
        public double CalculateDiscount(CartBuyDto _cart)
        {
            return ((_cart.CalculateWithFilter("GR") * 5) / 100);
        }
    }
}
