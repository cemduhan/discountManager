using discountController.Discount.Strategy;
using discountController.Models;

namespace discountController.Discount
{
    public class DiscountStrategyFactory
    {
        public IDiscountCalculatorService getDiscountStrategy(User _user)
        {
            if (_user.isEmployee)
            {
                return new EmployerDiscountStrategy();
            }
            else if (_user.isAffiliate)
            {
                return new AffiliateDiscountStrategy();
            }
            else if (_user.isLoyalCustomer)
            {
                return new LoyalCustomerDiscountStrategy();
            }
            return new NoDiscountStrategy();            
        }

        public IDiscountCalculatorService getCashDiscountStrategy()
        {
            return new CashDiscountStrategy();
        }


    }
}
