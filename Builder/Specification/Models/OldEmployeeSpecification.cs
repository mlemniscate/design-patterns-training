using Specification.Framework;

namespace Specification.Models;

public class OldEmployeeSpecification : Specification<Employee>
{

    public override bool IsSatisfiedBy(Employee employee)
    {
        return employee.Age > 50;
    }
}