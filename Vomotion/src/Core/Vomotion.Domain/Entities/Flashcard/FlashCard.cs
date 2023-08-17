namespace Vomotion.Domain.Entities;

public sealed class FlashCard : Base<FlashCard>
{
    public FlashCard(
        Note note,
        string frontWord,
        string backWord,
        string frontSentence,
        string backSentence,
        FlashCardState flashCardState)
    {
        Note = note;
        FrontWord = frontWord;
        BackWord = backWord;
        FrontSentence = frontSentence;
        BackSentence = backSentence;
        FlashCardState = flashCardState;
    }

    public Note Note { get; private set; }
    public string FrontWord { get; private set; }
    public string BackWord { get; private set; }
    public string FrontSentence { get; private set; }
    public string BackSentence { get; private set; }
    public FlashCardState FlashCardState { get; private set; }
}
