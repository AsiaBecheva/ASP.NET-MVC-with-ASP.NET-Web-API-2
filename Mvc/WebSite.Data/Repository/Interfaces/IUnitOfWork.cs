namespace WebSite.Data.Repository.Interfaces
{
    using Models;

    public interface IUnitOfWork
    {
        void SaveChanges();

        IGenericRepository<Image> ImageRepo { get; }
        IGenericRepository<Email> EmailRepo { get; }
        IGenericRepository<Article> ArticleRepo { get; }
        IGenericRepository<TeamMember> TeamMemberRepo { get; }
    }
}