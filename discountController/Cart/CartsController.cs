using discountController.Discount;
using discountController.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using discountController.Discount.Strategy;

namespace discountController.Cart
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {

        private readonly ICartsService _cartsService;

        public CartsController(ICartsService cartsService)
        {
            this._cartsService = cartsService;
        }

        [HttpPost("{id}")]
        public IActionResult BuyCart(string id, [FromBody] CartBuyDto _cart)
        {
            User _user = new User();

            switch (int.Parse(id))
            {
                case 1:
                    _user.isAffiliate = true;
                break;
                case 2:
                _user.isEmployee = true;
                break;
                case 3:
                _user.isLoyalCustomer = true;
                break;
            }
            return Ok(_cartsService.BuyCart(_user, _cart));
        }
    }
}
