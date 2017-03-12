namespace WebSite.Web.Services
{
    using Data.Repository;
    using Data.Repository.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using WebSite.Models;

    public class AllItemsService
    {
        IUnitOfWork db = new UnitOfWork();

        public List<Article> AllArticles()
        {
            var articles = db.ArticleRepo
                .Get()
                .Take(3)
                .OrderBy(x => x.CreatedOn)
                .ToList();

            return articles;
        }

        public List<TeamMember> AllMembers()
        {
            var members = db.TeamMemberRepo
                .Get()
                .OrderBy(x => x.EmployedOn)
                .ToList();

            return members;
        }
    }
}