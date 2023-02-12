using Library_Dashboard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_Dashboard.Configurations;

public class TCardsConfigurations : IEntityTypeConfiguration<T_Cards>
{
    public void Configure(EntityTypeBuilder<T_Cards> builder)
    {
        builder.HasOne(x => x.Teachers)
        .WithMany(g => g.T_Cards)
        .HasForeignKey(x => x.Id_Teacher);

        builder.HasOne(x => x.Book)
       .WithMany(g => g.T_Cards)
       .HasForeignKey(x => x.Id_Book);

        builder.HasOne(x => x.Lib)
       .WithMany(g => g.T_Cards)
       .HasForeignKey(x => x.Id_Lib);
    }
}
