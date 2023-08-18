using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vomotion.Domain.Entities;

namespace Vomotion.Persistence.Configurations;

internal abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T>
    where T : Base<T>
{
    public void Configure(EntityTypeBuilder<T> builder)
    {
        builder.ToTable(typeof(T).FullName);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
    }
}
