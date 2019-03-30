using App.Domain.ValueObjects;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace App.Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        public User()
        {
            Articles = new HashSet<Article>();
            Comments = new HashSet<Comment>();
        }
        public Guid UserId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string SecondName { get; set; }
        public virtual string Image { get; set; }
        public virtual string URL { get; set; }
        public virtual string Quote { get; set; }
        public virtual string Job { get; set; }
        public virtual string Education { get; set; }
        public virtual int View { get; set; }
        public virtual int Like { get; set; }
        public virtual int Follower { get; set; }

        public Address Address { get; set; }
        public Contact Contact { get; protected set; }
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
