namespace WebSite.Web.Models
{
    using System.ComponentModel.DataAnnotations;
    using WebSite.Infrastructure.Constants;
    using WebSite.Models;

    public class TeamMemberViewModel
    {
        [Required]
        [MinLength(ValidationConstants.MinLengthTeamMemberName)]
        [MaxLength(ValidationConstants.MaxLengthTeamMemberName)]
        public string Name { get; set; }

        [Required]
        [MinLength(ValidationConstants.MinLengthTeamMemberPosition)]
        [MaxLength(ValidationConstants.MaxLengthTeamMemberPosition)]
        public string Position { get; set; }

        [MinLength(ValidationConstants.MinLengthTeamMemberDescription)]
        [MaxLength(ValidationConstants.MaxLengthTeamMemberDescription)]
        public string Description { get; set; }

        public virtual Image Image { get; set; }
    }
}