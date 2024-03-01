namespace Escalouve.Domain.Shared.Exceptions;

public class ServiceValidationException : Exception
{
    public ServiceValidationException(string error) : base(error)
    {
    }

    public static void When(bool hasError, string error)
    {
        if (hasError)
            throw new ServiceValidationException(error);
    }
}

