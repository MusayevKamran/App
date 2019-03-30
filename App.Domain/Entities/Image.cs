namespace App.Domain.Entities
{
    public class Image
    {
        public int ImageId { get; set; }
        public virtual string ImageLink { get; set; }
        public virtual Article Article { get; set; }

    }
}
