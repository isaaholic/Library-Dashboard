using Library_Dashboard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_Dashboard.Configurations;

public class SCardsConfigurations : IEntityTypeConfiguration<S_Cards>
{
    public void Configure(EntityTypeBuilder<S_Cards> builder)
    {
        builder.HasOne(x => x.Student)
        .WithMany(g => g.S_Cards)
        .HasForeignKey(x => x.Id_Student);

        builder.HasOne(x => x.Book)
       .WithMany(g => g.S_Cards)
       .HasForeignKey(x => x.Id_Book);

        builder.HasOne(x => x.Lib)
       .WithMany(g => g.S_Cards)
       .HasForeignKey(x => x.Id_Lib);

    }
}
