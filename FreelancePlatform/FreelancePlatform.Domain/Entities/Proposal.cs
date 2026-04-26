using FreelancePlatform.Domain.Base;
using FreelancePlatform.Domain.Enums;
using FreelancePlatform.ValueObjects.Objects;

namespace FreelancePlatform.Domain.Entities;

public class Proposal : Entity<int>
{
    public Order Order { get; private set; }
    public User Freelancer { get; private set; }

    public Description Message { get; private set; }
    public Money ProposedPrice { get; private set; }

    public ProposalStatus Status { get; private set; }

    public Proposal(
        int id,
        Order order,
        User freelancer,
        Description message,
        Money proposedPrice) : base(id)
    {
        Order = order;
        Freelancer = freelancer;
        Message = message;
        ProposedPrice = proposedPrice;

        Status = ProposalStatus.Pending;
    }

    public void Accept() => Status = ProposalStatus.Accepted;

    public void Reject() => Status = ProposalStatus.Rejected;
}