namespace WebSite.Web.Models
{
    using System.ComponentModel.DataAnnotations;
    using Infrastructure.Constants;
    using WebSite.Models;

    public class ArticleViewModel
    {

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