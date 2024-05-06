using Balta.ContentContext.Enums;

namespace Balta.ContentContext;

public class Course : Content
{
    public Course()
    {
        Modules = new List<Module>();
    }
    public string Tag { get; set; }
    public ICollection<Module> Modules { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
}