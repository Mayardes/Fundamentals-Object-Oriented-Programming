namespace Balta.ContentContext;

public class CareerItem
{
    public CareerItem(int id, string title, string description, Course course)
    {
        Id = id;
        Title = title;
        Description = description;

        if (course == null)
            throw new Exception("Course can't be nullable");
        Course = course;
    }

    public int Id { get; set; }
    public int Order { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Course Course { get; set; }
}