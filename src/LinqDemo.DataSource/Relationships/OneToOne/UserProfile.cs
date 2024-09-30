namespace LinqDemo.DataSource.Relationships.OneToOne
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string Bio { get; set; }

        // Foreign key
        public int UserId { get; set; }

        // Navigation property to the user
        public User User { get; set; }
    }
}
