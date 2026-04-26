using FreelancePlatform.ValueObjects.Base;

namespace FreelancePlatform.ValueObjects.Objects;

public sealed class ReviewComment : ValueObject<string>
{
    public ReviewComment(string value) : base(value)
    {
    }
}