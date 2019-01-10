using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RM.Data.Extensions;
using RM.Domain.Models;
namespace RM.Data.Mappings
{
    public class CustomerMapping : EntityTypeConfiguration<Customer>
    {
        public override void Map(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c=>c.Id);
            builder.Property(c=>c.FirstName)
            .HasColumnType("varchar(80)")
            .IsRequired();
            builder.Property(c=>c.LastName)
            .HasColumnType("varchar(80)")
            .IsRequired();
            builder.Property(c=>c.Email)
            .HasColumnType("varchar(80)")
            .IsRequired();
            builder.Property(c=>c.Document)
            .HasColumnType("varchar(20)")
            .IsRequired();
            builder.Ignore(c=>c.ValidationResult);
            builder.Ignore(c=>c.CascadeMode);
            builder.ToTable("Customer");
        }
    }
}