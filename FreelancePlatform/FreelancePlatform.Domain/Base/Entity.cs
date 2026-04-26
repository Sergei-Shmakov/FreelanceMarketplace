namespace FreelancePlatform.Domain.Base;

/// базовая сущность

public abstract class Entity<TId>
{
    public TId Id { get; protected set; }

    protected Entity(TId id)
    {
        Id = id;
    }
}