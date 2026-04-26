namespace FreelancePlatform.ValueObjects.Exceptions;

public class InvalidEmailException : ValidationException
{
    public InvalidEmailException()
        : base("Некорректный адрес электронной почты.")
    {
    }
}