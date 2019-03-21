namespace App.Domain.Entities
{
    public class Image
    {
        public int ImageId { get; set; }

        public string ImageLink { get; set; }

        public ArticleImages ArticleImages { get; set; }
    }
}
