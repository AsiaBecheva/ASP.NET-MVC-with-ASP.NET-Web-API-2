namespace EventsApi.Data.Repository.Interfaces
{
    using Models;

    public interface IUnitOfWork
    {
        void SaveChanges();

        IGenericRepository<Event> EventRepo { get; }
    }
}