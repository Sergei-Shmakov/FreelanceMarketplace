using FreelancePlatform.ValueObjects.Base;
using FreelancePlatform.ValueObjects.Validators;

namespace FreelancePlatform.ValueObjects.Objects;

public sealed class CategoryName : ValueObject<string>
{
    public CategoryName(string value) : base(value)
    {
        Guard.AgainstEmpty(value, nameof(CategoryName));
    }
}