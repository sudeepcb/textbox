using System.Collections.Generic;

namespace TextBox.Domain.Models
{
    public class OrderHistory
    {
        public int OrderId { get; set; }
        public int UserId {get; set;}
        public User User {get; set;}
        public Order Order {get; set;}
    }
}