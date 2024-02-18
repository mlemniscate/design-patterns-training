namespace Specification.Framework;

public class OrSpecification<T> : CompositeSpecification<T>
{
    public OrSpecification(ISpecification<T> right, ISpecification<T> left) : base(right, left)
    {
    }

    public override bool IsSatisfiedBy(T value)
    {
        return _right.IsSatisfiedBy(value) || 
               _left.IsSatisfiedBy(value);
    }
}