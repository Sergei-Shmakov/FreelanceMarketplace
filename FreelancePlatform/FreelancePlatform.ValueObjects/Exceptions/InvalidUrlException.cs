namespace FreelancePlatform.ValueObjects.Exceptions;

public class InvalidUrlException : ValidationException
{
    public InvalidUrlException()
        : base("Некорректный URL.")
    {
    }
}