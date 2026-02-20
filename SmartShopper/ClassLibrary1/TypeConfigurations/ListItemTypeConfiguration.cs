using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartShopperDomain.ValueObjects;

namespace SmartShopperInfrastructure.TypeConfigurations
{
    internal class ListItemTypeConfiguration : IEntityTypeConfiguration<ListItem>
    {
        public void Configure(EntityTypeBuilder<ListItem> builder)
        {
            builder.ToTable("ListItems", "ShoppingPlanning");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id);
            builder.Property(c => c.Quantity);
            builder.Property(c => c.IsChecked);
            
            // Jawnie zdefiniuj shadow properties dla FK
            builder.Property<int>("FK_ShoppingListId");
            builder.Property<int>("FK_ProductId");
            
            builder.HasOne(c => c.Product)
                   .WithMany()
                   .HasForeignKey("FK_ProductId");
        }
    }
}
