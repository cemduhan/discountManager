using discountController.Models;

namespace discountController.Discount.Strategy
{
    public class EmployerDiscountStrategy:IDiscountCalculatorService
    {        
        public double CalculateDiscount(CartBuyDto _cart)
        {
            return ((_cart.CalculateWithFilter("GR") * 30) / 100);
        }
    }
}
