namespace Vomotion.Domain.Entities;

public sealed class Language : Base<Language>
{
    public Language(string nameEn, string nameOriginal)
    {
        NameEn = nameEn;
        NameOriginal = nameOriginal;
    }

    public string NameEn { get; private set; }
    public string NameOriginal { get; private set; }
}
