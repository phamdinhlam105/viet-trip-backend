namespace viet_trip_backend.Interfaces.Mapper
{

    public interface IMapToEntity<TEntity,TRequest>
    {
        TEntity MapToEntity(TRequest request);
    }
    public interface IMapToResponse<TEntity,TResponse>
    {
        TResponse MapToResponse(TEntity entity);
    }
    public interface IUpdateToUpdate<TEntity,TRequest>
    {
        void UpdateToEntity(TEntity entity, TRequest request);
    }
}
