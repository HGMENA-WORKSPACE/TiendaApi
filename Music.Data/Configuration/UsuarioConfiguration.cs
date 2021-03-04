namespace Music.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Music.Models;

    /// <summary>
    /// Defines the <see cref="UsuarioConfiguration" />.
    /// </summary>
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        /// <summary>
        /// The Configure.
        /// </summary>
        /// <param name="entity">The entity<see cref="EntityTypeBuilder{Usuario}"/>.</param>
        public void Configure(EntityTypeBuilder<Usuario> entity)
        {
            entity.ToTable("Usuario", "tienda");

            entity.HasIndex(e => e.PerfilId, "IX_Usuario_PerfilId");

            entity.Property(e => e.Apellidos).HasMaxLength(256);

            entity.Property(e => e.Email).HasMaxLength(100);

            entity.Property(e => e.Nombre).HasMaxLength(50);

            entity.Property(e => e.Password).HasMaxLength(512);

            entity.Property(e => e.Username).HasMaxLength(25);

            entity.HasOne(d => d.Perfil)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.PerfilId);
        }
    }
}
