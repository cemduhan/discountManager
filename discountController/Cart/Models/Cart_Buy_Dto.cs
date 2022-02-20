namespace discountController.Models
{
    public class CartBuyDto
    {
        public List<CartItem>  items { get; set; }

        public double CalculateTotal()
        {
            double total = 0;

            foreach (CartItem _item in this.items)
            {
                total = total + _item.Count * _item.item.Price;
            }

            return total;
        }

        public double CalculateWithFilter(string type)
        {
            double total = 0;

            foreach (CartItem _item in this.items.Where(a => a.item.Type == type))
            {
                total = total + (_item.Count * _item.item.Price);
            }

            return total;
        }

    }


    public class CartItem
    {
        public int Count { get; set; }
        public Item item { get; set; }
    }
}
