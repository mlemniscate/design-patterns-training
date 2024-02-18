// See https://aka.ms/new-console-template for more information

using CategoryBuilder.Model.Categories;

Console.WriteLine("Hello, World!");

new CategoryBuilder.Model.Categories.CategoryBuilder()
    .CreateRootCategory()
    .WithTitle("Root")
    .WithExperts(new List<Expert>());

new CategoryBuilder.Model.Categories.CategoryBuilder()
    .CreateNonRootCategory()
    .WithParent(new Category())
    .WithTitle("Category1")
    .WithExperts(new List<Expert>());

