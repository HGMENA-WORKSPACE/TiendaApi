using Music.Models.Enum;
using System;
using System.Collections.Generic;

#nullable disable

namespace Music.Models
{
    public class Producto
    {
        public Producto()
        {
            DetalleOrdens = new HashSet<DetalleOrden>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public StatusProducto Estatus { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; }
    }
}
