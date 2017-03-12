namespace WebSite.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using Models;

    public class Context : IdentityDbContext<User>
    {
        public Context()
            : base("WebSite", throwIfV1Schema: false)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<TeamMember> TeamMember { get; set; }
        public virtual DbSet<Event> Event { get; set; }


        public static Context Create()
        {
            return new Context();
        }
    }
}
