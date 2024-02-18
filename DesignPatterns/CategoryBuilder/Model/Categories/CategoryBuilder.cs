namespace CategoryBuilder.Model.Categories;

public class CategoryBuilder : 
    ICategoryParentBuilder,
    ICategoryTitleBuilder,
    ICategoryExpertBuilder,
    ICategoryTagBuilder
{
    private Category _category;

    public ICategoryTitleBuilder CreateRootCategory()
    {
        _category = new Category();
        _category.Parent = null;
        return _category as ICategoryTitleBuilder;
    }

    public ICategoryParentBuilder CreateNonRootCategory()
    {
        _category = new Category();
        return _category as ICategoryParentBuilder;
    }

    ICategoryExpertBuilder ICategoryTitleBuilder.WithTitle(string title)
    {
        _category.Title = title;
        return _category as ICategoryExpertBuilder;
    }

    ICategoryTagBuilder ICategoryExpertBuilder.WithExperts(List<Expert> experts)
    {
        _category.Experts = experts;
        return _category as ICategoryTagBuilder;
    }

    ICategoryTitleBuilder ICategoryParentBuilder.WithParent(Category? parent)
    {
        _category.Parent = parent;
        return _category as ICategoryTitleBuilder;
    }
}

public interface ICategoryParentBuilder
{
    public ICategoryTitleBuilder WithParent(Category? parent);
}

public interface ICategoryTitleBuilder
{
    public ICategoryExpertBuilder WithTitle(string title);
}

public interface ICategoryExpertBuilder
{
    public ICategoryTagBuilder WithExperts(List<Expert> experts);
}

public interface ICategoryTagBuilder
{
}
