using System;

namespace ApiKPITop500.Models
{
    public class Top500FaltantesDisponibles
    {


        public int id { get; set; }
        public string Description { get; set; }

        public string ItemLookupCode { get; set; }

        public int ItemId { get; set; }

        public int DepartmentID { get; set; }

        public double Quantity { get; set; }    
        public bool disponible { get; set; }

        public int? PasilloId { get; set; }

        public string Pasillo { get; set; }

        public DateTime Fecha { get; set; }
    }
}