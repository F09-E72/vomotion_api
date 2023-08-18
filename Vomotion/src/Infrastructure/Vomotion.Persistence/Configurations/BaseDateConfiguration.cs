using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vomotion.Domain.Entities;

namespace Vomotion.Persistence.Configurations;

internal abstract class BaseDateConfiguration<T> : IEntityTypeConfiguration<T> 
    where T : BaseDate<T>
{
    public void Configure(EntityTypeBuilder<T> builder)
    {
        builder.ToTable(typeof(T).FullName);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.DateAdded).ValueGeneratedOnAdd();
        builder.Property(x => x.DateUpdated).ValueGeneratedOnAddOrUpdate();
    }
}
