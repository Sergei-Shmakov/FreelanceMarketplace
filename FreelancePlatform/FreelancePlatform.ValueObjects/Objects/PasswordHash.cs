using FreelancePlatform.ValueObjects.Base;
using FreelancePlatform.ValueObjects.Validators;

namespace FreelancePlatform.ValueObjects.Objects;

public sealed class PasswordHash : ValueObject<string>
{
    public PasswordHash(string value) : base(value)
    {
        Guard.AgainstEmpty(value, nameof(PasswordHash));
    }
}