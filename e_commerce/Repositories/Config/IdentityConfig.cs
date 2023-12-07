using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class IdentityConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole{Name="user",NormalizedName="USER"},
                new IdentityRole{Name="Editor",NormalizedName="EDITOR"},
                new IdentityRole{Name="Admin",NormalizedName="ADMIN"}
            );
        }
    }
}