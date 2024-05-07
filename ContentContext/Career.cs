namespace Balta.ContentContext;

public class Career : Content
{
    public IList<CareerItem> CareerItems { get; set; }

    public int Total => CareerItems.Count;

    public Career(string title, string url): base(title, url)
    {
        CareerItems = new List<CareerItem>();
    }
}