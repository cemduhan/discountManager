namespace discountController.Models
{
    public class User
    {

        public User()
        {
            this.isLoyalCustomer = false;
            this.isAffiliate = false;
            this.isEmployee = false;


            this.Name = "nonNullable";
            this.email = "email@email.com";
            this.password = "hashedValue";
            this.Id = -1;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool isEmployee { get; set; }
        public bool isAffiliate { get; set; }
        public bool isLoyalCustomer { get; set; }

    }
}
