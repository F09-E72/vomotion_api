namespace Vomotion.Domain.Entities;

public sealed class Note : BaseDate<Note>
{
    public Note(
        string titleOriginal,
        string contentOriginal,
        int[] highlitedPositionsOriginal,
        string titleTranslated,
        string contentTranslated,
        int[] highlightedPositionsTranslated,
        User user,
        FlashCard[] flashcards,
        Notebook notebooks)
    {
        TitleOriginal = titleOriginal;
        ContentOriginal = contentOriginal;
        HighlitedPositionsOriginal = highlitedPositionsOriginal;
        TitleTranslated = titleTranslated;
        ContentTranslated = contentTranslated;
        HighlightedPositionsTranslated = highlightedPositionsTranslated;
        User = user;
        Flashcards = flashcards;
        Notebooks = notebooks;
    }

    public string TitleOriginal { get; private set; }
    public string ContentOriginal { get; private set; }
    public int[] HighlitedPositionsOriginal { get; private set; }
    public string TitleTranslated { get; private set; }
    public string ContentTranslated { get; private set; }
    public int[] HighlightedPositionsTranslated { get; private set; }
    public User User { get; private set; }
    public FlashCard[] Flashcards { get; private set; }
    public Notebook Notebooks { get; private set; }
}
