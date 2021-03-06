namespace Music.Dto
{
    /// <summary>
    /// Defines the <see cref="DetalleOrdenDto" />.
    /// </summary>
    public class DetalleOrdenDto
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the OrdenId.
        /// </summary>
        public int OrdenId { get; set; }

        /// <summary>
        /// Gets or sets the ProductoId.
        /// </summary>
        public int ProductoId { get; set; }

        /// <summary>
        /// Gets or sets the Cantidad.
        /// </summary>
        public decimal Cantidad { get; set; }

        /// <summary>
        /// Gets or sets the PrecioUnitario.
        /// </summary>
        public decimal PrecioUnitario { get; set; }

        /// <summary>
        /// Gets or sets the Total.
        /// </summary>
        public decimal Total { get; set; }
    }
}
