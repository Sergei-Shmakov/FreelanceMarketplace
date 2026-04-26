using FreelancePlatform.ValueObjects.Base;
using FreelancePlatform.ValueObjects.Validators;

namespace FreelancePlatform.ValueObjects.Objects;

public sealed class Description : ValueObject<string>
{
    public Description(string value) : base(value.Trim())
    {
        Guard.AgainstEmpty(value, nameof(Description));
    }
}