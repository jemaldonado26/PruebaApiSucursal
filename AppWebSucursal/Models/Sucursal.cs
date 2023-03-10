using System;
using System.Collections.Generic;

#nullable disable

namespace AppWebSucursal.Models
{
    public partial class Sucursal
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Identificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdMoneda { get; set; }

        public virtual TipoMonedum IdMonedaNavigation { get; set; }
    }
}
