namespace Music.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Music.Models;

    /// <summary>
    /// Defines the <see cref="PerfilConfiguration" />.
    /// </summary>
    public class PerfilConfiguration : IEntityTypeConfiguration<Perfil>
    {
        /// <summary>
        /// The Configure.
        /// </summary>
        /// <param name="entity">The entity<see cref="EntityTypeBuilder{Perfil}"/>.</param>
        public void Configure(EntityTypeBuilder<Perfil> entity)
        {
            entity.ToTable("Perfil", "tienda");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        }
    }
}
