namespace CategoryBuilder.Model.Categories
{
    public class Category
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public Category? Parent { get; set; }
        public List<Category> Children { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Expert> Experts { get; set; }
        public List<Feature> Features { get; set; }
    }
}