namespace Music.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Music.Models;

    /// <summary>
    /// Defines the <see cref="OrdenConfiguration" />.
    /// </summary>
    public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
    {
        /// <summary>
        /// The Configure.
        /// </summary>
        /// <param name="entity">The entity<see cref="EntityTypeBuilder{Orden}"/>.</param>
        public void Configure(EntityTypeBuilder<Orden> entity)
        {
            entity.ToTable("Orden", "tienda");

            entity.HasIndex(e => e.UsuarioId, "IX_Orden_UsuarioId");

            entity.Property(e => e.CantidadArticulos).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Usuario)
                .WithMany(p => p.Ordens)
                .HasForeignKey(d => d.UsuarioId);
        }
    }
}
