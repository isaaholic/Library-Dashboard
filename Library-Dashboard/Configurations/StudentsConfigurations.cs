using Library_Dashboard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_Dashboard.Configurations;

public class StudentsConfigurations : IEntityTypeConfiguration<Students>
{
    public void Configure(EntityTypeBuilder<Students> builder)
    {
        builder.HasOne(x => x.Group)
        .WithMany(g => g.Students)
        .HasForeignKey(x => x.Id_Group);
    }
}
