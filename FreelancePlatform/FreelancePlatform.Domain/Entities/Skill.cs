using FreelancePlatform.Domain.Base;
using FreelancePlatform.ValueObjects.Objects;
using static System.Net.WebRequestMethods;

namespace FreelancePlatform.Domain.Entities;

public class Skill : Entity<int>
{
    public Title Name { get; private set; }

    public Skill(int id, Title name) : base(id)
    {
        Name = name;
    }

    public override string ToString() => Name.Value;
}