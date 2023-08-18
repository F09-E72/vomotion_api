using System.ComponentModel.DataAnnotations.Schema;

namespace Vomotion.Domain.Entities;

public sealed class Note : BaseDate<Note>
{
    public Note(
        string titleOriginal,
        string contentOriginal,
        int[] highlitedPositionsOriginal,
        string titleTranslated,
        string contentTranslated,
        int[] highlightedPositionsTranslated)
    {
        TitleOriginal = titleOriginal;
        ContentOriginal = contentOriginal;
        HighlitedPositionsOriginal = highlitedPositionsOriginal;
        TitleTranslated = titleTranslated;
        ContentTranslated = contentTranslated;
        HighlightedPositionsTranslated = highlightedPositionsTranslated;
    }

    public string TitleOriginal { get; private set; }
    public string ContentOriginal { get; private set; }
    public int[] HighlitedPositionsOriginal { get; private set; }
    public string TitleTranslated { get; private set; }
    public string ContentTranslated { get; private set; }
    public int[] HighlightedPositionsTranslated { get; private set; }
    public int UserId { get; private set; }
    [ForeignKey("UserId")]
    public User? User { get; private set; }
    public int NotebookId { get; private set; }
    [ForeignKey("NotebookId")]
    public Notebook? Notebook { get; private set; }
    public IEnumerable<FlashCard>? Flashcards { get; private set; }
}
