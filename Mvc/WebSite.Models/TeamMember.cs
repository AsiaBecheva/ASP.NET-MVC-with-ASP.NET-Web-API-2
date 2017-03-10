namespace WebSite.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Infrastructure.Constants;

    public class TeamMember
    {
        public int Id { get; set; }

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

        public DateTime EmployedOn { get; set; }

        public virtual Image Image { get; set; }
    }
}
