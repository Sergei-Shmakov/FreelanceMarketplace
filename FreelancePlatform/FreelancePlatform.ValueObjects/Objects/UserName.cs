using FreelancePlatform.ValueObjects.Base;
using FreelancePlatform.ValueObjects.Validators;

public sealed class UserName : ValueObject<string>
{
    public UserName(string value) : base(value.Trim())
    {
        Guard.AgainstEmpty(value, nameof(UserName));
    }
}