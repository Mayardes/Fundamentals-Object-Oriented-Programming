using Balta.ContentContext;
using Balta.NotificationContext;

namespace Balta.SubscriptionContext;

public class Student : Base
{
    public string Name { get; set; }
    public string Email { get; set; }
    public User User { get; set; }
    public IList<Subscription> Subscriptions { get; set; }
    public bool IsPremium => Subscriptions.Any(x => x.IsActive);

    public void CreateSubscription(Subscription subscription)
    {
        if (IsPremium)
        {
            AddNotification(new Notification("Subscription", "You already premium!"));
            return;
        }
            Subscriptions.Add(subscription);
    }
    public Student()
    {
        Subscriptions = new List<Subscription>();
    }
}