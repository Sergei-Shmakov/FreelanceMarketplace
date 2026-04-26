namespace FreelancePlatform.ValueObjects.Base;


public abstract class ValueObject<T>
{
    public T Value { get; protected set; }

    protected ValueObject(T value)
    {
        Value = value;
    }

    public override string ToString()
        => Value?.ToString() ?? string.Empty;
}