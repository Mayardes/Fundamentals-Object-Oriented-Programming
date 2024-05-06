namespace Balta.ContentContext;

public class Course : Content
{
    public Course()
    {
        this.Modules = new List<Module>();
    }
    public string Tag { get; set; }
    public IList<Module> Modules { get; set; }
}