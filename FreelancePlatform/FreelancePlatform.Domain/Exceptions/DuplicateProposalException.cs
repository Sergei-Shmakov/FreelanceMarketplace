using FreelancePlatform.Domain.Base;

namespace FreelancePlatform.Domain.Exceptions;

public class DuplicateProposalException : DomainException
{
    public DuplicateProposalException(int orderId, int freelancerId)
        : base(
            $"Исполнитель с ID {freelancerId} уже отправил отклик на заказ №{orderId}. " +
            $"Повторная отправка отклика запрещена.")
    {
    }
}