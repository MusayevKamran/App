namespace App.Domain.Entities
{
    public class Article
    {
        public int ArticleId { get; set; }

        public string Title { get; set; }

        public string URL { get; set; }

        public int Row { get; set; }

        //public string Content { get; protected set; }

        //public string Image { get; protected set; }

        //public IEnumerable<ArticleImages> Images { get; protected set; }

        //public string Like { get; protected set; }

        //public bool IsActive { get; protected set; }

        //public DateTime CreatedDate { get; protected set; }

        //public DateTime UpdateDate { get; protected set; }

        //public PostCategory PostCategory { get; protected set; }

        //public IEnumerable<ArticleCategory> ArticleCategory { get; protected set; }

        //public IEnumerable<Comment> Comment { get; protected set; }

        //public virtual User User { get; protected set; }
    }
}
