using Balta.NotificationContext;

namespace Balta.ContentContext;

public class Article : Base
{
    public IList<Notification> Notifications { get; set; }
    public Article(string title, string url)
    {
    }
}