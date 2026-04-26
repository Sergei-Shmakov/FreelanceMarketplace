using FreelancePlatform.ValueObjects.Base;
using FreelancePlatform.ValueObjects.Validators;

namespace FreelancePlatform.ValueObjects.Objects;

public sealed class Email : ValueObject<string>
{
    public Email(string value) : base(Validate(value))
    {
    }

    private static string Validate(string value)
    {
        Guard.AgainstEmpty(value, nameof(Email));
        Guard.AgainstInvalidEmail(value);

        return value.Trim().ToLower();
    }

    public static implicit operator string(Email email) => email.Value;
}