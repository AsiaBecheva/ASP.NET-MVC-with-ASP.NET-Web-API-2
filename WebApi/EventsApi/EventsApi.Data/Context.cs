namespace EventsApi.Data
{
    using Migrations;
    using Models;
    using System.Data.Entity;

    public class Context : DbContext
    {
        public Context()
            : base("Events")
        {
        }

        public virtual DbSet<Event> Events { get; set; }

        public static Context Create()
        {
            return new Context();
        }
    }
}
