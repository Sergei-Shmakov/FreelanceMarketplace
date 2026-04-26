using FreelancePlatform.ValueObjects.Base;
using FreelancePlatform.ValueObjects.Validators;

public sealed class Money : ValueObject<decimal>
{
    public Money(decimal value) : base(value)
    {
        Guard.AgainstInvalidMoney(value);
    }
}