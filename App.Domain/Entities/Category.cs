using System.Collections.Generic;


namespace App.Domain.Entities
{
    public class Category
    {
        public Category()
        {
            ArticleCategory = new HashSet<ArticleCategory>();
        }
        public int CategoryId { get; set; }
        public virtual string Name { get; set; }
        public virtual int Row { get; set; }
        public virtual int Count { get; set; }
        public virtual bool IsNew { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual ICollection<ArticleCategory> ArticleCategory { get; set; }

    }
}