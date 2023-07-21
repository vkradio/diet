using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VkRadio.Diet.Model.Entities;

namespace VkRadio.Diet.Infrastructure.Data.Config;

public class FoodConfiguration : IEntityTypeConfiguration<Food>
{
    public void Configure(EntityTypeBuilder<Food> builder)
    {
        builder
            .HasIndex(e => e.Name)
            .IsUnique();
    }
}
