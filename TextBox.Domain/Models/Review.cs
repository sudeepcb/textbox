namespace TextBox.Domain.Models
{
    public class Review
    {
        public int Id { get; set; }
        public double RatingScore { get; set; }
        public User ReviewWriter { get; set; }
        public string ReviewTitle { get; set; }        
        public string Content { get; set; }
    }
}