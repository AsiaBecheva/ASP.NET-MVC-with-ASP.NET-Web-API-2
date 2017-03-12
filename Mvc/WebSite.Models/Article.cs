namespace WebSite.Models
{
    using System.ComponentModel.DataAnnotations;
    using Infrastructure.Constants;
    using System.Web;

    public class Article : Base
    {
        public int Id { get; set; }

        [Required]
        [MinLength(ValidationConstants.MinLengthArticleTitle)]
        [MaxLength(ValidationConstants.MaxLengthArticleTitle)]
        public string Title { get; set; }

        [Required]
        [MinLength(ValidationConstants.MinLengthArticleContent)]
        [MaxLength(ValidationConstants.MaxLengthArticleContent)]
        public string Content { get; set; } 
        
        public virtual Image Image { get; set; }
        
    }
}
