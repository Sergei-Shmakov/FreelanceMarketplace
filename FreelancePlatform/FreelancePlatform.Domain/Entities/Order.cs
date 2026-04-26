using FreelancePlatform.Domain.Base;
using FreelancePlatform.Domain.Enums;
using FreelancePlatform.ValueObjects.Objects;
using static System.Net.WebRequestMethods;

namespace FreelancePlatform.Domain.Entities;

public class Order : Entity<int>
{
    private readonly List<Proposal> _proposals = [];

    public User Client { get; private set; }
    public Title Title { get; private set; }
    public Description Description { get; private set; }
    public Money Budget { get; private set; }
    public CategoryName Category { get; private set; }

    public OrderStatus Status { get; private set; }

    public IReadOnlyCollection<Proposal> Proposals => _proposals.AsReadOnly();

    public Order(
        int id,
        User client,
        Title title,
        Description description,
        Money budget,
        CategoryName category) : base(id)
    {
        Client = client;
        Title = title;
        Description = description;
        Budget = budget;
        Category = category;

        Status = OrderStatus.Open;
    }

    public void AddProposal(Proposal proposal)
    {
        _proposals.Add(proposal);
    }

    public Contract AcceptProposal(Proposal proposal, int contractId)
    {
        proposal.Accept();
        Status = OrderStatus.InProgress;

        return new Contract(contractId, this, Client, proposal.Freelancer);
    }

    public void Complete()
    {
        Status = OrderStatus.Completed;
    }
}