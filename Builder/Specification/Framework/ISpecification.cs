namespace Specification.Framework;

public interface ISpecification<in T>
{
    bool IsSatisfiedBy(T value);
}