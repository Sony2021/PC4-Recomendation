using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC4_Recomendation.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string ProductoNombre { get; set; }
        public bool liked;
    }
}