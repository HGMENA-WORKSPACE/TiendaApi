namespace Music.Models
{
    using Music.Models.Enum;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Producto" />.
    /// </summary>
    public class Producto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Producto"/> class.
        /// </summary>
        public Producto()
        {
            DetalleOrdens = new HashSet<DetalleOrden>();
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
        /// Gets or sets the Precio.
        /// </summary>
        public decimal Precio { get; set; }

        /// <summary>
        /// Gets or sets the Estatus.
        /// </summary>
        public StatusProducto Estatus { get; set; }

        /// <summary>
        /// Gets or sets the FechaRegistro.
        /// </summary>
        public DateTime FechaRegistro { get; set; }

        /// <summary>
        /// Gets or sets the DetalleOrdens.
        /// </summary>
        public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; }
    }
}
