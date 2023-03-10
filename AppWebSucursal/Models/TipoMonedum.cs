using System;
using System.Collections.Generic;

#nullable disable

namespace AppWebSucursal.Models
{
    public partial class TipoMonedum
    {
        public TipoMonedum()
        {
            Sucursals = new HashSet<Sucursal>();
        }

        public int IdMoneda { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Sucursal> Sucursals { get; set; }
    }
}
