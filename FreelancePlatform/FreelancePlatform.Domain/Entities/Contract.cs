using FreelancePlatform.Domain.Base;
using FreelancePlatform.Domain.Enums;

namespace FreelancePlatform.Domain.Entities;

public class Contract : Entity<int>
{
    public Order Order { get; private set; }

    public User Client { get; private set; }
    public User Freelancer { get; private set; }

    public ContractStatus Status { get; private set; }

    public DateTime StartedAt { get; private set; }
    public DateTime? CompletedAt { get; private set; }

    public Contract(
        int id,
        Order order,
        User client,
        User freelancer) : base(id)
    {
        Order = order;
        Client = client;
        Freelancer = freelancer;

        StartedAt = DateTime.Now;
        Status = ContractStatus.InProgress;
    }

    public void Complete()
    {
        Status = ContractStatus.Completed;
        CompletedAt = DateTime.Now;

        Order.Complete();
    }
}