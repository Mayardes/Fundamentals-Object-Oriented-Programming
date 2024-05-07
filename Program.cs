#region Heritage
using Balta.ContentContext;

var course = new Course(string.Empty, string.Empty);
course.Title = string.Empty;
course.Url = string.Empty;
#endregion

#region WorkingWithLists

foreach (var item in course.Modules)
{
    
}

#endregion

#region ModelingCareer

var career = new Career(string.Empty, string.Empty);
career.CareerItems.Add(new CareerItem());
Console.WriteLine($"Total: {career.Total}");
#endregion

#region ConstructorMethod
var articles = new List<Article>();
articles.Add(new Article("Article about Object-Oriented programming", "http://..."));

foreach (var article in articles)
{
    Console.WriteLine($"Id: {article.Id}");
    Console.WriteLine($"Title: {article.Title}");
    Console.WriteLine($"Url: {article.Url}");
}
#endregion