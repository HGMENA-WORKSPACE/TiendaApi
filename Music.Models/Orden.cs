namespace Music.Models
{
    using Music.Models.Enum;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Orden" />.
    /// </summary>
    public class Orden
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Orden"/> class.
        /// </summary>
        public Orden()
        {
            DetalleOrdens = new HashSet<DetalleOrden>();
        }

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the CantidadArticulos.
        /// </summary>
        public decimal CantidadArticulos { get; set; }

        /// <summary>
        /// Gets or sets the Importe.
        /// </summary>
        public decimal Importe { get; set; }

        /// <summary>
        /// Gets or sets the FechaRegistro.
        /// </summary>
        public DateTime FechaRegistro { get; set; }

        /// <summary>
        /// Gets or sets the FechaActualizacion.
        /// </summary>
        public DateTime? FechaActualizacion { get; set; }

        /// <summary>
        /// Gets or sets the UsuarioId.
        /// </summary>
        public int UsuarioId { get; set; }

        /// <summary>
        /// Gets or sets the EstatusOrden.
        /// </summary>
        public EstatusOrden EstatusOrden { get; set; }

        /// <summary>
        /// Gets or sets the Usuario.
        /// </summary>
        public virtual Usuario Usuario { get; set; }

        /// <summary>
        /// Gets or sets the DetalleOrdens.
        /// </summary>
        public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; }
    }
}
