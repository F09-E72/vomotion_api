namespace Vomotion.Domain.Entities;

public sealed class Notebook : BaseDate<Notebook>
{
    public Notebook(Note[] notes, User user, string title)
    {
        Notes = notes;
        User = user;
        Title = title;
    }

    public Note[] Notes { get; private set; }
    public User User { get; private set; }
    public string Title { get; private set; }
}
