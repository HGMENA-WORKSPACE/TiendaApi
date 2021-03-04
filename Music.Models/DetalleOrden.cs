namespace Music.Models
{
    /// <summary>
    /// Defines the <see cref="DetalleOrden" />.
    /// </summary>
    public class DetalleOrden
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

        /// <summary>
        /// Gets or sets the Orden.
        /// </summary>
        public virtual Orden Orden { get; set; }

        /// <summary>
        /// Gets or sets the Producto.
        /// </summary>
        public virtual Producto Producto { get; set; }
    }
}
