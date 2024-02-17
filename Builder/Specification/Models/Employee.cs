namespace Specification.Models;

public class Employee
{
    public long Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Employee(long id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
        if (new OldEmployeeSpecification()
            .Or(new YoungEmployeeSpecification())
            .IsSatisfiedBy(this))
        {
            throw new Exception("Employee age is not good for being our employee");
        }
    }
}