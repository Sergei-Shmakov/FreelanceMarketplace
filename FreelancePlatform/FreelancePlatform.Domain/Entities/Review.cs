using FreelancePlatform.Domain.Base;
using FreelancePlatform.ValueObjects.Objects;

namespace FreelancePlatform.Domain.Entities;

public class Review : Entity<int>
{
    public Contract Contract { get; private set; }

    public User Reviewer { get; private set; }
    public User TargetUser { get; private set; }

    public int Rating { get; private set; }
    public ReviewComment Comment { get; private set; }

    public Review(
        int id,
        Contract contract,
        User reviewer,
        User targetUser,
        int rating,
        ReviewComment comment) : base(id)
    {
        Contract = contract;
        Reviewer = reviewer;
        TargetUser = targetUser;
        Rating = rating;
        Comment = comment;
    }
}