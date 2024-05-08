#region Heritage
using Balta.ContentContext;
using Balta.NotificationContext;

var course = new Course(string.Empty, string.Empty);
course.Title = string.Empty;
course.Url = string.Empty;
course.AddNotification(new Notification());
course.AddNotifications(new List<Notification>(){new Notification(string.Empty, string.Empty)});

#endregion

#region WorkingWithLists

foreach (var item in course.Modules)
{
    Console.WriteLine($"{item.Title}");
}

#endregion

#region ModelingCareer

var career = new Career(string.Empty, string.Empty);
career.CareerItems.Add(new CareerItem(0, string.Empty, string.Empty, new Course("cooking", string.Empty)));
Console.WriteLine($"Total: {career.Total}");
#endregion

#region ConstructorMethod
var articles = new List<Article>();
articles.Add(new Article("Article about Object-Oriented programming", "http://..."));

foreach (var article in articles)
{
    Console.WriteLine($"Id: {article.Id}");
    // Console.WriteLine($"Title: {article.Title}");
    // Console.WriteLine($"Url: {article.Url}");
}
#endregion

#region InteractingWithLists
Console.WriteLine("Working with lists:");
var courseOOP = new Course("Course Objected-Oriented programming", "");
var courseAspNet = new Course("Course AspNet MVC programming", "");
var courseCSharp = new Course("Course CSharp programming", "");

var courses = new List<Course>();
courses.Add(courseOOP);
courses.Add(courseAspNet);
courses.Add(courseCSharp);

var careers = new List<Career>();
var specialistCareer = new Career("Specialist .Net", string.Empty);
careers.Add(specialistCareer);

var careerItem = new CareerItem(1, "Starting here", "description career item", courseAspNet);

Console.WriteLine("Show up notifications:");
foreach (var item in careerItem.Notifications)
{
    Console.WriteLine($"{item.Message}");
}

specialistCareer.CareerItems.Add(careerItem);

foreach (var car in careers)
{
    Console.WriteLine($"Id: {car.Id}");
    Console.WriteLine($"Title: {car.Title}");
    Console.WriteLine($"Url: {car.Url}");
    
    foreach (var item in car.CareerItems.OrderByDescending(x => x.Order))
    {
        Console.WriteLine($"Id: {item.Id}");
        Console.WriteLine($"Title: {item.Title}");
        Console.WriteLine($"Description: {item.Description}");
        Console.WriteLine($"Title Course: {item.Course?.Title}");
        Console.WriteLine($"Level Course: {item.Course?.Level}");
    }
}

#endregion