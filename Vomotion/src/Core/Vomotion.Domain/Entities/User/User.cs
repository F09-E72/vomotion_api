using System.ComponentModel.DataAnnotations.Schema;

namespace Vomotion.Domain.Entities;

public sealed class User : BaseDate<User>
{
    public User(
        string firstName,
        string lastName,
        string email,
        byte[] password,
        string username)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        Username = username;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public byte[] Password { get; private set; }
    public string Username { get; private set; }
    public int NativeLanguageId { get; private set; }
    [ForeignKey("NativeLanguageId")]
    public Language? NativeLanguage { get; private set; }
    public IEnumerable<Language>? TargetLanguages { get; private set; }
    public int NotebookId { get; private set; }
    [ForeignKey("NotebookId")]
    public Notebook? Notebook { get; private set; }
}
