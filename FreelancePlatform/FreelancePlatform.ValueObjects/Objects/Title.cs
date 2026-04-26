using FreelancePlatform.ValueObjects.Base;
using FreelancePlatform.ValueObjects.Validators;

namespace FreelancePlatform.ValueObjects.Objects;

public sealed class Title : ValueObject<string>
{
    public Title(string value) : base(value.Trim())
    {
        Guard.AgainstEmpty(value, nameof(Title));
    }
}