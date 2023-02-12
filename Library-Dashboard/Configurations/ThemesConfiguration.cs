using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Library_Dashboard.Models;

public class ThemeConfiguration : IEntityTypeConfiguration<Themes>
{
    public void Configure(EntityTypeBuilder<Themes> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired();
    }
}