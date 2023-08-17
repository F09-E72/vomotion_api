namespace Vomotion.Domain.Entities;

public sealed class FlashCardState : Base<FlashCardState>
{
    public FlashCardState(string[] nameEn, int severity)
    {
        NameEn = nameEn;
        Severity = severity;
    }

    public string[] NameEn { get; private set; }
    public int Severity { get; private set; }
}
