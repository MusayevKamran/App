namespace App.Domain.Entities
{
    public class ArticleImages
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int ImageId { get; set; }
        public Image Image { get; set; }
    }
}
