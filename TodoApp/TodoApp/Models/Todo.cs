namespace TodoApp.Models;

public class Todo
{
    public int Id { get; private set; }
    
    public string Title { get; private set; }
    
    public string Description { get; private set; }

    public DateTime Created { get; private set; }

    public bool  IsDone { get; private set; }

    public Todo(string title, string description)
    {
        Title = title;
        Description = description;
        Created = DateTime.UtcNow;
        IsDone = false;
    }

    public void Complete()
    {
        IsDone = true;
    }
    
    public void Update(string title, string description)
    {
        Title = title;
        Description = description;
    }
}