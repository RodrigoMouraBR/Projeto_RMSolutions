using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RM.Data.Extensions;
using RM.Domain.Models;
namespace RM.Data.Mappings
{
    public class AddressMapping : EntityTypeConfiguration<Address>
    {
        public override void Map(EntityTypeBuilder<Address> builder)
        {
           builder.HasKey(a=>a.Id);
           builder.Property(c=>c.Street)
            .HasColumnType("varchar(80)")
            .IsRequired();
            builder.Property(c=>c.Number)
            .HasColumnType("char(10)")
            .IsRequired();
            builder.Property(c=>c.City)
            .HasColumnType("varchar(50)")
            .IsRequired();
            builder.Property(c=>c.State)
            .HasColumnType("varchar(30)")
            .IsRequired();
            builder.Property(c=>c.ZipCode)
            .HasColumnType("char(20)")
            .IsRequired();
            builder.Property(c=>c.ZipCode)
            .HasColumnType("char(20)")
            .IsRequired();

             builder.HasOne(c=>c.Customer)
             .WithMany(e=>e.Address)
             .HasForeignKey(c=>c.CustomerId)
             .IsRequired();

            builder.Ignore(c=>c.ValidationResult);
            builder.Ignore(c=>c.CascadeMode);
            builder.ToTable("Address");
        }
    }
}