using System.Text.RegularExpressions;
using FreelancePlatform.ValueObjects.Exceptions;

namespace FreelancePlatform.ValueObjects.Validators;

public static class Guard
{
    public static void AgainstEmpty(string value, string fieldName)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new EmptyValueException(fieldName);
    }

    public static void AgainstInvalidEmail(string email)
    {
        var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        if (!Regex.IsMatch(email, pattern))
            throw new InvalidEmailException();
    }

    public static void AgainstInvalidMoney(decimal value)
    {
        if (value <= 0)
            throw new InvalidMoneyException();
    }

    public static void AgainstInvalidUrl(string url)
    {
        if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
            throw new InvalidUrlException();
    }
}