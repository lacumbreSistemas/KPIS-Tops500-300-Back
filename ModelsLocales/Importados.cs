using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiKPITop500.ModelsLocales
{
    public class Importados
    {
        public double Venta { get; set; }
        public double CantidadSistema { get; set; }
      
        public string Department { get; set; }

        public string Category { get; set; }
        public string ItemLookupCode { get; set; }
        public string Description { get; set; }

        public string Ubicacion { get; set; }
    }
}