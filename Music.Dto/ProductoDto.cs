namespace Music.Dto
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the <see cref="ProductoDto" />.
    /// </summary>
    public class ProductoDto
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Nombre.
        /// </summary>
        [Display(Name = "Producto")]
        [Required(ErrorMessage = "El nombre del producto es requerido")]
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or sets the Precio.
        /// </summary>
        public decimal Precio { get; set; }
    }
}
