using System.ComponentModel.DataAnnotations.Schema;

namespace Vomotion.Domain.Entities;

public sealed class FlashCard : BaseDate<FlashCard>
{
    public FlashCard(
        string frontWord,
        string backWord,
        string frontSentence,
        string backSentence,
        int severity)
    {
        FrontWord = frontWord;
        BackWord = backWord;
        FrontSentence = frontSentence;
        BackSentence = backSentence;
        Severity = severity;
    }

    public string FrontWord { get; private set; }
    public string BackWord { get; private set; }
    public string FrontSentence { get; private set; }
    public string BackSentence { get; private set; }
    public int Severity { get; private set; }
    public int NoteId { get; private set; }
    [ForeignKey("NoteId")]
    public Note? Note { get; private set; }
}
