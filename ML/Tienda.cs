using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Tienda
    {
        public int IdTienda { get; set; }
        public string Name { get; set; }
        public ML.RazonSocial RazonSocial { get; set; }
        public int Num { get; set; }
        public string Calle { get; set; }
        public string Domicilio { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
    }
}
