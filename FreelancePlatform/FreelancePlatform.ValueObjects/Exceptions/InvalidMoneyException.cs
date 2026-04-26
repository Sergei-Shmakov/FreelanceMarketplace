namespace FreelancePlatform.ValueObjects.Exceptions;

public class InvalidMoneyException : ValidationException
{
    public InvalidMoneyException()
        : base("Сумма должна быть больше нуля.")
    {
    }
}