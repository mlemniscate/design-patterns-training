using Specification.Framework;

namespace Specification.Models;

public class YoungEmployeeSpecification : Specification<int>
{
    public override bool IsSatisfiedBy(int age)
    {
        return age < 18;
    }
}