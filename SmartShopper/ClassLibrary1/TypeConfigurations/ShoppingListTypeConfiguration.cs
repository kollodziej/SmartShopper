using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartShopperDomain.Entities;

namespace SmartShopperInfrastructure.TypeConfigurations
{
    internal class ShoppingListTypeConfiguration : IEntityTypeConfiguration<ShoppingList>
    {
        public void Configure(EntityTypeBuilder<ShoppingList> builder)
        {
            builder.ToTable("ShoppingLists", "ShoppingPlanning");
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name);
            builder.HasMany(c => c.ListItems).WithOne().HasForeignKey("FK_ShoppingListId");
        }
    }
}
