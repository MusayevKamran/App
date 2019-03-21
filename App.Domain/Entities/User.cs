using App.Domain.Infrastructure;
using App.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Entities
{
    public class User
    {
        public User()
        {
            Article = new HashSet<Article>();
            Comment = new HashSet<Comment>();
        }
        public Guid UserId { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Email { get; set; }

        public string Image { get; set; }

        public string URL { get; set; }

        public string Education { get; set; }

        public string Job { get; set; }

        public string About { get; set; }

        public string Quote { get; set; }

        public int Like { get; set; }

        public int Follower { get; set; }

        public int View { get; set; }

        //public Address Address { get; set; }

        //public Contact Contact { get; protected set; }

        public virtual ICollection<Article> Article { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }

    }
}
