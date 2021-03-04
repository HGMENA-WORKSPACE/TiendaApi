namespace Music.Models
{
    using Music.Models.Enum;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Usuario" />.
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Usuario"/> class.
        /// </summary>
        public Usuario()
        {
            Ordens = new HashSet<Orden>();
        }

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Nombre.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or sets the Apellidos.
        /// </summary>
        public string Apellidos { get; set; }

        /// <summary>
        /// Gets or sets the Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the Username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the Estatus.
        /// </summary>
        public EstatusUsuario Estatus { get; set; }

        /// <summary>
        /// Gets or sets the PerfilId.
        /// </summary>
        public int PerfilId { get; set; }

        /// <summary>
        /// Gets or sets the Perfil.
        /// </summary>
        public virtual Perfil Perfil { get; set; }

        /// <summary>
        /// Gets or sets the Ordens.
        /// </summary>
        public virtual ICollection<Orden> Ordens { get; set; }
    }
}
