namespace Music.Dto
{
    using Music.Models.Enum;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the <see cref="OrdenDto" />.
    /// </summary>
    public class OrdenDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdenDto"/> class.
        /// </summary>
        public OrdenDto()
        {
            DetallesOrden = new List<DetalleOrdenDto>();
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
        [Display(Name = "Fecha Registro")]
        [Required(ErrorMessage = "La fecha de la orden es requerido")]
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
        /// Gets or sets the Usuario.
        /// </summary>
        public string Usuario { get; set; }

        /// <summary>
        /// Gets or sets the EstatusOrden.
        /// </summary>
        public EstatusOrden EstatusOrden { get; set; }

        /// <summary>
        /// Gets the DetallesOrden.
        /// </summary>
        public List<DetalleOrdenDto> DetallesOrden { get; }
    }
}
