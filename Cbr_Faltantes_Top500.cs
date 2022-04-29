namespace ApiKPITop500
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("KPI.Cbr_Faltantes_Top500")]
    public partial class Cbr_Faltantes_Top500
    {
        public int id { get; set; }

        public int ItemId { get; set; }

        public bool? disponible { get; set; }

        public DateTime? Fecha { get; set; }

        public int? userID { get; set; }

        public int StoreId { get; set; }

        public bool? Top500 { get; set; }

        public bool? Top300 { get; set; }


    }
}
