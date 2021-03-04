using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Music.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Music.Data.Configuration
{
    public class PerfilConfiguration : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> entity)
        {
            entity.ToTable("Perfil", "tienda");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        }
    }
}
