#region Heritage
using Balta.ContentContext;

var course = new Course();
course.Title = string.Empty;
course.Url = string.Empty;
#endregion

#region WorkingWithLists

foreach (var item in course.Modules)
{
    
}

#endregion

#region ModelingCareer

var career = new Career();
career.CareerItems.Add(new CareerItem());
Console.WriteLine($"Total: {career.Total}");
#endregion
