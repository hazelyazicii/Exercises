namespace RentACar.Core.DataAccess;

public interface IEntityRepository<TEntity>
{
    public IList<TEntity> GetList();
    public TEntity? GetById(long id);
    public void Add(TEntity entity);
    public void Update(TEntity entity);
    public void Delete(TEntity entity);
}