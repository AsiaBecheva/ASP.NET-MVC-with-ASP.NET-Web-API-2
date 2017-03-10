namespace WebSite.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Image : Base
    {
        public Image()
        {
            this.Articles = new HashSet<Article>();
        }

        public int Id { get; set; }

        [Required]
        public string OriginalFileName { get; set; }

        [Required]
        public string SystemFileName { get; set; }

        [Required]
        public string Location { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
