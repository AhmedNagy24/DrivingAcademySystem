namespace DataAccess.Models
{
    public class Customer : User
    {
        public double Rating { get; set; }
        public int RatingCount { get; set; }
        public required bool IsSuspended { get; set; }
    }
}
