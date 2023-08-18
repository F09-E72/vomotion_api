using System.ComponentModel.DataAnnotations.Schema;

namespace Vomotion.Domain.Entities;

public sealed class Notebook : BaseDate<Notebook>
{
    public Notebook(
        int userId,
        string title)
    {
        UserId = userId;
        Title = title;
    }

    public IEnumerable<Note>? Notes { get; private set; }
    public int UserId { get; private set; }
    [ForeignKey("UserId")]
    public User? User { get; private set; }
    public string Title { get; private set; }
}
