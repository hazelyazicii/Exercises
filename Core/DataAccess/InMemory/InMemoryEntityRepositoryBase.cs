﻿using RentACar.Core.DataAccess;
using RentACar.Core.Entities;

namespace Core.DataAccess.InMemory;

public abstract class InMemoryEntityRepositoryBase<TEntity>
    : IEntityRepository<TEntity>
    where TEntity : Entity, IEntity, new()
{
    protected readonly HashSet<TEntity> _entities = new();

    protected abstract long generateId();

    public void Add(TEntity entity)
    {
        entity.Id = generateId();
        entity.CreatedAt = DateTime.UtcNow;
        _entities.Add(entity);
    }

    public void Delete(TEntity entity)
    {
        entity.DeletedAt = DateTime.UtcNow;
    }

    public TEntity? GetById(long id)
    {
        TEntity? entity = _entities.FirstOrDefault(
            e => e.Id.Equals(id) && e.DeletedAt.HasValue == false
        );
        return entity;
    }

    public IList<TEntity> GetList()
    {
        IList<TEntity> entities = _entities.Where(e => e.DeletedAt.HasValue == false).ToList();
        return entities;
    }

    public void Update(TEntity entity)
    {
        entity.UpdateAt = DateTime.UtcNow;
    }
}