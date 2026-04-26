using FreelancePlatform.ValueObjects.Base;
using FreelancePlatform.ValueObjects.Validators;

namespace FreelancePlatform.ValueObjects.Objects;

public sealed class ImageUrl : ValueObject<string>
{
    public ImageUrl(string value) : base(value)
    {
        Guard.AgainstEmpty(value, nameof(ImageUrl));
    }
}