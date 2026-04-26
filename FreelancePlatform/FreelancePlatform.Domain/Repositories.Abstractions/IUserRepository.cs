using FreelancePlatform.Domain.Entities;

namespace FreelancePlatform.Domain.Repositories.Abstractions;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(int id);

    Task AddAsync(User user);

    Task UpdateAsync(User user);
}