namespace viet_trip_backend.Interfaces.Repositories
{
    public interface ISlugRepository<T> where T:ISlug
    {
        Task<T> GetBySlug(string slug);
    }
}
