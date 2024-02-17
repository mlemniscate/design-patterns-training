using Specification.Framework;

namespace Specification.Models;

public class OldEmployeeSpecification : Specification<int>
{

    public override bool IsSatisfiedBy(int age)
    {
        return age > 50;
    }
}