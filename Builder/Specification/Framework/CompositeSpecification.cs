namespace Specification.Framework;

public abstract class CompositeSpecification<T> : Specification<T>
{
    public readonly ISpecification<T> _right;
    public readonly ISpecification<T> _left;

    protected CompositeSpecification(ISpecification<T> right, ISpecification<T> left)
    {
        _right = right;
        _left = left;
    }
}