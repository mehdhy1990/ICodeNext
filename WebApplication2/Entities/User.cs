namespace WebApplication2.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Order> Orders { get; set; }

    }

    public class Order
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public User User { get; set; }
    }
}
