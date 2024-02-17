using Specification.Framework;

namespace Specification.Models;

public class YoungEmployeeSpecification : Specification<Employee>
{
    public override bool IsSatisfiedBy(Employee employee)
    {
        return employee.Age < 18;
    }
}