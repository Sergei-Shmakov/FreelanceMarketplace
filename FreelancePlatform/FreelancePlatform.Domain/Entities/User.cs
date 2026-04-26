using FreelancePlatform.Domain.Base;
using FreelancePlatform.Domain.Enums;
using FreelancePlatform.ValueObjects.Objects;

namespace FreelancePlatform.Domain.Entities;

public class User : Entity<int>
{
    private readonly List<Skill> _skills = [];
    private readonly List<PortfolioItem> _portfolio = [];
    private readonly List<Review> _reviews = [];

    public UserName Name { get; private set; }
    public Email Email { get; private set; }
    public PasswordHash PasswordHash { get; private set; }
    public UserRole Role { get; private set; }

    public IReadOnlyCollection<Skill> Skills => _skills.AsReadOnly();
    public IReadOnlyCollection<PortfolioItem> Portfolio => _portfolio.AsReadOnly();
    public IReadOnlyCollection<Review> Reviews => _reviews.AsReadOnly();

    public decimal Rating =>
        _reviews.Count == 0
            ? 0m
            : Math.Round(_reviews.Average(x => (decimal)x.Rating), 2);

    public User(
        int id,
        UserName name,
        Email email,
        PasswordHash passwordHash,
        UserRole role) : base(id)
    {
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
    }

    public void AddSkill(Skill skill) => _skills.Add(skill);

    public void AddPortfolioItem(PortfolioItem item) => _portfolio.Add(item);

    public void AddReview(Review review) => _reviews.Add(review);
}