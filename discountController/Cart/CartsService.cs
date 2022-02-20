using discountController.Discount;
using discountController.Discount.Strategy;
using discountController.Models;

namespace discountController.Cart
{
    public class CartsService: ICartsService
    {
        public Invoice BuyCart(User _user, CartBuyDto _cart)
        {
            DiscountService _dService = new DiscountService();

            IDiscountCalculatorService _strategy = new DiscountStrategyFactory().getDiscountStrategy(_user);
            double _percantageDiscount = _dService.CalculateDiscountAmount(_cart, _strategy);

            _strategy = new DiscountStrategyFactory().getCashDiscountStrategy();
            double _cashDiscount = _dService.CalculateDiscountAmount(_cart, _strategy);

            return new Invoice()
            {
                amoundDue = _cart.CalculateTotal() - (_percantageDiscount + _cashDiscount),
                percantageDiscount = _percantageDiscount,
                cashDiscount = _cashDiscount,
                items = _cart.items
            };
        }
    }
}
