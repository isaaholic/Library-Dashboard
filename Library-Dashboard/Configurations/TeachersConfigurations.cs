using Library_Dashboard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_Dashboard.Configurations;

public class TeachersConfigurations : IEntityTypeConfiguration<Teachers>
{
    public void Configure(EntityTypeBuilder<Teachers> builder)
    {

        builder.HasOne(x => x.Departments)
        .WithMany(g => g.Teacher)
        .HasForeignKey(x => x.Id_Dep);
    }
}
