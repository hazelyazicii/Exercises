using System.Security.Cryptography;

namespace RentACar.Core.Entities;

public abstract class Entity : IEntity
{
    public long Id { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdateAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}