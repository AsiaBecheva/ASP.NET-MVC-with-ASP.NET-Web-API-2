namespace WebSite.Data.Repository
{
    using System;
    using WebSite.Data.Repository.Interfaces;
    using WebSite.Models;

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly Context context;
        private IGenericRepository<Image> imageRepo;
        private IGenericRepository<Email> emailRepo;
        private IGenericRepository<Article> articleRepo;
        private IGenericRepository<TeamMember> teamMemberRepo;

        public UnitOfWork()
        {
            this.context = new Context();
        }

        public IGenericRepository<Image> ImageRepo
        {
            get
            {
                if (imageRepo == null)
                {
                    imageRepo = new GenericRepository<Image>(context);
                }
                return imageRepo;
            }
        }

        public IGenericRepository<Email> EmailRepo
        {
            get
            {
                if (emailRepo == null)
                {
                    emailRepo = new GenericRepository<Email>(context);
                }
                return emailRepo;
            }
        }

        public IGenericRepository<Article> ArticleRepo
        {
            get
            {
                if (articleRepo == null)
                {
                    articleRepo = new GenericRepository<Article>(context);
                }
                return articleRepo;
            }
        }

        public IGenericRepository<TeamMember> TeamMemberRepo
        {
            get
            {
                if (teamMemberRepo == null)
                {
                    teamMemberRepo = new GenericRepository<TeamMember>(context);
                }
                return teamMemberRepo;
            }
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            context.Dispose();
        }
    }
}
