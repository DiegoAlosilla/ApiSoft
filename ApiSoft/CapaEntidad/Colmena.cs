﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Colmena
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public string ubicacion { get; set; }
        public string tipo { get; set; }
        public int marcos { get; set; }
        public byte[] imagen { get; set;}
        public string descripcion { get; set; }
        public string tipo_abeja { get; set; }
    }
}
