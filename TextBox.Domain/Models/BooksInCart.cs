using System.ComponentModel.DataAnnotations.Schema;

namespace TextBox.Domain.Models
{
  [NotMapped]
    public class ThisIsAName
    {
        [NotMapped]
        public int BookId {get; set;} 
        [NotMapped]
        public int CartId {get; set;} 
        [NotMapped]
        public Book Books {get; set;} 
        [NotMapped]
        public Cart Cart {get; set;}
        
    }
}