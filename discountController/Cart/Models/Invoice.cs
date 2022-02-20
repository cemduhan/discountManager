namespace discountController.Models
{
    public class Invoice: CartBuyDto
    {
        public double amoundDue { get; set; }

        public double percantageDiscount { get; set; }

        public double cashDiscount { get; set; }
    }
}
