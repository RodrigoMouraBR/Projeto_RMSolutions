using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RM.Data.Extensions
{
    public abstract class EntityTypeConfiguration<TEntity> where TEntity : class
    {
        public abstract void Map(EntityTypeBuilder<TEntity> builder);
    }
}