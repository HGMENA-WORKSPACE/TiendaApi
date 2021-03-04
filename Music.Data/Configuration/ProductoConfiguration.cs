namespace Music.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Music.Models;

    /// <summary>
    /// Defines the <see cref="ProductoConfiguration" />.
    /// </summary>
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        /// <summary>
        /// The Configure.
        /// </summary>
        /// <param name="entity">The entity<see cref="EntityTypeBuilder{Producto}"/>.</param>
        public void Configure(EntityTypeBuilder<Producto> entity)
        {
            entity.ToTable("Producto", "tienda");

            entity.Property(e => e.Nombre).HasMaxLength(256);

            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
        }
    }
}
