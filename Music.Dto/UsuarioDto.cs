namespace Music.Dto
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the <see cref="UsuarioDto" />.
    /// </summary>
    internal class UsuarioDto
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Nombre.
        /// </summary>
        [Display(Name = "Nombre de Usuario")]
        [Required(ErrorMessage = "El nombre del perfil es requerido")]
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or sets the Apellidos.
        /// </summary>
        [Display(Name = "Apellidos de Usuario")]
        public string Apellidos { get; set; }

        /// <summary>
        /// Gets or sets the Email.
        /// </summary>
        [Display(Name = "Correo Electrónico")]
        [Required(ErrorMessage = "El email del usuario es requerido")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the Username.
        /// </summary>
        [Display(Name = "Cuenta")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the PerfilId.
        /// </summary>
        public int PerfilId { get; set; }

        /// <summary>
        /// Gets or sets the Perfil.
        /// </summary>
        public string Perfil { get; set; }
    }
}
