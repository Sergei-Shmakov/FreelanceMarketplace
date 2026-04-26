using FreelancePlatform.Domain.Entities;

namespace FreelancePlatform.Domain.Repositories.Abstractions;

public interface IOrderRepository
{
    Task<Order?> GetByIdAsync(int id);

    Task AddAsync(Order order);

    Task UpdateAsync(Order order);
}