namespace WebSite.Web.Models
{
    using System.Collections.Generic;
    using WebSite.Models;

    public class AdminViewModel
    {
        public AdminViewModel()
        {
            this.Articles = new List<Article>();
            this.TeamMembers = new List<TeamMember>();
            this.Images = new List<Image>();
        }

        public List<Article> Articles { get; set; }

        public List<TeamMember> TeamMembers { get; set; }

        public List<Image> Images { get; set; }
    }
}