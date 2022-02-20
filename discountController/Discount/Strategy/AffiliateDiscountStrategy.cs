using discountController.Models;

namespace discountController.Discount.Strategy
{
    public class AffiliateDiscountStrategy: IDiscountCalculatorService
    {
        public double CalculateDiscount(CartBuyDto _cart)
        {
            return ((_cart.CalculateWithFilter("GR") * 10) / 100);
        }
    }
}
