namespace FreelancePlatform.Domain.Base;

/// базовое доменное исключение

public abstract class DomainException : Exception
{
    protected DomainException(string message) : base(message)
    {
    }
}