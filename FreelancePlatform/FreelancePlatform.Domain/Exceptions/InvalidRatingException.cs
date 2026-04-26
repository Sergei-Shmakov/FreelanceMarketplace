using FreelancePlatform.Domain.Base;

namespace FreelancePlatform.Domain.Exceptions;

public class InvalidRatingException : DomainException
{
    public InvalidRatingException(int rating)
        : base(
            $"Недопустимая оценка: {rating}. " +
            $"Допустимое значение — целое число от 1 до 5.")
    {
    }
}