using FreelancePlatform.Domain.Base;

namespace FreelancePlatform.Domain.Exceptions;

public class ContractAlreadyCompletedException : DomainException
{
    public ContractAlreadyCompletedException(int contractId, DateTime? completedAt)
        : base(
            $"Контракт №{contractId} уже завершен" +
            $"{(completedAt.HasValue ? $" ({completedAt.Value:G})" : "")}. " +
            $"Повторное завершение невозможно.")
    {
    }
}