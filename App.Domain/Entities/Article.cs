using App.Domain.Entities.Enum;
using System;
using System.Collections.Generic;

namespace App.Domain.Entities
{
    public class Article
    {
        public Article()
        {
            ArticleCategory = new HashSet<ArticleCategory>();
            Images = new HashSet<Image>();
            Comments = new HashSet<Comment>();
        }
        public int ArticleId { get; set; }
        public virtual string Title { get; set; }
        public virtual int Row { get; set; }
        public virtual string URL { get; set; }
        public virtual string Content { get; set; }
        public virtual string Like { get; set; }
        public virtual bool IsActive { get; set; }

        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual PostCategory PostCategory { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<ArticleCategory> ArticleCategory { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
