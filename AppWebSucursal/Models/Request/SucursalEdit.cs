﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebSucursal.Models.Request
{
    public class SucursalEdit
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public string direccion { get; set; }
        public string identificacion { get; set; }
        public int moneda { get; set; }
    }
}
