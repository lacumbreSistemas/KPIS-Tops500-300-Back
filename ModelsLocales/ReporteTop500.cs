using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiKPITop500.ModelsLocales
{
    public class ReporteTop500
    {

        public int id { get; set; }
        public string Description { get; set; }

        public string ItemLookupCode { get; set; }

        public int ItemId { get; set; }

        public int DepartmentID { get; set; }

        public string Departamento { get; set; }

        public double Quantity { get; set; }
        public int disponible { get; set; }

        public string Proveedor { get; set; }

        public DateTime Fecha { get; set; }
    }
}