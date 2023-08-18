using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vomotion.Domain.Entities;

namespace Vomotion.Persistence.Configurations;

internal sealed class UserConfiguration : BaseDateConfiguration<User>
{
    public new void Configure(EntityTypeBuilder<User> builder)
    {
        base.Configure(builder);

        builder
            .HasMany(u => u.TargetLanguages);
    }
}
