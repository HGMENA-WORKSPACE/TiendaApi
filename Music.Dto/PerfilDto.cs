namespace Music.Dto
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the <see cref="PerfilDto" />.
    /// </summary>
    public class PerfilDto
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Nombre.
        /// </summary>
        [Display(Name = "Perfil")]
        [Required(ErrorMessage = "El nombre del perfil es requerido")]
        public string Nombre { get; set; }
    }
}
