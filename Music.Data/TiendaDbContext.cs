namespace Music.Data
{
    using Microsoft.EntityFrameworkCore;
    using Music.Data.Configuration;
    using Music.Models;

    /// <summary>
    /// Defines the <see cref="TiendaDbContext" />.
    /// </summary>
    public partial class TiendaDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TiendaDbContext"/> class.
        /// </summary>
        public TiendaDbContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TiendaDbContext"/> class.
        /// </summary>
        /// <param name="options">The options<see cref="DbContextOptions{TiendaDbContext}"/>.</param>
        public TiendaDbContext(DbContextOptions<TiendaDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the DetallesOrden.
        /// </summary>
        public virtual DbSet<DetalleOrden> DetallesOrden { get; set; }

        /// <summary>
        /// Gets or sets the Ordenes.
        /// </summary>
        public virtual DbSet<Orden> Ordenes { get; set; }

        /// <summary>
        /// Gets or sets the Perfiles.
        /// </summary>
        public virtual DbSet<Perfil> Perfiles { get; set; }

        /// <summary>
        /// Gets or sets the Productos.
        /// </summary>
        public virtual DbSet<Producto> Productos { get; set; }

        /// <summary>
        /// Gets or sets the Usuarios.
        /// </summary>
        public virtual DbSet<Usuario> Usuarios { get; set; }

        /// <summary>
        /// The OnModelCreating.
        /// </summary>
        /// <param name="modelBuilder">The modelBuilder<see cref="ModelBuilder"/>.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.ApplyConfiguration(new DetalleOrdenConfiguration());
            modelBuilder.ApplyConfiguration(new OrdenConfiguration());
            modelBuilder.ApplyConfiguration(new PerfilConfiguration());
            modelBuilder.ApplyConfiguration(new ProductoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        /// <summary>
        /// The OnModelCreatingPartial.
        /// </summary>
        /// <param name="modelBuilder">The modelBuilder<see cref="ModelBuilder"/>.</param>
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
