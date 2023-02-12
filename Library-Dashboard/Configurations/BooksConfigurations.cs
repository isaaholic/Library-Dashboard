using Library_Dashboard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_Dashboard.Configurations;

public class BooksConfigurations : IEntityTypeConfiguration<Books>
{
    public void Configure(EntityTypeBuilder<Books> builder)
    {
        builder.Property(x => x.Id_Press).IsRequired();
        builder.Property(x => x.Id_Category).IsRequired();
        builder.Property(x => x.Id_Themes).IsRequired();
        builder.Property(x => x.Id_Author).IsRequired();

        builder.HasOne(x => x.Theme)
       .WithMany(g => g.Books)
       .HasForeignKey(x => x.Id_Themes);

        builder.HasOne(x => x.Authors)
      .WithMany(g => g.Books)
      .HasForeignKey(x => x.Id_Author);

        builder.HasOne(x => x.Categories)
      .WithMany(g => g.Books)
      .HasForeignKey(x => x.Id_Category);

        builder.HasOne(x => x.Press)
      .WithMany(g => g.Books)
      .HasForeignKey(x => x.Id_Press);
    }
}
