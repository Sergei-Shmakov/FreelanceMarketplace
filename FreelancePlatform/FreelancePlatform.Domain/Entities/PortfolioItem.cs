using FreelancePlatform.Domain.Base;
using FreelancePlatform.ValueObjects.Objects;
using static System.Net.WebRequestMethods;

namespace FreelancePlatform.Domain.Entities;

public class PortfolioItem : Entity<int>
{
    public Title Title { get; private set; }
    public Description Description { get; private set; }
    public ImageUrl ImageUrl { get; private set; }

    public PortfolioItem(
        int id,
        Title title,
        Description description,
        ImageUrl imageUrl) : base(id)
    {
        Title = title;
        Description = description;
        ImageUrl = imageUrl;
    }
}