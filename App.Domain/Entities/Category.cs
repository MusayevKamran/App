using System.Collections.Generic;


namespace App.Domain.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public int Row { get; set; }

        public int Count { get; set; }

        public bool IsNew { get; set; }

        public bool IsActive { get; set; }

        public List<ArticleCategory> ArticleCategory { get; set; } 
    }
}