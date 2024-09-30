namespace LinqDemo.DataSource.Relationships.OneToOne
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation property to the profile
        public UserProfile Profile { get; set; }
    }
}
