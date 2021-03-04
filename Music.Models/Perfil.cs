namespace Music.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Perfil" />.
    /// </summary>
    public class Perfil
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Perfil"/> class.
        /// </summary>
        public Perfil()
        {
            Usuarios = new HashSet<Usuario>();
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
        /// Gets or sets the Usuarios.
        /// </summary>
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
