namespace Vomotion.Domain.Entities;

public abstract class BaseDate<T> : Base<T>
{
    public DateTime DateAdded { get; set; }
    public DateTime DateUpdated { get; set; }
}
