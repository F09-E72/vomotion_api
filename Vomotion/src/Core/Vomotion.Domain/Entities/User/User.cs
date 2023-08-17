namespace Vomotion.Domain.Entities;

public sealed class User : Base<User>
{
    public User(
        string firstName,
        string lastName,
        string email,
        byte[] password,
        string username,
        Language nativeLanguage,
        List<Language> targetLanguages,
        Notebook notebooks)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        Username = username;
        NativeLanguage = nativeLanguage;
        TargetLanguages = targetLanguages;
        Notebooks = notebooks;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public byte[] Password { get; private set; }
    public string Username { get; private set; }
    public Language NativeLanguage { get; private set; }
    public List<Language> TargetLanguages { get; private set; }
    public Notebook Notebooks { get; private set; }
}
