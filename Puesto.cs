using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifa
{
    public class Puesto
    {
        public int Numero { get; set; }
        public bool EstaComprado { get; set; }
        public Comprador Comprador { get; set; }
    }
}
