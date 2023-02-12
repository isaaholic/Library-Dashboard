using Library_Dashboard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_Dashboard.Configurations;

public class GroupsConfigurations : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasOne(x => x.Faculties)
       .WithMany(g => g.Group)
       .HasForeignKey(x => x.Id_Faculty);
    }
}
