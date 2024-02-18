namespace Specification.Framework;

public class AndSpecification<T> : CompositeSpecification<T>
{
    public AndSpecification(ISpecification<T> right, ISpecification<T> left) : base(right, left)
    {
    }

    public override bool IsSatisfiedBy(T value)
    {
        return _right.IsSatisfiedBy(value) &&
               _left.IsSatisfiedBy(value);
    }
}