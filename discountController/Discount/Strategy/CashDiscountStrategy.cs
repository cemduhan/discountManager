using discountController.Models;

namespace discountController.Discount.Strategy
{
    public class CashDiscountStrategy: IDiscountCalculatorService
    {
        public double CalculateDiscount(CartBuyDto _cart)
        {
            double total = _cart.CalculateTotal();

            int discount = (int)((total / 100)  * 5);

            return discount;
        }
    }
}
