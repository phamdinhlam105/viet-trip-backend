namespace viet_trip_backend.Interfaces.Services
{
    public interface IAdd<TRequest>
    {
        Task Add(TRequest request);
    }

    public interface IUpdate<TResponse, TRequest>
    {
        Task<TResponse> Update(TRequest request);
    }

    public interface IDelete<TRequest>
    {
        Task Delete(TRequest request);
    }

    public interface IGetById<TResponse>
    {
        Task<TResponse> GetById(Guid id);
    }
    public interface IGetBySlug<TResponse>
    {
        Task<TResponse> GetBySlug(string slug);
    }

    public interface IGetAll<TResponse>
    {
        Task<IEnumerable<TResponse>> GetAll();
    }
    public interface IService<T, TRequest, TResponse> : IAdd<TRequest>, IUpdate<TResponse, TRequest>, IDelete<TRequest>, IGetById<TResponse>, IGetAll<TResponse>
    {

    }
}
