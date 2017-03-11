namespace EventsApi.Data.Repository
{
    using Data;
    using Interfaces;
    using Models;
    using System;

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly Context context;
        private IGenericRepository<Event> eventRepo;

        public UnitOfWork()
        {
            this.context = new Context();
        }

        public IGenericRepository<Event> EventRepo
        {
            get
            {
                if (eventRepo == null)
                {
                    eventRepo = new GenericRepository<Event>(context);
                }
                return eventRepo;
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
