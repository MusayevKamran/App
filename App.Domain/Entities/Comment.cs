using System;

namespace App.Domain.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }

        public int Count { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public Article Article { get; set; }
        public User User { get; set; }
    }
}
