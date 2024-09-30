using System.Collections.ObjectModel;

namespace LinqDemo.DataSource.Relationships.OneToOne
{
    public static class UserProfilesBuilder
    {
        public static ICollection<UserProfile> GetUserProfiles()
        {
            return new Collection<UserProfile>
            {
                new UserProfile
                {
                    Id = 1,
                    Bio = "Profile One",
                    UserId = 1,
                    User = new User
                    {
                        Id = 1,
                        Name = "John Doe"
                    }
                },

                new UserProfile
                {
                    Id = 2,
                    Bio = "Profile Two",
                    UserId = 2,
                    User = new User
                    {
                        Id = 2,
                        Name = "Jane Charlie"
                    }
                },

                new UserProfile
                {
                    Id = 3,
                    Bio = "Profile Three",
                    UserId = 3,
                    User = new User
                    {
                        Id = 3,
                        Name = "Harris Peterson"
                    }
                }
            };
        }
    }
}
