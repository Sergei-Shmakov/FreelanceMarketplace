using FreelancePlatform.Domain.Base;
using FreelancePlatform.Domain.Enums;
using FreelancePlatform.Domain.Entities;
using System.Net.NetworkInformation;

namespace FreelancePlatform.Domain.Exceptions;

public class OrderClosedException : DomainException
{
    public OrderClosedException(int orderId, OrderStatus status)
        : base(
            $"Невозможно отправить отклик на заказ №{orderId}. " +
            $"Текущий статус заказа: '{status}'. " +
            $"Отклики принимаются только для открытых заказов.")
    {
    }
}