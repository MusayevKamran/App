
using System;

namespace App.Domain.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public virtual string Content { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual User User { get; set; }
        public virtual Article Article { get; set; }
    }
}
