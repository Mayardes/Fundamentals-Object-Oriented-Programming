namespace Balta.ContentContext;

public class Lecture
{
    public Lecture()
    {
        Lectures = new List<Lecture>();
    }
    public int Order { get; set; }
    public string Title { get; set; }
    public IList<Lecture> Lectures { get; set; }
}