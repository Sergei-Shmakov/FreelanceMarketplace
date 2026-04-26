namespace FreelancePlatform.ValueObjects.Exceptions;

public class EmptyValueException : ValidationException
{
    public EmptyValueException(string fieldName)
        : base($"Поле '{fieldName}' не может быть пустым.")
    {
    }
}