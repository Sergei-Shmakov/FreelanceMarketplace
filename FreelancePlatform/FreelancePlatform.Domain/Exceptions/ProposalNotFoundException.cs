using FreelancePlatform.Domain.Base;

namespace FreelancePlatform.Domain.Exceptions;

public class ProposalNotFoundException : DomainException
{
    public ProposalNotFoundException(int proposalId, int orderId)
        : base(
            $"Отклик №{proposalId} не найден среди откликов заказа №{orderId}. " +
            $"Невозможно принять несуществующий отклик.")
    {
    }
}